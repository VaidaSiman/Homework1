using System;


namespace uzduotis28
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            /*
             * Aprašykite ir iškvieskite metodą, kuris išvestų bet kokį jūsų pasirinktą tekstą.
             * PROGRAMA PRADĖJO DARBĄ */
            Tekstas("pROGRAMA PRADĖJO DARBĄ");
        }

        static private void Tekstas(string betKoksTekstas)
        {
            Console.WriteLine($"{betKoksTekstas}");
        }
    }
}
