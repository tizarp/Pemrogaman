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
            List<Karyawan> list_Karyawan = new List<Karyawan>();
            
            void tampil_karyawan(){
            int nomor = 1;
            foreach (Karyawan karyawan in list_Karyawan)
            {
                Console.WriteLine();
                Console.WriteLine("{0}.NIK\t: {1}   ,\t: {2}   ,Gaji\t: {3},{4}",nomor,karyawan.nik,karyawan.nama,karyawan.Gaji(),karyawan.jenis_karyawan);
                nomor++;
            }
            }

            void tambah_karyawan_tetap(string jeniskaryawan,string nik,string nama,int gajibulanan){
                list_Karyawan.Add(new Karyawan_tetap {jenis_karyawan = jeniskaryawan, nik =nik, nama = nama, gaji_bulanan = gajibulanan});
            }

            void tambah_karyawan_harian(string jeniskaryawan,string nik,string nama,int totaljamkerja,int upah){
                list_Karyawan.Add(new Karyawan_harian {jenis_karyawan = jeniskaryawan, nik =nik, nama = nama,jumlah_jamkerja = totaljamkerja,upah_perjam = upah});
            }

            void tambah_sales(string jeniskaryawan,string nik,string nama,int jumlahpenjualan ,int KOMISI){
                list_Karyawan.Add(new Sales {jenis_karyawan = jeniskaryawan, nik =nik, nama = nama,jumlah_penjualan  =jumlahpenjualan,komisi = KOMISI});
            }

            void hapus_karyawan(){
                int no = 1;
                int jumlah_pekerja = 0;
                foreach (Karyawan karyawan in list_Karyawan){
                    Console.WriteLine("{0}.NIK : {1}",no,karyawan.nik);
                    no++;
                    jumlah_pekerja += 1;
                }

                Console.WriteLine();
                Console.WriteLine("pilih data yang ingin dihapus [1-");
                Console.Write(jumlah_pekerja);
                Console.Write("] :");
                int index_nik = int.Parse(Console.ReadLine());
                index_nik = index_nik -1;

                list_Karyawan.RemoveAt(index_nik);
                Console.WriteLine();
                Console.WriteLine("data karyawan berhasil dihapus");
                Console.WriteLine();
                Console.WriteLine("tekan enter untuk kembali");
            }

            bool keluar = false;
            while (keluar == false){
                Console.WriteLine();
                Console.WriteLine("+++pulih menu anda+++");
                Console.WriteLine();
                Console.WriteLine("1=>tambah data karyawan");
                Console.WriteLine("2=>hapus data karyawan");
                Console.WriteLine("3=>tampilkan data karyawan");
                Console.WriteLine("4=keluar");
                Console.Write("pilih menu [1..4] =");
                int menu = int .Parse(Console.ReadLine());
                Console.Clear();
                Console.WriteLine();

                if(menu <1 || menu >4){
                    Console.WriteLine("maaf,menu yang anda pilih tidak tersedia");
                }
                else if(menu ==1){
                    Console.WriteLine("tambah data karyawan");
                    Console.WriteLine();
                    Console.WriteLine("jenis karyawan");
                    Console.WriteLine("1=>karyawan tetap");
                    Console.WriteLine("2=>karyawan harian");
                    Console.WriteLine("3=>sales");
                    Console.Write("pilih : ");
                    int jk = int.Parse(Console.ReadLine());
                    if(jk ==1){
                    Console.Write("NIK : ");
                    string nik = Console.ReadLine();
                    Console.Write("NAMA : ");
                    String nama = Console.ReadLine();
                    Console.Write("gaji bulanan anda :");
                    int gb = int.Parse(Console.ReadLine());
                    string jenis = "karyawan tetap";

                    tambah_karyawan_tetap(jenis,nik,nama,gb);

                }
                    else if(jk ==2){
                        Console.Write("NIK : ");
                    string nik = Console.ReadLine();
                    Console.Write("NAMA : ");
                    String nama = Console.ReadLine();
                    Console.Write("jumlah jam kerja :");
                    int jamkerja = int.Parse(Console.ReadLine());
                    Console.Write("upah perjam :");
                    int upah = int.Parse(Console.ReadLine());
                    string jenis = "karyawan harian";

                    tambah_karyawan_harian(jenis,nik,nama,jamkerja,upah);
                    }
                    else if(jk ==3){
                        Console.Write("NIK : ");
                    string nik = Console.ReadLine();
                    Console.Write("NAMA : ");
                    String nama = Console.ReadLine();
                    Console.Write("jumlah jual :");
                    int jumlah_jual = int.Parse(Console.ReadLine());
                    Console.Write("komisi :");
                    int km = int.Parse(Console.ReadLine());
                    string jenis = "sales";

                    tambah_sales(jenis,nik,nama,jumlah_jual,km);
                    }
                    else{
                        Console.WriteLine("maaf,menu tidak terdaftar");
                    }
                    Console.WriteLine("tekan enter untuk kembali");
                }
                else if(menu ==2){
                    hapus_karyawan();
                }
                else if(menu ==3){
                    Console.WriteLine("data para karyawan");
                    tampil_karyawan();
                    Console.WriteLine("tekan enter untuk kembali");
                }
                else if(menu ==4){
                    keluar = true;
                }
                Console.ReadKey();
            }
        }
    }
}