using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1AnalisisGuia6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Black;
            Console.BackgroundColor = ConsoleColor.White;
            Console.Clear();
            Console.Title = "Tablas de multiplicar";

            Double multiplicando = 0, multiplo = 0;

            Console.WriteLine("Por favor digite el número del que desea conocer su tabla de multiplicación:");
            multiplicando = Double.Parse(Console.ReadLine());
            for (multiplo = 1; multiplo <= 10; multiplo++)
            {
                Console.WriteLine(multiplicando + " x " + multiplo + " = " + (multiplicando * multiplo));
            }
            Console.ReadKey();
        }
    }

}
