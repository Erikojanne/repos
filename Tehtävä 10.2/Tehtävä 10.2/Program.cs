// See https://aka.ms/new-console-template for more information
Console.WriteLine("Tehtävä 10 vaihe 2 ");
Console.WriteLine("--------------------------");
Console.WriteLine();

Random satluku = new Random();
int arvottuluku = satluku.Next(1, 13);
string arvaus = "";
int i = 0;
int arvattu = 0;

Console.WriteLine("Arvaa arvottu luku väliltä 1-12 (lopetus L-merkillä)");
Console.WriteLine();

while (arvaus != "L")  
{
    i++;
    Console.Write(i + " yritys: Arvaa luku ? ");
    arvaus = Console.ReadLine();
    
    if (arvaus != "L")
    {
        arvattu = int.Parse(arvaus);
        Console.WriteLine();
        if (arvattu == arvottuluku)
        {
            Console.WriteLine("Onneksi olkoon, arvasit oikein !!! ");
            Console.WriteLine("Oikea vastaus on " + arvottuluku);
            break;
        }
        
    } 

}
if (arvattu != arvottuluku)
{
    Console.WriteLine();
    Console.WriteLine("Lopetetaan... ");
    Console.WriteLine();
    Console.WriteLine("Halusit lopetaa LUUSERI !! ");
    Console.WriteLine();
    Console.WriteLine("Oikea vastaus on " + arvottuluku);
}