using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guia2Ejer8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero = 1;
            int numeroUsuario;
            int seleccion;

            Console.WriteLine("Introduzca 1 si desea evaluar un unico numero y 2 para evaluar hasta 1000: ");
            seleccion = int.Parse(Console.ReadLine());
            switch(seleccion)
            {
                case 1:
                    Console.WriteLine("Digite el numero que desea evaludar si es perfecto: ");
                    numeroUsuario = int.Parse(Console.ReadLine());
                    if (CalculoPerfectos(numeroUsuario))
                        {
                        Console.WriteLine("El numero " + numeroUsuario + " es perfecto"); 
                        }
                    else 
                        {
                        Console.WriteLine("El numero " + numeroUsuario + " no es perfecto");
                        }
                    break;
                case 2:
                    while (numero <= 1000)
                    {
                        if (CalculoPerfectos(numero))
                        {
                            Console.WriteLine("El numero " + numero + " es perfecto");
                            Console.WriteLine("Los factores de " + numero + " son: ");
                            for (int i = 1; i < numero; i++)
                            {
                                if ((numero % i) == 0)
                                {
                                    Console.WriteLine("-"+i);
                                }
                            }
                        }
                        numero++;
                    }
                    break;   
            }       
            Console.ReadKey();
        }
        static bool CalculoPerfectos(int num)
        {
            int contador = 0;
            for (int i = 1; i < num; i++)
            {
                if ((num % i) == 0)
                {
                    contador += i;
                }
            }
            if (num == contador)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
