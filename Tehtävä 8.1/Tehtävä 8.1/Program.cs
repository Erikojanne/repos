// See https://aka.ms/new-console-template for more information

string[] nimet = { "Omena", "Banaani", "Luumu" }; //Luodaan taulukko

int luku; // Esitellään muuttuja

Console.WriteLine("Tehtävä 8.1");
Console.WriteLine();
Console.WriteLine();
Console.WriteLine("-------------------");
Console.WriteLine();
Console.Write("Montako hedelmää haluat nähdä ? ");
luku = int.Parse(Console.ReadLine()); // Muuttuja saa arvon käyttäjällä
Console.WriteLine();

for (int i = 0; i < luku && i < nimet.Length; i++)
{
    Console.WriteLine(nimet[i]); //Tulostaminen
}
