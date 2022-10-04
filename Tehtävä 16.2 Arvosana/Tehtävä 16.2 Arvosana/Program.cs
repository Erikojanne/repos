// See https://aka.ms/new-console-template for more information
int arvosana;
string arvo = "";
int i = 0;

while (arvo != "e")
{
    Console.Write("Anna arvosana väliltä 4-10: ");
    arvosana = int.Parse(Console.ReadLine());
    Console.WriteLine();

    switch (arvosana)
    {
        
        case 4:
            Console.WriteLine("4 on hylätty arvosana. ");
            break;
        case 5:
            Console.WriteLine("5 välttävä arvosana. ");
            break;
        case 6:
            Console.WriteLine("6 kohtalainen arvosana. ");
            break;
        case 7:
            Console.WriteLine("7 tyydyttyvä arvosana. ");
            break;
        case 8:
            Console.WriteLine("8 hyvä arvosana. ");
            break;
        case 9:
            Console.WriteLine("9 kiitettävä arvosana. ");
            break;
        case 10:
            Console.WriteLine("10 erinomainen arvosana. ");
            break;

    }
    Console.WriteLine();
    i++;
    Console.Write("Haluatko jatkaa (k/e) ? ");
    arvo = Console.ReadLine();

    Console.WriteLine();

    if (arvo != "k")
    {
        break;
    }

}

