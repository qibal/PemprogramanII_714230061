using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P2_1_714230061
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Masukkan Angka Pertama : ");
            double input = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Masukkan Angka Kedua : ");
            double input2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Angka Pertama = " + input);
            Console.WriteLine("Angka Kedua = " + input2);
            Console.WriteLine(input + " + " + input2 + " = " + (input + input2));
            Console.WriteLine(input + " - " + input2 + " = " + (input - input2));
            Console.WriteLine(input + " x " + input2 + " = " + (input * input2));
            Console.WriteLine(input + " / " + input2 + " = " + (input / input2));

        }
    }
}
