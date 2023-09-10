using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guia2Ejer7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int rangoInicial;
            int rangoFinal;
            int total;
            Console.WriteLine("Digite el numero que sera el principio del rango a tomar para sumar los enteros: ");
            rangoInicial = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite el numero que sera el final del rango a tomar para sumar los enteros: ");
            rangoFinal = int.Parse(Console.ReadLine());
            total = SumaPares(rangoInicial,rangoFinal);
            Console.WriteLine("El total de los numeros pares sumados es: " + total);
            Console.ReadKey();
        }
        static int SumaPares(int inicioRango, int finalRango)
        {
            int sumatoria = 0;
            for (int i = inicioRango; i <= finalRango; i++)
            {
                if ((i % 2) == 0)
                {
                    sumatoria += i;
                }
            }
            return sumatoria;
            
        }
    }
}
