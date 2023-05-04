using System;

namespace uzduotis35
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            /*
             * Sukurti void tipo metodą, kuriam paduosim masyvą.
             * Metodas turi išvesti masyvo sumą 
             * (sumai skaičiuoti naudoti for ciklą ir 
             *  .Sum()  funkciją. 
             *  
             *  Tuomet metodas išves į konsolę
             *  
             *  2 tokias pačias sumas suskaičiuotas  skirtingais būdais)
             *  Išsikviesti metodą. */
            int[] skaiciai = {20, 4, 2, 4, 5, 10};

            SkaiciuotiSuma(skaiciai);
        }

        private static void SkaiciuotiSuma(int[] skaiciai)
        {
            int suma = 0;

            for (int i = 0; i < skaiciai.Length; i++)
            {
                suma += skaiciai[i];
            }

            int sumaMasyvo = skaiciai.Sum();

            Console.WriteLine(suma);
            Console.WriteLine(sumaMasyvo);
        }
    }
}
