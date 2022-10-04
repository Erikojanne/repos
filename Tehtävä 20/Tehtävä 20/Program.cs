// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

namespace Esim_20
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Anna jokin merkki : ");
            char value = char.Parse(Console.ReadLine());
            Console.WriteLine("");
            Console.WriteLine(value);
            Console.WriteLine("");
            if (char.IsLower(value))
            {
                Console.WriteLine("On pieni kirjain");
                Console.WriteLine("");
            }
            else if (char.IsUpper(value))
            {
                Console.WriteLine("On ISO kirjain");
                Console.WriteLine("");
            }
            else if (char.IsNumber(value))
            {
                Console.WriteLine("On numero " + value);
                Console.WriteLine("");
            }
            else if (char.IsWhiteSpace(value))
            {
                Console.WriteLine("Annoit tyhjän merkin");
                Console.WriteLine("");
            }
            else
            {
                Console.WriteLine("Annoit jonkin erikoismerkin !");
                Console.WriteLine("");
            }
        }
        
 
}
}