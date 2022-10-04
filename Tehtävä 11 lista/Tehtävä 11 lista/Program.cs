// See https://aka.ms/new-console-template for more information

Console.WriteLine("Tehtävä 11 ");
Console.WriteLine();
Console.WriteLine("----------------- ");

List<int> numero = new List<int>(); // Luodaan lista

int luku = 0; // alustetaan luku muuttuja
Console.WriteLine();

for (int i = 1; i <= 5; i++) 
{
    Console.Write(i + ". listan luku ? ");
    luku  = int.Parse(Console.ReadLine());
    numero.Add(luku);
    //lisää syötetyt luvut listaan "numero"
    Console.WriteLine();
    
}
for (int i = 0; i < numero.Count; i++)
{
    
    Console.WriteLine(numero[i]); // Tulostus
}
