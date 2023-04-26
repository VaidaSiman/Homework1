using System;

namespace uzduotis29
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            /*
             * Parašykite metodą, kuris pasisveikintų su vartotoju.
             * Vartotojas turi įvesti savo vardą, amžių ir hobio pavadinimą.
             * Visi šie duomenys yra duodami metodui, kuris visą šią informaciją išvedA 
             * formatuotaI */
            Console.Write("Įveskite savo vardą: ");
            string vardas = Console.ReadLine();
            Pasisveikinimas(vardas);
            Console.WriteLine();
            Console.Write("Koks jūsų amžius?  ");
            string amzius = Console.ReadLine();
            Metai(amzius);
            Console.WriteLine();
            Console.Write("Koks yra jūsų hobis?  ");
            string hobis = Console.ReadLine();
            Pomegis(hobis);
            Console.WriteLine();
        }

        private static void Pomegis(string hobis)
        {
            Console.WriteLine(hobis);
        }

        private static void Metai(string amzius)
        {
            Console.WriteLine($"{amzius}");
        }

        private static void Pasisveikinimas(string vardas)
        {
            Console.WriteLine($"Labas, {vardas}");
        }
    }
}
