// See https://aka.ms/new-console-template for more information
Console.WriteLine("Lasku x = y + 3");
Console.Write("Anna y arvo: ");
int luku = int.Parse(Console.ReadLine());
luku += 3;
Console.WriteLine("x = " +luku);

Console.WriteLine();

Console.WriteLine("Lasku x = y - 2");
Console.Write("Anna y arvo: ");
int luku1 = int.Parse(Console.ReadLine());
luku1 -= 2;
Console.WriteLine("x = " + luku1);

Console.WriteLine();

Console.WriteLine("Lasku x = y * 5");
Console.Write("Anna y arvo: ");
int luku2 = int.Parse(Console.ReadLine());
luku2 *= 5;
Console.WriteLine("x = " + luku2);

Console.WriteLine();


Console.WriteLine("Lasku x = x / y");
Console.Write("Anna x arvo: ");
int lukux = int.Parse(Console.ReadLine());
Console.Write("Anna y arvo: ");
int lukuy = int.Parse(Console.ReadLine());
int osamaara = lukux / lukuy;
Console.WriteLine("x = " + osamaara);

Console.WriteLine();

Console.WriteLine("Lasku x = x % y");
Console.Write("Anna x arvo: ");
int lukux1 = int.Parse(Console.ReadLine());
Console.Write("Anna y arvo: ");
int lukuy2 = int.Parse(Console.ReadLine());
int jakojaanos = lukux1 % lukuy2;
Console.WriteLine("x = " + jakojaanos);

Console.WriteLine();

Console.WriteLine("Lasku x += y");
Console.Write("Anna x arvo: ");
int luku3 = int.Parse(Console.ReadLine());
Console.Write("Anna y arvo: ");
int luku4 = int.Parse(Console.ReadLine());
luku3 += luku4;
Console.WriteLine("x= "+luku3);

Console.WriteLine();

Console.WriteLine("Lasku x -= y");
Console.Write("Anna x arvo: ");
int luku5 = int.Parse(Console.ReadLine());
Console.Write("Anna y arvo: ");
int luku6 = int.Parse(Console.ReadLine());
luku5 -= luku6;
Console.WriteLine("x= "+luku5);

Console.WriteLine();

Console.WriteLine("Lasku x* = y*5");
Console.Write("Anna x arvo: ");
int luku7 = int.Parse(Console.ReadLine());
Console.Write("Anna y arvo: ");
int luku8 = int.Parse(Console.ReadLine());
luku7 *= luku8 * 5;
Console.WriteLine("x= " +luku7);

Console.WriteLine();

Console.WriteLine("Lasku x /= y");
Console.Write("Anna x arvo: ");
int luku9 = int.Parse(Console.ReadLine());
Console.Write("Anna y arvo: ");
int luku10 = int.Parse(Console.ReadLine());
luku9 /= luku10;
Console.WriteLine("x = " +luku9);
