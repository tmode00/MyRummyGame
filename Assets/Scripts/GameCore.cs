using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Random = System.Random;
using System.Linq;

public class GameCore : MonoBehaviour
{
    //Globals:
    public bool Playerhas30; //Speichert ob der Spieler 30 Punkte zusammen hat
    public bool musictoogler = true;//Speichert ob Musik abspielt oder nicht

    public GameObject dummycard;

    //Listen von GameObjekten für Zugriff    
    public List<GameObject> DropZones;
    public List<GameObject> OrderZones;
       
    //Was Timer:
    public float targetTime = 3f;
    public bool TimerStatus = false;
    public bool canDrag = true;
    public bool gezogenstatus = false;
    public string RequestStringMerker = "";//für dragdrop
    public int[] Player1CardsArray;
    public int[] Player2CardsArray;
    public int[] UsedCardsArray;
    public int[] DroppedCardsArray;
    public int[] DZ1CardsArray;
    public int[] DZ2CardsArray;
    public int[] DZ3CardsArray;
    public int[] DZ4CardsArray;
    public int[] DZ5CardsArray;
    public int[] DZ6CardsArray;
    public int[] DZ7CardsArray;
    public int[] DZ8CardsArray;
    public int[] DZ9CardsArray;
    public string Oldweristdran = "";
    public int[] OldPlayer1CardsArray;
    public int[] OldPlayer2CardsArray;
    public int[] OldEnemyCardsArray;
    public int[] OldDroppedCardsArray;
    public int[] OldDZ1CardsArray;
    public int[] OldDZ2CardsArray;
    public int[] OldDZ3CardsArray;
    public int[] OldDZ4CardsArray;
    public int[] OldDZ5CardsArray;
    public int[] OldDZ6CardsArray;
    public int[] OldDZ7CardsArray;
    public int[] OldDZ8CardsArray;
    public int[] OldDZ9CardsArray;
    public GameObject Card0;
    public GameObject backblue;
    public GameObject backred;    
    public GameObject PlayerArea;
    public GameObject EnemyArea;
    public GameObject StapelArea;
    public List<GameObject> cards = new List<GameObject>();//// repräsentiert einen kompletten Stapel
    public List<GameObject> backcards = new List<GameObject>();//Repräsentiert den rückseitenstapel
    public List<Karte> Kartenstapel = new List<Karte>();


    //Startberech / Am ANfang ausgeführte Funktionen =>
    private void GameObjectListAdder()
    {
        DropZones = new List<GameObject>();
        DropZones.Add(GameObject.Find("DropZone1"));
        DropZones.Add(GameObject.Find("DropZone2"));
        DropZones.Add(GameObject.Find("DropZone3"));
        DropZones.Add(GameObject.Find("DropZone4"));
        DropZones.Add(GameObject.Find("DropZone5"));
        DropZones.Add(GameObject.Find("DropZone6"));
        DropZones.Add(GameObject.Find("DropZone7"));
        DropZones.Add(GameObject.Find("DropZone8"));
        DropZones.Add(GameObject.Find("DropZone9"));
        DropZones.Add(GameObject.Find("DropZone10"));

        OrderZones = new List<GameObject>();
        OrderZones.Add(GameObject.Find("OrderZone1"));
        OrderZones.Add(GameObject.Find("OrderZone2"));
        OrderZones.Add(GameObject.Find("OrderZone3"));
        OrderZones.Add(GameObject.Find("OrderZone4"));
        OrderZones.Add(GameObject.Find("OrderZone5"));
        OrderZones.Add(GameObject.Find("OrderZone6"));
        OrderZones.Add(GameObject.Find("OrderZone7"));
        OrderZones.Add(GameObject.Find("OrderZone8"));
        OrderZones.Add(GameObject.Find("OrderZone9"));
        OrderZones.Add(GameObject.Find("OrderZone10"));
        OrderZones.Add(GameObject.Find("OrderZone11"));
        OrderZones.Add(GameObject.Find("OrderZone12"));
        OrderZones.Add(GameObject.Find("OrderZone13"));

        backcards.Add(backblue);
        backcards.Add(backred);
        cards.Add(Card0);
        cards.Add(Card0);
        cards.Add(Card0);
        cards.Add(Card0);
        cards.Add(Card0);
        cards.Add(Card0);
        cards.Add(Card0);
        cards.Add(Card0);
        cards.Add(Card0);
        cards.Add(Card0);
        cards.Add(Card0);
        cards.Add(Card0);
        cards.Add(Card0);
        cards.Add(Card0);
        cards.Add(Card0);
        cards.Add(Card0);
        cards.Add(Card0);
        cards.Add(Card0);
        cards.Add(Card0);
        cards.Add(Card0);
        cards.Add(Card0);
        cards.Add(Card0);
        cards.Add(Card0);
        cards.Add(Card0);
        cards.Add(Card0);
        cards.Add(Card0);
        cards.Add(Card0);
        cards.Add(Card0);
        cards.Add(Card0);
        cards.Add(Card0);
        cards.Add(Card0);
        cards.Add(Card0);
        cards.Add(Card0);
        cards.Add(Card0);
        cards.Add(Card0);
        cards.Add(Card0);
        cards.Add(Card0);
        cards.Add(Card0);
        cards.Add(Card0);
        cards.Add(Card0);
        cards.Add(Card0);
        cards.Add(Card0);
        cards.Add(Card0);
        cards.Add(Card0);
        cards.Add(Card0);
        cards.Add(Card0);
        cards.Add(Card0);
        cards.Add(Card0);
        cards.Add(Card0);
        cards.Add(Card0);
        cards.Add(Card0);
        cards.Add(Card0);
        cards.Add(Card0);
        cards.Add(Card0);
        cards.Add(Card0);
        cards.Add(Card0);
        cards.Add(Card0);
        cards.Add(Card0);
        cards.Add(Card0);
        cards.Add(Card0);
        cards.Add(Card0);
        cards.Add(Card0);
        cards.Add(Card0);
        cards.Add(Card0);
        cards.Add(Card0);
        cards.Add(Card0);
        cards.Add(Card0);
        cards.Add(Card0);
        cards.Add(Card0);
        cards.Add(Card0);
        cards.Add(Card0);
        cards.Add(Card0);
        cards.Add(Card0);
        cards.Add(Card0);
        cards.Add(Card0);
        cards.Add(Card0);
        cards.Add(Card0);
        cards.Add(Card0);
        cards.Add(Card0);
        cards.Add(Card0);
        cards.Add(Card0);
        cards.Add(Card0);
        cards.Add(Card0);
        cards.Add(Card0);
        cards.Add(Card0);
        cards.Add(Card0);
        cards.Add(Card0);
        cards.Add(Card0);
        cards.Add(Card0);
        cards.Add(Card0);
        cards.Add(Card0);
        cards.Add(Card0);
        cards.Add(Card0);
        cards.Add(Card0);
        cards.Add(Card0);
        cards.Add(Card0);
        cards.Add(Card0);
        cards.Add(Card0);
        cards.Add(Card0);
        cards.Add(Card0);
        cards.Add(Card0);
        cards.Add(Card0);
        cards.Add(Card0);
        cards.Add(Card0);
        cards.Add(Card0);
        cards.Add(Card0);
        cards.Add(Card0);
        cards.Add(Card0);
        cards.Add(Card0);
        cards.Add(Card0);
        //Virtuellen Kartenstapeö erstellen:
        for (var i = 0; i <= 109; i++)
        {
            //ResLines[21] - [131] enthält die Karteninformationen:
            Karte acard;
            acard = new Karte(1, 1, 1, "A", "A", "A", "A", 1);
            Kartenstapel.Add(acard);
        }
    }
    
    private void ScreenAutoRotateandScale()
    {
        CanvasScaler canvasScaler = GameObject.Find("gamecore").gameObject.GetComponent<CanvasScaler>();
        float newscalfactor;
        if (Screen.orientation == ScreenOrientation.LandscapeLeft || Screen.orientation == ScreenOrientation.LandscapeRight)
        {
            newscalfactor = Convert.ToSingle(Screen.width) / Convert.ToSingle(2300);
        }
        else
        {
            Screen.orientation = ScreenOrientation.LandscapeLeft;
            newscalfactor = Convert.ToSingle(Screen.height) / Convert.ToSingle(2300);
        }
        canvasScaler.scaleFactor = newscalfactor;
        Screen.sleepTimeout = SleepTimeout.NeverSleep;
    }
    void Start()
    {
        Debug.Log("Staring Gamecore....");
        GameObjectListAdder();
        ScreenAutoRotateandScale();

        GameObject.Find("SpielvorbereitungContainerBG").GetComponent<Slideinout>().PushIn();
        GameObject.Find("Werbekommt13BackCanvas").GetComponent<CanvasGroup>().alpha = 0f;
        GameObject.Find("Werbekommt13BackCanvas").GetComponent<CanvasGroup>().blocksRaycasts = false;
        GameObject.Find("GameIDBGCanvas").GetComponent<CanvasGroup>().alpha = 0f;
        GameObject.Find("GameIDBGCanvas").GetComponent<CanvasGroup>().blocksRaycasts = false;

    }
    void Update()
    {
        if (transform.GetComponent<SendReceiver>().UnhandledResult)
        {
            //if (GameObject.Find("SpielvorbereitungContainerBG").GetComponent<Slideinout>().mypos > 3990)
            //{
            transform.GetComponent<SendReceiver>().UnhandledResult = false;
            HandleWebResult();
            //}
        }

        if (TimerStatus)
        {
            targetTime -= Time.deltaTime;

            if (targetTime <= 0.0f)
            {
                timerEnded();
            }

            //Liegt ein neues UpdateErgebnis for?
            //if (transform.GetComponent<SendReceiver>().UnhandledResult)
            //{
            //transform.GetComponent<SendReceiver>().UnhandledResult = false;
            //  try
            // {
            //HandleWebResult();//dann handeln    
            //   }
            //   catch (Exception e)
            //    {
            //        Debug.Log(e.Message);
            //         GameObject.Find("StatusTextBox").GetComponent<Text>().text = "Error: " + e.Message;
            //        GameObject.Find("SoundError").GetComponent<AudioSource>().Play(0);
            //     }



        }
    }

    //On Click-Bereiche:
    public void onClick_KartenSortieren()
    {
        GameObject.Find("SoundButtonpress").GetComponent<AudioSource>().Play(0);
        //Status des Sortieren Button ermitteln:
        if (GameObject.Find("ButtonSortModeText").GetComponent<Text>().text == "Karten sortieren")
        {
            GameObject.Find("ButtonSortModeText").GetComponent<Text>().color = Color.red;
            GameObject.Find("ButtonSortModeText").GetComponent<Text>().text = "sortieren beenden";
            //Im Sortiermodus sind die OrderZones verfügbar:
            set_all_orderzones_collidestatus("COLLIDE");
            set_all_dropzones_collidestatus("NOTCOLLIDE");
        }
        else
        {
            GameObject.Find("ButtonSortModeText").GetComponent<Text>().color = Color.black;
            GameObject.Find("ButtonSortModeText").GetComponent<Text>().text = "Karten sortieren";
            set_all_orderzones_collidestatus("NOTCOLLIDE");
            set_all_dropzones_collidestatus("COLLIDE");
        }
    }
    public void onClick_SpielBeenden()
    {
        Debug.Log("tschö mit ö");
        Application.Quit();
    }
    public void onClick_MusikToogler()
    {
        if (musictoogler == true)
        {
            musictoogler = false;
            GameObject.Find("Sound1").GetComponent<AudioSource>().Stop();
            GameObject.Find("Sound2").GetComponent<AudioSource>().Stop();
            GameObject.Find("Sound3").GetComponent<AudioSource>().Stop();
            GameObject.Find("Sound4").GetComponent<AudioSource>().Stop();
            GameObject.Find("Sound5").GetComponent<AudioSource>().Stop();
            GameObject.Find("Sound6").GetComponent<AudioSource>().Stop();
        }
        else
        {
            musictoogler = true;
            List<GameObject> MusicObjects;
            MusicObjects = new List<GameObject>();
            MusicObjects.Add(GameObject.Find("Sound1"));
            MusicObjects.Add(GameObject.Find("Sound2"));
            MusicObjects.Add(GameObject.Find("Sound3"));
            MusicObjects.Add(GameObject.Find("Sound4"));
            MusicObjects.Add(GameObject.Find("Sound5"));
            MusicObjects.Add(GameObject.Find("Sound6"));
            Random rnd = new Random();
            int dice = rnd.Next(0, 6); // creates a number between 1 and 6      
            MusicObjects[dice].GetComponent<AudioSource>().Play(0);
        }
    }
    public void onClick_Rueckgaengig()
    {
        UndoCardAnlegen();
    }

    
    public void onClick_StarNewGameRestart()
    {
        StopTimer();
        //Alles aufräumen:
        //Aklle Kinder der PLayerArea löschen:
        foreach (Transform child in GameObject.Find("PlayerArea").transform)
        {
            Destroy(child.gameObject);
        }

        foreach (Transform child in GameObject.Find("EnemyArea").transform)
        {
            Destroy(child.gameObject);
        }

        foreach (Transform child in GameObject.Find("DropZone1").transform) { Destroy(child.gameObject); }
        foreach (Transform child in GameObject.Find("DropZone2").transform) { Destroy(child.gameObject); }
        foreach (Transform child in GameObject.Find("DropZone3").transform) { Destroy(child.gameObject); }
        foreach (Transform child in GameObject.Find("DropZone4").transform) { Destroy(child.gameObject); }
        foreach (Transform child in GameObject.Find("DropZone5").transform) { Destroy(child.gameObject); }
        foreach (Transform child in GameObject.Find("DropZone6").transform) { Destroy(child.gameObject); }
        foreach (Transform child in GameObject.Find("DropZone7").transform) { Destroy(child.gameObject); }
        foreach (Transform child in GameObject.Find("DropZone8").transform) { Destroy(child.gameObject); }
        foreach (Transform child in GameObject.Find("DropZone9").transform) { Destroy(child.gameObject); }
        foreach (Transform child in GameObject.Find("DropZone10").transform) { Destroy(child.gameObject); }


        DropZones[0].GetComponent<DropZoneFields>().MyLayer = 0;
        DropZones[1].GetComponent<DropZoneFields>().MyLayer = 0;
        DropZones[2].GetComponent<DropZoneFields>().MyLayer = 0;
        DropZones[3].GetComponent<DropZoneFields>().MyLayer = 0;
        DropZones[4].GetComponent<DropZoneFields>().MyLayer = 0;
        DropZones[5].GetComponent<DropZoneFields>().MyLayer = 0;
        DropZones[6].GetComponent<DropZoneFields>().MyLayer = 0;
        DropZones[7].GetComponent<DropZoneFields>().MyLayer = 0;
        DropZones[8].GetComponent<DropZoneFields>().MyLayer = 0;
        DropZones[0].GetComponent<DropZoneFields>().MyLayer = 0;

        //Hide old GameStartFields
        GameObject.Find("Werbekommt13BackCanvas").GetComponent<CanvasGroup>().alpha = 0f;
        GameObject.Find("Werbekommt13BackCanvas").GetComponent<CanvasGroup>().blocksRaycasts = false;
        GameObject.Find("GameIDBGCanvas").GetComponent<CanvasGroup>().alpha = 0f;
        GameObject.Find("GameIDBGCanvas").GetComponent<CanvasGroup>().blocksRaycasts = false;


        
        Array.Clear(Player1CardsArray,0, Player1CardsArray.Length);
        Array.Clear(Player2CardsArray, 0, Player2CardsArray.Length);
        Array.Clear(UsedCardsArray, 0, UsedCardsArray.Length);
        Array.Clear(DroppedCardsArray, 0, DroppedCardsArray.Length);
        Array.Clear(DZ1CardsArray, 0, DZ1CardsArray.Length);
        Array.Clear(DZ2CardsArray, 0, DZ2CardsArray.Length);
        Array.Clear(DZ3CardsArray, 0, DZ3CardsArray.Length);
        Array.Clear(DZ4CardsArray, 0, DZ4CardsArray.Length);
        Array.Clear(DZ5CardsArray, 0, DZ5CardsArray.Length);
        Array.Clear(DZ6CardsArray, 0, DZ6CardsArray.Length);
        Array.Clear(DZ7CardsArray, 0, DZ7CardsArray.Length);
        Array.Clear(DZ8CardsArray, 0, DZ8CardsArray.Length);
        Array.Clear(DZ9CardsArray, 0, DZ9CardsArray.Length); 
        Array.Clear(OldPlayer1CardsArray, 0, OldPlayer1CardsArray.Length);
        Array.Clear(OldPlayer2CardsArray, 0, OldPlayer2CardsArray.Length);
        Array.Clear(OldEnemyCardsArray, 0, OldEnemyCardsArray.Length);
        Array.Clear(OldDroppedCardsArray, 0, OldDroppedCardsArray.Length);
        Array.Clear(OldDZ1CardsArray, 0, OldDZ1CardsArray.Length);
        Array.Clear(OldDZ2CardsArray, 0, OldDZ2CardsArray.Length);
        Array.Clear(OldDZ3CardsArray, 0, OldDZ3CardsArray.Length);
        Array.Clear(OldDZ4CardsArray, 0, OldDZ4CardsArray.Length);
        Array.Clear(OldDZ5CardsArray, 0, OldDZ5CardsArray.Length);
        Array.Clear(OldDZ6CardsArray, 0, OldDZ6CardsArray.Length);
        Array.Clear(OldDZ7CardsArray, 0, OldDZ7CardsArray.Length);
        Array.Clear(OldDZ8CardsArray, 0, OldDZ8CardsArray.Length);
        Array.Clear(OldDZ9CardsArray, 0, OldDZ9CardsArray.Length);
        Oldweristdran = "";

        //Stats ausbelenden, Spielvorbereitung einblenden
        GameObject.Find("StatsContainerBG").GetComponent<Slideinout>().PushOut();
        GameObject.Find("SpielvorbereitungContainerBG").GetComponent<Slideinout>().PushIn();        
        GameObject.Find("gamecore").GetComponent<GameCore>().Playerhas30 = false;
       

    }
    public void onClick_PreNewGame()
    {
        GameObject.Find("SoundButtonpress").GetComponent<AudioSource>().Play(0);
        GameObject.Find("Werbekommt13BackCanvas").GetComponent<CanvasGroup>().alpha = 1f;
        GameObject.Find("Werbekommt13BackCanvas").GetComponent<CanvasGroup>().blocksRaycasts = true;
        transform.GetComponent<SendReceiver>().RequestUrl = "http://" + GameObject.Find("ServerDropDown").GetComponent<Dropdown>().options[GameObject.Find("ServerDropDown").GetComponent<Dropdown>().value].text + "/rome/GetLatestID.php";
        transform.GetComponent<SendReceiver>().DoSendReceive(false);
        
        GameObject.Find("GameIDBGCanvas").GetComponent<CanvasGroup>().alpha = 0f;
        GameObject.Find("GameIDBGCanvas").GetComponent<CanvasGroup>().blocksRaycasts = false;
    }
    public void onClick_PreJoinGame()
    {
        GameObject.Find("SoundButtonpress").GetComponent<AudioSource>().Play(0);
        GameObject.Find("GameIDBGCanvas").GetComponent<CanvasGroup>().alpha = 1f;
        GameObject.Find("GameIDBGCanvas").GetComponent<CanvasGroup>().blocksRaycasts = true;        
        GameObject.Find("Werbekommt13BackCanvas").GetComponent<CanvasGroup>().alpha = 0f;
        GameObject.Find("Werbekommt13BackCanvas").GetComponent<CanvasGroup>().blocksRaycasts = false;
    }
    public void onClick_NewGame()
    {
        //Anfrage der ersten Karten / Creategame an Server senden:
        string whogot13 = "";
        if (GameObject.Find("DropdownWerhat13").GetComponent<Dropdown>().options[GameObject.Find("DropdownWerhat13").GetComponent<Dropdown>().value].text == "Player1")
        {
            whogot13 = "Player1";
            gezogenstatus = true;
        }
        if (GameObject.Find("DropdownWerhat13").GetComponent<Dropdown>().options[GameObject.Find("DropdownWerhat13").GetComponent<Dropdown>().value].text == "Player2")
        {
            whogot13 = "Player2";
            gezogenstatus = false;
        }
        transform.GetComponent<SendReceiver>().RequestUrl = "http://" + GameObject.Find("ServerDropDown").GetComponent<Dropdown>().options[GameObject.Find("ServerDropDown").GetComponent<Dropdown>().value].text + "/rome/CreateGame.php?GameID=" + GameObject.Find("GameIDTextBox").GetComponent<Text>().text + "&werbekommtdreizehn=" + whogot13;
        transform.GetComponent<SendReceiver>().DoSendReceive(false);

        GameObject.Find("SpielvorbereitungContainerBG").GetComponent<Slideinout>().PushOut();
        GameObject.Find("SoundShuffle").GetComponent<AudioSource>().Play(0);

        List<GameObject> MusicObjects;
        MusicObjects = new List<GameObject>();
        MusicObjects.Add(GameObject.Find("Sound1"));
        MusicObjects.Add(GameObject.Find("Sound2"));
        MusicObjects.Add(GameObject.Find("Sound3"));
        MusicObjects.Add(GameObject.Find("Sound4"));
        MusicObjects.Add(GameObject.Find("Sound5"));        
        MusicObjects.Add(GameObject.Find("Sound6"));
        Random rnd = new Random();
        int dice = rnd.Next(0, 6); // creates a number between 1 and 6      
        MusicObjects[dice].GetComponent<AudioSource>().Play(0);
    }
    public void onClick_JoinGame()
    {
        GameObject.Find("SoundButtonpress").GetComponent<AudioSource>().Play(0);
        string gid = GameObject.Find("InputGameidText").GetComponent<Text>().text;
        transform.GetComponent<SendReceiver>().RequestUrl = "http://" + GameObject.Find("ServerDropDown").GetComponent<Dropdown>().options[GameObject.Find("ServerDropDown").GetComponent<Dropdown>().value].text + "/rome/JoinGame.php?GameID=" + gid;
        transform.GetComponent<SendReceiver>().DoSendReceive(false);
    }
    public void onClick_KarteZiehen(Transform me)
    {
        GameObject.Find("SoundCardDrop3").GetComponent<AudioSource>().Play(0);
        if (canDrag == true)
        {
            string gegnerstapelcard = "";
            //GameID aus der GameIDTextBox an Server senden
            string gid = GameObject.Find("GameIDTextBox").GetComponent<Text>().text;
            //Wer wirft die Karte weg?
            string wersendet = GameObject.Find("wersendetText").GetComponent<Text>().text;

            //schauen welche Karte gezogen werden sol (die vom Stapel oder die vom Gegener)?
            if (me.tag == "ichbindergegnerstapel")
            {
                Debug.Log("stelle fest ichbindergegnerstapel)");
                foreach (Transform child in GameObject.Find("DropZone10").transform)
                {
                    Debug.Log("Childname:" + child.name);
                    gegnerstapelcard = child.gameObject.name;
                }
                gegnerstapelcard = gegnerstapelcard.Replace("Card ", "").Replace("(Clone)", "");
            }

            if (me.tag == "ichbinderstapel")
            {
                gegnerstapelcard = "DummyCard";
            }

            transform.GetComponent<SendReceiver>().RequestUrl = "http://" + GameObject.Find("ServerDropDown").GetComponent<Dropdown>().options[GameObject.Find("ServerDropDown").GetComponent<Dropdown>().value].text + "/rome/KarteZiehen.php?GameID=" + gid + "&gegnerstapelcard=" + gegnerstapelcard + "&wersendet=" + wersendet;
            transform.GetComponent<SendReceiver>().DoSendReceive(false);
        }
    }

    //Hilfsfunktionen:
    //Setzt alle Dropzones auf COLLIDE bzw. NICHT Collide
    //Setzt alle OrderZones auf COLLIDE bzw. NICHT Collide
    private void set_all_dropzones_collidestatus(string collidestatus)
    {
        for (int i = 0; i <= 9; i++)
        {
            DropZones[i].tag = collidestatus;
        }
    }
    private void set_all_orderzones_collidestatus(string collidestatus)
    {
        for (int i = 0; i <= 12; i++)
        {
            OrderZones[i].tag = collidestatus;
        }
    }
    //Gibt eine Virtuelle Karte zurück, übergeben wird der Name des Clones
    public Karte SearchCloneByName(string clonename)
    {
        string tempstr = clonename.Replace("Card ", "").Replace("(Clone)", "");
        return GameObject.Find("gamecore").GetComponent<GameCore>().GetCardByStapelID(Convert.ToInt16(tempstr));
    }
    //Function to Get a Card anhand von übergebener StapelID
    public Karte GetCardByStapelID(int StapelID)
    {
        for (var i = 0; i <= 109; i++)
        {
            if (Kartenstapel[i].StapelID == StapelID)
            {
                return Kartenstapel[i];
            }

        }
        return null;
    }

       
    //Immmer wenn es Tick macht ein Update Request an den Server senden=>
    void timerEnded()
    {
        targetTime = 3f;
        //do your stuff here.

        //GameID aus der ImputBox an Server senden
        string gid = GameObject.Find("GameIDTextBox").GetComponent<Text>().text;

        if (gid != "")
        {
            transform.GetComponent<SendReceiver>().RequestUrl = "http://" + GameObject.Find("ServerDropDown").GetComponent<Dropdown>().options[GameObject.Find("ServerDropDown").GetComponent<Dropdown>().value].text + "/rome/UpdateCheck.php?GameID=" + gid;
            transform.GetComponent<SendReceiver>().DoSendReceive(true);
        }
    }
    
    //Schreibt alle Informationen aus Karte in die Echten Gameobjekt-Karten
    public GameObject UpdateKarteInfosToCard(GameObject acard, Karte k)
    {
        acard.GetComponent<KarteFields>().LfdNr = k.LfdNr;
        acard.GetComponent<KarteFields>().StapelID = k.StapelID;
        acard.GetComponent<KarteFields>().Zaehlwert = k.Zaehlwert;
        acard.GetComponent<KarteFields>().Name = k.Name;
        acard.GetComponent<KarteFields>().Farbe = k.Farbe;
        acard.GetComponent<KarteFields>().Status = k.Status;
        acard.GetComponent<KarteFields>().Eigentuemer = k.Eigentuemer;
        acard.GetComponent<KarteFields>().AnlageID = k.AnlageID;
        acard.GetComponent<KarteFields>().FullInfo = k.Name + " " + k.Farbe + "(AnlageID: " + k.AnlageID + ")";

        return acard;
    }
       
    public void UpdateAllPlayer1Cards()
    {
        //Prüfen ob die Spieler1Karten sich geändert haben ---oben:
        // Debug.Log("Updating Player1Cards!!");

        //Aklle Kinder der PLayerArea löschen:
        foreach (Transform child in GameObject.Find("PlayerArea").transform)
        {
            Destroy(child.gameObject);
        }

        //Und neu erstellen:
        for (var i = 0; i < Player1CardsArray.Length; i++)
        {
            ///Erstellt Instanzen vom Prefab
            GameObject playerCard = Instantiate(cards[System.Convert.ToInt16(Player1CardsArray[i])], new Vector3(0, 0, 0), Quaternion.identity);
            playerCard = UpdateKarteInfosToCard(playerCard, GetCardByStapelID(System.Convert.ToInt16(Player1CardsArray[i])));

            //Name der Instanz ändern:
            //Bild der Instanz ändern
            playerCard.name = "Card " + Player1CardsArray[i] + "(Clone)";
            Image img = playerCard.GetComponent<Image>();
            Sprite sp = Resources.Load<Sprite>(Player1CardsArray[i].ToString());
            img.sprite = sp;

            //PlayerCard dem Canvas (bzw. der playerArea im Canvas) zuoordnen (damit die Instanzen sichtbar sind)
            playerCard.transform.SetParent(PlayerArea.transform, false);
        }

        OldPlayer1CardsArray = Player1CardsArray;
    }
    public void UpdateAllPlayer2Cards()
    {
        // Debug.Log("Updating Player2Cards!!");


        //Aklle Kinder der PLayerArea löschen:
        foreach (Transform child in GameObject.Find("PlayerArea").transform)
        {
            Destroy(child.gameObject);
        }

        //Und neu erstellen:
        for (var i = 0; i < Player2CardsArray.Length; i++)
        {
            ///Erstellt Instanzen vom Prefab
            GameObject playerCard = Instantiate(cards[System.Convert.ToInt16(Player2CardsArray[i])], new Vector3(0, 0, 0), Quaternion.identity);
            playerCard = UpdateKarteInfosToCard(playerCard, GetCardByStapelID(System.Convert.ToInt16(Player2CardsArray[i])));

            //Name der Instanz ändern:
            //Bild der Instanz ändern
            playerCard.name = "Card " + Player2CardsArray[i] + "(Clone)";
            Image img = playerCard.GetComponent<Image>();
            Sprite sp = Resources.Load<Sprite>(Player2CardsArray[i].ToString());
            img.sprite = sp;

            //PlayerCard dem Canvas (bzw. der playerArea im Canvas) zuoordnen (damit die Instanzen sichtbar sind)
            playerCard.transform.SetParent(PlayerArea.transform, false);
        }

        OldPlayer2CardsArray = Player2CardsArray;
    }
    public void UpdateAllEnemyCards()
    {
        //Prüfen ob die Gegnerkarten sich geändert haben --- oben ausgelagert:
        //Debug.Log("Updating EnemyCards!!");

        //Aklle Kinder der EnemyArea löschen:
        foreach (Transform child in GameObject.Find("EnemyArea").transform)
        {
            Destroy(child.gameObject);
        }

        //Und neu erstellen:
        if (GameObject.Find("wersendetText").GetComponent<Text>().text == "Player2")
        {
            ///Erstellt wenn Sender = Player2 (also Joiner) es is die x Karten von Spieler1
            for (var i = 0; i < Player1CardsArray.Length; i++)
            {
                ///EnemyCard dem Canvas (bzw. der playerArea im Canvas) zuoordnen (damit die Instanzen sichtbar sind)
                GameObject enemyCard = Instantiate(backcards[UnityEngine.Random.Range(0, backcards.Count)], new Vector3(0, 0, 0), Quaternion.identity);
                enemyCard.transform.SetParent(EnemyArea.transform, false);
            }

            OldEnemyCardsArray = Player1CardsArray;
        }

        if (GameObject.Find("wersendetText").GetComponent<Text>().text == "Player1")
        {
            ///Erstellt wenn Sender = Player1 (also Spielersteller) es is die x Karten von Spieler2
            for (var i = 0; i < Player2CardsArray.Length; i++)
            {
                ///Erstellt Instanzen vom Prefab
                ///EnemyCard dem Canvas (bzw. der playerArea im Canvas) zuoordnen (damit die Instanzen sichtbar sind)
                GameObject enemyCard = Instantiate(backcards[UnityEngine.Random.Range(0, backcards.Count)], new Vector3(0, 0, 0), Quaternion.identity);
                enemyCard.transform.SetParent(EnemyArea.transform, false);
            }

            OldEnemyCardsArray = Player2CardsArray;
        }
    }
    public void UpdateAllDroppedCards()
    {
        //Wenn wegwerfebnn gültig, in den Wartemodus schalten
        //AChtung gültigkeit später noch abfragen!!
        //Wenn die Weggeworfene Karte aktzeptiert wird...dann starte Timer
        //sonst Karte zurück vom ablegestapel zum Sender zurück....

        //StartTimer();
        //Debug.Log("DDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDD");


        //Prüfen ob die Gegnerkarten sich geändert haben --- oben ausgelagert:
        //Debug.Log("Updating EnemyCards!!");

        //Aklle Kinder der EnemyArea löschen:
        foreach (Transform child in GameObject.Find("DropZone10").transform)
        {
            Destroy(child.gameObject);
        }

        //Und neu erstellen:
        int lastelementpos;
        int lastelementid;
        if (GameObject.Find("wersendetText").GetComponent<Text>().text == "Player2")
        {
            lastelementpos = DroppedCardsArray.Length - 1;
            lastelementid = System.Convert.ToInt16(DroppedCardsArray[lastelementpos]);

            if (lastelementid != 999)
            {
                GameObject droppedCard = Instantiate(cards[lastelementid], new Vector3(0, 0, 0), Quaternion.identity);
                droppedCard = UpdateKarteInfosToCard(droppedCard, GetCardByStapelID(lastelementid));

                //Name der Instanz ändern:
                //Bild der Instanz ändern
                droppedCard.name = "Card " + DroppedCardsArray[lastelementpos].ToString() + "(Clone)";
                Image img = droppedCard.GetComponent<Image>();
                Sprite sp = Resources.Load<Sprite>(DroppedCardsArray[lastelementpos].ToString());
                img.sprite = sp;

                droppedCard.transform.SetParent(GameObject.Find("DropZone10").transform, false);
                droppedCard.tag = "InZoneCard";
                OldDroppedCardsArray = DroppedCardsArray;
            }
            else
            {
                GameObject droppedCard = Instantiate(dummycard, new Vector3(0, 0, 0), Quaternion.identity);
                droppedCard.transform.SetParent(GameObject.Find("DropZone10").transform, false);
                droppedCard.tag = "InZoneCard";
                OldDroppedCardsArray = DroppedCardsArray;
            }
        }

        if (GameObject.Find("wersendetText").GetComponent<Text>().text == "Player1")
        {
            lastelementpos = DroppedCardsArray.Length - 1;
            lastelementid = System.Convert.ToInt16(DroppedCardsArray[lastelementpos]);

            if (lastelementid != 999)
            {
                GameObject droppedCard = Instantiate(cards[lastelementid], new Vector3(0, 0, 0), Quaternion.identity);
                droppedCard = UpdateKarteInfosToCard(droppedCard, GetCardByStapelID(lastelementid));

                //Name der Instanz ändern:
                //Bild der Instanz ändern
                droppedCard.name = "Card " + DroppedCardsArray[lastelementpos].ToString() + "(Clone)";
                Image img = droppedCard.GetComponent<Image>();
                Sprite sp = Resources.Load<Sprite>(DroppedCardsArray[lastelementpos].ToString());
                img.sprite = sp;

                droppedCard.transform.SetParent(GameObject.Find("DropZone10").transform, false);
                droppedCard.tag = "InZoneCard";
                OldDroppedCardsArray = DroppedCardsArray;
            }
            else
            {
                GameObject droppedCard = Instantiate(dummycard, new Vector3(0, 0, 0), Quaternion.identity);
                droppedCard.transform.SetParent(GameObject.Find("DropZone10").transform, false);
                droppedCard.tag = "InZoneCard";
                OldDroppedCardsArray = DroppedCardsArray;
            }
        }
    }
    public void UpdateAllDZ1Cards()
    {
        //Aklle Kinder der Dropzone1 löschen:
        foreach (Transform child in GameObject.Find("DropZone1").transform)
        {
            Destroy(child.gameObject);
        }

        //Und neu erstellen:
        for (var i = 0; i < DZ1CardsArray.Length; i++)
        {
            ///Erstellt Instanzen vom Prefab
            GameObject dropZoneCard = Instantiate(cards[System.Convert.ToInt16(DZ1CardsArray[i])], new Vector3(0, 0, 0), Quaternion.identity);
            dropZoneCard = UpdateKarteInfosToCard(dropZoneCard, GetCardByStapelID(System.Convert.ToInt16(DZ1CardsArray[i])));

            //Name der Instanz ändern:
            //Bild der Instanz ändern
            dropZoneCard.name = "Card " + DZ1CardsArray[i].ToString() + "(Clone)";
            Image img = dropZoneCard.GetComponent<Image>();
            Sprite sp = Resources.Load<Sprite>(DZ1CardsArray[i].ToString());
            img.sprite = sp;

            //DropZoneCard der Dropzone zupordnen 
            dropZoneCard.transform.tag = "InZoneCard";
            dropZoneCard.transform.SetParent(GameObject.Find("DropZone1").transform, false);
        }

        OldDZ1CardsArray = DZ1CardsArray;
    }
    public void UpdateAllDZ2Cards()
    {
        //Aklle Kinder der Dropzone1 löschen:
        foreach (Transform child in GameObject.Find("DropZone2").transform)
        {
            Destroy(child.gameObject);
        }

        //Und neu erstellen:
        for (var i = 0; i < DZ2CardsArray.Length; i++)
        {
            ///Erstellt Instanzen vom Prefab
            GameObject dropZoneCard = Instantiate(cards[System.Convert.ToInt16(DZ2CardsArray[i])], new Vector3(0, 0, 0), Quaternion.identity);
            dropZoneCard = UpdateKarteInfosToCard(dropZoneCard, GetCardByStapelID(System.Convert.ToInt16(DZ2CardsArray[i])));

            //Name der Instanz ändern:
            //Bild der Instanz ändern
            dropZoneCard.name = "Card " + DZ2CardsArray[i].ToString() + "(Clone)";
            Image img = dropZoneCard.GetComponent<Image>();
            Sprite sp = Resources.Load<Sprite>(DZ2CardsArray[i].ToString());
            img.sprite = sp;

            //DropZoneCard der Dropzone zupordnen 
            dropZoneCard.transform.tag = "InZoneCard";
            dropZoneCard.transform.SetParent(GameObject.Find("DropZone2").transform, false);
        }

        OldDZ2CardsArray = DZ2CardsArray;
    }
    public void UpdateAllDZ3Cards()
    {
        //Aklle Kinder der Dropzone1 löschen:
        foreach (Transform child in GameObject.Find("DropZone3").transform)
        {
            Destroy(child.gameObject);
        }

        //Und neu erstellen:
        for (var i = 0; i < DZ3CardsArray.Length; i++)
        {
            ///Erstellt Instanzen vom Prefab
            GameObject dropZoneCard = Instantiate(cards[System.Convert.ToInt16(DZ3CardsArray[i])], new Vector3(0, 0, 0), Quaternion.identity);
            dropZoneCard = UpdateKarteInfosToCard(dropZoneCard, GetCardByStapelID(System.Convert.ToInt16(DZ3CardsArray[i])));

            //Name der Instanz ändern:
            //Bild der Instanz ändern
            dropZoneCard.name = "Card " + DZ3CardsArray[i].ToString() + "(Clone)";
            Image img = dropZoneCard.GetComponent<Image>();
            Sprite sp = Resources.Load<Sprite>(DZ3CardsArray[i].ToString());
            img.sprite = sp;

            //DropZoneCard der Dropzone zupordnen 
            dropZoneCard.transform.tag = "InZoneCard";
            dropZoneCard.transform.SetParent(GameObject.Find("DropZone3").transform, false);
        }

        OldDZ3CardsArray = DZ3CardsArray;
    }
    public void UpdateAllDZ4Cards()
    {
        //Aklle Kinder der Dropzone1 löschen:
        foreach (Transform child in GameObject.Find("DropZone4").transform)
        {
            Destroy(child.gameObject);
        }

        //Und neu erstellen:
        for (var i = 0; i < DZ4CardsArray.Length; i++)
        {
            ///Erstellt Instanzen vom Prefab
            GameObject dropZoneCard = Instantiate(cards[System.Convert.ToInt16(DZ4CardsArray[i])], new Vector3(0, 0, 0), Quaternion.identity);
            dropZoneCard = UpdateKarteInfosToCard(dropZoneCard, GetCardByStapelID(System.Convert.ToInt16(DZ4CardsArray[i])));

            //Name der Instanz ändern:
            //Bild der Instanz ändern
            dropZoneCard.name = "Card " + DZ4CardsArray[i].ToString() + "(Clone)";
            Image img = dropZoneCard.GetComponent<Image>();
            Sprite sp = Resources.Load<Sprite>(DZ4CardsArray[i].ToString());
            img.sprite = sp;

            //DropZoneCard der Dropzone zupordnen 
            dropZoneCard.transform.tag = "InZoneCard";
            dropZoneCard.transform.SetParent(GameObject.Find("DropZone4").transform, false);
        }

        OldDZ4CardsArray = DZ4CardsArray;
    }
    public void UpdateAllDZ5Cards()
    {
        //Aklle Kinder der Dropzone1 löschen:
        foreach (Transform child in GameObject.Find("DropZone5").transform)
        {
            Destroy(child.gameObject);
        }

        //Und neu erstellen:
        for (var i = 0; i < DZ5CardsArray.Length; i++)
        {
            ///Erstellt Instanzen vom Prefab
            GameObject dropZoneCard = Instantiate(cards[System.Convert.ToInt16(DZ5CardsArray[i])], new Vector3(0, 0, 0), Quaternion.identity);
            dropZoneCard = UpdateKarteInfosToCard(dropZoneCard, GetCardByStapelID(System.Convert.ToInt16(DZ5CardsArray[i])));

            //Name der Instanz ändern:
            //Bild der Instanz ändern
            dropZoneCard.name = "Card " + DZ5CardsArray[i].ToString() + "(Clone)";
            Image img = dropZoneCard.GetComponent<Image>();
            Sprite sp = Resources.Load<Sprite>(DZ5CardsArray[i].ToString());
            img.sprite = sp;

            //DropZoneCard der Dropzone zupordnen 
            dropZoneCard.transform.tag = "InZoneCard";
            dropZoneCard.transform.SetParent(GameObject.Find("DropZone5").transform, false);
        }

        OldDZ5CardsArray = DZ5CardsArray;
    }
    public void UpdateAllDZ6Cards()
    {
        //Aklle Kinder der Dropzone1 löschen:
        foreach (Transform child in GameObject.Find("DropZone6").transform)
        {
            Destroy(child.gameObject);
        }

        //Und neu erstellen:
        for (var i = 0; i < DZ6CardsArray.Length; i++)
        {
            ///Erstellt Instanzen vom Prefab
            GameObject dropZoneCard = Instantiate(cards[System.Convert.ToInt16(DZ6CardsArray[i])], new Vector3(0, 0, 0), Quaternion.identity);
            dropZoneCard = UpdateKarteInfosToCard(dropZoneCard, GetCardByStapelID(System.Convert.ToInt16(DZ6CardsArray[i])));

            //Name der Instanz ändern:
            //Bild der Instanz ändern
            dropZoneCard.name = "Card " + DZ6CardsArray[i].ToString() + "(Clone)";
            Image img = dropZoneCard.GetComponent<Image>();
            Sprite sp = Resources.Load<Sprite>(DZ6CardsArray[i].ToString());
            img.sprite = sp;

            //DropZoneCard der Dropzone zupordnen 
            dropZoneCard.transform.tag = "InZoneCard";
            dropZoneCard.transform.SetParent(GameObject.Find("DropZone6").transform, false);
        }

        OldDZ6CardsArray = DZ6CardsArray;
    }
    public void UpdateAllDZ7Cards()
    {
        //Aklle Kinder der Dropzone1 löschen:
        foreach (Transform child in GameObject.Find("DropZone7").transform)
        {
            Destroy(child.gameObject);
        }

        //Und neu erstellen:
        for (var i = 0; i < DZ7CardsArray.Length; i++)
        {
            ///Erstellt Instanzen vom Prefab
            GameObject dropZoneCard = Instantiate(cards[System.Convert.ToInt16(DZ7CardsArray[i])], new Vector3(0, 0, 0), Quaternion.identity);
            dropZoneCard = UpdateKarteInfosToCard(dropZoneCard, GetCardByStapelID(System.Convert.ToInt16(DZ7CardsArray[i])));

            //Name der Instanz ändern:
            //Bild der Instanz ändern
            dropZoneCard.name = "Card " + DZ7CardsArray[i].ToString() + "(Clone)";
            Image img = dropZoneCard.GetComponent<Image>();
            Sprite sp = Resources.Load<Sprite>(DZ7CardsArray[i].ToString());
            img.sprite = sp;

            //DropZoneCard der Dropzone zupordnen 
            dropZoneCard.transform.tag = "InZoneCard";
            dropZoneCard.transform.SetParent(GameObject.Find("DropZone7").transform, false);
        }

        OldDZ7CardsArray = DZ7CardsArray;
    }
    public void UpdateAllDZ8Cards()
    {
        //Aklle Kinder der Dropzone1 löschen:
        foreach (Transform child in GameObject.Find("DropZone8").transform)
        {
            Destroy(child.gameObject);
        }

        //Und neu erstellen:
        for (var i = 0; i < DZ8CardsArray.Length; i++)
        {
            ///Erstellt Instanzen vom Prefab
            GameObject dropZoneCard = Instantiate(cards[System.Convert.ToInt16(DZ8CardsArray[i])], new Vector3(0, 0, 0), Quaternion.identity);
            dropZoneCard = UpdateKarteInfosToCard(dropZoneCard, GetCardByStapelID(System.Convert.ToInt16(DZ8CardsArray[i])));

            //Name der Instanz ändern:
            //Bild der Instanz ändern
            dropZoneCard.name = "Card " + DZ8CardsArray[i].ToString() + "(Clone)";
            Image img = dropZoneCard.GetComponent<Image>();
            Sprite sp = Resources.Load<Sprite>(DZ8CardsArray[i].ToString());
            img.sprite = sp;

            //DropZoneCard der Dropzone zupordnen 
            dropZoneCard.transform.tag = "InZoneCard";
            dropZoneCard.transform.SetParent(GameObject.Find("DropZone8").transform, false);
        }

        OldDZ8CardsArray = DZ8CardsArray;
    }
    public void UpdateAllDZ9Cards()
    {
        //Aklle Kinder der Dropzone1 löschen:
        foreach (Transform child in GameObject.Find("DropZone9").transform)
        {
            Destroy(child.gameObject);
        }

        //Und neu erstellen:
        for (var i = 0; i < DZ9CardsArray.Length; i++)
        {
            ///Erstellt Instanzen vom Prefab
            GameObject dropZoneCard = Instantiate(cards[System.Convert.ToInt16(DZ9CardsArray[i])], new Vector3(0, 0, 0), Quaternion.identity);
            dropZoneCard = UpdateKarteInfosToCard(dropZoneCard, GetCardByStapelID(System.Convert.ToInt16(DZ9CardsArray[i])));

            //Name der Instanz ändern:
            //Bild der Instanz ändern
            dropZoneCard.name = "Card " + DZ9CardsArray[i].ToString() + "(Clone)";
            Image img = dropZoneCard.GetComponent<Image>();
            Sprite sp = Resources.Load<Sprite>(DZ9CardsArray[i].ToString());
            img.sprite = sp;

            //DropZoneCard der Dropzone zupordnen 
            dropZoneCard.transform.tag = "InZoneCard";
            dropZoneCard.transform.SetParent(GameObject.Find("DropZone9").transform, false);
        }

        OldDZ9CardsArray = DZ9CardsArray;
    }
    public void StartTimer()
    {
        TimerStatus = true;
    }
    public void StopTimer()
    {
        TimerStatus = false;
    }
    
    /// Aus DragDrop:
    //Anlege-Prüf-Routinen:
    public bool CheckSerieNormal(GameObject thiscard, GameObject child, int DZ_count)
    {
        Transform transform = thiscard.transform;

        Debug.Log("<color=white>===============Enter  CheckSerieNormal===============================================================</color>");

        bool istgleichefarbe = child.GetComponent<KarteFields>().Farbe == transform.GetComponent<KarteFields>().Farbe;

        //Prüfen ob die Gedroppte Karte rechts anlegbar ist, also eine Höher als das rechteste also letze Child:
        if (child.GetComponent<KarteFields>().AnlageID + 1 == transform.GetComponent<KarteFields>().AnlageID && istgleichefarbe)
        {
            //Nun da die Karte rechts Anlegbar ist schauen, ob es sich um das Rechteste Child handelt (mittelanlage in Serie verhindern):
            //Rechteste Karte wird ermittelt indem der SiblinIndex des Chiöds mit der Gesamtanzahl der Childs im DZ  abzüglich der noch nicht gelgten Karte geprüft wird
            if (child.transform.GetSiblingIndex() == DropZones[DZ_count].transform.childCount - 1)
            {
                transform.SetParent(DropZones[DZ_count].transform, false);
                GameObject.Find("SoundCardDrop4").GetComponent<AudioSource>().Play(0);
                transform.GetComponent<DragDrop>().anlegemerker = true;
                transform.SetAsLastSibling();
                Debug.Log("<color=green>" + transform.GetComponent<KarteFields>().FullInfo + " erfolgreich rechts an Child (mit Siblingindex " + child.transform.GetSiblingIndex() + ")" + child.GetComponent<KarteFields>().FullInfo + " angelegt</color>");
                return true;
            }
            else
            {
                Debug.Log("<color=red>" + transform.GetComponent<KarteFields>().FullInfo + " ist nicht   rechts an Child (mit Siblingindex " + child.transform.GetSiblingIndex() + ")" + child.GetComponent<KarteFields>().FullInfo + " anlegbar</color>");
            }
        }
        else
        {
            Debug.Log("<color=red>" + transform.GetComponent<KarteFields>().FullInfo + " ist nicht   rechts an Child (mit Siblingindex " + child.transform.GetSiblingIndex() + ")" + child.GetComponent<KarteFields>().FullInfo + " anlegbar</color>");
        }


        //Prüfen ob die Gedroppte Karte links anlegbar ist, also eine niedriger als das linkeste also erste Child:
        if (child.GetComponent<KarteFields>().AnlageID - 1 == transform.GetComponent<KarteFields>().AnlageID && istgleichefarbe)
        {
            //Nun da die Karte links Anlegbar ist schauen, ob es sich um das linkeste Child handelt (mittelanlage in Serie verhindern):
            //linkeste Karte wird ermittelt indem der SiblinIndex des Childs 0 sein muss (dannn ist es das  in der Schleife zuerst aufgerufene Child)
            if (child.transform.GetSiblingIndex() == 0)
            {
                transform.SetParent(DropZones[DZ_count].transform, false);
                GameObject.Find("SoundCardDrop3").GetComponent<AudioSource>().Play(0);
                transform.GetComponent<DragDrop>().anlegemerker = true;
                transform.SetAsFirstSibling();
                Debug.Log("<color=green>" + transform.GetComponent<KarteFields>().FullInfo + " erfolgreich links an Child (mit Siblingindex " + child.transform.GetSiblingIndex() + ")" + child.GetComponent<KarteFields>().FullInfo + " angelegt</color>");
                return true;
            }
            else
            {
                Debug.Log("<color=red>" + transform.GetComponent<KarteFields>().FullInfo + " ist nicht   links an Child (mit Siblingindex " + child.transform.GetSiblingIndex() + ")" + child.GetComponent<KarteFields>().FullInfo + " anlegbar da die Karte schon liegt</color>");
                return false;
            }
        }
        else
        {
            Debug.Log("<color=red>" + transform.GetComponent<KarteFields>().FullInfo + " ist nicht   links an Child (mit Siblingindex " + child.transform.GetSiblingIndex() + ")" + child.GetComponent<KarteFields>().FullInfo + " anlegbar</color>");
            return false;
        }
    }
    //Prüft ob rechts Ass anlegbar oder links 
    public bool CheckSerieAssKoenigUebersprung(GameObject thiscard, GameObject child, int DZ_count)
    {
        Transform transform = thiscard.transform;
        Debug.Log("<color=white>===============Enter CheckSerieAssKoenigUebersprung==================================================</color>");
        bool istgleichefarbe = child.GetComponent<KarteFields>().Farbe == transform.GetComponent<KarteFields>().Farbe;

        //Prüfen ob die Gedroppte Karte rechts anlegbar ist, also eine Höher als das rechteste also letze Child:
        if (child.GetComponent<KarteFields>().AnlageID - 12 == transform.GetComponent<KarteFields>().AnlageID && istgleichefarbe)
        {
            //Nun da die Karte rechts Anlegbar ist schauen, ob es sich um das Rechteste Child handelt (mittelanlage in Serie verhindern):
            //Rechteste Karte wird ermittelt indem der SiblinIndex des Chiöds mit der Gesamtanzahl der Childs im DZ  abzüglich der noch nicht gelgten Karte geprüft wird
            if (child.transform.GetSiblingIndex() == DropZones[DZ_count].transform.childCount - 1)
            {
                transform.SetParent(DropZones[DZ_count].transform, false);
                GameObject.Find("SoundCardDrop2").GetComponent<AudioSource>().Play(0);
                transform.GetComponent<DragDrop>().anlegemerker = true;
                transform.SetAsLastSibling();
                Debug.Log("<color=green>" + transform.GetComponent<KarteFields>().FullInfo + " erfolgreich mit Übersrpung rechts an Child (mit Siblingindex " + child.transform.GetSiblingIndex() + ")" + child.GetComponent<KarteFields>().FullInfo + " angelegt</color>");
                return true;
            }
            else
            {
                Debug.Log("<color=red>" + transform.GetComponent<KarteFields>().FullInfo + " ist nicht mit Übersprung rechts an Child (mit Siblingindex " + child.transform.GetSiblingIndex() + ")" + child.GetComponent<KarteFields>().FullInfo + " anlegbar da die Karte schon liegt</color>");
            }
        }
        else
        {
            Debug.Log("<color=red>" + transform.GetComponent<KarteFields>().FullInfo + " ist nicht mit Übersrpung rechts an Child (mit Siblingindex " + child.transform.GetSiblingIndex() + ")" + child.GetComponent<KarteFields>().FullInfo + " anlegbar</color>");
        }

        //Prüfen ob die Gedroppte Karte links anlegbar ist, also eine niedriger als das linkeste also erste Child:
        if (child.GetComponent<KarteFields>().AnlageID + 12 == transform.GetComponent<KarteFields>().AnlageID && istgleichefarbe)
        {
            //Nun da die Karte links Anlegbar ist schauen, ob es sich um das linkeste Child handelt (mittelanlage in Serie verhindern):
            //linkeste Karte wird ermittelt indem der SiblinIndex des Childs 0 sein muss (dannn ist es das  in der Schleife zuerst aufgerufene Child)
            if (child.transform.GetSiblingIndex() == 0)
            {
                transform.SetParent(DropZones[DZ_count].transform, false);
                GameObject.Find("SoundCardDrop1").GetComponent<AudioSource>().Play(0);
                transform.GetComponent<DragDrop>().anlegemerker = true;
                transform.SetAsFirstSibling();
                Debug.Log("<color=green>" + transform.GetComponent<KarteFields>().FullInfo + " erfolgreich mit Übersrpung links an Child (mit Siblingindex " + child.transform.GetSiblingIndex() + ")" + child.GetComponent<KarteFields>().FullInfo + " angelegt</color>");
                return true;
            }
            else
            {
                Debug.Log("<color=red>" + transform.GetComponent<KarteFields>().FullInfo + " ist nicht   links an Child (mit Siblingindex " + child.transform.GetSiblingIndex() + ")" + child.GetComponent<KarteFields>().FullInfo + " anlegbar da die Karte schon liegt</color>");
                return false;
            }
        }
        else
        {
            Debug.Log("<color=red>" + transform.GetComponent<KarteFields>().FullInfo + " ist nicht mit Übersrpung links an Child (mit Siblingindex " + child.transform.GetSiblingIndex() + ")" + child.GetComponent<KarteFields>().FullInfo + " anlegbar</color>");
            return false;
        }
    }
    public bool CheckGleiche(GameObject thiscard, int DZ_count)
    {
        Transform transform = thiscard.transform;
        //Alle Childs auflisten
        bool bisjetztpasstes = false;
        foreach (Transform superchild in DropZones[DZ_count].transform)
        {
            Debug.Log("Listning all Cardz in DZ ==> " + superchild.GetComponent<KarteFields>().FullInfo);

            if (superchild.GetComponent<KarteFields>().AnlageID == transform.GetComponent<KarteFields>().AnlageID && superchild.GetComponent<KarteFields>().Farbe != transform.GetComponent<KarteFields>().Farbe)
            {
                bisjetztpasstes = true;
            }
            else
            {
                bisjetztpasstes = false;
                break;
            }

            Debug.Log("bisjetztpasstes: " + bisjetztpasstes);
        }


        if (bisjetztpasstes)
        {
            transform.SetParent(DropZones[DZ_count].transform, false);
            GameObject.Find("SoundCardDrop3").GetComponent<AudioSource>().Play(0);
            transform.GetComponent<DragDrop>().anlegemerker = true;
            transform.SetAsLastSibling();
            return true;
        }
        else
        {
            return false;
        }

    }
    
    //Dirkefunktionen:
    //Wenn aufgerufen werden Alle angelegten Karten in allen 9 Dropzones zurück an den Spieler gegeben
    public void UndoCardAnlegen()
    {      
        
        for (int DZ_count = 0; DZ_count < 9; DZ_count++)
        {
            rekursivaufruf:
            int children = DropZones[DZ_count].transform.childCount;
            for (int i = 0; i < children; ++i)
            {
                Transform child = DropZones[DZ_count].transform.GetChild(i);
                if (child.GetComponent<DragDrop>().anlegemerker == true)
                {
                    AllowWegwerfen();//Da eine "rückgängig Karte" gefunden wurde wegwerfen wieder erlauben
                    GameObject.Find("StatusTextBox").GetComponent<Text>().text = "Angelegte Karten(n) wurden dir zurück gegeben";
                    GameObject.Find("StatusTextBox").GetComponent<Text>().color = Color.green;
                    //Karten sortieren freigeben:
                    GameObject.Find("ButtonSortMode").GetComponent<CanvasGroup>().alpha = 1f;
                    GameObject.Find("ButtonSortMode").GetComponent<CanvasGroup>().blocksRaycasts = true;

                    //Rückgängig-Button sperren:
                    GameObject.Find("ButtonRueckGaengig").GetComponent<CanvasGroup>().alpha = 0f;
                    GameObject.Find("ButtonRueckGaengig").GetComponent<CanvasGroup>().blocksRaycasts = false;


                    child.GetComponent<DragDrop>().anlegemerker = false;
                    child.SetParent(GameObject.Find("PlayerArea").transform, false);
                    child.SetSiblingIndex(child.GetComponent<DragDrop>().StartDragSiblingindex);
                    child.tag = "Untagged";
                    //Ausnahmsweise im inneren Rekursion aus Basic Zeiten, denn immer wenn eins entfernt wurde stimmen die DurchlaufIDS nicht mehr,
                    //daher solange entfernen bis keins mehr da ist durch Sprung in neue innere Schleifenprüfung ggf später mit While lösen 
                    goto rekursivaufruf;
                }
            }
        }

        StartTimer();
        targetTime = 0.1f;//InstantTimer            
    }

    //Setzt DropZone 10 auf grün (wegwerfen erlaubt=)  
    public void AllowWegwerfen()
    {
        Color mycolor;
        mycolor.r = 255; mycolor.g = 255; mycolor.b = 255; mycolor.a = 0.20f;
        GameObject.Find("DropZone10").GetComponent<Image>().color = mycolor;
        GameObject.Find("DropZone10").tag = "COLLIDE";
    }

    //ServerreturnHandler:
    private void HandleWebResult()
    {
        if (transform.GetComponent<SendReceiver>().ResLines[0] == "LatestID")
        {
            //GameID einschreiben:
            string str = transform.GetComponent<SendReceiver>().ResLines[1];
            GameObject.Find("GameIDTextBox").GetComponent<Text>().text = str;
        }
        else if (transform.GetComponent<SendReceiver>().ResLines[0] == "Error im Aufruf!")
        {
            Debug.Log("tschö mit ö");
            Application.Quit();
        }
        else if (transform.GetComponent<SendReceiver>().ResLines[0] == "NewGame")
        {
            //GameID setzen wenn Spiel erfolgreich kreiert wurde
            GameObject.Find("GameIDTextBox").GetComponent<Text>().text = transform.GetComponent<SendReceiver>().ResLines[1];
            GameObject.Find("GameIDTextBoxDuplicat").GetComponent<Text>().text = transform.GetComponent<SendReceiver>().ResLines[1];

            //Da ein Neues Spiel erstellt wurde ist Sender = Spieler1:
            GameObject.Find("wersendetText").GetComponent<Text>().text = "Player1";

            //PrMerken wer dran ist:
            GameObject.Find("weristdranText").GetComponent<Text>().text = transform.GetComponent<SendReceiver>().ResLines[4];
                       
            //Timer Starten da erfolgreich ein Spiel erstellt wurde, ab jetzt wird Timer alle Objekte Instanzieren und Destroyen!
            StartTimer();
            targetTime = 0.1f;//InstantTimer

            GameObject.Find("StatusTextBox").GetComponent<Text>().text = "Los gehts!";
        }
        else if (transform.GetComponent<SendReceiver>().ResLines[0] == "JoinGame")
        {
            //Spiel gefunden?
            if (transform.GetComponent<SendReceiver>().ResLines[1] == "NOGAME")
            {
                GameObject.Find("StatusTextBox").GetComponent<Text>().text = "Kein Spiel mit dieser ID gefunden";
                return;
            }
            else//wenn Spiel gefunden vom Server zurück kommt ===>
            {
                GameObject.Find("StatusTextBox").GetComponent<Text>().text = "Spiel vom " + transform.GetComponent<SendReceiver>().ResLines[3] + " gefunden";
                GameObject.Find("StatusTextBox").GetComponent<Text>().text = "Los gehts!";

                if (transform.GetComponent<SendReceiver>().ResLines[4] == "Player2hat13")
                {
                    gezogenstatus = true;
                }
                else if (transform.GetComponent<SendReceiver>().ResLines[4] == "Player1hat13")
                {
                    gezogenstatus = false;
                    //Wenn man keine 13 hat muss man erst eine ziehen, dann also estz DZ´s zugriffsfähig machen:                     
                    set_all_dropzones_collidestatus("NOTCOLLIDE");
                }

                //HauptGameID Feld füllen:
                GameObject.Find("GameIDTextBox").GetComponent<Text>().text = transform.GetComponent<SendReceiver>().ResLines[1];
                GameObject.Find("GameIDTextBoxDuplicat").GetComponent<Text>().text = transform.GetComponent<SendReceiver>().ResLines[1];

                //Da Join Spiel gewählt wurde ist Sender = Spieler2
                GameObject.Find("wersendetText").GetComponent<Text>().text = "Player2";

                //Timer Starten da erfolgreich ein Spiel gejoined wurde, ab jetzt wird Timer alle Objekte Instanzieren und Destroyen!
                StartTimer();
                targetTime = 0.1f;//InstantTimer

                GameObject.Find("SpielvorbereitungContainerBG").GetComponent<Slideinout>().PushOut();

                List<GameObject> MusicObjects;
                MusicObjects = new List<GameObject>();
                MusicObjects.Add(GameObject.Find("Sound1"));
                MusicObjects.Add(GameObject.Find("Sound2"));
                MusicObjects.Add(GameObject.Find("Sound3"));
                MusicObjects.Add(GameObject.Find("Sound4"));
                MusicObjects.Add(GameObject.Find("Sound5"));
                MusicObjects.Add(GameObject.Find("Sound6"));
                Random rnd = new Random();
                int dice = rnd.Next(0, 6); // creates a number between 1 and 6      
                MusicObjects[dice].GetComponent<AudioSource>().Play(0);

            }
        }
        else if (transform.GetComponent<SendReceiver>().ResLines[0] == "KarteZiehen")
        {
            if (transform.GetComponent<SendReceiver>().ResLines[1] == "iofromgegner")
            {
                //Timer Starten da erfolgreich eine Karte gezogn wurde (soll Timern obwohl man dran ist):
                StartTimer();
                targetTime = 0.1f;//InstantTimer                 
                gezogenstatus = true;

                //wenn erfolgreich Karte gezogen DummmyKarte wieder platzieren:
                foreach (Transform child in GameObject.Find("DropZone10").transform)
                {
                    Destroy(child.gameObject);
                }
                GameObject droppedCard = Instantiate(dummycard, new Vector3(0, 0, 0), Quaternion.identity);
                droppedCard.transform.SetParent(GameObject.Find("DropZone10").transform, false);
                droppedCard.tag = "InZoneCard";

                ///Alle Dropzones aktivieren, da eine Karte gezogen wurde:
                set_all_dropzones_collidestatus("COLLIDE");

                GameObject.Find("StatusTextBox").GetComponent<Text>().text = "Karte vom Gegner gezogen, nun anlegen und/oder wegwerfen!";

            }
            else if (transform.GetComponent<SendReceiver>().ResLines[1] == "iofromstack")
            {
                //Timer Starten da erfolgreich eine Karte gezogn wurde (soll Timern obwohl man dran ist):
                StartTimer();
                targetTime = 0.1f;//InstantTimer                 
                gezogenstatus = true;

                ///Alle Dropzones aktivieren, da eine Karte gezogen wurde:
                set_all_dropzones_collidestatus("COLLIDE");
                GameObject.Find("StatusTextBox").GetComponent<Text>().text = "Karte vom Stapel gezogen, nun anlegen und/oder wegwerfen!";
            }
            
            else
            {
                GameObject.Find("StatusTextBox").GetComponent<Text>().text = transform.GetComponent<SendReceiver>().ResLines[1];
                GameObject.Find("SoundCardRefuse").GetComponent<AudioSource>().Play(0);
            }
        }
        else if (transform.GetComponent<SendReceiver>().ResLines[0] == "UpdateCheck")
        {
            ///DB lokal Spiegeln:
            string id = transform.GetComponent<SendReceiver>().ResLines[1];
            string GameID = transform.GetComponent<SendReceiver>().ResLines[2];
            string GameCreationTime = transform.GetComponent<SendReceiver>().ResLines[3];
            string Player1Cards = transform.GetComponent<SendReceiver>().ResLines[4];
            string Player2Cards = transform.GetComponent<SendReceiver>().ResLines[5];
            string UsedCards = transform.GetComponent<SendReceiver>().ResLines[6];
            string Player1KartenInHand = transform.GetComponent<SendReceiver>().ResLines[7];
            string Player2KartenInHand = transform.GetComponent<SendReceiver>().ResLines[8];
            string zugid = transform.GetComponent<SendReceiver>().ResLines[9];
            string Spielphase = transform.GetComponent<SendReceiver>().ResLines[10];
            string weristdran = transform.GetComponent<SendReceiver>().ResLines[11];
            string DZ1Cards = transform.GetComponent<SendReceiver>().ResLines[12];
            string DZ2Cards = transform.GetComponent<SendReceiver>().ResLines[13];
            string DZ3Cards = transform.GetComponent<SendReceiver>().ResLines[14];
            string DZ4Cards = transform.GetComponent<SendReceiver>().ResLines[15];
            string DZ5Cards = transform.GetComponent<SendReceiver>().ResLines[16];
            string DZ6Cards = transform.GetComponent<SendReceiver>().ResLines[17];
            string DZ7Cards = transform.GetComponent<SendReceiver>().ResLines[18];
            string DZ8Cards = transform.GetComponent<SendReceiver>().ResLines[19];
            string DZ9Cards = transform.GetComponent<SendReceiver>().ResLines[20];
            string dropzone10 = transform.GetComponent<SendReceiver>().ResLines[21];


            //Sollte ein gewinner feststehen:
            if (Spielphase == "WinPlayer1")
            {
                GameObject.Find("StatsContainerBG").GetComponent<Slideinout>().PushIn();
                GameObject.Find("SoundStats").GetComponent<AudioSource>().Play(0);
                GameObject.Find("Sound1").GetComponent<AudioSource>().Stop();
                GameObject.Find("Sound2").GetComponent<AudioSource>().Stop();
                GameObject.Find("Sound3").GetComponent<AudioSource>().Stop();
                GameObject.Find("Sound4").GetComponent<AudioSource>().Stop();
                GameObject.Find("Sound5").GetComponent<AudioSource>().Stop();
                GameObject.Find("Sound6").GetComponent<AudioSource>().Stop();



                //Strafpunkte eintragen
                GameObject.Find("Player2SP").GetComponent<Text>().text = transform.GetComponent<SendReceiver>().ResLines[23].ToString();

                int sum;
                sum = System.Convert.ToInt16(GameObject.Find("Player2SPGES").GetComponent<Text>().text) + System.Convert.ToInt16(GameObject.Find("Player2SP").GetComponent<Text>().text);
                GameObject.Find("Player2SPGES").GetComponent<Text>().text = sum.ToString();
                StopTimer();

            }

            if (Spielphase == "WinPlayer2")
            {
                GameObject.Find("StatsContainerBG").GetComponent<Slideinout>().PushIn();
                GameObject.Find("SoundStats").GetComponent<AudioSource>().Play(0);

                GameObject.Find("Sound1").GetComponent<AudioSource>().Stop();
                GameObject.Find("Sound2").GetComponent<AudioSource>().Stop();
                GameObject.Find("Sound3").GetComponent<AudioSource>().Stop();
                GameObject.Find("Sound4").GetComponent<AudioSource>().Stop();
                GameObject.Find("Sound5").GetComponent<AudioSource>().Stop();
                GameObject.Find("Sound6").GetComponent<AudioSource>().Stop();


                //Strafpunkte eintragen
                GameObject.Find("Player1SP").GetComponent<Text>().text = transform.GetComponent<SendReceiver>().ResLines[22].ToString();

                int sum;
                sum = System.Convert.ToInt16(GameObject.Find("Player1SPGES").GetComponent<Text>().text) + System.Convert.ToInt16(GameObject.Find("Player1SP").GetComponent<Text>().text);
                GameObject.Find("Player1SPGES").GetComponent<Text>().text = sum.ToString();
                StopTimer();
            }




            ///Virtuellen Kartenstapel aktualisieren:
            int cardindex = 0;
            for (var i = 24; i < 134; i++)
            {
                string[] OneStapelCardArray = transform.GetComponent<SendReceiver>().ResLines[i].Split('~');

                //ResLines[21] - [131] enthält die Karteninformationen:
                Kartenstapel[cardindex].LfdNr = System.Convert.ToInt16(OneStapelCardArray[0]);
                Kartenstapel[cardindex].StapelID = System.Convert.ToInt16(OneStapelCardArray[1]);
                Kartenstapel[cardindex].Zaehlwert = System.Convert.ToInt16(OneStapelCardArray[2]);
                Kartenstapel[cardindex].Name = OneStapelCardArray[3].ToString();
                Kartenstapel[cardindex].Farbe = OneStapelCardArray[4].ToString();
                Kartenstapel[cardindex].Status = OneStapelCardArray[5].ToString();
                Kartenstapel[cardindex].Eigentuemer = OneStapelCardArray[6].ToString();
                Kartenstapel[cardindex].AnlageID = System.Convert.ToInt16(OneStapelCardArray[7]);

                cardindex += 1;
            }



            //Rückmeldungszeilen mit ~ in Arrays entpacken:
            string[] tempstrarray;
            tempstrarray = Player1Cards.Split('~');
            Player1CardsArray = new int[tempstrarray.Length];
            for (int i = 0; i < tempstrarray.Length; i++)
            {
                Player1CardsArray[i] = System.Convert.ToInt16(tempstrarray[i]);
            }
            Array.Clear(tempstrarray, 0, tempstrarray.Length);

            tempstrarray = Player2Cards.Split('~');
            Player2CardsArray = new int[tempstrarray.Length];
            for (int i = 0; i < tempstrarray.Length; i++)
            {
                Player2CardsArray[i] = System.Convert.ToInt16(tempstrarray[i]);
            }
            Array.Clear(tempstrarray, 0, tempstrarray.Length);

            tempstrarray = UsedCards.Split('~');
            UsedCardsArray = new int[tempstrarray.Length];
            for (int i = 0; i < tempstrarray.Length; i++)
            {
                UsedCardsArray[i] = System.Convert.ToInt16(tempstrarray[i]);
            }
            Array.Clear(tempstrarray, 0, tempstrarray.Length);

            if (DZ1Cards != "")
            {
                tempstrarray = DZ1Cards.Split('~');
                DZ1CardsArray = new int[tempstrarray.Length];
                for (int i = 0; i < tempstrarray.Length; i++)
                {
                    DZ1CardsArray[i] = System.Convert.ToInt16(tempstrarray[i]);
                }
                Array.Clear(tempstrarray, 0, tempstrarray.Length);
            }

            if (DZ2Cards != "")
            {
                tempstrarray = DZ2Cards.Split('~');
                DZ2CardsArray = new int[tempstrarray.Length];
                for (int i = 0; i < tempstrarray.Length; i++)
                {
                    DZ2CardsArray[i] = System.Convert.ToInt16(tempstrarray[i]);
                }
                Array.Clear(tempstrarray, 0, tempstrarray.Length);
            }

            if (DZ3Cards != "")
            {
                tempstrarray = DZ3Cards.Split('~');
                DZ3CardsArray = new int[tempstrarray.Length];
                for (int i = 0; i < tempstrarray.Length; i++)
                {
                    DZ3CardsArray[i] = System.Convert.ToInt16(tempstrarray[i]);
                }
                Array.Clear(tempstrarray, 0, tempstrarray.Length);
            }

            if (DZ4Cards != "")
            {
                tempstrarray = DZ4Cards.Split('~');
                DZ4CardsArray = new int[tempstrarray.Length];
                for (int i = 0; i < tempstrarray.Length; i++)
                {
                    DZ4CardsArray[i] = System.Convert.ToInt16(tempstrarray[i]);
                }
                Array.Clear(tempstrarray, 0, tempstrarray.Length);
            }

            if (DZ5Cards != "")
            {
                tempstrarray = DZ5Cards.Split('~');
                DZ5CardsArray = new int[tempstrarray.Length];
                for (int i = 0; i < tempstrarray.Length; i++)
                {
                    DZ5CardsArray[i] = System.Convert.ToInt16(tempstrarray[i]);
                }
                Array.Clear(tempstrarray, 0, tempstrarray.Length);
            }

            if (DZ6Cards != "")
            {
                tempstrarray = DZ6Cards.Split('~');
                DZ6CardsArray = new int[tempstrarray.Length];
                for (int i = 0; i < tempstrarray.Length; i++)
                {
                    DZ6CardsArray[i] = System.Convert.ToInt16(tempstrarray[i]);
                }
                Array.Clear(tempstrarray, 0, tempstrarray.Length);
            }

            if (DZ7Cards != "")
            {
                tempstrarray = DZ7Cards.Split('~');
                DZ7CardsArray = new int[tempstrarray.Length];
                for (int i = 0; i < tempstrarray.Length; i++)
                {
                    DZ7CardsArray[i] = System.Convert.ToInt16(tempstrarray[i]);
                }
                Array.Clear(tempstrarray, 0, tempstrarray.Length);
            }

            if (DZ8Cards != "")
            {
                tempstrarray = DZ8Cards.Split('~');
                DZ8CardsArray = new int[tempstrarray.Length];
                for (int i = 0; i < tempstrarray.Length; i++)
                {
                    DZ8CardsArray[i] = System.Convert.ToInt16(tempstrarray[i]);
                }
                Array.Clear(tempstrarray, 0, tempstrarray.Length);
            }

            if (DZ9Cards != "")
            {
                tempstrarray = DZ9Cards.Split('~');
                DZ9CardsArray = new int[tempstrarray.Length];
                for (int i = 0; i < tempstrarray.Length; i++)
                {
                    DZ9CardsArray[i] = System.Convert.ToInt16(tempstrarray[i]);
                }
                Array.Clear(tempstrarray, 0, tempstrarray.Length);
            }



            //byte[] ba = Encoding.Default.GetBytes(dropzone10);
            //var hexString = BitConverter.ToString(ba);

            //Debug.Log(hexString);
            //if (hexString != "09")

            if (dropzone10 != "") //geht nur weil nicht lastline                    
            {
                tempstrarray = dropzone10.Split('~');
                DroppedCardsArray = new int[tempstrarray.Length];
                for (int i = 0; i < tempstrarray.Length; i++)
                {
                    DroppedCardsArray[i] = System.Convert.ToInt16(tempstrarray[i]);
                }
                Array.Clear(tempstrarray, 0, tempstrarray.Length);
            }
            else
            {
                DroppedCardsArray = new int[1];
                DroppedCardsArray[0] = 999;//DummyCard
            }




            //Weristdran updaten, falls weristdran sich geändert hat:

            if (Oldweristdran != weristdran)
            {
                GameObject.Find("weristdranText").GetComponent<Text>().text = weristdran;
                Oldweristdran = GameObject.Find("weristdranText").GetComponent<Text>().text;
            }


            if (GameObject.Find("weristdranText").GetComponent<Text>().text == GameObject.Find("wersendetText").GetComponent<Text>().text)
            {
                if (GameObject.Find("ServeInfoText").GetComponent<Text>().text == "Okay, du bist dran....")
                {
                    ///kein Sound abspielen wenn Du bist dran schon steht
                }
                else
                {
                    GameObject.Find("SoundNextplayer2").GetComponent<AudioSource>().Play(0);
                    //Wenn der Change ist auf "du bist dran" dann ist es der moment zum Karte ziehen:
                    if (GameObject.Find("StatusTextBox").GetComponent<Text>().text != "Los gehts!")
                    {
                        GameObject.Find("StatusTextBox").GetComponent<Text>().text = "Bitte ziehe eine Karte oder sortiere!";
                    }

                }

                GameObject.Find("ServeInfoText").GetComponent<Text>().text = "Okay, du bist dran....";
                GameObject.Find("ServeInfoText").GetComponent<Text>().color = Color.green;
                canDrag = true;
                StopTimer();

                //Karten sortieren freigeben:
                GameObject.Find("ButtonSortMode").GetComponent<CanvasGroup>().alpha = 1f;
                GameObject.Find("ButtonSortMode").GetComponent<CanvasGroup>().blocksRaycasts = true;
            }
            else
            {
                //Karten sortieren sperren:
                GameObject.Find("ButtonSortMode").GetComponent<CanvasGroup>().alpha = 0f;
                GameObject.Find("ButtonSortMode").GetComponent<CanvasGroup>().blocksRaycasts = false;


                GameObject.Find("ServeInfoText").GetComponent<Text>().text = "Warte auf Gegner!";
                GameObject.Find("ServeInfoText").GetComponent<Text>().color = Color.red;
                canDrag = false;
            }




            bool theresachange = false;
            //Alle SpielObjekte die vom Server kommen (immer wieder neu) darstellen:        
            if (GameObject.Find("wersendetText").GetComponent<Text>().text == "Player1")
            {
                try
                {
                    if (Player1CardsArray.SequenceEqual(OldPlayer1CardsArray) == false)
                    {
                        theresachange = true;
                    }
                }
                catch
                {
                    theresachange = true;
                }

                //Änderung eingetreten, daher:    
                if (theresachange)
                {
                    UpdateAllPlayer1Cards(); //Wenn Sender = Spieler1, dann sind die Karten unten Spieler1 Karten zu updaten               
                }
            }

            theresachange = false;
            if (GameObject.Find("wersendetText").GetComponent<Text>().text == "Player2")
            {
                //Prüfen ob die Gegnerkarten sich geändert haben:            
                try
                {
                    if (Player2CardsArray.SequenceEqual(OldPlayer2CardsArray) == false)
                    {
                        theresachange = true;
                    }
                }
                catch
                {
                    theresachange = true;
                }

                //Änderung eingetreten, daher:    
                if (theresachange)
                {
                    UpdateAllPlayer2Cards(); //Wenn Sender = Spieler2, dann sind die Karten unten Spieler2 Karten zu updaten
                }
            }

            theresachange = false;
            try
            {
                if (GameObject.Find("wersendetText").GetComponent<Text>().text == "Player2")
                {
                    if (Player1CardsArray.SequenceEqual(OldEnemyCardsArray) == false)
                    {
                        theresachange = true;
                    }
                }

                if (GameObject.Find("wersendetText").GetComponent<Text>().text == "Player1")
                {
                    if (Player2CardsArray.SequenceEqual(OldEnemyCardsArray) == false)
                    {
                        theresachange = true;
                    }
                }
            }
            catch
            {
                theresachange = true;
            }

            //Änderung eingetreten, daher:    
            if (theresachange)
            {
                UpdateAllEnemyCards();
            }


            theresachange = false;
            try
            {
                if (GameObject.Find("wersendetText").GetComponent<Text>().text == "Player2")
                {
                    if (DroppedCardsArray.SequenceEqual(OldDroppedCardsArray) == false)
                    {
                        theresachange = true;
                    }
                }

                if (GameObject.Find("wersendetText").GetComponent<Text>().text == "Player1")
                {
                    if (DroppedCardsArray.SequenceEqual(OldDroppedCardsArray) == false)
                    {
                        theresachange = true;
                    }
                }
            }
            catch
            {
                theresachange = true;
            }

            //Änderung eingetreten, daher:    
            if (theresachange)
            {
                UpdateAllDroppedCards();
            }

            theresachange = false;
            try
            {
                if (GameObject.Find("wersendetText").GetComponent<Text>().text == "Player2")
                {
                    if (DZ1CardsArray.SequenceEqual(OldDZ1CardsArray) == false)
                    {
                        theresachange = true;
                    }
                }

                if (GameObject.Find("wersendetText").GetComponent<Text>().text == "Player1")
                {
                    if (DZ1CardsArray.SequenceEqual(OldDZ1CardsArray) == false)
                    {
                        theresachange = true;
                    }
                }
            }
            catch
            {
                theresachange = true;
            }

            //Änderung eingetreten, daher:    
            if (theresachange)
            {
                UpdateAllDZ1Cards();
            }

            theresachange = false;
            try
            {
                if (GameObject.Find("wersendetText").GetComponent<Text>().text == "Player2")
                {
                    if (DZ2CardsArray.SequenceEqual(OldDZ2CardsArray) == false)
                    {
                        theresachange = true;
                    }
                }

                if (GameObject.Find("wersendetText").GetComponent<Text>().text == "Player1")
                {
                    if (DZ2CardsArray.SequenceEqual(OldDZ2CardsArray) == false)
                    {
                        theresachange = true;
                    }
                }
            }
            catch
            {
                theresachange = true;
            }

            //Änderung eingetreten, daher:    
            if (theresachange)
            {
                UpdateAllDZ2Cards();
            }

            theresachange = false;
            try
            {
                if (GameObject.Find("wersendetText").GetComponent<Text>().text == "Player2")
                {
                    if (DZ3CardsArray.SequenceEqual(OldDZ3CardsArray) == false)
                    {
                        theresachange = true;
                    }
                }

                if (GameObject.Find("wersendetText").GetComponent<Text>().text == "Player1")
                {
                    if (DZ3CardsArray.SequenceEqual(OldDZ3CardsArray) == false)
                    {
                        theresachange = true;
                    }
                }
            }
            catch
            {
                theresachange = true;
            }

            //Änderung eingetreten, daher:    
            if (theresachange)
            {
                UpdateAllDZ3Cards();
            }

            theresachange = false;
            try
            {
                if (GameObject.Find("wersendetText").GetComponent<Text>().text == "Player2")
                {
                    if (DZ4CardsArray.SequenceEqual(OldDZ4CardsArray) == false)
                    {
                        theresachange = true;
                    }
                }

                if (GameObject.Find("wersendetText").GetComponent<Text>().text == "Player1")
                {
                    if (DZ4CardsArray.SequenceEqual(OldDZ4CardsArray) == false)
                    {
                        theresachange = true;
                    }
                }
            }
            catch
            {
                theresachange = true;
            }

            //Änderung eingetreten, daher:    
            if (theresachange)
            {
                UpdateAllDZ4Cards();
            }

            theresachange = false;
            try
            {
                if (GameObject.Find("wersendetText").GetComponent<Text>().text == "Player2")
                {
                    if (DZ5CardsArray.SequenceEqual(OldDZ5CardsArray) == false)
                    {
                        theresachange = true;
                    }
                }

                if (GameObject.Find("wersendetText").GetComponent<Text>().text == "Player1")
                {
                    if (DZ5CardsArray.SequenceEqual(OldDZ5CardsArray) == false)
                    {
                        theresachange = true;
                    }
                }
            }
            catch
            {
                theresachange = true;
            }

            //Änderung eingetreten, daher:    
            if (theresachange)
            {
                UpdateAllDZ5Cards();
            }

            theresachange = false;
            try
            {
                if (GameObject.Find("wersendetText").GetComponent<Text>().text == "Player2")
                {
                    if (DZ6CardsArray.SequenceEqual(OldDZ6CardsArray) == false)
                    {
                        theresachange = true;
                    }
                }

                if (GameObject.Find("wersendetText").GetComponent<Text>().text == "Player1")
                {
                    if (DZ6CardsArray.SequenceEqual(OldDZ6CardsArray) == false)
                    {
                        theresachange = true;
                    }
                }
            }
            catch
            {
                theresachange = true;
            }

            //Änderung eingetreten, daher:    
            if (theresachange)
            {
                UpdateAllDZ6Cards();
            }

            theresachange = false;
            try
            {
                if (GameObject.Find("wersendetText").GetComponent<Text>().text == "Player2")
                {
                    if (DZ7CardsArray.SequenceEqual(OldDZ7CardsArray) == false)
                    {
                        theresachange = true;
                    }
                }

                if (GameObject.Find("wersendetText").GetComponent<Text>().text == "Player1")
                {
                    if (DZ7CardsArray.SequenceEqual(OldDZ7CardsArray) == false)
                    {
                        theresachange = true;
                    }
                }
            }
            catch
            {
                theresachange = true;
            }

            //Änderung eingetreten, daher:    
            if (theresachange)
            {
                UpdateAllDZ7Cards();
            }

            theresachange = false;
            try
            {
                if (GameObject.Find("wersendetText").GetComponent<Text>().text == "Player2")
                {
                    if (DZ8CardsArray.SequenceEqual(OldDZ8CardsArray) == false)
                    {
                        theresachange = true;
                    }
                }

                if (GameObject.Find("wersendetText").GetComponent<Text>().text == "Player1")
                {
                    if (DZ8CardsArray.SequenceEqual(OldDZ8CardsArray) == false)
                    {
                        theresachange = true;
                    }
                }
            }
            catch
            {
                theresachange = true;
            }

            //Änderung eingetreten, daher:    
            if (theresachange)
            {
                UpdateAllDZ8Cards();
            }

            theresachange = false;
            try
            {
                if (GameObject.Find("wersendetText").GetComponent<Text>().text == "Player2")
                {
                    if (DZ9CardsArray.SequenceEqual(OldDZ9CardsArray) == false)
                    {
                        theresachange = true;
                    }
                }

                if (GameObject.Find("wersendetText").GetComponent<Text>().text == "Player1")
                {
                    if (DZ9CardsArray.SequenceEqual(OldDZ9CardsArray) == false)
                    {
                        theresachange = true;
                    }
                }
            }
            catch
            {
                theresachange = true;
            }

            //Änderung eingetreten, daher:    
            if (theresachange)
            {
                UpdateAllDZ9Cards();
            }

        }
        //Prüfen ob 1.,2 Spieler gewonnnen 
        else if (transform.GetComponent<SendReceiver>().ResLines[0] == "Player1")
        {
            GameObject.Find("StatsContainerBG").GetComponent<Slideinout>().PushIn();
            GameObject.Find("SoundStats").GetComponent<AudioSource>().Play(0);
            GameObject.Find("gamecore").GetComponent<GameCore>().StopTimer();

            GameObject.Find("Sound1").GetComponent<AudioSource>().Stop();
            GameObject.Find("Sound2").GetComponent<AudioSource>().Stop();
            GameObject.Find("Sound3").GetComponent<AudioSource>().Stop();
            GameObject.Find("Sound4").GetComponent<AudioSource>().Stop();
            GameObject.Find("Sound5").GetComponent<AudioSource>().Stop();
            GameObject.Find("Sound6").GetComponent<AudioSource>().Stop();

            //Strafpunkte eintragen
            GameObject.Find("Player2SP").GetComponent<Text>().text = transform.GetComponent<SendReceiver>().ResLines[1].ToString();

            int sum;
            sum = System.Convert.ToInt16(GameObject.Find("Player2SPGES").GetComponent<Text>().text) + System.Convert.ToInt16(GameObject.Find("Player2SP").GetComponent<Text>().text);
            GameObject.Find("Player2SPGES").GetComponent<Text>().text = sum.ToString();





        }
        else if (transform.GetComponent<SendReceiver>().ResLines[0] == "Player2")
        {
            GameObject.Find("StatsContainerBG").GetComponent<Slideinout>().PushIn();
            GameObject.Find("SoundStats").GetComponent<AudioSource>().Play(0);
            GameObject.Find("gamecore").GetComponent<GameCore>().StopTimer();
            GameObject.Find("Sound1").GetComponent<AudioSource>().Stop();
            GameObject.Find("Sound2").GetComponent<AudioSource>().Stop();
            GameObject.Find("Sound3").GetComponent<AudioSource>().Stop();
            GameObject.Find("Sound4").GetComponent<AudioSource>().Stop();
            GameObject.Find("Sound5").GetComponent<AudioSource>().Stop();
            GameObject.Find("Sound6").GetComponent<AudioSource>().Stop();

            //Strafpunkte eintragen
            GameObject.Find("Player1SP").GetComponent<Text>().text = transform.GetComponent<SendReceiver>().ResLines[1].ToString();

            int sum;
            sum = System.Convert.ToInt16(GameObject.Find("Player1SPGES").GetComponent<Text>().text) + System.Convert.ToInt16(GameObject.Find("Player1SP").GetComponent<Text>().text);
            GameObject.Find("Player1SPGES").GetComponent<Text>().text = sum.ToString();
        }
        else if (transform.GetComponent<SendReceiver>().ResLines[0] == "OrderOK")
        {
            Debug.Log("Sortieren erfolgreich");
            GameObject.Find("StatusTextBox").GetComponent<Text>().text = "Karten erfolgreich sortiert...";
            GameObject.Find("SoundCardDrop4").GetComponent<AudioSource>().Play(0);
        }
        else if (transform.GetComponent<SendReceiver>().ResLines[0] == "Dropio")
        {
            //Anlegen (0 Karten oder mehr) erfolgreich
            Debug.Log("Wegwerfen erfolgreich.............");
            GameObject.Find("StatusTextBox").GetComponent<Text>().text = "Karte weggeworfen!";

            //Nun da wegwerfen erfolgreich noch Karten anlegen:
            transform.GetComponent<SendReceiver>().RequestUrl = RequestStringMerker;
            transform.GetComponent<SendReceiver>().DoSendReceive(false);
        }
        else if (transform.GetComponent<SendReceiver>().ResLines[0] == "Anlegeio")
        {
            //Anlegen (0 Karten oder mehr) erfolgreich
            Debug.Log("Anlegen erfolgreich.............");
            GameObject.Find("StatusTextBox").GetComponent<Text>().text = "Karte weggeworfen, warte bitte auf deinen Gegner!";

            //Alle Dropzones inaktivieren, weil erst eine Karte gezohen werden muss:
            //'Instant Timer OneTime' da Gegner dran ist                            
            GameObject.Find("gamecore").GetComponent<GameCore>().gezogenstatus = false;
            GameObject.Find("DropZone1").tag = "NOTCOLLIDE";
            GameObject.Find("DropZone2").tag = "NOTCOLLIDE";
            GameObject.Find("DropZone3").tag = "NOTCOLLIDE";
            GameObject.Find("DropZone4").tag = "NOTCOLLIDE";
            GameObject.Find("DropZone5").tag = "NOTCOLLIDE";
            GameObject.Find("DropZone6").tag = "NOTCOLLIDE";
            GameObject.Find("DropZone7").tag = "NOTCOLLIDE";
            GameObject.Find("DropZone8").tag = "NOTCOLLIDE";
            GameObject.Find("DropZone9").tag = "NOTCOLLIDE";
            GameObject.Find("DropZone10").tag = "NOTCOLLIDE";
            GameObject.Find("gamecore").GetComponent<GameCore>().StartTimer();
            GameObject.Find("gamecore").GetComponent<GameCore>().targetTime = 0.1f;//InstantTimer
        }
        else if (transform.GetComponent<SendReceiver>().ResLines[0] == "No30")
        {
            Debug.Log("ENtering No30");
            //Alle Karten die angelegt wurden wieder löschen, da diese nicht angelegt werden konnten:
            for (int DZ_count = 0; DZ_count < 9; DZ_count++)
            {
                foreach (Transform child in DropZones[DZ_count].transform)
                {
                    child.GetComponent<DragDrop>().anlegemerker = false;
                    Destroy(child.gameObject);
                }
            }

            //Anlegen (0 Karten oder mehr) erfolgreich
            Debug.Log("Wegwerfen aber nicht auslegen erfolgreich da keine 30");
            GameObject.Find("StatusTextBox").GetComponent<Text>().text = "Du hast noch keine 30, daher wird nur weggeworfen...";
            GameObject.Find("gamecore").GetComponent<GameCore>().gezogenstatus = false;


            //Weggeworfene Karte suchen und zerstören:
            //Aklle Kinder der EnemyArea löschen:
            foreach (Transform child in GameObject.Find("DropZone10").transform)
            {
                Destroy(child.gameObject);
            }

            //'Instant Timer OneTime'                            
            GameObject.Find("gamecore").GetComponent<GameCore>().StartTimer();
            GameObject.Find("gamecore").GetComponent<GameCore>().targetTime = 0.1f;//InstantTimer
        }
        else if (transform.GetComponent<SendReceiver>().ResLines[0] == "AnlegeNotioWeniger3")
        {
            Debug.Log("ENtering AnlegeNotioWeniger3");
            //Alle Karten die angelegt wurden wieder löschen, da diese nicht angelegt werden konnten:
            for (int DZ_count = 0; DZ_count < 9; DZ_count++)
            {
                foreach (Transform child in DropZones[DZ_count].transform)
                {
                    child.GetComponent<DragDrop>().anlegemerker = false;
                    Destroy(child.gameObject);
                }
            }

            //Anlegen (0 Karten oder mehr) erfolgreich
            Debug.Log("Wegwerfen aber nicht auslegen erfolgreich da weniger als 3 Karten");
            GameObject.Find("StatusTextBox").GetComponent<Text>().text = "Ein Auslegblock hat < 3 Karten welche du zurück in deiner Hand hast.";
            GameObject.Find("gamecore").GetComponent<GameCore>().gezogenstatus = false;


            //Weggeworfene Karte suchen und zerstören:
            //Aklle Kinder der EnemyArea löschen:
            foreach (Transform child in GameObject.Find("DropZone10").transform)
            {
                Destroy(child.gameObject);
            }

            //Alle Dropzones inaktivieren, weil erst eine Karte gezohen werden muss:
            //'Instant Timer OneTime' da Gegner dran ist                            
            GameObject.Find("gamecore").GetComponent<GameCore>().gezogenstatus = false;
            GameObject.Find("DropZone1").tag = "NOTCOLLIDE";
            GameObject.Find("DropZone2").tag = "NOTCOLLIDE";
            GameObject.Find("DropZone3").tag = "NOTCOLLIDE";
            GameObject.Find("DropZone4").tag = "NOTCOLLIDE";
            GameObject.Find("DropZone5").tag = "NOTCOLLIDE";
            GameObject.Find("DropZone6").tag = "NOTCOLLIDE";
            GameObject.Find("DropZone7").tag = "NOTCOLLIDE";
            GameObject.Find("DropZone8").tag = "NOTCOLLIDE";
            GameObject.Find("DropZone9").tag = "NOTCOLLIDE";
            GameObject.Find("DropZone10").tag = "NOTCOLLIDE";
            GameObject.Find("gamecore").GetComponent<GameCore>().StartTimer();
            GameObject.Find("gamecore").GetComponent<GameCore>().targetTime = 0.1f;//InstantTimer
        }        
        else
        {
            //Fehlermeldung vom Server ausgeben bei Fehler:
            GameObject.Find("StatusTextBox").GetComponent<Text>().text = transform.GetComponent<SendReceiver>().ResLines[0];
        }
  
    }
}

