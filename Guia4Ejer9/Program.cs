using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guia4Ejer9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero, d;
            double suma, termino, pi;
            Console.WriteLine("Numero para sacar pi: ");
            numero = int.Parse(Console.ReadLine());

            suma = 1;
            d = 3;
            for(int i = 2; i <= numero; i++)
            {
                termino = 1.0 / d;
                if ((i % 2) != 0)
                {
                    suma += termino;
                }
                else
                {
                    suma -= termino;
                }
                d = d + 2;
            }
            pi = suma * 4;

            Console.WriteLine("El resultado es: " + pi);
            Console.ReadKey();  
        }
    }
}
