using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime;
using System.Text;
using System.Threading.Tasks;

namespace Guia2Ejer1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero1;
            int numero2;
            int numero3;
            int numero4;
            int suma;
            int producto;

            Console.WriteLine("Ingrese el primero numero: ");
            numero1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el segundo numero: ");
            numero2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el tercer numero: ");
            numero3 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el cuarto numero: ");
            numero4 = int.Parse(Console.ReadLine());

            suma = numero1 + numero2;
            producto = numero3 * numero4;
            Console.WriteLine("El resultado de la suma de " + numero1 + " + " + numero2 + " es: "+ suma);
            Console.WriteLine("El resultado de la multipliacion de " + numero3 + " x " + numero4 + " es: " + producto);
            Console.ReadKey();
        }   
    }
}
