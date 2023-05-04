using System;

namespace uzduotis25
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            /*Liepti vartotojui įvesti 5 pažymius 
             * VIENOJE eilutėje atskiriant tarpu. 
             * Rasti  didžiausią pažymį.
             * */

            Console.Write($"Įveskite penkis pažymius atskiriant juos tarpu: " );
            string pazymys = Console.ReadLine();
            string[] suskaidytasPazymys = pazymys.Split(' ');
            Console.WriteLine();

            int[] skaiciai = new int[suskaidytasPazymys.Length];
            for (int i = 0; i < suskaidytasPazymys.Length; i++)
            {
                skaiciai[i] = Convert.ToInt32(suskaidytasPazymys[i]);
            }

            Console.WriteLine($"Didžiausias pažymys: {skaiciai.Max()}");

            /*
             * Liepti vartotojui įvesti 5 pažymius 
             * VIENOJE eilutėje atskiriant kableliu
             * Rasti mažiausią pažymį.
             */
            
            Console.Write($"Įveskite penkis skaičius ir atskirkite juos kableliu: ");
            string ivedimasPazymiai = Console.ReadLine();
            string[] suskaidytasPazymiuIvedimas = ivedimasPazymiai.Split(',');
            Console.WriteLine();

            int[] pazymiai = new int[suskaidytasPazymiuIvedimas.Length];
            for(int i = 0; i < suskaidytasPazymiuIvedimas.Length; i++)
            {
                pazymiai[i] = Convert.ToInt32(suskaidytasPazymiuIvedimas[i]);
            }

            Console.WriteLine($"Mažiausias pažymys: {pazymiai.Min()}");
        }
    }
}
