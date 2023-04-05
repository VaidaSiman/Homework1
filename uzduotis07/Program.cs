using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace uzduotis07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;


            /*
             * Liepkite vartotojui įvesti savo vardą ir amžių. 
             * Į ekraną išveskite: “Jūsų vardas {vardas}, o amžius {amžius}.
             */

             Console.Write("Jūsų vardas: ");
             string vardas = Console.ReadLine();
             Console.Write("Jūsų amžius: ");
             int amzius = Convert.ToInt32(Console.ReadLine());
             Console.WriteLine ($"Jūsų vardas {vardas}, o amžius  {amzius}");
             Console.WriteLine();

            /*
             * Liepkite vartotojui įvesti bet kokį simbolį. 
             * Atspausdinkite 3x3 kvadratą iš to simbolio.
             */

             Console.Write("Įveskite, bet kokį simbolį ");
             int simbolisASCII = Console.Read();
             Console.ReadLine();
             char simbolisKaipCharacter = Convert.ToChar(simbolisASCII);
             string simbolisKaipString = Convert.ToString(simbolisASCII);

             char c = simbolisKaipCharacter;
             string s = simbolisKaipString;

             Console.WriteLine($"{c}{c}{c}");
             Console.WriteLine($"{c}{c}{c}");
             Console.WriteLine($"{c}{c}{c}");
             Console.WriteLine();

             Console.WriteLine(s);
             Console.WriteLine();
             Console.WriteLine(s + s + s);
             Console.WriteLine(s + s + s);
             Console.WriteLine(s + s + s); 
             Console.WriteLine(); 

            /*
             * Liepkite vartotojui įvesti bet kokį skaičių. 
             * Išveskite į ekraną šio skaičiaus kvadratą.
             */

            Console.Write("Įveskite, bet kokį skaičių: ");
            string ivedimas = Console.ReadLine();
            int skaicius = Convert.ToInt32 (ivedimas);
            Console.WriteLine(Math.Pow(skaicius, 2)); 


            /*
             * Liepkite vartotojui įvesti tris skaičius. 
             * Išveskite visų šių skaičių sumą, skirtumą, sandaugą ir dalmenį, nurodant atliekamus veiksmus ir šių skaičių reikšmes ekrane. 
             * Pvz.: 5 + 3 + 8 = 16 
             */

            Console.WriteLine("Įveskite pirmąjį skaičių: ");
            string pirmasSkaicius = Console.ReadLine();
            int s1 = Convert.ToInt32(pirmasSkaicius);

            Console.WriteLine("Įveskite antrąjį skaičių: ");
            string antrasSkaicius = Console.ReadLine();
            int s2 = Convert.ToInt32(antrasSkaicius);

            Console.WriteLine("Įveskite trečiąjį skaičių: ");
            string treciasSkaicius = Console.ReadLine();
            int s3 = Convert.ToInt32(treciasSkaicius);


            Console.WriteLine($"Skaičių suma: {s1} + {s2} + {s3} = {s1 + s2 + s3}");
            Console.WriteLine($"Skaičių suma: {s1} - {s2} - {s3} = {s1 - s2 - s3}");
            Console.WriteLine($"Skaičių suma: {s1} * {s2} * {s3} = {s1 * s2 * s3}");

            double s4 = Convert.ToDouble(s3);
            Console.WriteLine($"Skaičių suma: {s1} / {s2} / {s3} = {s1 / s2 / s4}");
        }
    }
}
