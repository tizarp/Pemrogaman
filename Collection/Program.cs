using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gaji_karyawan
{
    class Program
    {
        static void Main(string[] args)
        {
            Karyawan_tetap karyawantetap = new Karyawan_tetap();

            karyawantetap.nik = "19.11.2709";
            karyawantetap.nama = "Mukhammad";
            karyawantetap.gaji_bulanan = 5000000;

            Karyawan_harian karyawanharian = new Karyawan_harian();

            karyawanharian.nik = "19.11.2710";
            karyawanharian.nama = "Tizar";
            karyawanharian.jumlah_jamkerja = 84;
            karyawanharian.upah_perjam = 60000;

            Sales sales = new Sales();
            
            sales.nik = "19.11.2709";
            sales.nama = "Prakoso";
            sales.jumlah_penjualan = 30;
            sales.komisi = 30000;


            List<Karyawan> listkaryawan = new List<Karyawan>();

            listkaryawan.Add(karyawantetap);
            listkaryawan.Add(karyawanharian);
            listkaryawan.Add(sales);

            int nomor = 1;
            
            foreach (Karyawan karyawan in listkaryawan)
            {
                Console.WriteLine();
                Console.WriteLine("{0}.Nama\t: {1}   ,NIK\t: {2}   ,Gaji\t: {3:N0}",nomor,karyawan.nama,karyawan.nik,karyawan.Gaji);
                nomor++;
            }

            Console.ReadKey();
        }
    }
}