using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KarteFields : MonoBehaviour
{
    public int LfdNr = 0;
    public int StapelID = 0;
    public int Zaehlwert = 0;
    public string Name = "";
    public string Farbe = "";
    public string Status = "verfuegbar";
    public string Eigentuemer = "stapel";
    public int AnlageID = 0;
    public string FullInfo = "";
}

public class Karte
{
    public int LfdNr = 0;
    public int StapelID = 0;
    public int Zaehlwert = 0;
    public string Name = "";
    public string Farbe = "";
    public string Status = "verfuegbar";
    public string Eigentuemer = "stapel";
    public int AnlageID = 0;
    //public bool anlegemerker = false;

    //public Karte() { } falls man noch Kartenerstellung mit anderen Parametern zu lasen wird (überladen)

    public Karte(int LfdNr, int StapelID, int Zaehlwert, string Name, string Farbe, string Status, string Eigentuemer, int AnlageID)
    {
        this.LfdNr = LfdNr;
        this.StapelID = StapelID;
        this.Zaehlwert = Zaehlwert;
        this.Name = Name;
        this.Farbe = Farbe;
        this.Status = Status;
        this.Eigentuemer = Eigentuemer;
        this.AnlageID = AnlageID;
    }
}
