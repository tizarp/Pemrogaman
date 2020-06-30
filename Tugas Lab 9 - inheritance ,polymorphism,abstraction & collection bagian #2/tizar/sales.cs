using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gaji_karyawan
{
    class Sales : Karyawan
    {
        public int jumlah_penjualan { get; set; }
        public int komisi { get; set; }

        public override int Gaji() => jumlah_penjualan*komisi;
    }
}