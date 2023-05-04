using System;

namespace uzduotis33
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            /*
             * Įvesti du skaičius iš konsolės
             * Paklausti vartotojo kokį veiksmą su tais skaičiais nori atlikti:
             * sudėtis, atimtis,  kėlimas 4 laipsniu
             * sudėjus abu skaičius, kvadratinė šaknis sudėjus abu skaičius.
             * Parašyti po atskirą metodą kiekvienam veiksmui
             * (sudėčiai ir atimčiai naudoti  int tipą,
             *  o visiems kitiems double).
             * Su switch() patikrinti kokį veiksmą atlikti 
             * ir kiekviename case‘e išsikviesti  atitinkamą metodą,
             * jei tokio case‘o nėra – informuoti vartotoją, 
             * jog tokio  veiksmo nėra */

            Console.WriteLine("Įveskite pirmąjį skaičių: ");
            int skaiciusPirmas = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Įveskite antrąjį skaičių: ");
            int skaiciusAntras = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("Kokį veiksmą norite atlikti:");
            Console.WriteLine("1 - sudėti du skaičius;");
            Console.WriteLine("2 - skaičių atimtis;");
            Console.WriteLine("3 - skaičius sudėti ir pakelti 4 laipsniu;");
            Console.WriteLine("4 - skaičius sudėti ir ištraukti šaknį");
            int pasirinkimas = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Jūsų pasirinkimas: {pasirinkimas}.");

            switch (pasirinkimas)
            {
                case 1:
                    Console.WriteLine($"{skaiciusPirmas} + {skaiciusAntras} = {Suma(skaiciusPirmas, skaiciusAntras)}");
                    break;
                case 2:
                    Console.WriteLine($"{skaiciusPirmas} - {skaiciusAntras} = {Atimtis(skaiciusPirmas, skaiciusAntras)}");
                    break;
                case 3:
                    Console.WriteLine($"Skaičių sumos 4 laispnis lygus {KelimasKetvirtuojuLaipsniu(skaiciusPirmas, skaiciusAntras)}");
                    break;
                case 4:
                    Console.WriteLine($"Skaičių sumos kvadratinė šaknis: {KvadratineSaknis(skaiciusPirmas, skaiciusAntras)}");
                    break;
                default:
                    Console.WriteLine("Tokio pasirinkimo nėra.");
                    break;
            }
        }

        private static double KvadratineSaknis(int skaiciusPirmas, int skaiciusAntras)
        {
            return Math.Sqrt(Suma(skaiciusPirmas, skaiciusAntras));
        }

        private static double KelimasKetvirtuojuLaipsniu(int skaiciusPirmas, int skaiciusAntras)
        {
            return Math.Pow(Suma(skaiciusPirmas, skaiciusAntras),4);
        }

        private static int Atimtis(int skaiciusPirmas, int skaiciusAntras)
        {
            return skaiciusPirmas - skaiciusAntras;
        }

        private static int Suma(int skaiciusPirmas, int skaiciusAntras)
        {
            return skaiciusPirmas + skaiciusAntras;
        }
    }
}
