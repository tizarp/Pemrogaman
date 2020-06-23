using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gaji_karyawan
{
    class Sales : Karyawan
    {
        public double jumlah_penjualan { get; set; }
        public double komisi { get; set; }

        public override double Gaji { get { return jumlah_penjualan*komisi; } }
    }
}