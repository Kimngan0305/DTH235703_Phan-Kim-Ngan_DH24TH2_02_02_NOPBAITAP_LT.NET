using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bai3._2TH2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnThongBao_Click(object sender, EventArgs e)
        {
            int thang = int.Parse(txtThang.Text);
            string mua;

            switch (thang)
            {
                case 1:
                case 2:
                case 3:
                    mua = "Mùa xuân"; break;
                case 4:
                case 5:
                case 6:
                    mua = "Mùa hạ"; break;
                case 7:
                case 8:
                case 9:
                    mua = "Mùa thu"; break;
                case 10:
                case 11:
                case 12:
                    mua = "Mùa đông"; break;
                default:
                    mua = "Tháng không hợp lệ"; break;
            }

            MessageBox.Show(mua, "Mùa trong năm");
        }
    }
}
