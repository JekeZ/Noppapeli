using System;

namespace Tentti02
{
    static class Sovellus
    {
        //Kysytään käyttäjältä pelaajien nimet
        public static void Aja()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Noppa-peli");
            Console.ResetColor();

            Console.Write("Pelaajan 1 Nimi: ");
            string pelaaja1Nimi = Console.ReadLine();

            Console.Write("Pelaajan 2 Nimi: ");
            string pelaaja2Nimi = Console.ReadLine();

            Pelaaja pelaaja1 = new Pelaaja(pelaaja1Nimi);
            Pelaaja pelaaja2 = new Pelaaja(pelaaja2Nimi);

            Peli peli = new Peli(3, pelaaja1, pelaaja2);

            Pelaaja voittaja;
            while (peli.Voittaja == null)
            {
                peli.PelaaKierros();
            }
            voittaja = peli.Voittaja;

            //Tulostetaan Pelin voittaja, sekä noppien heitto lukumäärä.
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"Pelin voittaja on {voittaja.Nimi} ja noppia heitettiin {peli.KierrosLkm} kertaa!");
            Console.ResetColor();
        }
    }
    public class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Sovellus.Aja();
            }
            catch (Exception e)
            {
                Console.WriteLine($"Ohjelman suoritus päättyi virheeseen.\nVIrhe: {e.Message}");
            }
        }
    }
}
