using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uzduotis06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Lietuviškos raidės
            Console.OutputEncoding = Encoding.UTF8;

            //Išveskite pasirinkto skaičiaus daugybos lentelę. Pvz.: 5 * 0 = 0   5 * 1 = 5 


            int skaicius = 4;
            int numeris = 0;
            Console.WriteLine("{0} * {1} = {2}", skaicius, numeris, (skaicius * numeris));
            Console.WriteLine("{0} * {1} = {2}", skaicius, ++numeris, (skaicius * numeris));
            Console.WriteLine("{0} * {1} = {2}", skaicius, ++numeris, (skaicius * numeris));
            Console.WriteLine("{0} * {1} = {2}", skaicius, ++numeris, (skaicius * numeris));
            Console.WriteLine("{0} * {1} = {2}", skaicius, ++numeris, (skaicius * numeris));
            Console.WriteLine("{0} * {1} = {2}", skaicius, ++numeris, (skaicius * numeris));
            Console.WriteLine("{0} * {1} = {2}", skaicius, ++numeris, (skaicius * numeris));
            Console.WriteLine("{0} * {1} = {2}", skaicius, ++numeris, (skaicius * numeris));
            Console.WriteLine("{0} * {1} = {2}", skaicius, ++numeris, (skaicius * numeris));
            Console.WriteLine("{0} * {1} = {2}", skaicius, ++numeris, (skaicius * numeris));
            Console.WriteLine("{0} * {1} = {2}", skaicius, ++numeris, (skaicius * numeris));
            Console.WriteLine();

            /*Susikurkite sveikojo skaičiaus kintamąjį 
                su dviženklio skaičiaus reikšme. 
                Išveskite į ekraną šio skaičiaus skaitmenų sandaugą.*/

            int dvizenklisskaicius = 35;
            int desimtys = dvizenklisskaicius / 10; 
            int vienetai = dvizenklisskaicius % 10; //liekana 

            Console.WriteLine($"Dviženklis skaičius: {dvizenklisskaicius}");
            Console.WriteLine($"Skaičiaus skaitmenų daugyba: {desimtys} * {vienetai} = {desimtys * vienetai}");
            Console.WriteLine();
        }
    }
}
