// See https://aka.ms/new-console-template for more information
Console.OutputEncoding = System.Text.Encoding.UTF8; // Euro

string[] nimet = { "Vasara", "Saha", "Kirves" }; //Luodaan taulukko

int[] hinnat = { 5, 10, 15 }; // Luodaan taulukko


Console.WriteLine("Tehtävä 8.2");
Console.WriteLine();
Console.WriteLine("------------------");
Console.WriteLine();

for (int i = 0; i < 3; i++)
{
    Console.WriteLine(nimet[i] + " " + hinnat[i] + " €");  // Tulostaminen
}
