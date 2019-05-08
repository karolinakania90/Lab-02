using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_02
{
    class Program
    {
        public static void Prostokat(int n, int m)
        {
            for (int i = 0; i < m; i++)
            {
                Console.Write("x");
                for (int j = 1; j < n; j++)
                {
                    Console.Write("x");
                }
                Console.WriteLine();
            }
        }

        public static void Main(string[] args)
        {
            Prostokat(5, 7);

            Console.Read();
        }
    }
}
