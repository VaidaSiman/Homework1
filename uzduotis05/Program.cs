using System;


namespace uzduotis05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Lietuviškos raidės
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            //Išveskite į ekraną dviejų skaičių sumą, skirtumą, sandaugą ir dalmenį, kiekvieną kartą nurodant atliekamą veiksmą ir šių skaičių reikšmes. 

            float skaicius1 = 5.0f;
            int skaicius2 = 6;
            int skaicius3 = 3;
         
            Console.WriteLine("{0}+{1} = {2}" , skaicius1, skaicius2, skaicius1 + skaicius2);
            Console.WriteLine("{0} - {1} = {2}", skaicius1, skaicius2, skaicius1 - skaicius2);
            Console.WriteLine("{0} * {1} = {2}", skaicius1, skaicius2, skaicius1 * skaicius2);
            Console.WriteLine("{0} / {1} = {2}", skaicius1, skaicius2, skaicius1 / skaicius2);
            Console.WriteLine();

            //Išveskite į ekraną pasirinktą skaičių, jo kvadratą ir jį pakeltą trečiuoju laipsniu.

            Console.WriteLine(skaicius1);
            Console.WriteLine(Math.Pow(skaicius1,2)); //kėlimas kvadratu
            Console.WriteLine(Math.Pow(skaicius1, 3)); //kėlimas kubu
            Console.WriteLine();
            //Išveskite į ekraną trijų skaičių sandaugą.
            Console.WriteLine(skaicius1 * skaicius2 * skaicius3);
        }
    }
}
