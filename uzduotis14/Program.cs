using System;


namespace uzduotis14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            /*
             * Į ekraną išveskite kelis sunumeruotus pasirinkimus 
             * 1 - stacionarus kompiuteris
             * 2 - nešiojamas kompiuteris
             * 3 - planšetė 
             * 
             * Liepkite vartotojui įvesti pasirinkimo numerį. 
             * Pagal įvestą numerį išveskite atitinkamą tekstą. Pvz
             * nešiojamuoju kompiuteriu galite naudotis visus
             * stacionariu kompiuteriu galite naudotis tik namuose arba darbo vietoje
             * planšete galite naudotis visur
             * Neradus tinkamo varianto išvesti, kad tokio pasirinkimo nėra.
             */

            Console.WriteLine("1 - stacionarus kompiuteris;");
            Console.WriteLine("2 - nešiojamas kompiuteris;");
            Console.WriteLine("3 - planšetė.");
            Console.WriteLine();

            Console.WriteLine("Pasirinkite vieno iš anksčiau pateiktų variantų numerį: ");
            string ivedimas = Console.ReadLine();
            int numeris = Convert.ToInt32(ivedimas);
            Console.WriteLine();

            switch (numeris)
            {
                case 1:
                    Console.WriteLine("Nešiojamuoju kompiuteriu galite naudotis visur.");
                    break;

                case 2:
                    Console.WriteLine("Stacionariu kompiuteriu galite naudotis tik namuose arba darbo vietoje.");
                    break;

                case 3:
                    Console.WriteLine("Plančete galite naudotis visur.");
                    break;

                default:
                    Console.WriteLine("Tokio pasirinkimo nėra!");
                    break; 
            }
        }
}
}
