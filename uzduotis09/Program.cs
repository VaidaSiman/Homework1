using System;


namespace uzduotis09
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            /*
             * Liepkite vartotojui įvesti savo amžių. 
             * Jei amžius yra 18 arba daugiau, tuomet į ekraną išveskite, kad “jūs galite balsuoti;
             */

            Console.Write("Įveskite savo amžių: ");
            string ivedimas = Console.ReadLine();
            int amzius = Convert.ToInt32(ivedimas);
            Console.WriteLine();

            if (amzius >= 18)
            {
                Console.WriteLine("Jūs galite balsuoti");
            } 

            /*
             * Liepkite vartotojui įvesti bet kokį skaičių. Parašykite šias atskiras if sąlygas:
             * Patikrinti, ar skaičius neigiamas, jei taip - aprėkti vartotoją :)
             * Patikrinti, ar skaičius teigiamas, jei taip - pasveikinti vartotoją;
             * Patikrinti, ar skaičius lyginis, jei taip - išvesti “taip, skaičius yra lyginis”;
             * Patikrinti, ar skaičius dalinasi iš 4, jei taip - išvesti “taip, dalinasi iš 4”;
             * Patikrinti, ar skaičius yra didesnis nei 10, jei taip - išvesti “taip, skaičius yra didesnis už 10”.
             */

            Console.Write("Įveskite bet kokį skaičių: ");
            string ivedimas1 = Console.ReadLine();
            int skaicius = Convert.ToInt32(ivedimas1);
            Console.WriteLine();

            Console.WriteLine($"Įvestas skaičius: {skaicius}");

            if (skaicius < 0 )
            {
                Console.WriteLine("KODEL AAAAA!!!");
            }

            if (skaicius >=0)
            {
                Console.WriteLine("Sveikinu, Jūs įvedėte teigiamą skaičių");
            }
            
            if (skaicius % 2 == 0 )
            {
                Console.WriteLine("Skaičius yra lyginis");
            }

            if (skaicius % 4 == 0)
            {
                Console.WriteLine("Skaičius dalinasi iš 4");
            } 

            if (skaicius >10)
            {
                Console.WriteLine("Taip, skaičius yra didesnis už 10");
            }
            Console.WriteLine();

            /*
             * Liepkite vartotojui įvesti du savo pažymius, 
             * raskite šių pažymių vidurkį, patikrinkite, 
             * ar vidurkis yra lygus arba didesnis už 5, jei taip, išveskite “Valio!!!”.
             */

            Console.Write("Įveskite savo pirmąjį pažymį: ");
            string ivedimas2 = Console.ReadLine();
            int pazymis = Convert.ToInt32(ivedimas2);
            Console.WriteLine();

            Console.Write("Įveskite savo antrąjį pažymį: ");
            string ivedimas3 = Console.ReadLine();
            int pazymis2 = Convert.ToInt32(ivedimas3);
            Console.WriteLine();

            double vidurkis = (double)(pazymis + pazymis2) / 2;
            Console.WriteLine($"Jūsų pažymių vidurkis yra {vidurkis}");
            Console.WriteLine();

            if (vidurkis >= 5)
            {
                Console.WriteLine("Valio!!!");
            }
        }
    }
}
