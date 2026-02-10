using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hada_p1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string respuesta;
            do
            {
                Console.WriteLine("¿Qué conversión desea realizar? (min/seg) o 'salir':");
                respuesta = Console.ReadLine();

                if (respuesta == "min")
                {
                    Console.WriteLine("Introduce la cantidad de minutos:");
                    double m = double.Parse(Console.ReadLine());
                    Console.WriteLine("{0} minutos son {1} segundos.", m, HadaP1.Minutes2Seconds(m));
                }
                else if (respuesta == "seg")
                {
                    Console.WriteLine("Introduce la cantidad de segundos:");
                    double s = double.Parse(Console.ReadLine());
                    Console.WriteLine("{0} segundos son {1} minutos.", s, HadaP1.Seconds2Minutes(s));
                }
                else if (respuesta == "h")
                {
                    Console.WriteLine("Introduce la cantidad de horas:");
                    double h = double.Parse(Console.ReadLine());
                    Console.WriteLine("{0} horas son {1} minutos.", h, HadaP1.Hours2Minutes(h));
                }

            } while (respuesta != "salir"); 
            }
    }
}
