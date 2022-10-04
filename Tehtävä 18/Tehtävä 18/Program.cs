// See https://aka.ms/new-console-template for more information
Console.Write("Anna jokin sana tai lause, niin ohjelma tekee sille temppuja. : ");
string teksti = Console.ReadLine();
Console.WriteLine();
Console.WriteLine(teksti);
Console.WriteLine();

for (int i = 0; i < teksti.Length; i++)
{
    Console.Write(teksti[i] + " ");
}
Console.WriteLine();

for (int i = teksti.Length - 1; i > -1; i--)
{
    Console.Write(teksti[i] + " ");

}
Console.WriteLine();