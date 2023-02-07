using System;

public class Noppa
{
    private static System.Random Random;
    private int Lukema;
    private int HeittoLkm;
    public Noppa()
    {
        HeittoLkm = 0;
    }
    public int Heita()
    {
        int arvottuluku = Random.Next(1, 6);
        Lukema = arvottuluku;
        HeittoLkm = HeittoLkm + 1;
        return Lukema;
    }
}
