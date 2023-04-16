using System;

namespace uzduotis20
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            /*
             * Įveskite iš konsolės 2 skaičius (stataus trikampio statinių ilgius).
             * Suraskite įžambinę ir ją išveskite į ekraną.
             * Tip: Pitagoro teorema teigia, jog stataus trikampio statinių kvadratų suma yra
             * lygi įžambinės kvadratui.
             * 
             * Jau žinome, jog Math.Pow(skaicius, laipsnis) – kintamąjį skaičius pakelia laipsniu.
             * Jei norime ištraukti kvadratinę šaknį, reiktų kelti 0.5 laipsniu.
             * Arba naudoti šaknies funkciją Math.Sqrt(z)
             */

            Console.Write("Įveskite trikampio statinės a ilgį: ");
            double skaicius = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine();

            Console.Write("Įveskite trikampio statinės b ilgį: ");
            double skaicius2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine();

            double izambine = Math.Sqrt(Math.Pow(skaicius, 2) + Math.Pow(skaicius2, 2));

            Console.WriteLine($"{izambine}");
            Console.WriteLine();
        }
    }
}
