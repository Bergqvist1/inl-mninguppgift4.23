using System;
using System.Globalization;

namespace Uppgift_4_23
{
    class Program
    {
        static void Main(string[] args)
        {

            bool b = true;
            int n = 0;
            for (int i = 0; b == true;)
            {
                Console.WriteLine("Skriv in ett heltal? Vill du fortsätta? Svara j för ja eller n för nej. Skriv sedan ditt nya heltal");
                string svar = Console.ReadLine();
                if (svar == "j")
                {
                    n = int.Parse(Console.ReadLine());
                    if (n > i)
                    {
                        i = n;
                    }
                }
                else
                {
                    Console.WriteLine("Detta är det största talet du skrev: " + i);
                    b = false;
                }
            }

        }
    }
}
