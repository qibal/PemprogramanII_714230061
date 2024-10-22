using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace P3_1_714230061
{
    internal class Program
    {
        static void Main(string[] args)
        {

            do
            {
                Console.Clear();
                Console.Write("MENENTUKAN INDEKS PRESTASI MAHASISWA\n------------------------------------");
                Console.Write("\nMasukan Nama Mahasiswa: ");

                string nama = Console.ReadLine();

                Console.WriteLine("Masukan Nilai : ");

                int nilai = Convert.ToInt16(Console.ReadLine());

                string[] grade = { "A", "B", "C", "D" };

                if (nilai >= 85)
                {
                    Console.WriteLine("Indeks nama {0} adalah {1}", nama, grade[0]);
                }
                else if (nilai >= 70 && nilai < 85)
                {
                    Console.WriteLine("Indeks nama {0} adalah {1}", nama, grade[1]);
                }
                else if (nilai >= 60 && nilai < 70)
                {
                    Console.WriteLine("Indeks nama {0} adalah {1}", nama, grade[2]);
                }
                else
                {
                    Console.WriteLine("Indeks nama {0} adalah {1}", nama, grade[3]);
                }


                Console.Write("\nMasukan Indeks yang di tampilkan : ");

                char indeks = Convert.ToChar(Console.ReadLine());

                Console.Write("Indeks Prestasi adalah {0}", nama);

                prestasi(indeks);

                Console.WriteLine("ingin mengulang kembali? (Y/T)");
            }
            while (Console.ReadLine() == "Y");

          
        }


        private static void prestasi(char indeks) {
            switch (indeks)
            {
                case 'A':
                    Console.WriteLine("sangat baik");
                    break;
                case 'B':
                    Console.WriteLine("baik");
                    break;
                case 'C':
                    Console.WriteLine("cukup");
                    break;
                case 'D':
                    Console.WriteLine("buruk");
                    break;
                default:
                    Console.WriteLine("invalid indeks prestasi");
                    break;
            }
        
        }
    }
}
