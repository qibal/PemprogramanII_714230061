﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
namespace P6_3_714230061
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void SetErrorMessages(TextBox textBox,string warningMessage,string wrongMessage, string correctMessage) {
            epWarning.SetError(textBox, warningMessage);
            epWrong.SetError(textBox, wrongMessage);
            epCorrect.SetError(textBox, correctMessage);
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void txtHuruf_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtHuruf_Leave(object sender, EventArgs e)
        {
            if (txtHuruf.Text == "")
            {
                SetErrorMessages(txtHuruf, "Textbox Huruf tidak boleh  kosong!", "", "");
            } else if(txtHuruf.Text.All(Char.IsLetter)){
                SetErrorMessages(txtHuruf,"","","Betul!");
            }
            else {
                SetErrorMessages(txtHuruf, "", "Inputan hanya boleh huruf!", "");
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtAngka1_TextChanged(object sender, EventArgs e)
        {
            if (txtAngka1.Text == "")
            {
                SetErrorMessages(txtAngka1, "Textbox Angka tidak boleh  kosong!", "", "");
            }
            else if (txtAngka1.Text.All(Char.IsNumber))
            {
                if (txtAngka2.Text == "")
                {
                    SetErrorMessages(txtAngka2, "Textbox Angka tidak boleh  kosong", "", "");
                }
                else if (Convert.ToInt32(txtAngka1.Text) < Convert.ToInt32(txtAngka2.Text))
                {
                    SetErrorMessages(txtAngka1, "", "Angka 1 harus lebih besar dari angka 2", "");
                    SetErrorMessages(txtAngka2, "", "Angka 1 harus lebih besar dari angka 2", "");
                }
                else
                {
                    SetErrorMessages(txtAngka1, "", "", "Betul!");
                }
               
            }
            else
            {
                SetErrorMessages(txtAngka1, "", "Inputan hanya boleh huruf!", "");
            }
        }

        private void txtAngka2_TextChanged(object sender, EventArgs e)
        {
            if (txtAngka2.Text == "")
            {
                SetErrorMessages(txtAngka2, "Textbox Angka tidak boleh  kosong!", "", "");
            }
            else if (txtAngka2.Text.All(Char.IsNumber))
            {

                if (txtAngka1.Text == "")
                {
                    SetErrorMessages(txtAngka1, "Textbox Angka tidak boleh  kosong", "", "");
                }

                SetErrorMessages(txtAngka2, "", "", "Betul!");
            }
           
            else
            {
                SetErrorMessages(txtAngka2, "", "Inputan hanya boleh huruf!", "");
            }
        }

        private void txtAngka_TextChanged(object sender, EventArgs e)
        {
            if (txtAngka.Text == "")
            {
                SetErrorMessages(txtAngka, "Textbox Angka tidak boleh  kosong!", "", "");
            }
            else if (txtAngka.Text.All(Char.IsNumber))
            {
                SetErrorMessages(txtAngka, "", "", "Betul!");
            }
            else
            {
                SetErrorMessages(txtAngka, "", "Inputan hanya boleh angka!", "");
            }
        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {
            if (txtEmail.Text == "")
            {
                SetErrorMessages(txtEmail, "Textbox Email tidak boleh  kosong!", "", "");
            }
            else if (Regex.IsMatch(txtEmail.Text, @"^^[^@\s]+@[^@\s]+(\.[^@\s]+)+$"))
            {
                SetErrorMessages(txtEmail, "", "", "Betul!");
            }
            else
            {
                SetErrorMessages(txtEmail, "", "Inputan email salah\nContoh :a@b.c", "");
            }
        }

        private void txtAngka1_Leave(object sender, EventArgs e)
        {
            if (txtAngka2.Text == "")
            {
                SetErrorMessages(txtAngka2, "Textbox Angka tidak boleh  kosong!", "", "");
            }
            else if (txtAngka2.Text.All(Char.IsNumber))
            {

                SetErrorMessages(txtAngka2, "", "", "Betul!");
            }
            else
            {
                SetErrorMessages(txtAngka1, "", "Inputan hanya boleh huruf!", "");
            }
        }

        private void txtAngka2_Leave(object sender, EventArgs e)
        {
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void txtAngka_Leave(object sender, EventArgs e)
        {

        }
    }
}
