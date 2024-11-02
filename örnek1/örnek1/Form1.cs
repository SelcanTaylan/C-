using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace örnek1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double bakiye ,toplam;
            bakiye = Convert.ToDouble(txtBakiye.Text);
            if (rbTamBilet.Checked)
            {
               if(bakiye == 20)
                {
                    toplam = bakiye - 20;
                    lblKalan.Text = "Kalan Bakiye: " + toplam;
                }
                else
                {
                    toplam = 20 - bakiye;
                    MessageBox.Show(toplam+" Yetersiz Bakiye");
                }
            }
            else if (rbOgretmen.Checked)
            {
                if (bakiye == 14.32)
                {

                    toplam = bakiye - 14.32;
                    lblKalan.Text = "Kalan Bakiye: " + toplam;
                }
                else
                {
                    toplam = 14.32 - bakiye;
                    MessageBox.Show(toplam+" Yetersiz Bakiye");
                }
            }
            else
            {
                if (bakiye == 9.76)
                {

                    toplam = bakiye - 9.76;
                    lblKalan.Text = "Kalan Bakiye: " + toplam;
                }
                else
                {
                    toplam = 9.76 - bakiye;
                    MessageBox.Show(toplam + " Yetersiz Bakiye");
                }
            }
        }
    }
}
