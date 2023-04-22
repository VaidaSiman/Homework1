using System;

namespace uzduotis24
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            /*Paklausti vartotojo, kiek duomenų nori įvesti į masyvą 
             * Pagal tai sukursime tokio dydžio masyvą
             * Iš konsolės įvesti duomenis į masyvą
             */

            Console.WriteLine($"Kiek duomenų norite įvesti?");
            int kiekDuomenu = Convert.ToInt32( Console.ReadLine());

            int[] skaiciuMasyvas = new int[kiekDuomenu];

            /* 
            * Surasti 2 sumas:
            * Suma1 – kai masyvo elementas yra lyginis skaičius  */

            for ( int i = 0; i < kiekDuomenu; i++ )
            {
                Console.WriteLine($"Įveskite {i + 1} skaičių: ");
                skaiciuMasyvas[i] = Convert.ToInt32( Console.ReadLine() );
         
            }
            
            int sumaLyginis = 0;
            for(int i = 0; i <  skaiciuMasyvas.Length; i++)
            {
                if (skaiciuMasyvas[i] % 2 == 0)
                {
                    sumaLyginis += skaiciuMasyvas[i];
                }
            }
            Console.WriteLine($"Suma, kai masyvo elementas yra lyginis skaičius: {sumaLyginis}");
            Console.WriteLine();

            //Suma2 – kai masyvo indeksas nėra lyginis skaičius

            int sumaNelyginis = 0;
            for (int i = 0; i < skaiciuMasyvas.Length; i++)
            {
                if (i % 2 != 0)
                {
                    sumaNelyginis += skaiciuMasyvas[i];
                }
            }
            Console.WriteLine($"Masyvo suma, kai indeksas nėra lyginis: {sumaNelyginis}");
        }
    }
}
