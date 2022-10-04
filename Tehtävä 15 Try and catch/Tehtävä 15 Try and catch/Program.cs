// See https://aka.ms/new-console-template for more information

namespace Exception_Handling
{
    class Program
    {
        static void Main(string[] args)
        {
        label:
            // Try block: The code which may raise exception at runtime
            try
            {
                int num1, num2;
                decimal result;

                Console.WriteLine("Jakolaskuohjelma. Sinun pitää antaa jaettava & jakaja ja saat tuloksen. ");
                Console.Write("Anna jaettava: ");
                num1 = Convert.ToInt32(Console.ReadLine());
                Console.Write("Anna jakaja: ");
                num2 = Convert.ToInt32(Console.ReadLine());

                result = (decimal)num1 / (decimal)num2;
                Console.WriteLine("Osamäärä on : " + result.ToString());
                Console.ReadLine();
            }

            //Multiple Catch block to handle exception

            catch (DivideByZeroException dex)
            {
                Console.WriteLine("Jakaja ei voi olla 0");
                Console.WriteLine("Lisätietoa virheestä: \n\n" + dex.ToString() + "\n\n");
                goto label;
            }

            catch (FormatException fex)
            {
                Console.WriteLine("Eipä ollut luku");
                Console.WriteLine("Lisätietoa virheestä: \n\n" + fex.ToString() + "\n\n");
                goto label;
            }

            //Parent Exception: Catch all type of exception

            catch (Exception ex)
            {
                Console.WriteLine("Othe Exception raised" + ex.ToString() + "\n\n");
                goto label;
            }

            //Finally block: it always executes

            finally
            {
                Console.WriteLine("Finally Block: For Continue Press Enter and for Exit press Ctrl + c");
                Console.ReadLine();
            }
        }
    }
}