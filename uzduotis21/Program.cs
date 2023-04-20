using System;

namespace uzduotis21
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            //Susikurti 2 masyvus su duomenimis, išbandant abu kūrimo būdus (iškart 
            //su  duomenimis, arba pirma nusirodant dydį ir tada priskiriant reikšmes),
            // pasibandymui išsivesti norimus duomenis iš visų šių masyvų:
            // skirtą studentų pažymiams saugoti;
            // skirtą mašinų markėms saugoti.

            int[] pazymiai = {1, 2, 3, 4, 5, 6, 7, 8, 9, 10};

            Console.WriteLine(pazymiai[3]);
            Console.WriteLine(pazymiai[6]);
            Console.WriteLine();

            int[] studentuPazymiai = new int [10];

                studentuPazymiai[0] = 1;
                studentuPazymiai[1] = 2;
                studentuPazymiai[2] = 3;
                studentuPazymiai[3] = 4;
                studentuPazymiai[4] = 5;
                studentuPazymiai[5] = 6;
                studentuPazymiai[6] = 7;
                studentuPazymiai[7] = 8;
                studentuPazymiai[8] = 9;
                studentuPazymiai[9] = 10;

            Console.WriteLine(studentuPazymiai[0]);
            Console.WriteLine();

            string[] marke = { "audi", "mazda", "suzuki", "passat", "subaru" };
            Console.WriteLine(marke[0]);
            Console.WriteLine(marke[1]);
            Console.WriteLine(marke[2]);
            Console.WriteLine(marke[3]);
            Console.WriteLine(marke[4]);
            Console.WriteLine();

            string[] automobiliuMarke = new string[5];
          
                automobiliuMarke[0] = "audi";
                automobiliuMarke[1] = "mazda";
                automobiliuMarke[2] = "suzuki";
                automobiliuMarke[3] = "passat";
                automobiliuMarke[4] = "subaru";

            Console.WriteLine(automobiliuMarke[2]);
        }
    }
}
