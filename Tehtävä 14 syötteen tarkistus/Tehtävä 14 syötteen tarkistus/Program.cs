// See https://aka.ms/new-console-template for more information

namespace Tryparse
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Tehtävä 14 (H.Sten) ");
            Console.WriteLine("------------------------");
            Console.WriteLine();
            Console.Write("Anna kokonaisluku ? ");
            string numInput = Console.ReadLine();
            Console.WriteLine();

            int num = 0;
            
            bool succes =Int32.TryParse(numInput, out num);
            
            if (succes)
            {
                Console.WriteLine("Converted '" + numInput + "' to " + num +".         JEE!");
            }
            else
            {
                Console.WriteLine("Attempted conversion of '" + numInput + "' failed.      SORRY! ");
            }


            
        }
    }
}