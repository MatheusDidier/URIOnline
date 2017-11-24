using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemOfADownload
{
    class Program
    {

        static string parteDaMusica(int soma)
        {
            switch (soma)
            {
                case 0:
                    return "PROXYCITY";
                case 1:
                    return "P.Y.N.G.";
                case 2:
                    return "DNSUEY!";
                case 3:
                    return "SERVERS";
                case 4:
                    return "HOST!";
                case 5:
                    return "CRIPTONIZE";
                case 6:
                    return "OFFLINE DAY";
                case 7:
                    return "SALT";
                case 8:
                    return "ANSWER!";
                case 9:
                    return "RAR?";
                default:
                    return "WIFI ANTENNAS";
            }

        }
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string[] botao = Console.ReadLine().Split(' ');
                int soma = Convert.ToInt32(botao[0])  + Convert.ToInt32(botao[1]);
                string frase = parteDaMusica(soma);
                Console.WriteLine(frase);
            }

        }
    }
}
