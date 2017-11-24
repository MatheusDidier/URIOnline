using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaquinaDeCafe
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] A = new int[3];
            int menorTempo = Int32.MaxValue;
            int somaTempo;

            for (int i = 0; i < A.Length; i++)
            {
                A[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < A.Length; i++)
            {
                somaTempo = 0;
                for (int j = 0; j < A.Length; j++)
                {
                    if (i != j)
                    {
                        somaTempo += A[j] * Math.Abs(i - j) * 2;
                    }
                }

                if (somaTempo < menorTempo)
                {
                    menorTempo = somaTempo;
                }
            }

            Console.WriteLine(menorTempo);



        }
    }
}
