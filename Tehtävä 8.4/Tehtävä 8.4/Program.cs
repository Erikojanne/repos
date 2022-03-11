// See https://aka.ms/new-console-template for more information


Console.WriteLine("Tehtävä 8.4 ");
Console.WriteLine();
Console.WriteLine("--------------------");
Console.WriteLine();
Console.Write("HEROt ovat seuraavat :");
Console.WriteLine();
int[] luku = { 1, 2, 3, 4};
string[] nimet = {"Ana", "Bastion", "Brigette", "D.Va(mech)"};
string[] role = { "Support", "Defence", "Support", "Tank" };
int[] health = { 200, 200, 200, 400 };
int[] armor = { 0, 100, 50, 200 };







for (int i = 0; i < 4; i++)
{
    Console.WriteLine(+luku[i] + " " + nimet[i]);
   
}
Console.WriteLine();
//Console.Write("Valitse minkä HEROn tiedot haluat nähdä ? ");
Console.WriteLine();
for (int j = 0; j < 4; j++)
{
   // Console.Write("Valitse minkä HEROn tiedot haluat nähdä ? ");
    Console.WriteLine(+ health[j] + " " + armor[j]);
}
/*Console.Write("Valitse minkä HEROn tiedot haluat nähdä ? ");
Console.WriteLine();
int maara = int.Parse(Console.ReadLine());
string[] role = new string[maara];
int[] health = new int[maara];
int[] armor = new int[maara]; // luodaan taulukko

for (int i = 0;i < maara; i++)
{
    Console.Write("Anna {0}. tuotteen nimi ? ", i + 1);
    role[i] = Console.ReadLine();
    Console.Write("Anna {0}. tuotteen hinta ? ", i + 1);
    health[i] = int.Parse(Console.ReadLine());
    Console.Write("Anna {0}. tuotteen lukumäärä ? ", i + 1);
    armor[i] = int.Parse(Console.ReadLine());
}*/






