using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SequenciaDeSequencias
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int X = 1;
            string valor = null;
            
            while((valor = Console.ReadLine()) != null && Convert.ToInt32(valor) <= 200 && Convert.ToInt32(valor) >= 0)
            {
                int numero = Convert.ToInt32(valor);
                string sequencia = "0"; 
                for(int i = 1; i <= numero; i++)
                {
                    for(int j = 1; j <= i; j++)
                    {
                        sequencia += " " + i;
                    }
                }
                int N = sequencia.Split(' ').Length;
                string palavra;
                if(!(numero == 0))
                {
                    palavra = "numeros";
                }
                else
                {
                    palavra = "numero";
                }
                Console.WriteLine("Caso " + X + ": " + N  + " " + palavra);
                Console.WriteLine(sequencia);
                Console.WriteLine();
                X++;

            }
        }
    }
}
