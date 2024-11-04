using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P4_2_714230061
{
    public abstract class KhodamBase
    {
        protected string NamaPengguna;

        public string Nama
        {
            get { return NamaPengguna; }
            set { NamaPengguna = value; }
        }

        protected KhodamBase(string nama)
        {
            NamaPengguna = nama;
        }
        public abstract string GetKhodam();
    }
}
