﻿using System;

namespace ResponsiPemrograman2709
{
    class Program
    {
        static void Main(string[] args)
        {
            karyawan pegawai1 = new karyawan(1234567890, "Mukhammad", 35000000);
            karyawan pegawai2 = new karyawan(0987654321, "Tizar", 40000000);


            Console.WriteLine("++++++++++++++++++++++++++++++++");
            Console.WriteLine("NIK   NAMA            GAJI ANDA");
            Console.WriteLine("++++++++++++++++++++++++++++++++");
            pegawai1.gajiawal();
            pegawai2.gajiawal();
            Console.WriteLine("++++++++++++++++++++++++++++++++");
            Console.WriteLine("++++++++++++++++++++++++++++++++");
            Console.WriteLine("     asiqq naik gaji nihh");
            Console.WriteLine("++++++++++++++++++++++++++++++++");
            Console.WriteLine("++++++++++++++++++++++++++++++++");
            Console.WriteLine("NIK   NAMA            GAJI ANDA");
            Console.WriteLine("++++++++++++++++++++++++++++++++");
            pegawai1.gajiakhir();
            pegawai2.gajiakhir();

            Console.ReadKey();

        }
    }

    class karyawan
    {

        public int nik { get; set; }
        public string nama { get; set; }
        public int gajibulanan { get; set; }

        public karyawan(int nik, string nama, int gaji)
        {

            this.nik = nik;
            this.nama = nama;

            if (gaji < 0)
            {

                this.gajibulanan = 0;
            }
            else
            {
                this.gajibulanan = gaji;
            }

        }

        public void gajiawal()
        {
            Console.WriteLine("{0}      {1}             {2}", nik, nama, gajibulanan);

        }

        public void gajiakhir()
        {

            double tmp = 0;
            tmp = 0.1 * gajibulanan;
            gajibulanan += Convert.ToInt32(tmp);
            Console.WriteLine("{0}      {1}             {2}", nik, nama, gajibulanan);

        }

    }
}
