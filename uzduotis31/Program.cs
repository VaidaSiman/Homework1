using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uzduotis31
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            /*
             * Parašykite sumos funkciją su 3 parametrais, kuris gražina int tipo atsakymą
             * Parašykite dalmens funkciją su 2 parametrais, kuris gražina double tipo  atsakymą.
             * Išsikvieskite abi funkcijas ir atsakymą išveskite į ekraną.
             */
           
            int skaicius = 2;
            int skaicius1 = 3;
            int skaicius2 = 1;

            int sumaSkaiciu = Suma(skaicius, skaicius1, skaicius2);
            double SkaiciuDalyba = Dalyba(skaicius, skaicius1);

            Console.WriteLine($"Skaičiai: {skaicius}, {skaicius1}, {skaicius2}");
            Console.WriteLine($"Skaičių suma: {sumaSkaiciu}");
            Console.WriteLine($"Skaičių dalyba, pirmojo ir antrojo: {SkaiciuDalyba}");
        }

        private static double Dalyba(int skaicius, int skaicius1)
        {
            return (double)skaicius / skaicius1;
        }

        private static int Suma(int skaicius, int skaicius1, int skaicius2)
        {
            return skaicius + skaicius1 + skaicius2;
        }
    }
}
