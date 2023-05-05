using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace burcHesapla
{
    public partial class BurcHesapla : Form
    {
        int gun;
        int ay;
        public BurcHesapla()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            ay = Convert.ToInt16(dateTimePicker1.Value.Month);
            gun = Convert.ToInt16(dateTimePicker1.Value.Day);

        }

        private void button1_Click(object sender, EventArgs e)
        {

            ay = Convert.ToInt16(dateTimePicker1.Value.Month);
            gun = Convert.ToInt16(dateTimePicker1.Value.Day);

            if ((ay == 12 & gun >= 12) || (ay == 1 & gun <= 20))
            {
                TxtBurc.Text = "OĞLAK";

            }

            if ((ay == 9 & gun >= 22) || (ay == 10 & gun <= 23))
            {
                TxtBurc.Text = "TERAZİ";

            }

            if ((ay == 1 & gun >= 21) || (ay == 2 & gun <= 19))
            {
                TxtBurc.Text = "KOVA";

            }

            if ((ay == 2 & gun >= 20) || (ay == 3 & gun <= 20))
            {
                TxtBurc.Text = "BALIK";

            }

            if ((ay == 3 & gun >= 21) || (ay == 4 & gun <= 20))
            {
                TxtBurc.Text = "KOÇ";

            }

            if ((ay == 4 & gun >= 21) || (ay == 5 & gun <= 21))
            {
                TxtBurc.Text = "BOĞA";

            }


            if ((ay == 5 & gun >= 22) || (ay == 6 & gun <= 21))
            {
                TxtBurc.Text = "İKİZLER";
            }

            if ((ay == 6 & gun >= 22) || (ay == 7 & gun <= 23))
            {
                TxtBurc.Text = "YENGEÇ";

            }

            if ((ay == 7 & gun >= 24) || (ay == 8 & gun <= 23))
            {
                TxtBurc.Text = "ASLAN";

            }

            if ((ay == 8 & gun >= 24) || (ay == 9 & gun <= 23))
            {
                TxtBurc.Text = "BAŞAK";
            }


            if ((ay == 102 & gun >= 23) || (ay == 11 & gun <= 22))
            {
                TxtBurc.Text = "AKREP";
            }

            if ((ay == 11 & gun >= 23) || (ay == 12 & gun <= 22))
            {
                TxtBurc.Text = "YAY";
            }
        }
    }
}
