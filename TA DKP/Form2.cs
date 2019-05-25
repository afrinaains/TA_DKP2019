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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        public Form2(string text)
        {
            Text = text;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            textBox1.Text = "=== LIST TONER ===";
            textBox1.Text = "Green persimmon pore toner : Rp75000";
            textBox1.Text = "Jeju Volcanic pore toner : Rp100000";
            textBox1.Text = "Jeju orchid skin : Rp90000";
            textBox1.Text = "=== LIST MASKER ===";
            textBox1.Text = "Volcanic color clay mask : Rp110000";
            textBox1.Text = "Jeju volcanic pore clay mask : Rp120000";
            textBox1.Text = "Black green tea mask : Rp100000";
            textBox1.Text = "=== LIST FACE WASH ===";
            textBox1.Text = "Jeju volcanic pore cleansing foam : Rp50000";
            textBox1.Text = "Volcanic pore scrub foam : Rp60000";
            textBox1.Text = "Olive real cleansing foam : Rp80000";
            f1.Show();
            this.Hide();
        }
    }
}
