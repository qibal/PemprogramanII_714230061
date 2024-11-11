namespace P5_4_714230061
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.input_nama = new System.Windows.Forms.TextBox();
            this.pilihan_kelas = new System.Windows.Forms.GroupBox();
            this.btn_panahan = new System.Windows.Forms.CheckBox();
            this.btn_yoga = new System.Windows.Forms.CheckBox();
            this.btn_voli = new System.Windows.Forms.CheckBox();
            this.btn_tenis = new System.Windows.Forms.CheckBox();
            this.btn_bulutangkis = new System.Windows.Forms.CheckBox();
            this.btn_renang = new System.Windows.Forms.CheckBox();
            this.btn_basket = new System.Windows.Forms.CheckBox();
            this.btn_sepakbola = new System.Windows.Forms.CheckBox();
            this.pilihan_jadwal = new System.Windows.Forms.GroupBox();
            this.btn_minggu = new System.Windows.Forms.RadioButton();
            this.btn_sabtuminggu = new System.Windows.Forms.RadioButton();
            this.btn_selasakamis = new System.Windows.Forms.RadioButton();
            this.btn_seninrabu = new System.Windows.Forms.RadioButton();
            this.btn_tampilkan = new System.Windows.Forms.Button();
            this.btn_selesai = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.pilihan_kelas.SuspendLayout();
            this.pilihan_jadwal.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(200, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nama";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(200, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Jenis Kelamin";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(200, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tanggal Lahir";
            // 
            // input_nama
            // 
            this.input_nama.Location = new System.Drawing.Point(298, 73);
            this.input_nama.Name = "input_nama";
            this.input_nama.Size = new System.Drawing.Size(200, 20);
            this.input_nama.TabIndex = 3;
            this.input_nama.TextChanged += new System.EventHandler(this.input_nama_TextChanged);
            // 
            // pilihan_kelas
            // 
            this.pilihan_kelas.Controls.Add(this.btn_panahan);
            this.pilihan_kelas.Controls.Add(this.btn_yoga);
            this.pilihan_kelas.Controls.Add(this.btn_voli);
            this.pilihan_kelas.Controls.Add(this.btn_tenis);
            this.pilihan_kelas.Controls.Add(this.btn_bulutangkis);
            this.pilihan_kelas.Controls.Add(this.btn_renang);
            this.pilihan_kelas.Controls.Add(this.btn_basket);
            this.pilihan_kelas.Controls.Add(this.btn_sepakbola);
            this.pilihan_kelas.Location = new System.Drawing.Point(90, 181);
            this.pilihan_kelas.Name = "pilihan_kelas";
            this.pilihan_kelas.Size = new System.Drawing.Size(259, 187);
            this.pilihan_kelas.TabIndex = 6;
            this.pilihan_kelas.TabStop = false;
            this.pilihan_kelas.Text = "Pilihan Kelas";
            this.pilihan_kelas.Enter += new System.EventHandler(this.g_kelas_Enter);
            // 
            // btn_panahan
            // 
            this.btn_panahan.AutoSize = true;
            this.btn_panahan.Location = new System.Drawing.Point(133, 152);
            this.btn_panahan.Name = "btn_panahan";
            this.btn_panahan.Size = new System.Drawing.Size(69, 17);
            this.btn_panahan.TabIndex = 1;
            this.btn_panahan.Text = "Panahan";
            this.btn_panahan.UseVisualStyleBackColor = true;
            this.btn_panahan.CheckedChanged += new System.EventHandler(this.btn_panahan_CheckedChanged);
            // 
            // btn_yoga
            // 
            this.btn_yoga.Location = new System.Drawing.Point(26, 152);
            this.btn_yoga.Name = "btn_yoga";
            this.btn_yoga.Size = new System.Drawing.Size(80, 17);
            this.btn_yoga.TabIndex = 0;
            this.btn_yoga.Text = "Yoga";
            this.btn_yoga.UseVisualStyleBackColor = true;
            this.btn_yoga.CheckedChanged += new System.EventHandler(this.btn_toga_CheckedChanged);
            // 
            // btn_voli
            // 
            this.btn_voli.Location = new System.Drawing.Point(133, 110);
            this.btn_voli.Name = "btn_voli";
            this.btn_voli.Size = new System.Drawing.Size(80, 17);
            this.btn_voli.TabIndex = 0;
            this.btn_voli.Text = "Voli";
            this.btn_voli.UseVisualStyleBackColor = true;
            this.btn_voli.CheckedChanged += new System.EventHandler(this.btn_voli_CheckedChanged);
            // 
            // btn_tenis
            // 
            this.btn_tenis.Location = new System.Drawing.Point(26, 110);
            this.btn_tenis.Name = "btn_tenis";
            this.btn_tenis.Size = new System.Drawing.Size(80, 17);
            this.btn_tenis.TabIndex = 0;
            this.btn_tenis.Text = "Tenis";
            this.btn_tenis.UseVisualStyleBackColor = true;
            this.btn_tenis.CheckedChanged += new System.EventHandler(this.btn_tenis_CheckedChanged);
            // 
            // btn_bulutangkis
            // 
            this.btn_bulutangkis.Location = new System.Drawing.Point(133, 68);
            this.btn_bulutangkis.Name = "btn_bulutangkis";
            this.btn_bulutangkis.Size = new System.Drawing.Size(80, 17);
            this.btn_bulutangkis.TabIndex = 0;
            this.btn_bulutangkis.Text = "BuluTangkis";
            this.btn_bulutangkis.UseVisualStyleBackColor = true;
            this.btn_bulutangkis.CheckedChanged += new System.EventHandler(this.btn_bulutangkis_CheckedChanged);
            // 
            // btn_renang
            // 
            this.btn_renang.Location = new System.Drawing.Point(26, 68);
            this.btn_renang.Name = "btn_renang";
            this.btn_renang.Size = new System.Drawing.Size(80, 17);
            this.btn_renang.TabIndex = 0;
            this.btn_renang.Text = "Renang";
            this.btn_renang.UseVisualStyleBackColor = true;
            this.btn_renang.CheckedChanged += new System.EventHandler(this.btn_renang_CheckedChanged);
            // 
            // btn_basket
            // 
            this.btn_basket.Location = new System.Drawing.Point(133, 26);
            this.btn_basket.Name = "btn_basket";
            this.btn_basket.Size = new System.Drawing.Size(80, 17);
            this.btn_basket.TabIndex = 0;
            this.btn_basket.Text = "Basket";
            this.btn_basket.UseVisualStyleBackColor = true;
            this.btn_basket.CheckedChanged += new System.EventHandler(this.btn_basket_CheckedChanged);
            // 
            // btn_sepakbola
            // 
            this.btn_sepakbola.Location = new System.Drawing.Point(26, 26);
            this.btn_sepakbola.Name = "btn_sepakbola";
            this.btn_sepakbola.Size = new System.Drawing.Size(80, 17);
            this.btn_sepakbola.TabIndex = 0;
            this.btn_sepakbola.Text = "Sepak Bola";
            this.btn_sepakbola.UseVisualStyleBackColor = true;
            this.btn_sepakbola.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // pilihan_jadwal
            // 
            this.pilihan_jadwal.Controls.Add(this.btn_minggu);
            this.pilihan_jadwal.Controls.Add(this.btn_sabtuminggu);
            this.pilihan_jadwal.Controls.Add(this.btn_selasakamis);
            this.pilihan_jadwal.Controls.Add(this.btn_seninrabu);
            this.pilihan_jadwal.Location = new System.Drawing.Point(440, 181);
            this.pilihan_jadwal.Name = "pilihan_jadwal";
            this.pilihan_jadwal.Size = new System.Drawing.Size(241, 187);
            this.pilihan_jadwal.TabIndex = 7;
            this.pilihan_jadwal.TabStop = false;
            this.pilihan_jadwal.Text = "Pilihan Jadwal";
            this.pilihan_jadwal.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // btn_minggu
            // 
            this.btn_minggu.Location = new System.Drawing.Point(51, 152);
            this.btn_minggu.Name = "btn_minggu";
            this.btn_minggu.Size = new System.Drawing.Size(184, 17);
            this.btn_minggu.TabIndex = 0;
            this.btn_minggu.TabStop = true;
            this.btn_minggu.Text = "Minggu, 13:00 -  20:00";
            this.btn_minggu.UseVisualStyleBackColor = true;
            this.btn_minggu.CheckedChanged += new System.EventHandler(this.btn_minggu_CheckedChanged);
            // 
            // btn_sabtuminggu
            // 
            this.btn_sabtuminggu.Location = new System.Drawing.Point(51, 112);
            this.btn_sabtuminggu.Name = "btn_sabtuminggu";
            this.btn_sabtuminggu.Size = new System.Drawing.Size(184, 17);
            this.btn_sabtuminggu.TabIndex = 0;
            this.btn_sabtuminggu.TabStop = true;
            this.btn_sabtuminggu.Text = "Sabtu s/d Minggu, 09:00 - 11:00";
            this.btn_sabtuminggu.UseVisualStyleBackColor = true;
            this.btn_sabtuminggu.CheckedChanged += new System.EventHandler(this.btn_sabtuminggu_CheckedChanged);
            // 
            // btn_selasakamis
            // 
            this.btn_selasakamis.Location = new System.Drawing.Point(51, 68);
            this.btn_selasakamis.Name = "btn_selasakamis";
            this.btn_selasakamis.Size = new System.Drawing.Size(184, 17);
            this.btn_selasakamis.TabIndex = 0;
            this.btn_selasakamis.TabStop = true;
            this.btn_selasakamis.Text = "Selasa s/d Kamis, 14.00 - 16.00";
            this.btn_selasakamis.UseVisualStyleBackColor = true;
            this.btn_selasakamis.CheckedChanged += new System.EventHandler(this.btn_selasakamis_CheckedChanged);
            // 
            // btn_seninrabu
            // 
            this.btn_seninrabu.AutoSize = true;
            this.btn_seninrabu.Location = new System.Drawing.Point(51, 32);
            this.btn_seninrabu.Name = "btn_seninrabu";
            this.btn_seninrabu.Size = new System.Drawing.Size(169, 17);
            this.btn_seninrabu.TabIndex = 0;
            this.btn_seninrabu.TabStop = true;
            this.btn_seninrabu.Text = "Senin s/d Rabu, 14.00 - 16.00";
            this.btn_seninrabu.UseVisualStyleBackColor = true;
            this.btn_seninrabu.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // btn_tampilkan
            // 
            this.btn_tampilkan.Location = new System.Drawing.Point(274, 391);
            this.btn_tampilkan.Name = "btn_tampilkan";
            this.btn_tampilkan.Size = new System.Drawing.Size(75, 23);
            this.btn_tampilkan.TabIndex = 0;
            this.btn_tampilkan.Text = "Tampilkan";
            this.btn_tampilkan.UseVisualStyleBackColor = true;
            this.btn_tampilkan.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_selesai
            // 
            this.btn_selesai.Location = new System.Drawing.Point(440, 391);
            this.btn_selesai.Name = "btn_selesai";
            this.btn_selesai.Size = new System.Drawing.Size(75, 23);
            this.btn_selesai.TabIndex = 8;
            this.btn_selesai.Text = "Selesai";
            this.btn_selesai.UseVisualStyleBackColor = true;
            this.btn_selesai.Click += new System.EventHandler(this.btn_selesai_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(298, 103);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(200, 21);
            this.comboBox1.TabIndex = 9;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged_1);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(298, 136);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.btn_selesai);
            this.Controls.Add(this.btn_tampilkan);
            this.Controls.Add(this.pilihan_jadwal);
            this.Controls.Add(this.pilihan_kelas);
            this.Controls.Add(this.input_nama);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.pilihan_kelas.ResumeLayout(false);
            this.pilihan_kelas.PerformLayout();
            this.pilihan_jadwal.ResumeLayout(false);
            this.pilihan_jadwal.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox input_nama;
        private System.Windows.Forms.GroupBox pilihan_kelas;
        private System.Windows.Forms.GroupBox pilihan_jadwal;
        private System.Windows.Forms.RadioButton btn_seninrabu;
        private System.Windows.Forms.CheckBox btn_yoga;
        private System.Windows.Forms.CheckBox btn_voli;
        private System.Windows.Forms.CheckBox btn_tenis;
        private System.Windows.Forms.CheckBox btn_bulutangkis;
        private System.Windows.Forms.CheckBox btn_renang;
        private System.Windows.Forms.CheckBox btn_basket;
        private System.Windows.Forms.CheckBox btn_sepakbola;
        private System.Windows.Forms.RadioButton btn_minggu;
        private System.Windows.Forms.RadioButton btn_sabtuminggu;
        private System.Windows.Forms.RadioButton btn_selasakamis;
        private System.Windows.Forms.Button btn_tampilkan;
        private System.Windows.Forms.Button btn_selesai;
        private System.Windows.Forms.CheckBox btn_panahan;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}

