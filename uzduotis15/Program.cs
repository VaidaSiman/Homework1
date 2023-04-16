using System;


namespace uzduotis15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            /*
             * Parašyti for, kuris išvestų kiekvieną skaičių pradedant nuo 0 ir baigiant 10. 
             * Kiekvieną skaičių išvesti skirtingoje eilutėje.
             */
            
            for (int i = 0; i < 11;  i++)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine();
            /*Parašyti for, kuris išvestų kas antrą skaičių pradedant 0 ir baigiant 15.
             * Kiekvieną skaičių išvesti toje pačioje eilutėje,
             * po kiekvieno skaičiaus dedant tarpą.
             */

            for (int i = 0; i < 16;  i += 2)
            {
                Console.Write($"{i} ");
            }
            Console.WriteLine();
          

            /* Parašyti for, kuris išvestų kas trečią skaičių, pradedant 1 ir baigiant 20.
             * Kiekvieną skaičių išvesti toje pačioje eilutėje, tačiau parašant skaičių 
             * laužtiniuose skliaustuose. Pvz.: [1][4][7]...
             */
            
            for (int i = 1; i < 21; i += 3)
            {
                Console.Write($"[{i}] ");
            }
            Console.WriteLine();

            /* 
             * Parašyti for, kuris eitų pro kiekvieną skaičių nuo 1 iki 10.
             * jame apsirašyti if sąlygą, kuri patikrintų,
             * ar dabartinis skaičius yra lyginis, jei taip – tai šį skaičių išvesti.
             */

            for (int i = 1; i < 11; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine($"{i}");
                }
            }
         }
     }
}
