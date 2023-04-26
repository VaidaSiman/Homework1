using System;

namespace uzduotis18
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            /* Tikslas: 
             * Suskaičiuoti, kiek duonos kepalų kepykla sugebės iškepti per dieną.
             * Patikrinti, ar kepykla spės iškepti visus tos dienos užsakymus, 
             * jei ne, suskaičiuoti, kiek kepalų nespės iškepti.
             * Suskaičiuoti, kiek kepykla uždirbs pelno iš visų tą dieną iškeptų duonos kepalų.
             * 
             * Iš anksto žinoma informacija:
             * Darbo valandų per dieną - 8 val.
             * 
             * Vartotojo įvedama informacija:
             * Kiek darbuotojas gali iškepti kepalų per valandą.
             * Kiek darbuotojų turi kepykla.
             * Vieno kepalo savikaina.
             * Vieno kepalo pardavimo kaina.
             * Kiek kepykla turi tą dieną iškepti kepalų (užsakymai).
             */

            Console.Write("Per valandą iškeptų duonos kepalų skačius (vieno darbuotojo): ");
            int skaičiusKepalų = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            Console.Write("Darbuotojų skaičius: ");
            int darbuotojai = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            Console.Write("Duonos kepalo savikaina: ");
            double savikaina = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine();

            Console.Write("Vieneto pardavimo kaina: ");
            double kaina = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine();

            Console.Write("Užsakymų skaičius: ");
            int uzsakymaiDienos = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            int valandosDarbo = 8;
            int iskeptaIsviso = skaičiusKepalų * valandosDarbo * darbuotojai;

            Console.WriteLine($"Kepykla iškepa per dieną: {iskeptaIsviso}");
            Console.WriteLine();

            if (iskeptaIsviso >= uzsakymaiDienos)
            {
                Console.WriteLine("Kepykla iškepė numatytą dienos kepalų skaičių!");
            }

            else 
            {
                Console.WriteLine($"Neiškeptas numatytas kepalų skaičius. Iki numatytos dienos tikslo trūko: {uzsakymaiDienos - iskeptaIsviso} duonos kepalų.");
            }

            Console.WriteLine();
            Console.WriteLine($"Dienos pelnas: {(kaina - savikaina) * uzsakymaiDienos}");
        }
    }
}
