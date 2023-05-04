using System;

namespace uzduotis34
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            /*
             * Įvesti du skaičius iš konsolės
             * Paklausti vartotojo kokį veiksmą 
             * su tais skaičiais nori atlikti: Daugybą ar  dalyba
             * 
             * Parašyti po atskirą metodą kiekvienam veiksmui
             * (daugybai naudoti int tipą, o  dalybai double)
             * 
             * Su if patikrinti kokį veiksmą atlikti 
             * ir išsikviesti atitinkamą metodą,
             * jei tokio  veiksmo nėra –
             *  – informuoti vartotoją, jog tokio veiksmo nėra.
             */

            Console.WriteLine("Įveskite pirmąjį skaičių: ");
            int skaiciusPirmas = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Įveskite antrąjį skaičių: ");
            int skaiciusAntras = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("Kokį veiksmą norite atlikti: ");
            Console.WriteLine("1 - skaičių daugybą;");
            Console.WriteLine("2 - skaičių dalyba;");
            int pasirinkimas = Convert.ToInt32(Console.ReadLine()); 
            Console.WriteLine($"Jūsų pasirinkimas: {pasirinkimas}");
            Console.WriteLine();

            Daugyba(skaiciusPirmas, skaiciusAntras);
            Dalyba(skaiciusPirmas, skaiciusAntras);

            if (pasirinkimas == 1)
            {
                Console.WriteLine(Daugyba(skaiciusPirmas, skaiciusAntras));
            }

            if (pasirinkimas == 2)
            {
                Console.WriteLine(Dalyba(skaiciusPirmas, skaiciusAntras));
            }

            else
            {
                Console.WriteLine("TOKIO PASIRINKIMO NĖRA!");
            }
        }

        private static double Dalyba(int skaiciusPirmas, int skaiciusAntras)
        {
            return (double)skaiciusPirmas / skaiciusAntras;
        }

        private static int Daugyba(int skaiciusPirmas, int skaiciusAntras)
        {
            return skaiciusPirmas * skaiciusAntras;
        }
    }
}
