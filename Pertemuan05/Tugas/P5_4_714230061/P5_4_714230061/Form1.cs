using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace P5_4_714230061
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Menambahkan pilihan jenis kelamin ke ComboBox saat form dimuat
            comboBox1.Items.Add("Pria");
            comboBox1.Items.Add("Wanita");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Validasi jika pilihan kelas tidak dipilih
            if (!btn_sepakbola.Checked && !btn_basket.Checked && !btn_renang.Checked &&
                !btn_bulutangkis.Checked && !btn_tenis.Checked && !btn_voli.Checked &&
                !btn_yoga.Checked && !btn_panahan.Checked)
            {
                MessageBox.Show("Harus memilih salah satu dari pilihan kelas!", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Validasi jika pilihan jadwal tidak dipilih
            if (!btn_seninrabu.Checked && !btn_selasakamis.Checked && !btn_sabtuminggu.Checked && !btn_minggu.Checked)
            {
                MessageBox.Show("Harus memilih salah satu dari pilihan jadwal!", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // tampilkan informasi
            string nama = input_nama.Text;
            string jenisKelamin = comboBox1.SelectedItem?.ToString() ?? "";
            string tanggalLahir = dateTimePicker1.Value.ToString("dd MMMM yyyy");

            // Mengambil pilihan kelas
            string pilihanKelas = "";
            if (btn_sepakbola.Checked) pilihanKelas += "Sepak Bola, ";
            if (btn_basket.Checked) pilihanKelas += "Basket, ";
            if (btn_renang.Checked) pilihanKelas += "Renang, ";
            if (btn_bulutangkis.Checked) pilihanKelas += "Bulu Tangkis, ";
            if (btn_tenis.Checked) pilihanKelas += "Tenis, ";
            if (btn_voli.Checked) pilihanKelas += "Voli, ";
            if (btn_yoga.Checked) pilihanKelas += "Yoga, ";
            if (btn_panahan.Checked) pilihanKelas += "Panahan, ";

            // Menghapus koma terakhir pada pilihan kelas
            if (pilihanKelas.EndsWith(", "))
                pilihanKelas = pilihanKelas.Substring(0, pilihanKelas.Length - 2);

            // Mengambil pilihan jadwal
            string pilihanJadwal = "";
            if (btn_seninrabu.Checked) pilihanJadwal = "Senin s/d Rabu, 14.00 - 16.00";
            else if (btn_selasakamis.Checked) pilihanJadwal = "Selasa s/d Kamis, 14.00 - 16.00";
            else if (btn_sabtuminggu.Checked) pilihanJadwal = "Jum'at s/d Minggu, 09.00 - 11.00";
            else if (btn_minggu.Checked) pilihanJadwal = "Minggu, 13.00 - 20.00";

            // Menampilkan kotak dialog informasi
            MessageBox.Show($"Nama : {nama}\nJenis Kelamin : {jenisKelamin}\nTanggal Lahir : {tanggalLahir}\nPilihan Kelas : {pilihanKelas}\nPilihan Jadwal : {pilihanJadwal}", "Informasi Pendaftaran", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btn_tenis_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btn_basket_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btn_selasakamis_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void btn_renang_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btn_bulutangkis_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btn_voli_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btn_toga_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btn_panahan_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btn_sabtuminggu_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btn_minggu_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void input_nama_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void g_kelas_Enter(object sender, EventArgs e)
        {

        }

        private void btn_selesai_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }
    }
}
