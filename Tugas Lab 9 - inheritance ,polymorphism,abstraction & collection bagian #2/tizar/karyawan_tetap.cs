using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gaji_karyawan
{
    class Karyawan_tetap : Karyawan
    {
        public int gaji_bulanan { get; set; }
        public override int Gaji() =>gaji_bulanan;
        
        
    }
}