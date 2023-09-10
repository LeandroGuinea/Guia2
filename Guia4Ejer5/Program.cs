using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guia4Ejer5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numeroUsuario;

            Console.WriteLine("Digite el numero que desea comprobar si es primo: ");
            numeroUsuario = int.Parse(Console.ReadLine());
            if (ValidarPrimo(numeroUsuario))
            {
                Console.WriteLine("El numero ingresado es primo");
            }
            else
            {
                Console.WriteLine("El numero ingresado no es primo");
            }
            Console.ReadKey();
        
        }
        static bool ValidarPrimo(int numero)
        {
            for (int i = 2; i < numero; i++)
            {
                if ((numero % i) == 0)
                {
                    return false;
                }

            } 
            return true;
        }
    }
}
