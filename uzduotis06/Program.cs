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

            float dalmuo = 12.00f;
            float atsakymas = skaicius / dalmuo;
            Console.WriteLine(atsakymas);

        }
    }
}
