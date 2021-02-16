using System;

namespace Primer_Parcial
{
    class Program
    {
        static void Main(string[] args)
        {
            int total, c1000, c500, c200, c100;
            c1000 = 0;
            c500 = 0;
            c200 = 0;
            c100 = 0;
            string billete;
            Console.WriteLine("Cajero Automático para el Banco FDP INVERSMENTS");
            Console.WriteLine("Ingrese un monto a retirar: ");
            billete =Console.ReadLine();
            total = int.Parse(billete);
            if (total > 20000)
            {
                Console.WriteLine("Su monto exdece el limite de transaccion");
            }
            if (total >= 1000)
            {
                c1000 = (total / 1000);
                total = total - (c1000 * 1000);
            }
            if (total >= 500)
            {
                c500 = (total / 500);
                total = total - (c500 * 500);
            }
            if (total >= 200)
            {
                c200 = (total / 200);
                total = total - (c200 * 200);
            }
            if (total >= 100)
            {
                c100 = (total / 100);
                total = total - (c100 * 100);
            }
            
            Console.WriteLine("Se le entregaran 1000: " + c1000);
            Console.WriteLine("Se le entregaran 500: " + c500);
            Console.WriteLine("Se le entregaran 200: " + c200);
            Console.WriteLine("Se le entregaran 100: " + c100);
            Console.ReadKey();
        }
    }
}