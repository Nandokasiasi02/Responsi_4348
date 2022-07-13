using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Penjualan
{
    class Program
    {
        static List<Penjualan> daftarProduk = new List<Penjualan>();
        static Penjualan Penjual = new Penjualan();

        static void Main(string[] args)
        {
            while (true)
            {
                TampilMenu();
                Console.Write("\nNomor Menu [1..3]: ");
                int nomorMenu = Convert.ToInt32(Console.ReadLine());

                switch (nomorMenu)
                {
                    case 1:
                        TambahPenjualan();
                        break;
                    case 2:
                        TampilPenjualan();
                        break;

                    case 3: // keluar dari program
                        return;

                    default:
                        break;
                }
            }
        }

        static void TampilMenu()
        {
            Console.Clear();

            Console.WriteLine("Pilihan Menu Aplikasi\n");
            Console.WriteLine("1. Tambah produk");
            Console.WriteLine("2. Tampilkan produk");
            Console.WriteLine("3. Keluar\n");
        }

        static void TambahPenjualan()
        {
            Console.Clear();
            Penjual = new Penjualan();
            Console.WriteLine("Tambah data produk");
            Console.WriteLine();
            Console.Write("Nota       : ");
            Penjual.Nota = Console.ReadLine();
            Console.Write("Tanggal    : ");
            Penjual.Tanggal = Console.ReadLine();
            Console.Write("Customer   : ");
            Penjual.Nama = Console.ReadLine(