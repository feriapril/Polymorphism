using System;
using System.Data.Common;

namespace Tugas5
{
    public class Program
    {
        static void Main(string[] args)
        {
            Printer printer = new Printer();

            Console.WriteLine("Pilih Printer");
            Console.WriteLine("1. Epson!");
            Console.WriteLine("2. Cannon");
            Console.WriteLine("3. LaserJet\n");

            Console.WriteLine("Nomor Printer [1..3]: ");
            int nomorPrinter = Convert.ToInt32(Console.ReadLine());

            if (nomorPrinter == 1)
                printer = new Epson();
            else if (nomorPrinter == 2)
                printer = new Canon();
            else
                printer = new LaserJet();

            printer.Show();
            printer.Print();

            Console.ReadKey();
        }
    }
}