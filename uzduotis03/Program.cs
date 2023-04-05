using System;


namespace uzduotis03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Lietuviškos raidės
            Console.OutputEncoding = Encoding.UTF8;

            /* Išveskite į ekraną norimo dydžio tuščiavidurį kvadratą iš žvaigždučių.
            ****
            *  *
            *  *
            **** */

            string pilnaeilute = "******";
            string tusciaeilute = "*    *";

            Console.WriteLine(pilnaeilute);
            Console.WriteLine(tusciaeilute);
            Console.WriteLine(tusciaeilute);
            Console.WriteLine(pilnaeilute); 
                }
    }
}
