using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChurrasNoYuri
{
    class Program
    {
        static void Main(string[] args)
        {
            string quantidade = null;

            while ((quantidade = Console.ReadLine()) != null)
            {
                int quantidadeN = int.Parse(quantidade);
                int[] preco = new int[quantidadeN];
                string[] nome = new string[quantidadeN];

                for (int i = 0; i < quantidadeN; i++)
                {
                    string[] churras = Console.ReadLine().Split(' ');
                    nome[i] = churras[0];
                    preco[i] = Convert.ToInt32(churras[1]);

                }

                for (int i = 0; i < quantidadeN; i++)
                {
                    for (int j = 0; j < quantidadeN; j++)
                    {
                        for (int k = 0; k < quantidadeN - j; k++)
                        {
                            if (preco[i] < preco[j] && i != j)
                            {
                                int aux = preco[i];
                                preco[i] = preco[j];
                                preco[j] = aux;

                                string auxStr = nome[i];
                                nome[i] = nome[j];
                                nome[j] = auxStr;

                            }
                        }

                    }
                }

                for (int i = 0; i < quantidadeN; i++)
                {
                    if (!(i == quantidadeN - 1))
                    {
                        Console.Write(nome[i] + " ");
                    }
                    else
                    {
                        Console.WriteLine(nome[i]);
                    }
                }
                
            }
        }
    }
}
