using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P4_2_714230061
{
    public class CekKhodam : KhodamBase
    {

        public CekKhodam(string nama) : base(nama) { }

        public override string GetKhodam()
        {
            Random rnd = new Random();
            int index = rnd.Next(KhodamList.DaftarKhodam.Count);
            return KhodamList.DaftarKhodam[index];
        }

        public void TampilkanKhodam()
        {
            Console.WriteLine("Khodamn : " + GetKhodam());
        }

    }
}
