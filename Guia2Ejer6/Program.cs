using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guia2Ejer6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numAnime;
            List<string> Lista = new List<string>();
            Console.WriteLine("Ingrese el numero de animes por agregar a la lista: ");
            numAnime = int.Parse(Console.ReadLine());

            for (int i = 1; i <= numAnime; i++)
            {
                Console.WriteLine("Digite el nombre del Anime " + i);
                Lista.Add(Console.ReadLine());
            }
            Console.WriteLine("Los animes en tu lista son: ");
            foreach (string anime in Lista)
            {
                Console.WriteLine("-"+anime);                
            }
            Console.ReadKey();
        }
    }
}
