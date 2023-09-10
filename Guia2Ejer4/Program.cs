using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guia2Ejer4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero;
            int numeroMayor = 0;
            int numeroMenor = 0;
            for (int i = 1; i <= 3; i++)
            {
                Console.WriteLine("Ingrese el numero "+ i);
                numero = int.Parse(Console.ReadLine());
                if (i == 1) {
                    numeroMayor = numero;
                    numeroMenor = numero;
                }
                if (numeroMayor < numero)
                {
                    numeroMayor = numero;
                }
                if (numeroMenor > numero)
                {
                    numeroMenor = numero;
                }
            }
            Console.WriteLine("El numero mayor es: " + numeroMayor);
            Console.WriteLine("El numero menor es: " + numeroMenor);
            Console.ReadKey();  

        }
    }
}
