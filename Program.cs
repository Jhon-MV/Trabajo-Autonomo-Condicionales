using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad_Autonoma_Boole
{
    class Program
    {
        static void Main(string[] args)
        {
            double a;
            double b;
            double blancos;
            double anulados;
            double n;
            double p;
            double total;
            double diferencia = 0;
            double ganador = 0;

            Console.WriteLine("Ingresar la cantidad de votos por el partido 1.");
            a = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingresar la cantidad de votos por el partido 2.");
            b = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingresar la cantidad de votos en blanco.");
            blancos = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingresar la cantidad de votos anulados.");
            anulados = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingresar la poblacion total de todas las edades.");
            n = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingresar el porcentaje de poblacion mayor de edad.");
            p = double.Parse(Console.ReadLine());
            p *= 0.01;
            total = a + b + blancos + anulados;
            if (a > b) { diferencia = a - b; ganador = 1; }
            if (b > a) { diferencia = b - a; ganador = 2; }

            if ((total > n || (total * 0.1) > diferencia) && (total < (n * 0.3)))
            { Console.WriteLine("Las elecciones deben ser realizadas nuevamente."); }
            else { Console.WriteLine("El ganador de las elecciones es el partido " + ganador + "."); }
        }
    }
}
