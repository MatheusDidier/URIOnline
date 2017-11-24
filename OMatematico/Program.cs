using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OMatematico
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string[] tabuada = Console.ReadLine().Split('x');
                int x = Convert.ToInt32(tabuada[0]);
                int y = Convert.ToInt32(tabuada[1]);

                for (int j = 5; j <= 10; j++)
                {
                    int multiplicacao1 = x * j;
                    int multiplicacao2 = y * j;
                    Console.Write(x + " x " + j + " = " + (multiplicacao1));
                    if (!(x == y))
                    {
                        Console.Write(" &&");

                        Console.Write(" " + y + " x " + j + " = " + (y * j));
                    }
                    Console.WriteLine();

                }

            }

            Console.ReadLine();
        }
    }
}
