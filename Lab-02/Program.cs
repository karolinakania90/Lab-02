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
                Console.WriteLine(i);

            }
            Console.WriteLine();
            for (int j = 0; j < m; j++)
            {
                Console.Write(j);
            }
        }

        public static void Main(string[] args)
        {
            Prostokat(5, 7);

            Console.Read();
        }

    }
}
