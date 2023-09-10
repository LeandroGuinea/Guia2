using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guia2Ejer2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double precio;
            int cantidad;
            double total;

            Console.WriteLine("Ingrese el precio del articulo: ");
            precio = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la cantidad del articulo que lleva el cliente: ");
            cantidad = int.Parse(Console.ReadLine());

            total = precio * cantidad;
            Console.WriteLine("El total a pagar del cliente es: $" + total);
            Console.ReadKey();  
        }
    }
}
