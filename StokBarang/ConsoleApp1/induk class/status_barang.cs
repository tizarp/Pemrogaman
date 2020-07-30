using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.FP
{
    public abstract class barang
    {
        public string kodebarang { get; set; }
        public string namabarang { get; set; }
        public double totalbarang { get; set; }

        public virtual string stok()
        {
            return "stok";
        }
    }
}
