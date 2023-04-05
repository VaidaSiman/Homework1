using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uzduoti04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Lietuviškos raidės
            Console.OutputEncoding = Encoding.UTF8;

            /*Susikurkite reikiamus kintamuosius užduočiai atlikti. Į ekraną išveskite: Automobilio {markė} {modelis} ({metai} m.) rida - {rida} km.
            Tarp { } nurodyti reikiami kintamieji, šiose vietose jų reikšmės turi būti įstatytos.*/ 

            string marke = "VW";
            string modelis = "GOLF";
            int metai = 1998;
            int rida = 123456; 

            Console.WriteLine("Automobilio {0} {1} {2} m. rida - {3} km", marke, modelis,  metai, rida); 
        }
    }
}
