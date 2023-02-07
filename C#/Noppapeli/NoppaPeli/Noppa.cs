using System;

public class Noppa
{
    private static System.Random Random = new System.Random();
    public int Lukema { get; set; }
    public int HeittoLkm { get; set; }
    public Noppa()
    {
        HeittoLkm = 0;
    }
    //Määritetään heittojen luvut menemään 1-6 väliltä sattumanmukaisesti
    public int Heita()
    {
        int arvottuluku = Random.Next(1, 6);
        Lukema = arvottuluku;
        HeittoLkm = HeittoLkm + 1;
        return Lukema;
    }
}
