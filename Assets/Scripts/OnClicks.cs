using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnClicks : MonoBehaviour
{
    private GameCore gamecore;
    void Start()
    {
        gamecore = GameObject.Find("gamecore").GetComponent<GameCore>();
    }

    //On Click-Bereiche Innerhalb des sichtbaren Spiels:
    public void onClick_KartenSortieren() { gamecore.onClick_KartenSortieren(); }
    public void onClick_SpielBeenden()    { gamecore.onClick_SpielBeenden();    }
    public void onClick_MusikToogler()    { gamecore.onClick_MusikToogler();    }
    public void onClick_Rueckgaengig()    { gamecore.onClick_Rueckgaengig();    }

    //MainButtons innerhalb des SichtbarenSpiels mit SendReceive Wirkung =>
    public void onClick_NewGame() { gamecore.onClick_NewGame(); }
    public void onClick_JoinGame() { gamecore.onClick_JoinGame(); }
    public void onClick_KarteZiehen() { gamecore.onClick_KarteZiehen(transform); }
    

    //On Click-Bereiche Innerhalb der Spielvorbereitung:
    public void onClick_PreNewGame() { gamecore.onClick_PreNewGame(); }
    public void onClick_PreJoinGame() { gamecore.onClick_PreJoinGame(); }

    //On Click-Bereiche Innerhalb der Statistik:
    public void onClick_StarNewGameRestart() { gamecore.onClick_StarNewGameRestart(); }
}
