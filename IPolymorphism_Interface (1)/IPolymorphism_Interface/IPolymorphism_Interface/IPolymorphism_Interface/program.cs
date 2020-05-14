using System;

namespace Polymorphism._1
{
    class Program
    {
        static void Main(string[] args)
        {
            printerwindows printer;

            Console.WriteLine("Pilih Printer:");
            Console.WriteLine("1.Epson");
            Console.WriteLine("2.Canon");
            Console.WriteLine("3.Laserjet");

            Console.WriteLine("Nomor printer [1,2,3] : ");
            int nomorprinter = Convert.ToInt32(Console.ReadLine());

            if (nomorprinter == 1)
            {
                printer = new Epson();
            }
            else if (nomorprinter == 2)
            {
                printer = new Canon();
            }
            else
            {
                printer = new Laserjet();
            }

            printer.show();
            printer.print();

            Console.ReadKey();
        }
    }
}
