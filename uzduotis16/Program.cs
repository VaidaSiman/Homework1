using System;

namespace uzduotis16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            /*
             * Raskite visų skaičių nuo 1 iki 100 sumą.
             */
           
            int suma = 0;

            for (int i = 0; i < 101; i++)
            {
                suma += i;
            }
            Console.WriteLine("atsakymas: " + suma);
            Console.WriteLine();
            
            /*Raskite visų lyginių skaičių nuo 20 iki 40 sumą. */
            
            int suma1 = 0;

            for (int i = 20; i < 41; i++)
            {
                suma1 += i;
            }
            Console.WriteLine("atsakymas: " + suma1);
            Console.WriteLine();

            /* Raskite visų nelyginių skaičių nuo 30 iki 60 sumą. */
           
            int suma2 = 0;

            for (int i = 30; i < 61; i++)
            {
                suma2 += i;
            }
            Console.WriteLine("atsakymas: " + suma2);
            Console.WriteLine();

            /*Rasti visų skaičių, žemesnių už 1000 ir didesnių už 0 bei kurie dalinasi iš 3 arba
             * 5, sumą.
             * Pavyzdys:
             * Visi skaičiai mažesni už 10 ir kurie dalinasi iš 3 arba 5 yra: 3, 5, 6, 9.
             * Šių skaičių suma yra 23.
             * Turite gauti 233168 atsakymą.
             */

            int suma3 = 0;

            for (int i = 0; i < 1000; i++)
            {
                if (i % 3 == 0 || i % 5 == 0)
                {
                    suma3 += i;
                }
            }
            Console.WriteLine("atsakymas: " + suma3);
            Console.WriteLine();
        }
     }
}
