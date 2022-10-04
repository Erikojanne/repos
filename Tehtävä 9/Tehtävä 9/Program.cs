// See https://aka.ms/new-console-template for more information
Console.WriteLine("Tehtävä 9");
Console.WriteLine();
Console.WriteLine("---------------");
Console.WriteLine();

// Muuttujien esittely alue
int[] lkm;
lkm = new int[5];
double keskiarvo = 0;
Console.WriteLine("Anna viisi lukua laske niiden keskiarvo");

for (int i = 0; i < 5; i++)
{
    Console.Write("Anna {0}. luku ? ", i+1);
    lkm[i] = int.Parse(Console.ReadLine());
}
Console.WriteLine();
foreach (int i in lkm)
{
  keskiarvo += i;
}
Console.WriteLine("keskiarvo on {0:0.00} ",  + keskiarvo / 5);