﻿// See https://aka.ms/new-console-template for more information


// See https://aka.ms/new-console-template for more information





double arvo;
int numero;

Console.Write("VALUUTTALASKURI");

Console.WriteLine();

Console.Write("---------------");

Console.WriteLine();
Console.WriteLine();

Console.Write("Anna summa euroina ?");
arvo = double.Parse(Console.ReadLine());

Console.WriteLine();

Console.Write("Vastaa 1 jos haluat muuntaa dollareiksi ja 2 jos haluat muuntaa punniksi ?");
numero = int.Parse(Console.ReadLine());

Console.WriteLine();

double dollari = arvo * 1.1345;
double punta = arvo * 0.8376;

string dollarit = string.Format("{0,10:0.00}", dollari);
string punnat = string.Format("{0,10:0.00}", punta);

if (numero == 1)
{
Console.WriteLine(dollarit + "$");
}
else if (numero == 2)
{
Console.WriteLine(punnat + "£");
}



/*Console.WriteLine(dollarit + " $");

Console.WriteLine( punnat + " £");*/

