using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiteraZ
{
    class Program
    {

        static void Main(string[] args)
        {

            for (int i = 0; i < 7; i++)
            {
                Console.Write("*");
            }


            Console.WriteLine();

            int n = 8;
            int m = 8;

            // góra i dół
            int suma = 2;

            for (int i = 0; i < n - suma; i++)
            {
                for (int j = 0; j < m - i - suma; j++)
                {
                    Console.Write(" ");
                    if (j > m - i - 2 * suma)
                    {
                        Console.Write("*");
                    }

                }
                Console.WriteLine();
            }

            for (int i = 0; i < 7; i++)
            {
                Console.Write("*");
            }


            Console.WriteLine();

            Console.Read();
        }
    }
}
