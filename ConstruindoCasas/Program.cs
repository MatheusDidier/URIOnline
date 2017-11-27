using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstruindoCasas
{
    class Program
    {
        static void Main(string[] args)
        {
            do
            {
                string[] valores = Console.ReadLine().Split(' ');
          
                int A = Convert.ToInt32(valores[0]);
                if (A == 0)
                {
                    break;
                }
                int B = Convert.ToInt32(valores[1]);
                int C = Convert.ToInt32(valores[2]);
                int valor = (A * B * 100) / C;
                int quadrado = 1;

                while (true)
                {
                    if (quadrado * quadrado > valor)
                    {
                        quadrado--;
                        break;
                    }
                    quadrado++;
                }
                Console.WriteLine(quadrado);
            } while (true);

        }
    }
}
