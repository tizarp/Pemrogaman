using System;
using System.Collections.Generic;
using System.Text;

namespace Polymorphism._1
{
    class printerwindows
    {
        public virtual void show()
        {
            Console.WriteLine("display dimension printer");
        }

        public virtual void print()
        {
            Console.WriteLine("printer printing.....");
        }
    }
}
