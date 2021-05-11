using UnityEngine;
using UnityEngine.Networking;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System;
using UnityEngine.UI;

public class SendReceiver : MonoBehaviour
{
    public string[] ResLines;
    public string RequestUrl;
    public bool UnhandledResult;
    public bool comesfromtimer;

    public void DoSendReceive(bool comesfromtime)
    {
        comesfromtimer = comesfromtime;
        GameObject.Find("gamecore").GetComponent<GameCore>().canDrag = false;

        if (comesfromtime)
        {

        }
        else
        {
            transform.GetComponent<CanvasGroup>().alpha = 0.9f;
            transform.GetComponent<CanvasGroup>().blocksRaycasts = false;
        }


        StartCoroutine(Upload());
    }

    IEnumerator Upload()
    {
        if (comesfromtimer)
        {
            Debug.LogWarning("Calling automatic ServerRequest ==> " + RequestUrl);
        }
        else
        {
            Debug.LogWarning("Calling manuel ServerRequest ==> " + RequestUrl);
            //GameObject.Find("ServeInfoText").GetComponent<Text>().text = "Serveranfrage läuft...";
            GameObject.Find("ServeInfoText").GetComponent<Text>().color = Color.red;
        }      
        
        
        UnityWebRequest www = UnityWebRequest.Get(RequestUrl);
        yield return www.SendWebRequest();

        if (www.result != UnityWebRequest.Result.Success)
        {
            GameObject.Find("StatusTextBox").GetComponent<Text>().text = www.error;
            GameObject.Find("SoundError").GetComponent<AudioSource>().Play(0);            
        }
        else
        {            
            HandleReturns(www);
        }
    }


    private void HandleReturns(UnityWebRequest www)
    {        
        GameObject.Find("ServeInfoText").GetComponent<Text>().color = Color.green;
        //GameObject.Find("ServeInfoText").GetComponent<Text>().text = "Bereit...";
        
        //Rückgaben in ein Array lesen und In Editor Sichtbar machen (zum anfragenden Objekt): 
        string CompleteWebResult = www.downloadHandler.text;
        ResLines = CompleteWebResult.Split('\n');
        UnhandledResult = true;

        //Update Complete allow dragDrop:        
        GameObject.Find("gamecore").GetComponent<GameCore>().canDrag = true;

        transform.GetComponent<CanvasGroup>().alpha = 1f;
        transform.GetComponent<CanvasGroup>().blocksRaycasts = true;
    }

}
