// See https://aka.ms/new-console-template for more information
string teksti;

Console.Write("Anna jokin sana, niin ohjelma kertoo onko sanassa pientä a-kirjainta monesko se on : ");
teksti = Console.ReadLine();
Console.WriteLine();
Console.WriteLine(teksti);
Console.WriteLine();

if (teksti.Contains("a"))
{
    Console.WriteLine();
    Console.WriteLine("Löytyy pieni a-kirjain");
    Console.WriteLine();
    Console.WriteLine("Ensimmäinen pieni a-kirjain on " + teksti.IndexOf("a") + ". kirjain annetussa sanassa!" ); // Tein IndexOf kun oli yksinkertaisempi 
    Console.WriteLine();
}
else
{
    Console.WriteLine();
    Console.WriteLine("Eipä löytynyt haettua kirjainta tästä sanasta! ");
}
