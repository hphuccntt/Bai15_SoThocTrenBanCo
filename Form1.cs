using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai15_SoThocTrenBanCo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnTinh_Click(object sender, EventArgs e)
        {
            int o = Convert.ToInt32(txtSo.Text);
            double tongthoc = 0;


            if (o > 64)
            {
                txtSo.Text = "No! trên bàn có 64 ô thôi: ";

            }
            else
            {
                    while (o > 64 || o < 0) ;
                    for (int i = 0; i < o; i++)
                    {
                        tongthoc = tongthoc + Math.Pow(2, i);
                    }
            }
            txtKQ.Text = tongthoc.ToString();
        }

        private void txtSo_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
