using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uzduotis05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Lietuviškos raidės
            Console.OutputEncoding = Encoding.UTF8;

            int skaicius = 5;
            int numeris = 6;
            int indeksas = 3;
            int suma = skaicius + numeris;

            Console.WriteLine("{0} + {1} = {2}",skaicius, numeris,suma);
          
            int skirtumas = skaicius - numeris;
            Console.WriteLine("{0} - {1} = {2}", skaicius, numeris, skirtumas);

            int sandauga = skaicius * numeris;
            Console.WriteLine("{0} * {1} = {2}", skaicius, numeris, sandauga);

            int dalyba = skaicius / numeris;
            Console.WriteLine("{0} / {1} = {2}", skaicius, numeris, dalyba);
            Console.WriteLine();

            Console.WriteLine(skaicius);
            Console.WriteLine(Math.Pow(skaicius,2)); //Kvadratin4 šaknis
            Console.WriteLine(Math.Pow(skaicius, 3)); //Kubinė šaknis
            Console.WriteLine();
            Console.WriteLine(skaicius * numeris * indeksas);



        }
    }
}
