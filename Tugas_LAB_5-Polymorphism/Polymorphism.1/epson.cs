using System;
using System.Collections.Generic;
using System.Text;

namespace Polymorphism._1
{
   class Epson : printerwindows

    {
        public override void show()
        {
            Console.WriteLine("Epson display dimension : 10*11");
        }
        public override void print()
        {
            Console.WriteLine("Epson printer printing....");
        }
    }
}
