using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConverterParaHexadecimal
{
    class Program
    {

        static string retornaHexa(int valor)
        {
            switch (valor)
            {
                case 10:
                    return "A";
                    
                case 11:
                    return "B";
                 
                case 12:
                    return "C";
                    
                case 13:
                    return "D";
                   
                case 14:
                    return  "E";
                    
                case 15:
                    return  "F";
                    
                default:
                    return Convert.ToString(valor);
           
            }
        }

        static void Main(string[] args)
        {
           
                int resto;
                int numero = int.Parse(Console.ReadLine());
                string hexadecimalAntes = "";
                string hexadecimal = "";

                do
                {
                    resto = numero % 16;
                    numero = numero / 16;

                    hexadecimalAntes += retornaHexa(resto);


                } while (numero > 16);

                if (numero > 0)
                {
                    hexadecimalAntes += retornaHexa(numero);
                }
                for (int i = (hexadecimalAntes.Length - 1); i >= 0; i--)
                {
                    hexadecimal += hexadecimalAntes[i];
                }

                Console.WriteLine(hexadecimal);
            
        }
    }
}
