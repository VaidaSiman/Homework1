using System;

namespace uzduotis19
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            /*
             * Parašyti For ciklą, kuris suskaičiuotų, 
             * kiek skaičių intervale [0 – 1000) dalinasi iš 16.
             */
           
            for (int i = 0; i < 1001; i++)
            {
                if (i % 16 == 0)
                Console.WriteLine(i);
            }
            Console.WriteLine();
            /*
             * Liepkite vartotojui įvesti teigiamą skaičių.
             * While ciklo viduje skaičių kelkite vis
             * didesniu laipsniu ir jį išveskite į ekraną, 
             * kol skaičius netaps didesnis už 1500.
             */

            Console.Write("Įveskite teigiamą skaičių: ");
            int skaicius = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            int laipsnis = 1;
            int atsakymas = Convert.ToInt32(Math.Pow(skaicius, 1));
           

            while (Math.Pow(atsakymas, laipsnis) < 1501 && Math.Pow(atsakymas, laipsnis) > 0)
            {
                Console.WriteLine(Math.Pow(atsakymas,laipsnis));
                laipsnis++; 
            } 
         }
    }
}
