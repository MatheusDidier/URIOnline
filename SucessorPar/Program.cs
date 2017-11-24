using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SucessorPar
{
    class Program
    {
        static void Main(string[] args)
        {
            int X = int.Parse(Console.ReadLine());
            if (X % 2 == 0)
            {
                X++;
            }
            X++;
            Console.WriteLine(X);
            
        }
    }
}
