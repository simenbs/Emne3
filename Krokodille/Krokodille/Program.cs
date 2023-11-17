namespace Krokodille
{
    internal class Program
    {
        static void Main()
        {
            Random rndm = new Random();
            int poengscore = 0;

            while (true)
            {
                int tall1 = rndm.Next(1, 12);
                int tall2 = rndm.Next(1, 12);

                Console.WriteLine($"{tall1} _ {tall2}");

                Console.Write("Mindre, større eller lik? Svar med tegnene '<', '>' eller '=' : ");
                string brukerSvar = Console.ReadLine();

                if (brukerSvar == "<")
                {
                    if (tall1 < tall2)
                    {
                        poengscore++;
                    }
                    else
                    {
                        poengscore--;   
                    }
                }
                else if (brukerSvar == ">")
                {
                    if (tall1 > tall2)
                    {
                        poengscore++;   
                    }
                    else
                    {
                        poengscore--;
                    }
                }
                else if (brukerSvar == "=")
                    if (tall1 == tall2)
                    {
                        poengscore++;
                    }
                    else
                    {
                        poengscore--;
                    }
                else
                {
                    break;
                }

                Console.WriteLine($"Din poengscore ble: {poengscore}");
            }
            
        }
    }
}