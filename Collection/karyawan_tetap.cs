using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gaji_karyawan
{
    class Karyawan_tetap : Karyawan
    {
        public double gaji_bulanan { get; set; }
        public override double Gaji { get{ return gaji_bulanan; } }
        
        
    }
}