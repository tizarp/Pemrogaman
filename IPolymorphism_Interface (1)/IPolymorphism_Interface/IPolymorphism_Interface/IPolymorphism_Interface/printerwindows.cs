using System;
using System.Collections.Generic;
using System.Text;

namespace Polymorphism._1
{
    public interface printerwindows
    {
        void show();
        void print();
    }

    class Epson : printerwindows

    {
        public void show()
        {
            Console.WriteLine("Epson display dimension : 10*11");
        }
        public void print()
        {
            Console.WriteLine("Epson printer printing.....");
        }
    }

    class Canon : printerwindows
    {
        public void show()
        {
            Console.WriteLine("Canon display dimension : 9.5*12");
        }
        public void print()
        {
            Console.WriteLine("Canon printer printing.....");
        }
    }

    class Laserjet : printerwindows
    {
        public void show()
        {
            Console.WriteLine("Laserjet display dimension : 12*12");
        }
        public void print()
        {
            Console.WriteLine("Laserjet printer printing.....");
        }
    }
}
