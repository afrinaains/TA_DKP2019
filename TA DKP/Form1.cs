using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TA_DKP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton7_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton8_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton9_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool pilihan;
            int harga = 0;
            int total = 0;
            int jumlahbarang;

            pilihan = radioButton1.Checked;
            if (radioButton1.Checked)
            {
                //harga = 75000;
                jumlahbarang = comboJumlah.SelectedIndex + 1;
                Price one = new Price(75000);
                harga = one.harga;
                total = harga * jumlahbarang;
            }

            pilihan = radioButton2.Checked;
            if (radioButton2.Checked)
            {
                //harga = 100000;
                jumlahbarang = comboJumlah.SelectedIndex + 1;
                Price one = new Price(100000);
                harga = one.harga;
                total = harga * jumlahbarang;
            }

            pilihan = radioButton3.Checked;
            if (radioButton3.Checked)
            {
                //harga = 90000;
                jumlahbarang = comboJumlah.SelectedIndex + 1;
                Price one = new Price(90000);
                harga = one.harga;
                total = harga * jumlahbarang;
            }

            pilihan = radioButton4.Checked;
            if (radioButton4.Checked)
            {
                //harga = 110000;
                jumlahbarang = comboJumlah.SelectedIndex + 1;
                Price one = new Price(110000);
                harga = one.harga;
                total = harga * jumlahbarang;
            }

            pilihan = radioButton5.Checked;
            if (radioButton5.Checked)
            {
                //harga = 120000;
                jumlahbarang = comboJumlah.SelectedIndex + 1;
                Price one = new Price(120000);
                harga = one.harga;
                total = harga * jumlahbarang;
            }

            pilihan = radioButton6.Checked;
            if (radioButton6.Checked)
            {
                //harga = 100000;
                jumlahbarang = comboJumlah.SelectedIndex + 1;
                Price one = new Price(100000);
                harga = one.harga;
                total = harga * jumlahbarang;
            }

            pilihan = radioButton7.Checked;
            if (radioButton7.Checked)
            {
                //harga = 50000;
                jumlahbarang = comboJumlah.SelectedIndex + 1;
                Price one = new Price(50000);
                harga = one.harga;
                total = harga * jumlahbarang;
            }

            pilihan = radioButton8.Checked;
            if (radioButton8.Checked)
            {
                //harga = 60000;
                jumlahbarang = comboJumlah.SelectedIndex + 1;
                Price one = new Price(60000);
                harga = one.harga;
                total = harga * jumlahbarang;
            }

            pilihan = radioButton9.Checked;
            if (radioButton9.Checked)
            {
                //harga = 80000;
                jumlahbarang = comboJumlah.SelectedIndex + 1;
                Price one = new Price(80000);
                harga = one.harga;
                total = harga * jumlahbarang;
            }

            textBox1.Text = "Terimakasih sudah membeli. Total harganya : " + total;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = String.Empty;
        }
    }
}
