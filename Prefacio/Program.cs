using System;

namespace Prefacio
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] numero = Console.ReadLine().Split(' ');

            int a = Convert.ToInt32(numero[0]);
            int b = Convert.ToInt32(numero[1]);
            int r = 0, q = 0;
            if (a >= 0 && b < 0)
            {
                q = (a / b);
                r = -b * q + a;
            }
            else if (a < 0 && b >= 0)
            {
                int resultado;
                for (int i = 0; i <= -a; i++)
                {
                    resultado = b * -i;
                    if (resultado <= a)
                    {
                        q = -i;
                        r = -b * q + a;
                        break;
                    }
                }

            }
            else if (a < 0 && b < 0)
            {
                int resultado;
                for (int i = 0; i <= Math.Abs(a); i++)
                {
                    resultado = Math.Abs(b) * i;
                    if (resultado >= Math.Abs(a))
                    {
                        q = i;
                        r = -b * q + a;
                        break;
                    }
                }
            }
            else
            {
                q = a / b;
                r = a % b;

            }

            Console.WriteLine(q + " " + r);
       



        }
    }
}
