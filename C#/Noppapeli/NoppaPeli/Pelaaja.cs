using System;

public class Pelaaja : INimi 
{
    public string Nimi { get; set; }
    public int Pisteet { get; set; }
    public Noppa Noppa { get; set; }
    //Määritetään Pelaaja konstruktori
    public Pelaaja(string pelaaja)
    {
        Nimi = pelaaja;
        Pisteet = 0;
        Noppa = new Noppa();
    }
}
