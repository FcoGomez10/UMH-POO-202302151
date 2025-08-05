using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double costo = 10;
            Console.Write($"Costo por hora: {costo}" + " ");

            double horas = 8;
            Console.Write($"Horas trabajadas: {horas}" + " ");


            double total = costo * horas;

            Console.WriteLine("Total devengado: " + total);
        }
    }
}
