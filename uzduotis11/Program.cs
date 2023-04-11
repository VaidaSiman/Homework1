using System;


namespace uzduotis11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            /*
             * Liepkite vartotojui įvesti tris skaičius, parašyti šią patikrinimo sąlygą, naudojant else if dalis:
             * ar pirmas skaičius didesnis už antrą;
             * ar antras skaičius didesnis už trečią;
             * ar trečias skaičius didesnis už pirmą;
             * ar pirmi du skaičiai lygūs;
             */

            Console.Write("Įveskite pirmąjį skaičių: ");
            string ivedimas = Console.ReadLine();
            int pirmasSkaicius = Convert.ToInt32(ivedimas);
            Console.WriteLine();

            Console.Write("Įveskite antąjį skaičių: ");
            string ivedimas1 = Console.ReadLine();
            int antrasSkaicius = Convert.ToInt32(ivedimas1);
            Console.WriteLine();

            Console.Write("Įveskite trečiąjį skaičių: ");
            string ivedimas2 = Console.ReadLine();
            int treciasSkaicius = Convert.ToInt32(ivedimas2);
            Console.WriteLine();

            Console.WriteLine($"Jūsų įvesti skaičiai yra {pirmasSkaicius}, {antrasSkaicius}, {treciasSkaicius}");
            Console.WriteLine();

            if (pirmasSkaicius > antrasSkaicius)
            {
                Console.WriteLine("Pirmasis skaičius yra didesnis už antrąjį");
            }

            else if (antrasSkaicius > treciasSkaicius)
            {
                Console.WriteLine("Antrasis skaičius yra didesnis už trečiąjį");
            }

            else if (treciasSkaicius > pirmasSkaicius)
            {
                Console.WriteLine("Trečiasis skaičius yra didesnis už pirmąjį");
            }

            else if (pirmasSkaicius == antrasSkaicius)
            {
                Console.WriteLine("Pirmi du skaičiai yra lygūs");
            } 

            /*
             * Liepkite vartotojui įvesti šios dienos oro temperatūrą, atlikite šiuos patikrinimus:
             * ar temperatūra < 0 - išvesti “žiauriai šalta”;
             * ar temperatūra < 10 - išvesti “labai šalta”;
             * ar temperatūra < 20 - išvesti “šalta”;
             * ar temperatūra < 30 - išvesti “normali temperatūra”;
             * ar temperatūra < 40 - išvesti “karšta”;
             * ar temperatūra >= 40 - išvesti “visiškai degina”;
             */

            Console.WriteLine("Įveskite šios dienos oro temperatūrą: ");
            string ivedimas3 = Console.ReadLine();
            int temperatura = Convert.ToInt32(ivedimas3);
            
            if (temperatura < 0)
            {
                Console.WriteLine("Žiauriai šalta!");
            }

            else if (temperatura <10)
            {
                Console.WriteLine("Labai šalta");
            }

            else if (temperatura < 20)
            {
                Console.WriteLine("Šalta");
            }

            else if (temperatura < 30)
            {
                Console.WriteLine("Normali temperatūra");
            }

            else if (temperatura < 40)
            {
                Console.WriteLine("Karšta");
            }

            else if (temperatura >= 40)
            {
                Console.WriteLine("Visiškai degina");
            }
        }
    }
}
