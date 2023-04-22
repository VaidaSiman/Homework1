using System;

namespace uzduotis22
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            /*
             * Susikurkite savaitės temperatūrų rodmenų masyvą. 
             * Raskite:
             * žemiausią temperatūrą;
             * didžiausią temperatūrą;
             * vidurkį;
             * Temperatūrų, esančių žemiau už vidurkį, kiekį;
             * Temperatūrų, esančių aukščiau už vidurkį, kiekį.
             */
            
            int[] savaitesTemperatura = { 10, 11, 15, 8, 14, 19, 25, 17, 5, 7, 16 };
            double vidurkis = savaitesTemperatura.Average(); //ARBA (double)savaitesTemperatura.Sum() / savaitesTemperatura.Length;
            int maziauVidurkio = 0;
            int daugiauVidurkio = 0;

            for (int i = 0; i < savaitesTemperatura.Length; i++)
            {
                if (savaitesTemperatura[i] < vidurkis) maziauVidurkio++;
                if (savaitesTemperatura[i] > vidurkis) daugiauVidurkio++;   
            }
            Console.WriteLine($"Žemiausia temperatūra: {savaitesTemperatura.Min()}");
            Console.WriteLine($"Aukščiausia temperatūra: {savaitesTemperatura.Max()}");
            Console.WriteLine($"{vidurkis}");
            Console.WriteLine($"Temperatūrų, esančių žemiau vidurkio: {maziauVidurkio}");
            Console.WriteLine($"Temperatūros, esančios aukščiau vidurkio: {daugiauVidurkio}");
            Console.WriteLine();
          
            /*
             * Susikurkite studentų pažymių masyvą. Raskite:
             */

            int[] pazymiai = {10, 8, 5, 3, 7, 8, 9, 10, 6, 6, 4, 2, 8, 7, 9, 10};

            //geriausias pažymys: 
            Console.WriteLine($"Geriausias pažymys: {pazymiai.Max()}");
            Console.WriteLine(); 

            // kiek mokinių gavo dešimtukus: 
            int kiekGavoDesimtukus = 0; 

            for(int i = 0; i < pazymiai.Length; i++)
            {
                if (pazymiai[i] == 10) kiekGavoDesimtukus++; 
            }
            Console.WriteLine($"Kiek mokinių gavo dešimtukus: {kiekGavoDesimtukus}");
            Console.WriteLine();

            //kiek mokinių yra gavę neigiamą pažymį (žemiau nei 4);
            int neigiamasPazymys = 0; 

            for( int i = 0; i < pazymiai.Length; i++)
            {
                if (pazymiai[i] < 4) neigiamasPazymys++;
            }
            Console.WriteLine($"Kiek mokinių gavo neigiamą pažymį: {neigiamasPazymys}");
            Console.WriteLine();

            //pažymių vidurkį.
            Console.WriteLine($"Pažymių vidurkis: {(double)pazymiai.Average()}"); 
        }
    }
}
