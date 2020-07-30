using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

using ConsoleApp1.FP;

namespace ConsoleApp1
{
    class Program
    {
        static void Main()
        {
            List<barang> Barang = new List<barang>();

            Pilih(Barang);
        }

        static void Pilih(List<barang> Barang)
        {
            bool status = true;
            int pil;
            while (status == true)
            {
            menu:
                try
                {
                    Console.Clear();
                    Console.WriteLine("---------------------------");
                    Console.WriteLine("|---PT.Semangat Bersama---|");
                    Console.WriteLine("|       Pilih Menu        |");
                    Console.WriteLine("|1. Tambah barang         |");
                    Console.WriteLine("|2. Hapus barang          |");
                    Console.WriteLine("|3. Tampilkan barang      |");
                    Console.WriteLine("|4. Exit                  |");
                    Console.WriteLine("---------------------------");
                    Console.Write("Masukkan Pilihan Anda[1-4]: ");
                    pil = int.Parse(Console.ReadLine());
                }
                catch (Exception)
                {
                    Console.WriteLine("Menu tidak ditemukan");
                    Console.WriteLine("\nTekan enter untuk kembali ke menu");
                    Console.ReadKey();
                    goto menu;
                }

                switch (pil)
                {
                    case 1:
                        {
                            Tambahbarang(Barang);
                            kembalikeMainMenu();
                            break;
                        }

                    case 2:
                        {
                            hapusbarang(Barang);
                            kembalikeMainMenu();
                            break;
                        }

                    case 3:
                        {
                            Tampilbarang(Barang);
                            kembalikeMainMenu();
                            break;

                        }

                    case 4:
                        {
                            Console.WriteLine("terima kasih");
                            Thread.Sleep(1000);
                            status = false;
                            break;
                        }

                    default:
                        {
                            Console.WriteLine("Pilihan tidak ada, \nTekan enter untuk kembali ke menu");
                            Console.ReadKey();
                            Pilih(Barang);
                            break;
                        }
                }
            }
        }

        static void Tambahbarang(List<barang> Barang)
        {
            int pil;
        tambah:
            try
            {
                Console.Clear();
                Console.WriteLine("---------------------------");
                Console.WriteLine("|---PT.Semangat Bersama---|");
                Console.WriteLine("|      Tambah barang      |");
                Console.WriteLine("|1. stok banyak           |");
                Console.WriteLine("|2. stok setandart        |");
                Console.WriteLine("|3. stock kurang          |");
                Console.WriteLine("---------------------------");
                Console.Write("Masukkan Pilihan Anda [1-3]: ");
                pil = int.Parse(Console.ReadLine());
            }
            catch (Exception)
            {
                Console.WriteLine("menu tidak ditemukan");
                Console.WriteLine("\nTekan enter untuk kembali ke menu");
                Console.ReadKey();
                goto tambah;
            }

            switch (pil)
            {
                case 1:
                    {
                        lebih lebih = new lebih();

                        Console.WriteLine("\nstok banyak");

                        Console.Write("kode barang  : ");
                        lebih.kodebarang = Console.ReadLine();

                        Console.Write("nama barang : ");
                        lebih.namabarang = Console.ReadLine();

                        Console.Write("jumlah barang saat ini : ");
                        lebih.totalbarang = Convert.ToDouble(Console.ReadLine());

                        Barang.Add(lebih);
                        break;
                    }

                case 2:
                    {
                        cukup cukup = new cukup();

                        Console.WriteLine("\nstok menengah");

                        Console.Write("kode barang : ");
                        cukup.kodebarang = Console.ReadLine();

                        Console.Write("nama barang : ");
                        cukup.namabarang = Console.ReadLine();

                        Console.Write("jumlah barang saat ini : ");
                        cukup.totalbarang = Convert.ToDouble(Console.ReadLine());

                        Barang.Add(cukup);
                        break;
                    }

                case 3:
                    {
                        kurang kurang = new kurang();

                        Console.WriteLine("\nstok habis");

                        Console.Write("kode barang : ");
                        kurang.kodebarang = Console.ReadLine();

                        Console.Write("nama barang : ");
                        kurang.namabarang = Console.ReadLine();

                        Console.Write("jumlah barang saat ini : ");
                        kurang.totalbarang = Convert.ToDouble(Console.ReadLine());

                        Barang.Add(kurang);
                        break;
                    }


                default:
                    {
                        Console.WriteLine("Pilihan tidak ada, \nTekan enter untuk kembali ke menu");
                        Console.ReadKey();
                        Tambahbarang(Barang);
                        break;
                    }
            }
        }

        static void hapusbarang(List<barang> Barang)
        {
            bool hapus = true;

            Tampilbarang(Barang);
            Console.Write("\nMasukkan kode barang yang akan dihapus: ");
            string kodebarang = Console.ReadLine();

            for (int i = 0; i < Barang.Count; i++)
            {
                if (Barang[i].kodebarang == kodebarang)
                {
                    Barang.Remove(Barang[i]);
                    hapus = true;
                    break;
                }
                else
                {
                    hapus = false;
                }
            }

            switch (hapus)
            {
                case true:
                    Console.WriteLine("\nbarang berhasil dihapus", kodebarang);
                    break;
                case false:
                    Console.WriteLine("\nbarang tidak ditemukan", kodebarang);
                    break;
            }
        }

        static void Tampilbarang(List<barang> Barang)
        {
            Console.Clear();
            Console.WriteLine(String.Format("| {0} | {1} | {2} | {3} | {4} |", "NO", "kode barang", "nama barang", "jumlah barang", "stok barang"));
         
            for (int i = 0; i < Barang.Count; i++)
            {
                Console.WriteLine(String.Format("| {0} |    {1}    | {2}      | {3}     | {4}     |",
                    i + 1, Barang[i].kodebarang, Barang[i].namabarang, Barang[i].totalbarang,Barang[i].stok()));
            }
        }

        static void kembalikeMainMenu()
        {
            Console.WriteLine("\nTekan enter untuk kembali ke menu");
            Console.ReadKey();
        }
    }
}