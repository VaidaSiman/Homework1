using System;


namespace uzduotis10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            /*Liepkite įvesti skaičių.
             * Jei skaičius lyginis, tuomet išveskite šį skaičių bei jo penktą laipsnį.
             * Jei skaičius nesidalina iš 4, tuomet liepkite įvesti antrąjį skaičių. Išveskite abiejų skaičių sumą ir sandaugą;
             */

            Console.Write("Įveskite skaičių: ");
            string ivedimas = Console.ReadLine();
            int skaicius = Convert.ToInt32(ivedimas);
            Console.WriteLine();

            if (skaicius % 2 == 0)
            {
                Console.WriteLine($"Jūsų įvestas skaičius: {skaicius}. Skaičius pakeltas penktuoju laipsniu {Math.Pow(skaicius, 5)}");
            }

            if (skaicius % 4 != 0)
            {
                Console.Write($"Įveskite kitą skaičių: ");
            } 

            string ivedimas2 = Console.ReadLine();
            int kitasSkaicius = Convert.ToInt32(ivedimas2);
            Console.WriteLine();

            Console.WriteLine($"Skaičių suma: {skaicius + kitasSkaicius}");
            Console.WriteLine($"Skaičiu sandauga: {skaicius * kitasSkaicius}");
        }
    }
}
