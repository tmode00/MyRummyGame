using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DragDrop : MonoBehaviour
{
    public GameObject Canvas;
    private bool isDragging = false;   
    public bool anlegemerker;
    private GameCore gamecore;    
    public string AnlegeKartenString = "";
    private GameObject startParent;
    private Vector2 startPosition;
    public int LastDropZoneID;
    public int LastOrderZoneID = -1;
    public int lastSiblingindex;
    public int StartDragSiblingindex;
    
    //Wird gestartet wenn Objekt instanziert wurde
    private void Awake()
    {
        Canvas = GameObject.Find("gamecore");//Find Ibject in Stage by String!
    }
    private void Start()
    {
        gamecore = GameObject.Find("gamecore").GetComponent<GameCore>();

    }
    void Update()
    {
        //Wenn DragDrop erlaubt (solange kein ServerRequest läuft)
        if (GameObject.Find("gamecore").GetComponent<GameCore>().canDrag)
        {
            if (isDragging)
            {
                transform.position = new Vector2(Input.mousePosition.x, Input.mousePosition.y);
                transform.SetParent(Canvas.transform, true);//damit bleibt beim dragdrop das objekt auf der Ebene (verschwindet nicht hintemr Tisch)

            }
        }      
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.transform.tag != "COLLIDE")
        {
            return;
        }

        if (collision.gameObject.transform.tag != "InZoneCard")
        {
            // Debug.Log("CollisionEnterNoINzoomcard!!");
            Color mycolor;
            mycolor.r = 255;
            mycolor.g = 71;
            mycolor.b = 239;
            mycolor.a = 0.40f;
            collision.gameObject.GetComponent<Image>().color = mycolor;
        }
        else
        {
            // Debug.Log("CollisionEnterINzoomcard!!");
            //Reset Color of DropZoneN:
            Color mycolor;
            mycolor.r = 255;
            mycolor.g = 255;
            mycolor.b = 255;
            mycolor.a = 0.20f;
            collision.gameObject.GetComponent<Image>().color = mycolor;
        }

        //Alle 13 OrderZones durchlaufen (index 0 bis 12)
        for (var i = 0; i < 13; i++)
        {

            if (collision.gameObject.name == gamecore.OrderZones[i].name)
            {
                lastSiblingindex = i;
                LastOrderZoneID = i;
            }
        }

        //alles Dropzones durchlaufen
        for (var i = 0; i < 10; i++)
        {
            // if (gamecore.DropZones[i] != null)
            //{
            if (collision.gameObject.name == gamecore.DropZones[i].name)
            {
                //denbn Wegwerfhaufen soll die Karte nicht aufnehmen(das macht der Timer später):
                if (i != 9)//Wenn i nicht der 9. DropDownIndex (also DropZone10) ist:
                {
                    //Dann wird die Karte aufgenommen, sonst wird sie nicht aufgenommen, nur der Index geändert und bei DragEnd destroyed!
                    gamecore.DropZones[i] = collision.gameObject;
                }

                LastDropZoneID = i + 1;
            }
            //}            
        }
    }
    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.transform.tag != "COLLIDE")
        {
            return;
        }

        //Debug.Log("CollisionExit!!");
        //Reset Color of DropZoneN:
        Color mycolor;
        mycolor.r = 255;
        mycolor.g = 255;
        mycolor.b = 255;
        mycolor.a = 0.20f;
        collision.gameObject.GetComponent<Image>().color = mycolor;

        LastDropZoneID = 0;
        LastOrderZoneID = -1;
        for (var i = 0; i < 10; i++)
        {
            //gamecore.DropZones[i] = null;         
        }

        lastSiblingindex = StartDragSiblingindex;
    }
    public void StartDrag()
    {

        if (GameObject.Find("gamecore").GetComponent<GameCore>().canDrag)
        {
            LastOrderZoneID = -1;
            // Debug.Log("Calldragdrop!");
            if (transform.tag != "InZoneCard")
            {
                // Debug.Log("Call Entire dragdrop!");

                startParent = transform.parent.gameObject; //StartParent = Player oder Enemy Area (da wo die Karte zugeordnet war)
                lastSiblingindex = transform.GetSiblingIndex();//Merken wo die Karte war
                StartDragSiblingindex = transform.GetSiblingIndex();//Merken wo die Karte beim Start des Drag-Vorgangs war

                //Debug.Log("LastSiblingIndex: " + lastSiblingindex);

                startPosition = transform.position;
                isDragging = true;
            }
        }
    }
    
    //DragDrop Functions:
    private void CardSortRequest()
    {
        //LastSiblinIndex an Server melden:
        //benötigt Felder gameID,wersendet, newSiblingInex, CardID
        string gid = GameObject.Find("GameIDTextBox").GetComponent<Text>().text;
        string wersendet = GameObject.Find("wersendetText").GetComponent<Text>().text;
        string NewSiblingindexx = lastSiblingindex.ToString();
        string thisStapelID = transform.name.Replace("Card ", "");
        thisStapelID = thisStapelID.Replace("(Clone)", "");
        gamecore.GetComponent<SendReceiver>().RequestUrl = "http://" + GameObject.Find("ServerDropDown").GetComponent<Dropdown>().options[GameObject.Find("ServerDropDown").GetComponent<Dropdown>().value].text + "/rome/OrderCard.php?GameID=" + gid + "&wersendet=" + wersendet + "&NewSiblingIndex=" + NewSiblingindexx + "&StapelID=" + thisStapelID;
        gamecore.GetComponent<SendReceiver>().DoSendReceive(false);
    }
    private void CardDropRequest()
    {
        ////Angelegte Karten sammeln
        //Alle DropZones durchlaufen um die Karten zu sammeln
        AnlegeKartenString = "";
        int len = 0;
        for (int DZ_count = 0; DZ_count < 9; DZ_count++)
        {
            //Nun alle Childs dieser DZ durchlaufen (CHild repräsentiert die Cards selbst in der DZ)
            string tmpstringg = "";
            foreach (Transform child in gamecore.DropZones[DZ_count].transform)
            {
                //nur die Karten senden die "neu" angelegt wurden und die wirklich da liegen (nicht die abgelehnten z.B. weil apsst nicht zur Serie)
                if (child.GetComponent<DragDrop>().anlegemerker == true)
                {
                    child.GetComponent<DragDrop>().anlegemerker = false;
                    tmpstringg = tmpstringg + child.GetComponent<KarteFields>().StapelID.ToString() + "~";
                }

            }
            len = tmpstringg.Length > 0 ? tmpstringg.Length - 1 : 0;
            tmpstringg = tmpstringg.Substring(0, len);

            AnlegeKartenString = AnlegeKartenString + tmpstringg + "x";
        }
        len = AnlegeKartenString.Length > 0 ? AnlegeKartenString.Length - 1 : 0;
        AnlegeKartenString = AnlegeKartenString.Substring(0, len);

        //Testexplode


        //Ja, erlaubt, also wegwerfenFerror
        //Karte Weggeforfen, WebRequest auslösen =>   
        string tempstr = transform.name.Replace("Card ", "");
        tempstr = tempstr.Replace("(Clone)", "");

        //GameID aus der GameIDTextBox an Server senden
        string gid = GameObject.Find("GameIDTextBox").GetComponent<Text>().text;

        //Wer wirft die Karte weg?
        string wersendet = GameObject.Find("wersendetText").GetComponent<Text>().text;

        //Karte löschen (Wenn die Weggeworfene Karte nicht aktzeptiert wird, wird der TimerSie wiederherstellen, 
        //wird Sie aktzeptiert wird der Timer diese auf dem Müllhaufen darstellen)
        gamecore.GetComponent<SendReceiver>().RequestUrl = "http://" + GameObject.Find("ServerDropDown").GetComponent<Dropdown>().options[GameObject.Find("ServerDropDown").GetComponent<Dropdown>().value].text + "/rome/DropCard.php?GameID=" + gid + "&wersendet=" + wersendet + "&DropCardStapelID=" + tempstr + "&anlagestring=" + AnlegeKartenString;
        gamecore.GetComponent<SendReceiver>().DoSendReceive(false);

        //für KarteAnlagen alles merken (request wird nur ausgelöst, wenn wegwerfen erfolgreich):
        gamecore.RequestStringMerker = "http://" + GameObject.Find("ServerDropDown").GetComponent<Dropdown>().options[GameObject.Find("ServerDropDown").GetComponent<Dropdown>().value].text + "/rome/KarteAnlegen.php?GameID=" + gid + "&wersendet=" + wersendet + "&anlagestring=" + AnlegeKartenString;


        //Damit Karte bei erfolgreichem RQ gelöst werden kann diese zun. der DZ zuordnen
        transform.SetParent(gamecore.DropZones[9].transform, false);
        GameObject.Find("SoundCardDrop2").GetComponent<AudioSource>().Play(0);
    }
    private void sendcardbacktoplayer(string errormsg)
    {
        //Position des in der hand befindlichen Objektes zurück auf die oben festgelegte Startpositionn
        //Zurück gehen zur Startposition (zur eigenen Hand) (siehe oben //StartParent = Player oder Enemy Area (da wo die Karte zugeordnet war))
        //Karte wqieder da einordnen wo sie vorher war:
        transform.position = startPosition;
        transform.SetParent(startParent.transform, false);
        transform.SetSiblingIndex(lastSiblingindex);
        GameObject.Find("StatusTextBox").GetComponent<Text>().text = errormsg;        
        GameObject.Find("StatusTextBox").GetComponent<Text>().color = Color.red;
    }
    private void WegwerfenSperren(string errormsg)
    {
        Color mycolor2;
        GameObject.Find("DropZone10").tag = "NOTCOLLIDE";
        mycolor2.r = 255; mycolor2.g = 0; mycolor2.b = 0; mycolor2.a = 0.40f;
        GameObject.Find("DropZone10").GetComponent<Image>().color = mycolor2;

        //Karten sortieren sperren:
        GameObject.Find("ButtonSortMode").GetComponent<CanvasGroup>().alpha = 0f;
        GameObject.Find("ButtonSortMode").GetComponent<CanvasGroup>().blocksRaycasts = false;

        //Rückgängig-Button freigeben:
        GameObject.Find("ButtonRueckGaengig").GetComponent<CanvasGroup>().alpha = 1f;
        GameObject.Find("ButtonRueckGaengig").GetComponent<CanvasGroup>().blocksRaycasts = true;
        GameObject.Find("StatusTextBox").GetComponent<Text>().color = Color.red;
        GameObject.Find("StatusTextBox").GetComponent<Text>().text = errormsg;
    }
    private void WegwerfenFreigeben(string errormsg)
    {
        Color mycolor2;
        //ja es liegen 30 Punkte da oder lagen vorher schonmal 30 Punkte da und es sind 3 Karten min. auf der DZ
        mycolor2.r = 255; mycolor2.g = 255; mycolor2.b = 255; mycolor2.a = 0.20f;
        GameObject.Find("DropZone10").GetComponent<Image>().color = mycolor2;
        GameObject.Find("DropZone10").tag = "COLLIDE";

        //Karten sortieren freigeben:
        GameObject.Find("ButtonSortMode").GetComponent<CanvasGroup>().alpha = 1f;
        GameObject.Find("ButtonSortMode").GetComponent<CanvasGroup>().blocksRaycasts = true;

        //Rückgängig-Button sperren:
        GameObject.Find("ButtonRueckGaengig").GetComponent<CanvasGroup>().alpha = 0f;
        GameObject.Find("ButtonRueckGaengig").GetComponent<CanvasGroup>().blocksRaycasts = false;
        GameObject.Find("StatusTextBox").GetComponent<Text>().color = Color.green;
        GameObject.Find("StatusTextBox").GetComponent<Text>().text = errormsg;
    }

    public void EndDrag()
    {
        if (GameObject.Find("gamecore").GetComponent<GameCore>().canDrag)
        {            
            if (LastOrderZoneID != -1)///Wenn <> -1 ist, dann wurde sie über Orderzone 1--13 irgendwo abgelegt
            {
                CardSortRequest();
                isDragging = false;                
                transform.SetParent(startParent.transform, false);
                transform.SetSiblingIndex(lastSiblingindex);
                LastOrderZoneID = -1;
                return;
            }
           

            if (transform.tag != "InZoneCard")
            {
                isDragging = false;
                if (LastDropZoneID != 0)//Wenn die Karte in der Dropzone landet:
                {
                    //Layer Ändern damit keine Kollision mehr:
                    transform.tag = "InZoneCard";

                    Color mycolor;
                    mycolor.r = 255;
                    mycolor.g = 255;
                    mycolor.b = 255;
                    mycolor.a = 0.20f;

                    //Elternschaft übernimmt die  jeweilige dropZone
                    //Wichtiger Moment,da hier gepprüft werden muss, was passiert,
                    //wenn eine Karte "angelegt" wurde
                    //Alle 9 Dropzones durchlaufen (prüfen ob eine Karte in einer DropZone landet 
                    for (int DZ_count = 0; DZ_count < 9; DZ_count++)
                    {
                        //Alle Karten in der DropZone Sortieren, dazu alle UNSORTIERTEN Karten in eine Temporäre Liste aufnehmen
                        List<GameObject> AllDropZoneChildsArray;
                        AllDropZoneChildsArray = new List<GameObject>();

                        foreach (Transform child in gamecore.DropZones[DZ_count].transform)
                        {
                            AllDropZoneChildsArray.Add(child.gameObject);
                        }

                        //WEnn die Karte in Dropzone z.B. 3 geworfen wurde ist DZ_count = 2 (soomit würde Karte der 3. DZ zugeordnet werden, sofern prüfung bestanden wird):
                        if (LastDropZoneID == DZ_count + 1) //(+1 da LastDropZoneID mit 1 beginnt))
                        {
                            bool generellAnlegbar = false;
                            //1. Karte darf jede seib (theoretisch auch ein Joker):
                            if (gamecore.DropZones[DZ_count].gameObject.transform.childCount == 0)
                            {
                                generellAnlegbar = true;
                                //1. Karte sofort der Dropzone hinzufügen
                                transform.SetParent(gamecore.DropZones[DZ_count].transform, false);
                                transform.GetComponent<DragDrop>().anlegemerker = true;
                                GameObject.Find("SoundCardDrop1").GetComponent<AudioSource>().Play(0);
                            }
                            else
                            {
                                //Ab der 2. Karte immer alle Karten der DZ durchlaufen und auf Anlagemöglichkeiten prüfen:
                                foreach (GameObject child in AllDropZoneChildsArray)
                                {
                                    //nur Serie Prüfen wenn diese Dropzone kein Anlagetyp 9 (gleiche Karten) gleiche ist
                                    if (gamecore.DropZones[DZ_count].GetComponent<DropZoneFields>().MyLayer != 9)
                                    {
                                        //Kann die Kare normal links pder Rechts angelegt werden?
                                        if (gamecore.CheckSerieNormal(this.gameObject, child, DZ_count))
                                        {
                                            //Wenn True wurde Karte Rechts oder Links an Serie angelegt 
                                            //DropZone als "Anlageserie deklarieren":
                                            gamecore.DropZones[DZ_count].GetComponent<DropZoneFields>().MyLayer = 8;
                                            generellAnlegbar = true;
                                        }
                                        else if (gamecore.CheckSerieAssKoenigUebersprung(this.gameObject, child, DZ_count))
                                        {
                                            //Wenn True wurde Karte mit Übersprung Rechts oder links angelegt
                                            //DropZone als "Anlageserie deklarieren":
                                            gamecore.DropZones[DZ_count].GetComponent<DropZoneFields>().MyLayer = 8;
                                            generellAnlegbar = true;
                                        }
                                    }
                                }

                                //nur gleiche Prüfen wenn diese Dropzone kein Anlagetyp 8 (Serie) ist
                                if (gamecore.DropZones[DZ_count].GetComponent<DropZoneFields>().MyLayer != 8)
                                {
                                    if (gamecore.CheckGleiche(this.gameObject, DZ_count))
                                    {
                                        //Wenn True wurde Gleiche Karte mit unterschiedlicher Farbe angelegt 
                                        //DropZone als "Gleiche Karten" deklarieren:
                                        gamecore.DropZones[DZ_count].GetComponent<DropZoneFields>().MyLayer = 9;
                                        generellAnlegbar = true;
                                    }
                                }
                            }
                            ///Wenn sich die KArte gar nicht anlegen lässt:
                            if (generellAnlegbar == false)
                            {
                                Debug.Log("Karte nicht kompatibel zu in irgend einer Form anlegen!");                               

                                //PlayerCard dem Canvas (bzw. der playerArea im Canvas) zuoordnen (damit die Instanzen sichtbar sind)
                                transform.SetParent(GameObject.Find("PlayerArea").transform, false);
                                GameObject.Find("SoundCardRefuse").GetComponent<AudioSource>().Play(0);

                                transform.tag = "Untagged";

                                //Karte wieder dahin wo sie weggenommen wurde
                                transform.SetSiblingIndex(lastSiblingindex);
                            }                            
                        }
                    }

                    //Wenn am EndDrag die Karte im Wegwerfbereich landet ==>
                    if (LastDropZoneID == 10)
                    {
                        //prüfen ob Wegwerfen erlaubt (nur wenn ich dran bin):
                        if (GameObject.Find("weristdranText").GetComponent<Text>().text == GameObject.Find("wersendetText").GetComponent<Text>().text)
                        {
                            //Prüfen ob der gezogenstatus passt:
                            if (GameObject.Find("gamecore").GetComponent<GameCore>().gezogenstatus)
                            {
                                CardDropRequest();
                            }
                            else
                            {
                                GameObject.Find("SoundCardRefuse").GetComponent<AudioSource>().Play(0);
                                sendcardbacktoplayer("Du bist dran, musst aber erst eine ziehen!");
                            }
                        }
                        else
                        {
                            GameObject.Find("SoundCardRefuse").GetComponent<AudioSource>().Play(0);
                            sendcardbacktoplayer("Du bist nicht dran! Warte bitte!");
                        }
                    }

                }
                else//wenn am Ende des DragAndDrop vorganges die Karte nicht über der DropZone ist:
                {
                    GameObject.Find("SoundCardRefuse").GetComponent<AudioSource>().Play(0);
                    sendcardbacktoplayer("Karte zurück zu dir!");
                }
            }
        }

        //Nur wenn keine Sortierung aktiv ist:
        if (GameObject.Find("ButtonSortModeText").GetComponent<Text>().text == "Karten sortieren")
        {
            //in allen Angelgten Karten guggen ob einzelne daliegen, nur wenn nicht Wegwerfen freigeben         
            bool[] isgood = new bool[] { false, false, false, false, false, false, false, false, false };
            for (int DZ_count = 0; DZ_count < 9; DZ_count++)
            {
                if (gamecore.DropZones[DZ_count].gameObject.transform.childCount > 2 || gamecore.DropZones[DZ_count].gameObject.transform.childCount == 0)
                {
                    isgood[DZ_count] = true;
                }
            }

            if (isgood[0] == true && isgood[1] == true && isgood[2] == true && isgood[3] == true && isgood[4] == true && isgood[5] == true && isgood[6] == true && isgood[7] == true && isgood[8] == true)
            {
                //Nun schauen ob der Spieler 30 ausgelegt hat:
                if (gamecore.Playerhas30)
                {
                    WegwerfenFreigeben("Du hast 30 bereits in Vorrunde ausgelegt, lege an oder werfe weg");
                }
                else//Spieler hat noch keine 30, daher zählen
                {
                    for (int DZ_count = 0; DZ_count < 9; DZ_count++)
                    {
                        //Nun, da wir in einer DZ sind alle Childs dieser DZ zusammenzählen:
                        int gesamtzaehler = 0;
                        foreach (Transform child in gamecore.DropZones[DZ_count].transform)
                        {
                            //nur die Karten zählen die echt rausgelegt wurden
                            if (child.GetComponent<DragDrop>().anlegemerker == true)
                            {
                                gesamtzaehler = gesamtzaehler + gamecore.SearchCloneByName(child.name).Zaehlwert;
                                WegwerfenSperren("Noch keine 30, du hast erst " + gesamtzaehler.ToString() + " Punkte ausgelegt!");
                                
                            }                                
                        }

                        //sind es 30?
                        if (gesamtzaehler >= 30)
                        {
                            gamecore.Playerhas30 = true;                            
                            WegwerfenFreigeben("Über 30 Punkte ausgelegt, werfe weg oder lege weiter an!");
                        }
                    }
                }
            }
            else//Sollte irgendwo nur eine Karte liegen wegwerfen sperren
            {
                WegwerfenSperren("Bitte lege mindestens 3 Karten aus oder Rückgängig!");
            }
        }
            

    }


   
}
