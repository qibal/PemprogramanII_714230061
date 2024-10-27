using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace P3_2_714230061
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string pesan;

            do
            {

                Console.WriteLine("==== MENU PERSEGI PANJANG ====");
                Console.WriteLine("1. Hitung Luas");
                Console.WriteLine("2. Hitung Keliling");
                Console.WriteLine("3. Keluar");
                Console.Write("Pilihan Menu (1-3) : ");

                int menu = Convert.ToInt32(Console.ReadLine());
                Hitung(menu);
                Console.Write("Ingin mengulang kembali? (Y/T): ");
                pesan = Console.ReadLine().ToUpper();
                if (pesan =="T")
                {
                    Console.WriteLine("Terimakasih!");
                }



            }
            while (pesan == "Y");
            
        }


        private static void Hitung(int menu)
        {
            if (menu == 1)
            {
                Console.Write("Masukan Panjang : ");
                int panjang = Convert.ToInt32(Console.ReadLine());
                Console.Write("Masukan Lebar : ");
                int lebar = Convert.ToInt32(Console.ReadLine());

                int luas = panjang * lebar;

                Console.WriteLine("Luas Persegi Panjang : {0}", luas);
            }
            else if (menu == 2)
            {
                Console.Write("Masukan Panjang : ");
                int panjang = Convert.ToInt32(Console.ReadLine());
                Console.Write("Masukan Lebar : ");
                int lebar = Convert.ToInt32(Console.ReadLine());

                int keliling = 2 * (panjang + lebar);

                Console.WriteLine("Keliling Persegi Panjang : {0}", keliling);
            }else if(menu == 3)
            {
                Console.WriteLine("program selesai");
            }
            else
            {
                Console.WriteLine("Menu tidam tersedia. Silahkan  pilih menu yang valid!");
            }
        }
    }
}
