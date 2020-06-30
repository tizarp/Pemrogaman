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
        public int upah_perjam { get; set; }
        public int jumlah_jamkerja { get; set; }
        public override int Gaji() => upah_perjam*jumlah_jamkerja;
    }
}