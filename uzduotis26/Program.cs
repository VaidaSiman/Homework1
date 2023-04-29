using System;
using System.Collections.Generic;
using System.Linq;

namespace uzduotis26
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            /*
             * Sugeneruokite sąrašą
             * kurį užpildykite atsitiktiniais  skaičiais nuo 1 iki 100. Raskite:
             * mažiausią skaičių;
             * didžiausią skaičių;
             * vidurkį;
             * kiek skaičių yra žemesni už vidurkį;
             * lyginių skaičių sumą; */
           
            List<int> skaiciai = new List<int>();
            Random atsitiktiniaiSkaiciai = new Random();
            int sarasoIlgis = atsitiktiniaiSkaiciai.Next(5, 50); //ne maziua penkios ir ne daugiau 50

            int minSkaicius = 0;
            int maxSkaicius = 0;

            for(int i = 0; i < sarasoIlgis; i++)
            {
                skaiciai.Add(atsitiktiniaiSkaiciai.Next(1, 101));
            }
            
            foreach (int skaicius in skaiciai)
            {
                Console.Write($"{skaicius}");
                if (skaicius < skaiciai.Average())
                {
                    minSkaicius++;
                }
                if (skaicius % 2 == 0)
                {
                    maxSkaicius += skaicius;
                }
            }
            Console.WriteLine();

            Console.WriteLine($"Sąrašo ilgis: {sarasoIlgis}.");
            Console.WriteLine($"Mažiausias skaičius: {skaiciai.Min()}");
            Console.WriteLine($"Didžiausias skaičius: {skaiciai.Max()}");
            Console.WriteLine($"Vidurkis: {skaiciai.Average()}");
            Console.WriteLine($"Kiek skaičių yra žemesni už vidurkį: {minSkaicius}");
            Console.WriteLine($"Lyginių skaičių suma: {maxSkaicius}");
            Console.WriteLine();
            
            /*Liepkite vartotojui pasirinkti kiek studentų pažymių nori suvesti į sąrašą.
             * Tegul jis užpildo šį sąrašą duomenimis, įvedant juos per konsolę. 
             * Raskite:
             * didžiausią pažymį;
             * mažiausią pažymį;
             * vidurkį; */

            Console.WriteLine("Kiek pažymių norite įvesti į sąrašą:  ");
            int pazymiuKiekis = Convert.ToInt32(Console.ReadLine());
 
            List<int> pazymiai = new List<int>();

            for (int i = 0; i < pazymiuKiekis; i++)
            {
                Console.Write($"Įveskite į {i + 1} pažymį: ");
                pazymiai.Add(Convert.ToInt32(Console.ReadLine()));
            }

            Console.WriteLine($"Didžiausias pažymys: {pazymiai.Max()}");
            Console.WriteLine($"Mažiausias pažymys: {pazymiai.Min()}");
            Console.WriteLine($"Pažymių vidurkis: {pazymiai.Average()}");
            Console.WriteLine();
        }
     }
}
