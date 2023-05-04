using System;

namespace uzduotis30
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            /*
             * Leiskite vartotojui įvesti du sveikuosius skaičius į programą.
             * Sukurkite ir panaudokite šiuos metodus:
             * Suma;
             * Skirtumas;
             * Sandauga;
             * Dalmuo;
             */
            Console.Write("Įveskite pirmąjį skaičių: ");
            int skaicius1 = Convert.ToInt32(Console.ReadLine()); 
            Console.WriteLine();
            Console.Write("Įveskite antrąjį skaičių: ");
            int skaicius2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            Suma(skaicius1, skaicius2);
            Skirtumas(skaicius1, skaicius2);
            Sandauga(skaicius1, skaicius2);
            Dalmuo(skaicius1, skaicius2);
        }

        public static void Dalmuo(int skaicius1, int skaicius2)
        {
            Console.WriteLine($"{skaicius1} / {skaicius2} = {(double)skaicius1 / skaicius2}");
        }

        public static void Sandauga(int skaicius1, int skaicius2)
        {
            Console.WriteLine($"{skaicius1} * {skaicius2} = {skaicius1 * skaicius2}");
        }

        public static void Skirtumas(int skaicius1, int skaicius2)
        {
            Console.WriteLine($"{skaicius1} - {skaicius2} = {skaicius1 - skaicius2}");
        }

        public static void Suma(int skaicius1, int skaicius2)
        {
            Console.WriteLine($"{skaicius1} + {skaicius2} = {skaicius1 + skaicius2}");
        }
    }
}
