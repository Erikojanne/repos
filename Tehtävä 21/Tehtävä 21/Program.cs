// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
using System;
namespace Esim_21
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("");
            Console.Write("Ohjelma heittää kahta noppaa viisi kertaa ja laskee kaikkien heittojen yhteissumman.");
            Console.WriteLine("");

            // Esitellään ja alustetaan tarvittavat muuttujat
            int yhteisSumma = 0;
            int kierrosSumma = 0;
            int tulos1 = 0;
            int tulos2 = 0;

            // Luodaan random olio, eli esitellään noppa
            Random noppa = new Random();
            // Viiden heittokierroksen silmukka
            for (int i = 1; i < 6; i++)
            {
                // Heitetään noppaa 2 kertaa jokaisella kierroksella
                tulos1 = noppa.Next(1, 7);
                tulos2 = noppa.Next(1, 7);


                // Lasketaan kierroksen noppien summa
                kierrosSumma = tulos1 + tulos2;
                // Tulostetaan kahden nopan heiton tulokset ja summa
                Console.WriteLine("");
                Console.WriteLine(i + ". heiton nopat: " + tulos1 + " ja " + tulos2 + " --> kahden nopan summa on " + kierrosSumma);
                Console.WriteLine("");

                // Lisätään joka kierroksella yhteissummaan kierroksen tulokset (edelliset 
                // kierrokset + tämä kierros)
                yhteisSumma = kierrosSumma + yhteisSumma;
            }
            
                
                Console.WriteLine("Yhteissumma on " + yhteisSumma);
            
        }
       
    }
}

