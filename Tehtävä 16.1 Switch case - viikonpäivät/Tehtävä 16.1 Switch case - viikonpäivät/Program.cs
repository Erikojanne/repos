// See https://aka.ms/new-console-template for more information

int viikonpaiva;
string vp = "";
int i = 0;

while (vp != "e")
{ 
    Console.Write("Anna numero väliltä 1-7, niin kerron mikä viikonpäivä on kyseessä ? ");
viikonpaiva = int.Parse(Console.ReadLine());
Console.WriteLine();

switch (viikonpaiva)
    {

        case 1:
            Console.WriteLine("Maanantai");
            break;
        case 2:
            Console.WriteLine("Tiistai");
            break;
        case 3:
            Console.WriteLine("Keskiviikko");
            break;
        case 4:
            Console.WriteLine("Torstai");
            break;
        case 5:
            Console.WriteLine("Perjantai");
            break;
        case 6:
            Console.WriteLine("Lauantai");
            break;
        case 7:
            Console.WriteLine("Sunnuntai");
            break;

    }
    Console.WriteLine();
    i++;
    Console.Write("Haluatko jatkaa (k/e) ? ");
    vp = Console.ReadLine();

    Console.WriteLine();
    
    if (vp != "k")
    {
        break;
    }

}










