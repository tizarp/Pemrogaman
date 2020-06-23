using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gaji_karyawan
{
    class Karyawan_harian : Karyawan
    {
        public double upah_perjam { get; set; }
        public double jumlah_jamkerja { get; set; }
        public override double Gaji { get { return upah_perjam*jumlah_jamkerja; } }
    }
}