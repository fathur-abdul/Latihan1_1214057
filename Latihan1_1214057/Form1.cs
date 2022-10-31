using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Latihan1_1214057
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Size = new Size(376, 228);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(tbNama.Text != "")
            {
                if (tbProdi.Text != "")
                {
                    if (tbKelas.Text != "")
                    {
                        MessageBox.Show
                        ("Data Lengkap !!!",
                        "Informasi Data Submit",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Size = new Size(347, 402);
                    }
                    else
                    {
                        MessageBox.Show
                        ("Kelas Belum Diisi !!!",
                        "Informasi Data Submit",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show
                    ("Prodi Belum Diisi !!!",
                    "Informasi Data Submit",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show
                ("Nama Belum Diisi !!!",
                "Informasi Data Submit",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                checkBox1.Enabled = true; checkBox1.Checked = false;
                checkBox2.Enabled = false; checkBox2.Checked = false;
                checkBox3.Enabled = true; checkBox3.Checked = false;
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                checkBox1.Enabled = false; checkBox1.Checked = false;
                checkBox2.Enabled = true; checkBox2.Checked = false;
                checkBox3.Enabled = true; checkBox3.Checked = false;
            }
        }
    }
}
