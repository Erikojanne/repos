// See https://aka.ms/new-console-template for more information
Console.Write("Anna esimmäinen kokonaisluku: ");
int luku1 = int.Parse(Console.ReadLine());
Console.WriteLine();
Console.Write("Anna toinen kokonaisluku: ");
int luku2 = int.Parse(Console.ReadLine());

int kl = luku2;
if (luku1 > luku2)
{
    luku2 = luku1;
    luku1 = kl;
}
Console.WriteLine();
Console.WriteLine("Annoit luvut {0} ja {1} ", luku1,  luku2);

Console.WriteLine();
Console.Write("Anna ensimmäinen kokonaisluku: ");
int luku3 = int.Parse(Console.ReadLine());
Console.WriteLine();
Console.Write("Anna toinen kokonaisluku: ");
int luku4 = int.Parse(Console.ReadLine());
Console.WriteLine();
Console.Write("Anna kolmas kokonaisluku: ");
int luku5 = int.Parse(Console.ReadLine());
Console.WriteLine();
int suurin;

if (luku4 > luku3 && luku4 > luku5)
{
    suurin = luku4;
}
else if (luku5 > luku3 && luku5 > luku4)
{
    suurin = luku5;
}
else
{
    suurin = luku3;
}
Console.WriteLine();
Console.WriteLine("Suurin luku on: " + suurin);
Console.WriteLine();

Console.Write("Pyydän kokonaislukua väliltä 0-9: ");

int lause = int.Parse(Console.ReadLine());
Console.WriteLine();
switch (lause)
{
    case 0:
        Console.WriteLine("Väärä numero");
        break;
    case 1:
        Console.WriteLine("Sillä sipuli");
        break;
    case 2:
        Console.WriteLine("Jippii");
        break;
    case 3:
        Console.WriteLine("Ei tässä mittään juu");
        break;
    case 4:
        Console.WriteLine("Kyllä lähtee");
        break;
    case 5:
        Console.WriteLine("Do dii");
        break;
    case 6:
        Console.WriteLine("Jopas nyt");
        break;
    case 7:
        Console.WriteLine("Jumankauta juu nääs päivää");
        break;
    case 8:
        Console.WriteLine("Miksi tämä numero");
        break;
    case 9:
        Console.WriteLine("Yritä jotain muuta numeroa");
        break;
        default:
        Console.WriteLine("Älä huijaa, valitse kokonaisluku väliltä 0-9");
        break;
}

Console.WriteLine();


Console.WriteLine("Anna viisi kokonaislukua ja ohjelma valitsee suurimman");
Console.WriteLine();
int[] luvut;
luvut = new int[5];
for (int i = 0; i < 5; i++)
{
    Console.Write("Anna {0}. kokonaisluku ? ", i+1);
    luvut[i] = int.Parse(Console.ReadLine());
}
Console.WriteLine();

int isoin = luvut[0];
for (int j = 1; j < 5; j++)
{
    if (luvut[j] > luvut[j - 1])
    {
        isoin = luvut[j];
        
    } 
}
    Console.WriteLine("Suurin kokonaisluku on: " + isoin);

Console.WriteLine();

Console.Write("Valitse haluatko syöttää: 1 (kokonaisluvun), 2(doubleluvun), 3(merkkijonon): ");

Console.WriteLine();
int luku = int.Parse(Console.ReadLine());
Console.WriteLine();
switch (luku)
{
    case 1:
        Console.Write("Syötä kokonaisluku: ");
        int kokonaisluku = int.Parse(Console.ReadLine());
        Console.WriteLine("Syöttämäsi kokonaisluku on: " + kokonaisluku + " ja siihen lisätty yksi: " + (kokonaisluku + 1));
        break;
    case 2:
        Console.Write("Syötä doubleluku: ");
        double dbluku = double.Parse(Console.ReadLine());
        Console.WriteLine("Syöttämäsi doubleluku on: " + dbluku + " ja siihen lisätty yksi: " +(dbluku + 1));
        break;
    case 3:
        Console.Write("Syötä merkkijono: ");
        string mrjono = Console.ReadLine();
        Console.WriteLine("Syöttämäsi merkkijono on: " + mrjono + " ja siihen lisätty *-merkki: " +(mrjono + "*"));
        break;
    default:
        Console.WriteLine("STOP! VALITSE 1, 2, 3 ");
        break;

}
Console.Write("Bonuspisteitä 1-9 välissä: ");
int bonus = int.Parse(Console.ReadLine());
switch (bonus)
{
    case 1:
    case 2:
    case 3:
       Console.WriteLine("Bonuspisteet: " + bonus * 10);
       break;
    case 4:
    case 5:
    case 6:
        Console.WriteLine("Bonuspisteet: " + bonus * 100);
        break;
    case 7:
    case 8:
    case 9:
        Console.WriteLine("Bonuspisteet: " + bonus * 1000);
        break;
    default:
        Console.WriteLine("Älä huijaa. Anna uudestaan bonuspisteet väliltä 0-9. ");
        break;

}
Console.WriteLine();
string sana = "";
Console.Write(" Anna numero välillä 0-999: ");
string nro = Console.ReadLine();
int maara = nro.Length;
if (maara == 3) //sadat
{
    sana += Sadat(nro[0]);
    if (nro[1] == '1')
    {
        sana += Poikkeukset(nro[2]);
    }
    else
    {
        sana += Kymmenet(nro[1]);
        sana += Ykkoset(nro[2]);
    }

}
else if (maara == 2)  //kymmenet
{
    Console.WriteLine("Nro[0] = " + nro[0]);
    if (nro[0] == '1')
    {
        sana += Poikkeukset(nro[1]);
    }
    else
    {
        sana += Kymmenet(nro[0]);
        sana += Ykkoset(nro[1]);
    }
}
    else      //Ykkoset
{
    sana += Ykkoset(nro[0]);
}
Console.WriteLine(sana);
static string Sadat(int lukux)
{
    switch (lukux)
    {

        case '9':
            return "yhdeksansataa";
        case '8':
            return "kahdeksansataa";
        case '7':
            return "seitsemänsataa";
        case '6':
            return "kuusisataa";
        case '5':
            return "viisisataa";
        case '4':
            return "neljäsataa";
        case '3':
            return "kolmesataa";
        case '2':
            return "kaksisataa";
        case '1':
            return "sata";
        default:
            return "";
    }
}
static string Kymmenet(int lukux)
{switch (lukux)
    {
        case '9':
            return "yhdeksänkymmentä";
        case '8':
            return "kahdeksankymmentä";
        case '7':
            return "seitsemänkymmentä";
        case '6':
            return "kuusikymmentä";
        case '5':
            return "viisikymmentä";
        case '4':
            return "neljäkymmentä";
        case '3':
            return "kolmekymmentä";
        case '2':
            return "kaksikymmentä";
        case '1':
            return "kymmenen";
        default:
            return "";
    }

}
static string Ykkoset(int lukux)
{
    switch (lukux)
    {
        case '9':
            return "yhdeksän";
        case '8':
            return "kahdeksan";
        case '7':
            return "seitsemän";
        case '6':
            return "kuusi";
        case '5':
            return "viisi";
        case '4':
            return "neljä";
        case '3':
            return "kolme";
        case '2':
            return "kaksi";
        case '1':
            return "yksi";
        default:
            return "";
    }
}
static string Poikkeukset(int lukux)
{
    switch (lukux)
    {
        case '9':
            return "yhdeksäntoista";
        case '8':
            return "kahdeksantoista";
        case '7':
            return "seitsemäntoista";
        case '6':
            return "kuusitoista";
        case '5':
            return "viisitoista";
        case '4':
            return "neljätoista";
        case '3':
            return "kolmetoista";
        case '2':
            return "kaksitoista";
        case '1':
            return "yksitoista";
        default:
            return "";
    }
}
    



