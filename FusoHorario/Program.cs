using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FusoHorario
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string[] fusos = Console.ReadLine().Split(' ');
          
                int S = int.Parse(fusos[0]) * 60;
                int T = int.Parse(fusos[1]) * 60;
                int F = int.Parse(fusos[2]) * 60;
                int retirar24Horas = ((S + T + F) % (60 * 24)) / 60;
                if (retirar24Horas < 0)
                {
                    retirar24Horas = 24 + retirar24Horas;
                }

                Console.WriteLine(retirar24Horas);
 
   


        }
    }
}
