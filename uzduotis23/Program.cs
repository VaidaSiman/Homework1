using System;

namespace uzduotis23
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            /*
             * Susikurkite kintamąjį, kuris pasakytų kiek automobilis vidutiniškai sunaudoja  degalų 100 – ui km
             * Susikurkite masyvą, kuriame saugotumėte skirtingose kelionėse nuvažiuotų kilometrų rodmenis.
             * Raskite:
             * trumpiausią kelionę;*/

            double degaluSunaudojimas = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"Kiek degalų sunaudoja automobilis 100 kilometrų: {degaluSunaudojimas} litro.");

            int[] nuvaziuotiKilometrai = { 20, 45, 120, 88, 37, 12, 79, 76, 20, 23, 44, 48, 154, 139, 114, 100 };
            Console.WriteLine($"Trumpiausia kelionė buvo: {nuvaziuotiKilometrai.Min()}");

            // ilgiausią kelionę;

            Console.WriteLine($"Ilgiausia kelionė buvo: {nuvaziuotiKilometrai.Max()}");

            // kiek kuro sąnaudų sunaudojo automobilis (skaičiavimui reikės rasti visus  nuvažiuotus km).

            int suma = nuvaziuotiKilometrai.Sum();
           
            Console.WriteLine($"Kiek kuro sunaudojo automobilis iš viso: {(suma * degaluSunaudojimas) / 100}"); 
        }
    }
}
