﻿// See https://aka.ms/new-console-template for more information


int ika;
string sukupuoli;
Console.Write("Minkä ikäinen olet ? ");
ika = int.Parse(Console.ReadLine());

Console.WriteLine();
Console.Write("Olet nainen vai mies (N/M) ? ");
sukupuoli = Console.ReadLine();

Console.WriteLine();





if (ika <= 14)
{
    if (sukupuoli == "M" || sukupuoli == "m" )Console.WriteLine("Mitäs poitsu ?");
    if (sukupuoli == "N" || sukupuoli == "n") Console.WriteLine("Mitäs tyttö ?");
}
  else if (ika <=25 )
{
    if (sukupuoli == "M" || sukupuoli == "m") Console.WriteLine("Mitäs nuori mies ?");
    if (sukupuoli == "N" || sukupuoli == "n") Console.WriteLine("Mitäs nuori nainen?");
}

else if (ika <= 56)
{
    if (sukupuoli == "M" || sukupuoli == "m") Console.WriteLine("Olet mies parhaassa iässä !");
    if (sukupuoli == "N" || sukupuoli == "n") Console.WriteLine("Olet nainen parhaassa iässä !");
}
else  
{
    if (sukupuoli == "M" || sukupuoli == "n") Console.WriteLine("Mitäs vanha ukko ?");
    if (sukupuoli == "N" || sukupuoli == "n") Console.WriteLine("Mitäs vanha akka ?");
}


