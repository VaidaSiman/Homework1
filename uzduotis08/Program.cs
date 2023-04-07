using System;

namespace uzduotis08
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            /*
             * Liepkite vartotojui įvesti bet kokį sveikąjį skaičių. 
             * Išveskite šio skaičiaus daugybos lentelę nuo 1 iki 5. 
             * Pvz. 2 * 1 = 2
             */

             Console.Write("Įveskite sveikąjį skaičių: ");
             string pasirinkimas = Console.ReadLine();
             int sveikasisskaicius = Convert.ToInt32 (pasirinkimas);
             int daugiklis = 1;

             Console.WriteLine("{0} * {1} = {2}", sveikasisskaicius, daugiklis, (sveikasisskaicius * daugiklis));
             Console.WriteLine("{0} * {1} = {2}", sveikasisskaicius, ++daugiklis, (sveikasisskaicius * daugiklis));
             Console.WriteLine("{0} * {1} = {2}", sveikasisskaicius, ++daugiklis, (sveikasisskaicius * daugiklis));
             Console.WriteLine("{0} * {1} = {2}", sveikasisskaicius, ++daugiklis, (sveikasisskaicius * daugiklis));
             Console.WriteLine("{0} * {1} = {2}", sveikasisskaicius, ++daugiklis, (sveikasisskaicius * daugiklis));
             Console.WriteLine(); 


            /*
             * Liepkite vartotojui įvesti tris skaičius. 
             * Į ekraną išveskite šiuos skaičius ir jų vidurkį. 
             * Pvz.:Įvestų skaičių 4, 5, 8 vidurkis: 5,7.
             */

            Console.Write("Įveskite pirmąjį skaičių ");
            string ivedimas = Console.ReadLine();
            int pirmasSkaicius =Convert.ToInt32(ivedimas);
            Console.WriteLine(); 

            Console.Write("Įveskite antrąjį skaičių ");
            string ivedimas2 = Console.ReadLine();
            int antrasSkaicius = Convert.ToInt32(ivedimas2);
            Console.WriteLine();

            Console.Write("Įveskite trečiąjį skaičių ");
            string ivedimas3 = Console.ReadLine();
            int treciasSkaicius = Convert.ToInt32(ivedimas3);
            Console.WriteLine();

            double vidurkis = (double) (pirmasSkaicius + antrasSkaicius + treciasSkaicius) /3;

            Console.WriteLine($"Skaičių vidurkis: {pirmasSkaicius} + {antrasSkaicius} + {treciasSkaicius} / 3 = {vidurkis}");
            Console.WriteLine(); 

            /*
             * Liepkite įvesti tris skaičius. 
             * Išveskite įvestus skaičius, jų kvadratus, juos pakeltus trečiuoju laipsniu, 
             * taip pat tuos skaičius, padalintus iš dviejų.
             */

            Console.Write("Įveskite pirmąjį skaičių ");
            string pasirinkimas1 = Console.ReadLine();
            double skaicius1 = Convert.ToDouble(pasirinkimas1);
            Console.WriteLine();

            Console.Write("Įveskite antrąjį skaičių ");
            string pasirinkimas2 = Console.ReadLine();
            double skaicius2 = Convert.ToDouble(pasirinkimas2);
            Console.WriteLine();

            Console.Write("Įveskite trečiąjį skaičių ");
            string pasirinkimas3 = Console.ReadLine();
            double skaicius3 = Convert.ToDouble(pasirinkimas3);
            Console.WriteLine();

            Console.WriteLine($"Jūsų įvestas pirmas skaičius yra {skaicius1}, pakeltas kvadratu: {Math.Pow(skaicius1, 2)}, pakeltas trečiuoju laipsniu: {Math.Pow(skaicius1, 3)}");
            Console.WriteLine($"{skaicius1} / 2 = {skaicius1 / 2}");

            Console.WriteLine($"Jūsų įvestas pirmas skaičius yra {skaicius2}, pakeltas kvadratu: {Math.Pow(skaicius2, 2)}, pakeltas trečiuoju laipsniu: {Math.Pow(skaicius2, 3)}");
            Console.WriteLine($"{skaicius2} / 2 = {skaicius2 / 2}");

            Console.WriteLine($"Jūsų įvestas pirmas skaičius yra {skaicius3}, pakeltas kvadratu: {Math.Pow(skaicius3, 2)}, pakeltas trečiuoju laipsniu: {Math.Pow(skaicius3, 3)}");
            Console.WriteLine($"{skaicius3} / 2 = {skaicius3 / 2}");
        }
    }
}
