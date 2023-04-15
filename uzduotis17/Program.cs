using System;


namespace uzduotis17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            /*
             * Liepkite vartotojui įvesti teigiamą skaičių.
             * Ciklo pagalba šį skaičių išvesti mažėjimo tvarka iki kol jis pasieks 0.
             * Pvz.: 5 4 3 2 1. Kiekvieną kartą išvesti skirtingose eilutėse.
             */
   
            Console.Write("Įveskite teigiamą skaičių: ");
            string ivedimas = Console.ReadLine();
            int skaicius = Convert.ToInt32(ivedimas);
            Console.WriteLine();

            while (skaicius > 0)
            {
                Console.WriteLine(skaicius);
                skaicius--;
            }
            Console.WriteLine();
  
            /*
             * Liepkite vartotojui įvesti neigiamą skaičių. 
             * Ciklo pagalba šį skaičių išvesti didėjimo tvarka iki kol jis pasieks 0.
             * taip pat išvesti 0. Pvz.: -4 -3 -2 -1 0.
             * Kiekvieną kartą išvesti toje pačioje eilutėje, skaičius atskiriant tarpais.
             */

            Console.Write("Įveskite neigiamą skaičių: ");
            string ivedimas1 = Console.ReadLine();
            int negatyvusSk = Convert.ToInt32(ivedimas1);
            Console.WriteLine();

            while (negatyvusSk <= 0)
            {
                Console.Write($"{negatyvusSk} ");
                negatyvusSk++;
            }
            Console.WriteLine();

            /*
             * Padarykite skaičiuotuvą
             *  Kiekvieno ciklo iteracijos metu vartotojas turi suvesti du skaičius.
             *  Iš šių skaičių turi būti grąžinami visi sudėties,
             *  skirtumo, sandaugos ir dalmens atsakymai, išvedant kartu ir atliekamus veiksmus. 
             *   Pvz.:
             *   5 + 4 = 9
             *   5 - 4 = 1
             *   Programa vykdoma tol, kol vartotojas nori atlikinėti skaičiavimus.
             */

            Console.Write("Įveskite pirmąjį skaičių: ");
            string ivedimas2 = Console.ReadLine();
            double pirmasisSkaicius = Convert.ToDouble(ivedimas2);
            Console.WriteLine();

            Console.Write("Įveskite antrąjį skaičių: ");
            string ivedimas3 = Console.ReadLine();
            double antrasisSkaicius = Convert.ToDouble(ivedimas3);
            Console.WriteLine();

            while (pirmasisSkaicius > 0 && antrasisSkaicius > 0)
            {
                Console.WriteLine($"{pirmasisSkaicius} + {antrasisSkaicius} = {pirmasisSkaicius + antrasisSkaicius}");
                Console.WriteLine($"{pirmasisSkaicius} - {antrasisSkaicius} = {pirmasisSkaicius - antrasisSkaicius}");
                Console.WriteLine($"{pirmasisSkaicius} * {antrasisSkaicius} = {pirmasisSkaicius * antrasisSkaicius}");
                Console.WriteLine($"{pirmasisSkaicius} / {antrasisSkaicius} = {pirmasisSkaicius / antrasisSkaicius}");
                pirmasisSkaicius++;
                antrasisSkaicius++;
            }
            Console.WriteLine();
        }
    }
}
