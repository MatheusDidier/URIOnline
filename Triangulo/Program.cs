using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triangulo
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] lados = new int[4];
            int[] lados3 = new int[3];

            string possivel = "N";
            string[] ladosStr = Console.ReadLine().Split(' ');
            for (int i = 0; i < lados.Length; i++)
            {
                lados[i] = Convert.ToInt32(ladosStr[i]);
            }

            for (int i = 0; i < lados.Length; i++)
            {
                int contador = 0;
                for (int j = 0; j < lados.Length; j++)
                {
                    if (i != j)
                    {
                        lados3[contador] = lados[j];
                        contador++;
                    }
                }

                if (lados3[0] < (lados3[1] + lados3[2]) && lados3[1] < (lados3[0] + lados3[2]) && lados3[2] < (lados3[0] + lados3[1]))
                {
                    possivel = "S";
                    break;
                }
            }


            Console.WriteLine(possivel);


        }
    }
}
