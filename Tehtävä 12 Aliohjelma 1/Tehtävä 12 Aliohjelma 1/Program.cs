// See https://aka.ms/new-console-template for more information
public class Nelio {
    
    public static void Main() {
        Console.WriteLine("Tehtävä 12 (H.Sten)");
        Console.WriteLine("-------------------------");
        Console.WriteLine();

        int luku = 0;
        Console.Write("Anna luku, jonka neliön haluat tietää ? ");
        luku = int.Parse(Console.ReadLine());
        Console.WriteLine();
        Console.WriteLine("Luvun " + luku + " nelio on " + KahdenLuvunTulo(luku));
        
    }
    
    public static int KahdenLuvunTulo(int luku) {
        int tulo = luku * luku;
        return tulo;
    }
}
