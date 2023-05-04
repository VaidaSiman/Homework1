using System;

namespace uzduotis13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            /*
             * Liepkite vartotojui įvesti tris skaičius. 
             * Su switch patikrinkite pirmąjį skaičių:
             * ar jis lygus 1: išveskite visų trijų skaičių sumą;
             * ar jis lygus 2: išveskite pirmo ir trečio skaičių skirtumą;
             * ar jis lygus 3: išveskite antro ir trečio skaičių sandaugą.
             */
            
            Console.Write("Įveskite pirmąjį skaičių: ");
            string ivedimas = Console.ReadLine();
            double skaicius = Convert.ToDouble(ivedimas);
            Console.WriteLine();

            Console.Write("Įveskite pirmąjį skaičių: ");
            string ivedimas1 = Console.ReadLine();
            double skaicius2 = Convert.ToDouble(ivedimas1);
            Console.WriteLine();

            Console.Write("Įveskite pirmąjį skaičių: ");
            string ivedimas3 = Console.ReadLine();
            double skaicius3 = Convert.ToDouble(ivedimas3);
            Console.WriteLine();

            switch (skaicius)
            {
                case 1:
                    Console.WriteLine($"{skaicius} + {skaicius2} + {skaicius3} = {skaicius + skaicius2 + skaicius3}");
                    break; 

                case 2:
                    Console.WriteLine($"{skaicius} - {skaicius3} = {skaicius - skaicius3}");
                    break;

                case 3:
                    Console.WriteLine($"{skaicius2} * {skaicius3} = {skaicius2 * skaicius3}");
                    break; 
            }
            Console.WriteLine(); 
            /*
             * Liepkite vartotojui įvesti gyvūno rūšį. 
             * Su switch patikrinkite:
             * ar įvestas gyvūnas yra šuo;
             * ar įvestas gyvūnas yra katė;
             * ar įvestas gyvūnas yra žiurkėnas.
             */

            Console.WriteLine("Įveskite gyvūno rūšį: ");
            string rusis = Console.ReadLine();
            Console.WriteLine();

            switch (rusis)
            {
                case "suo":
                    Console.WriteLine("Įvestas gyvūnas yra šuo.");
                    break;

                case "kate":
                    Console.WriteLine("Įvestas gyvūnas yra katė.");
                    break;

                case "ziurkenas":
                    Console.WriteLine("Įvestas gyvūnas yra žiurkėnas.");
                    break;
                default:
                    Console.WriteLine("Toks gyvūnas nerastas.");
                    break; 
            }
        }
    }
}
