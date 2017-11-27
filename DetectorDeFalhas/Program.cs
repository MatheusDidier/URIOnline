using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DetectorDeFalhas
{
    class Program
    {
        static void Main(string[] args)
        {
            string X;
            bool achou = false;
            int maior = Int32.MinValue;
            int Y = 0;
            while (!string.IsNullOrEmpty(X = Console.ReadLine()))
            {
                int numero = Convert.ToInt32(X);
                if (numero > maior && !achou)
                {
                    maior = numero;
                }
                else if (numero <= maior && !achou)
                {
                    Y = maior + 1;
                    achou = true;
                }
            }

            if (achou)
            {
                Console.WriteLine(Y);
            }
            else
            {
                maior++;
                Console.WriteLine(maior);
            }
            Console.ReadKey();
        }
    }
}
