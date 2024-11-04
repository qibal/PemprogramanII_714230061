using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P4_2_714230061
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ngaran saha ?: ");
            string nama = Console.ReadLine();

            CekKhodam khodam = new CekKhodam(nama);

            khodam.TampilkanKhodam();
        }
    }
}
