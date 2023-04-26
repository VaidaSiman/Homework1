using System;


namespace uzduotis12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            /*
             * Liepkite įvesti tris skirtingus skaičius. 
             * Suraskite, kuris iš šių skaičių yra didžiausias.
             */
            
            Console.Write("Įveskite pirmąjį skaičių: ");
            string ivedimas = Console.ReadLine();
            int skaicius1 = Convert.ToInt32(ivedimas);

            Console.Write("Įveskite pirmąjį skaičių: ");
            string ivedimas2 = Console.ReadLine();
            int skaicius2 = Convert.ToInt32(ivedimas2);

            Console.Write("Įveskite pirmąjį skaičių: ");
            string ivedimas3 = Console.ReadLine();
            int skaicius3 = Convert.ToInt32(ivedimas3);
            Console.WriteLine();

            if (skaicius1 > skaicius2 && skaicius1 > skaicius3)
            {
                Console.WriteLine($"Skaičius {skaicius1} yra didžiausias");
            }

            if (skaicius2 > skaicius1 && skaicius2 > skaicius3)
            {
                Console.WriteLine($"Skaičius {skaicius2} yra didžiausias");
            }
               
            if (skaicius3 > skaicius1 && skaicius3 > skaicius2)
            {
                Console.WriteLine($"Skaičius {skaicius3} yra didžiausias");
            } 
           
            else
            {
                Console.WriteLine($"Visi skaičiai yra vienodi");
            } 
            /*
             * Liepkite įvesti egzamino rezultatą. Atlikite šiuos patikrinimus:
             * ar gautas rezultatas yra [8-10];
             * ar gautas rezultatas yra [5-8);
             * ar gautas rezultatas yra < 5.
             */
            
            Console.Write("Įveskite egzamino rezultatą: ");
            string pasirinkimas = Console.ReadLine();
            int rezultatas = Convert.ToInt32(pasirinkimas);

            if (rezultatas >= 8 && rezultatas <=10)
            {
                Console.WriteLine("Jūsų egzamino rezultatas patenka tarp [8-10}");
            }

            if(rezultatas >= 5 && rezultatas <8)
            {
                Console.WriteLine("Jūsų egzamino rezultatas patenka tarp [5-7]");
            }

            if (rezultatas < 5 && rezultatas >= 1)
            {
                Console.WriteLine("Jūsų egzamino rezultatas patenka tarp [1 - 5]"); 
            }

            /*
             * Liepkite įvesti du skaičius. 
             * Patikrinkite (naudojant 4 atskirus if’us):
             * ar pirmas skaičius yra didesnis už antrąjį, arba yra lygus 0;
             * ar antras skaičius yra didesnis už pirmąjį, arba yra lygus 5;
             * ar pirmas skaičius yra didesnis už antrąjį ir yra lygus 20;
             * ar antras skaičius yra didesnis už pirmąjį ir yra mažesnis už 100.
             */
            Console.Write("Įveskite pirmąjį skaičių: ");
            string ivestis = Console.ReadLine();
            int pirmasSkaicius = Convert.ToInt32(ivestis);
            Console.WriteLine();

            Console.Write("Įveskite pirmąjį skaičių: ");
            string ivestis2 = Console.ReadLine();
            int antrasSkaicius = Convert.ToInt32(ivestis2);
            Console.WriteLine();

            if (pirmasSkaicius > antrasSkaicius || pirmasSkaicius == 0)
            {
                Console.WriteLine("Pirnmas skaičius yra didesnis už antrąjį arba lygus nuliui");
            }

            if (antrasSkaicius > pirmasSkaicius && antrasSkaicius == 5)
            {
                Console.WriteLine("Antras skaičius yra didesnis už pirmąjį arba lygus 5");
            }

            if (pirmasSkaicius > antrasSkaicius && pirmasSkaicius == 20 )
            {
                Console.WriteLine("Pirmas skaičius yra didesnis už antrąjį ir lygus 20");
            }

            if (antrasSkaicius > pirmasSkaicius && antrasSkaicius < 100)
            {
                Console.WriteLine("Antras skaičius yra didesnis už pirmąjį ir mažesnis už 100");
            }
        }
    }
}
