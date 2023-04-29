using System;

namespace uzduotis32
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            /*
             * Paprašyti įvesti vartotojo vardą.
             * Sukurti string tipo metodą, kuris gražina frazę pvz „Sveiki, Mantas“.
             * Išvesti šią frazę į konsolę
             */

            Console.WriteLine("Įveskite savo vardą: ");
            string vardas = Console.ReadLine();

            Console.WriteLine(Vartotojas(vardas));
        }

        private static string Vartotojas(string vardas)
        {
            return ($"Sveiki, {vardas}!");
        }
    }
}
