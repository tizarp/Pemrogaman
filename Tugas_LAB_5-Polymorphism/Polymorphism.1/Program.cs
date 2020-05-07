using System;

namespace Polymorphism._1
{
  class Program
    {
        static void Main(string[] args)
        {
            printerwindows printer;

            Console.WriteLine("Pilih Printer:");
            Console.WriteLine("1. epson");
            Console.WriteLine("2. canon");
            Console.WriteLine("3. laserjet");

            Console.WriteLine("Nomor Printer[1..3] : ");
            int nomorprinter = Convert.ToInt32(Console.ReadLine());

            if (nomorprinter == 1)
            {
                printer = new Epson();
                printer.show();
                printer.print();
            }
            else if (nomorprinter == 2)
            {
                printer = new canon();
                printer.show();
                printer.print();
            }
            else if (nomorprinter == 3)
            {
                printer = new laserjet();
                printer.show();
                printer.print();
            }

            Console.ReadKey();
        }
    }
}
