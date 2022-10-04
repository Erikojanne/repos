// See https://aka.ms/new-console-template for more information

    int luku;
    luku = 3 + 5;
    Console.WriteLine("summa: " +luku);

{
    double fahrenheit1 = 10 * 1.8D + 32;
    Console.WriteLine("Fahrenheit: " + fahrenheit1);
}
{
    int summa1 = 8+5;
    int erotus = 8-5;
    int tulo = 8*5;
    double jako = 8/5D;
    Console.WriteLine(summa1 + "/ " +erotus+ "/ "+tulo + "/ "+jako);
}
{
    int jakojaanos = 5 % 2;
    Console.WriteLine(jakojaanos);
}
{
    string nimi;
    Console.Write("Kirjoita etunimesi: ");
    nimi = Console.ReadLine();
    Console.WriteLine("Hei " +nimi);
}
static void laskeYhteen(int eka, int toka)
{
    Console.WriteLine(eka + " + " + toka + " = " + (eka + toka));
}

    int luku1, luku2, summa;
    Console.Write("Anna yhteenlaskettava kokonaisluku: ");
    luku1 = int.Parse(Console.ReadLine());
    Console.Write("Anna toinen yhteenlaskettava kokonaisluku: ");
    luku2 = int.Parse(Console.ReadLine());
    laskeYhteen(luku1, luku2);
    
static void fahrenheit(double eka)
{
    Console.WriteLine(eka + " celsius astetta" + " on " + (eka * 1.8D + 32) + " fahrenheit astetta. ");
}
double luku3;
Console.Write("Anna lämpötila celsius asteina: ");
luku3 = double.Parse(Console.ReadLine());
fahrenheit(luku3);

static void laskuja(int eka, int toka)
{
    Console.WriteLine((eka + toka) + " / " + (eka - toka) + " / " + (eka * toka) + " / " + (eka / toka));
}
int luku4, luku5;
Console.Write("Anna kokonaisluku: ");
luku4 = int.Parse(Console.ReadLine());
Console.Write("Anna toinen kokonaisluku: ");
luku5 = int.Parse(Console.ReadLine());
laskuja(luku4, luku5);

static void jakojaanos1(int eka, int toka)
{
    Console.WriteLine("Lukujen jakojäännös on: " + (eka % toka));
}
int luku6, luku7;
Console.Write("Anna kokonaisluku: ");
luku6 = int.Parse(Console.ReadLine());
Console.Write("Anna toinen kokonaisluku: ");
luku7 = int.Parse(Console.ReadLine());
jakojaanos1(luku6, luku7); 

int kerto;
Console.Write("Anna luku 1 ja 10 väliltä: ");
kerto = int.Parse(Console.ReadLine());
Console.WriteLine();

for (int i = 1; i < 11; i++)
{
    int tulo = i * kerto;
    Console.WriteLine(kerto + " * " + i + " = " +tulo);
}


