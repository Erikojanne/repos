// See https://aka.ms/new-console-template for more information
using System;

Console.WriteLine("Hello, World!");

public class Asunto
{
    public double pintaAla;
    public int huoneet;
    public String vuokra;
    public bool vapaa;

    public Asunto(double pintaAla, int huoneet, String vuokra, bool vapaa)
    {
        this.pintaAla = pintaAla;
        this.huoneet = huoneet;
        this.vuokra = vuokra;
        this.vapaa = true;
    }
    public void tulostaTiedot()
    {
        Console.WriteLine("Asunnon tiedot");
        Console.WriteLine("--------------");
        Console.WriteLine("Pinta-ala=" + pintaAla);
        Console.WriteLine("Huoneiden lukumäärä=" + huoneet);
        Console.WriteLine("Vuokra=" + vuokra);
    }

    public void varaaAsunto()
    {
        if (vapaa)
        {
            Console.WriteLine("Onko vapaa? " + vapaa);
            vapaa = false;
        }
        else
        {
            Console.WriteLine("Asunto on varattu.");
        }
    }
}
class Testiluokka
{
    public static void Main(string[] args)
    {
        Testiluokka asunto = new Testiluokka(62.45, 3, "643,00 €", false);
        asunto.tulostaTiedot();
        asunto.varaaAsunto();
    }
}