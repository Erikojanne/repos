// See https://aka.ms/new-console-template for more information

string aurinko, vesi, lampotila;

Console.Write("paistaako aurinko (K/E) ? ");
aurinko = Console.ReadLine();
Console.WriteLine();
Console.Write("Sataako vettä (K/E) ? ");
vesi = Console.ReadLine();
Console.WriteLine();
Console.Write("Onko lämpötila >0 (K/E) ? ");
lampotila = Console.ReadLine();

Console.WriteLine();

if (aurinko == "K" && vesi == "K" && lampotila == "K")
{
    Console.WriteLine("Aurinko paistaa ja vettä sataa, taitaa tulla kesä.");
}
else if (aurinko == "E" && vesi == "K" && lampotila == "K")
{
    Console.WriteLine("Syksy saapui tuuli vei lehdet mennessään.");
}
else if (aurinko == "E" && vesi == "E" && lampotila == "K")
{
    Console.WriteLine("Jo joutui armas aika ja suvi suloinen.");
}
else if (aurinko == "K" && vesi == "E" && lampotila == "E")
{
    Console.WriteLine("Keväinen talvi kesän tuo.");
}
else
{
    Console.WriteLine("Ompa erikoinen sää!");
}