using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guia2Ejer10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = 0;
            string bin = "";
            bool v = true;
            Console.WriteLine("Escribe un numero binario: ");
            bin = Console.ReadLine();
            for (int x = bin.Length - 1, y = 0; x >= 0; x--, y++)
            {
                if (bin[x] == '0' || bin[x] == '1')
                {
                    n += (int)(int.Parse(bin[x].ToString()) * Math.Pow(2, y));
                }
                else
                {
                    v = false;

                }
            }
            if (v == false)
            {
                Console.WriteLine("'" + bin + "' No es binario");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("Decimal: {0}", n);
                Hexa(n);
                Octal(n);
            }

        }
        private static void Hexa(int n)
        {
            int q;
            int dn = 0;
            int m;
            int l;
            int tmp;
            int s;
            q = n;
            for (l = q; l > 0; l = l / 16)
            {
                tmp = l % 16;
                if (tmp < 10)
                    tmp = tmp + 48;
                else
                    tmp = tmp + 55;
                dn = dn * 100 + tmp;
            }
            Console.Write("Hexadecimal : ");
            for (m = dn; m > 0; m = m / 100)
            {
                s = m % 100;
                Console.Write("{0}", (char)s);
            }

        }
        private static void Octal(int n)
        {
            int cociente, i = 1, j;
            int[] octalNumber = new int[100];
            cociente = n;
            while (cociente != 0)
            {
                octalNumber[i++] = cociente % 8;
                cociente = cociente / 8;
            }
            Console.Write("\nOctal: ");
            for (j = i - 1; j > 0; j--)
                Console.Write(octalNumber[j]);
            Console.Read();
        }
    }
}