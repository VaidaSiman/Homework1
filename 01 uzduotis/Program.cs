using System;


namespace _01_uzduotis
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Parašykite programą, kuri išvestų žodį “Labas” ir jūsų vardą toje pačioje eilutėje.

            Console.WriteLine("Labas Vaida");
            Console.WriteLine();

            /* Susikurkite kintamąjį žmogaus amžiui nusakyti, išveskite į ekraną tekstą su
          šiuo amžiumi: “Įvestas amžius: { amžius}”. Tarp { }
          nurodytas kintamasis, kurio reikšmė toje vietoje turi būti įstatyta. */

            int amzius = 30; 
            Console.WriteLine("Įvestas amžius: " + amzius);
            Console.WriteLine();

            //Susikurkite skaičiaus kintamąjį, kurį išveskite penkis kartus toje pačioje eilutėje be tarpų tarp šių skaičių (skaičius - 25, išvedimas - 2525252525).

            int skaicius = 25; 
            Console.Write(skaicius);
            Console.Write(skaicius);
            Console.Write(skaicius);
            Console.Write(skaicius);
            Console.Write(skaicius);
            Console.WriteLine();
            Console.WriteLine();

            /* Susikurkite skaičiaus kintamąjį, kurį išveskite penkis kartus toje pačioje
           eilutėje su tarpais tarp šių skaičių(skaičius -25, rezultatas - 25 25 25 25 25). */

            Console.WriteLine(skaicius + " " + skaicius + " " + skaicius + " " + skaicius + " " + skaicius);
            Console.WriteLine();
        }
    }
}
