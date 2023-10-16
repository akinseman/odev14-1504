using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace odev14_1504
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void ratek_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double tutar;
            tutar = Convert.ToDouble(txtsayi.Text);
            if (ratakit1.Checked == true || ratasit2.Checked  == true)

            {
                tutar = tutar + (tutar * 0.05);

            }
            if (ratasit3.Checked == true || ratasit4.Checked== true)
            {
                tutar = tutar + (tutar * 0.10);
            }
            MessageBox.Show("DENECEK TOPLAM TUTAR:" + tutar.ToString() + "    tl");
        }

        private void ratasit3_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
