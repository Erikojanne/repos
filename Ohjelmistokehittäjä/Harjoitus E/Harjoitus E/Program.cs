// See https://aka.ms/new-console-template for more information
int ika;
aloitus:
try
{
    Console.Write("Anna ikäsi kokonaislukuna ? ");
    ika = int.Parse(Console.ReadLine());
    Console.WriteLine();
    Console.WriteLine(ika + " - näytät ikäistäsi nuoremmalta ");
}

catch
{
    Console.WriteLine("Ei ole kokonaisluku. ANNA KOKONAISLUKU!!!!!");
    goto aloitus;
}

int luku;
aloitus1:
Console.WriteLine();
try
{
    Console.Write("Anna kokonaisluku joka on suurempi kuin 10: ");
    luku = int.Parse(Console.ReadLine());
}

catch
{
    Console.WriteLine("Ei ole kokonaisluku. ANNA KOKONAISLUKU!!!!!");
    goto aloitus1;
}


for (int i = 0; i < luku; i++)
{
    for (int j = 0; j < luku; j++)
    {
        Console.Write(luku + " ");
    }
    for (int k = 0; k < luku; k++)
    {
        Console.Write(luku);
        
    }
   
}
Console.WriteLine();

string teksti, teksti1;
int arvo;

Console.Write("Anna sana niin ohjelma vaihtaa ensimmäisen ja viimeisen kirjaimen keskenään: ");
teksti = Console.ReadLine();

arvo = teksti.Length;
char[] taulu = new char[arvo];

for (int i = 0; i < arvo; i++)

    taulu[i] = teksti[i];
    taulu[0] = teksti[arvo - 1];
    taulu[arvo - 1] = teksti[0];
    teksti1 = String.Join(" ", taulu);
    Console.WriteLine("Annoit sanan " + teksti + " ja kirjainten paikat on vaihdettu: " + teksti + " " + teksti1);
Console.WriteLine();

Console.WriteLine("Anna kaksi kokonaislukua niin ohjelma kertoo ovatko ne positiivisia vai negatiivisiä: ");
int pos;
Console.Write("Ensimmäinen: ");
pos = int.Parse(Console.ReadLine());
int neg;
Console.Write("Toinen: ");
neg = int.Parse(Console.ReadLine());
Console.WriteLine();
if (pos >= 0 && neg >= 0)
{
    Console.WriteLine("Luvut ovat positiivisiä");
}
else if (pos <= 0 && neg <= 0)
{
    Console.WriteLine("Luvut ovat negatiivisiä");
}
else if (pos > 0 && neg < 0)
{
    Console.WriteLine("Ensimmäinen positiivinen ja toinen negatiivinen ");
}
else if (pos < 0 && neg > 0)
{
    Console.WriteLine("Ensimmäinen negatiivinen ja toinen positiivinen");
}
Console.WriteLine();
string lause;
Console.Write("Kirjoita kokonainen lause: ");
lause = Console.ReadLine();
string[] taulu1 = lause.Split(' ');
string pisin = taulu1[0];

for (int i = 1; i < taulu.Length; i++)
{
    if (taulu1[i].Length > pisin.Length)
    {
        pisin = taulu1[i];
    } 

}
Console.WriteLine("Lause oli " +lause+ " ja pisin sana on " + pisin);
Console.WriteLine();
Console.WriteLine("Parittomia lukuja");
for (int i = 1; i <= 99; i+=2)
{
    Console.WriteLine(i);
}
Console.WriteLine();
Console.WriteLine("3:lla jaollisia lukuja");
for (int i = 3; i <= 99; i += 3)
{
    Console.WriteLine(i);
}
Console.WriteLine();
