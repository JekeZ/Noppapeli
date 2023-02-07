using System;

public class Peli
{
    public Pelaaja Pelaaja1 { get; set; }
    public Pelaaja Pelaaja2 { get; set; }
    public int KierrosLkm { get; set; }
    public int VoitonPisteRaja { get; }

   //Koodataan pisteet.
    public Pelaaja Voittaja
    {
        get
        {
            if (Pelaaja1.Pisteet >= VoitonPisteRaja)
            {
                return Pelaaja1;
            }
            else if (Pelaaja2.Pisteet >= VoitonPisteRaja)
            {
                return Pelaaja2;
            }
            else
            {
                return null;
            }
        }
    }
    public Peli(int voitonpisteraja, Pelaaja pelaaja1, Pelaaja pelaaja2)
    {
        VoitonPisteRaja = voitonpisteraja;
        Pelaaja1 = pelaaja1;
        Pelaaja2 = pelaaja2;
        KierrosLkm = 1;
    }
    private int NoppienHeitto(Pelaaja pelaaja)
    {
        int ekaheitto = pelaaja.Noppa.Heita();
        int tokaheitto = pelaaja.Noppa.Heita();
        int tulos = ekaheitto + tokaheitto;
        Console.WriteLine($"{pelaaja.Nimi}: {ekaheitto} + {tokaheitto} = {tulos}");
        return tulos;
    }
    //Koodataan pelaajille menemään niin, että kierroksen voittanut saa yhden pisteen ja
    //hävinnyt menettää pisteet. Jos molemmat pelaajat heittää saman numeron, peli jatkuu, eikä pisteet muutu.
    public void PelaaKierros()
    {
        Console.WriteLine($"Heittokierros {KierrosLkm}");
        KierrosLkm += 1;
        int tulos = NoppienHeitto(Pelaaja1);
        int tulos2 = NoppienHeitto(Pelaaja2);
        if (tulos > tulos2)
        {
            Pelaaja1.Pisteet += 1;
            Pelaaja2.Pisteet = 0;
        }
        else if (tulos2 > tulos)
        {
            Pelaaja2.Pisteet += 1;
            Pelaaja1.Pisteet = 0;
        }
        else
        {
            Pelaaja1.Pisteet = Pelaaja1.Pisteet;
            Pelaaja2.Pisteet = Pelaaja2.Pisteet;
        }
    }

}
