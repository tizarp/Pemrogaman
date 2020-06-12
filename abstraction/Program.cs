using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using HelloWorld.Interface;      // dengan Interface

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {

            Imakanan makanan;       // Menggunakan Interface

            Console.WriteLine();
            makanan = new apel();
            makanan.buah();
            Console.WriteLine();

            makanan = new mangga();
            makanan.buah();
            Console.WriteLine();

            makanan = new jeruk();
            makanan.buah();
            Console.WriteLine();

            makanan = new semangka();
            makanan.buah();
            Console.WriteLine();

            Console.ReadKey();
        }
    }
}