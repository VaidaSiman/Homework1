using System;

namespace uzduotis22
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            /*
             * Papildyti praeitos užduoties kodą. 
             * Išvesti narių skaičių, pirmą narį ir paskutinį  
             * narį bent iš vieno pasirinkto masyvo.
             */
            
            int[] pazymiai = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            Console.WriteLine($"Pirma reikšmė: {0}", pazymiai[0]);
            Console.WriteLine($"Paskutinė reikšmė: {pazymiai.Length}", pazymiai.Length - 1);

           /*
            string[] automobiliuMarke = new string[5];

            automobiliuMarke[0] = "audi";
            automobiliuMarke[1] = "mazda";
            automobiliuMarke[2] = "suzuki";
            automobiliuMarke[3] = "passat";
            automobiliuMarke[4] = "subaru";

            Console.WriteLine($"Pirma reikšmė: {0}", automobiliuMarke[0]);
            Console.WriteLine($"Paskutinė reikšmė: {automobiliuMarke.Length}", automobiliuMarke.Length - 1); 
           */
        }
    }
}
