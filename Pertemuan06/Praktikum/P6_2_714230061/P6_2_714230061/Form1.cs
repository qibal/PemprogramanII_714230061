﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P6_2_714230061
{
    public partial class Form1 : Form
    {
        public string filePath;
        public Form1()
        {
            InitializeComponent();
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void openFileButton_Click(object sender, EventArgs e)
        {
            try
            {

                DialogResult userResponse = openFileDialog1.ShowDialog();
                if (userResponse == DialogResult.OK)
                {
                    filePath = openFileDialog1.FileName.ToString();
                    MessageBox.Show("You Successfully opened: " + filePath, "Success",
                    MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                }
                else
                {
                    MessageBox.Show("You cancelede the open file location","Warning",
                    MessageBoxButtons.OK,MessageBoxIcon.Warning,MessageBoxDefaultButton.Button1,MessageBoxOptions.RightAlign);
                }

            }
            catch(Exception ex) {

                MessageBox.Show(ex.Message.ToString(), "Error",
                    MessageBoxButtons.OK,MessageBoxIcon.Stop);
            }
        }
    }
}
