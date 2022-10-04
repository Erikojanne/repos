// See https://aka.ms/new-console-template for more information
public class summa
{
    public static int KolmenLuvunSumma(int luku1, int luku2, int luku3)
    {
        int kolmenLuvunSumma = luku1 + luku2 + luku3;
        return kolmenLuvunSumma;
    }
    public static void Main()
    {
        Console.WriteLine("Tehtävä 13 (H.Sten ");
        Console.WriteLine("------------------------");
        Console.WriteLine();

        int luku1 = 0;
        int luku2 = 0;
        int luku3 = 0;
        
        Console.WriteLine("Anna 3 lukua, niin lasken niiden summan... ");
        Console.WriteLine();

        for (int i = 1; i < 4; i++)
        {
            Console.Write("Anna {0}. luku ? ", i);
             int luku = int.Parse(Console.ReadLine());
            Console.WriteLine();
            if (i == 1) { luku1 = luku;}
            else if (i == 2) { luku2 = luku;}
            else { luku3 = luku;}
         }
        Console.WriteLine("Kolmen luvun " + luku1 + ", " + luku2 + " ja " + luku3 + " summa on " + KolmenLuvunSumma(luku1, luku2, luku3));
    }
}

