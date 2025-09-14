using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai2._6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void ThongTin(out int a, out int b)
        {
            a = int.Parse(txta.Text);
            b = int.Parse(txtb.Text);
        }


        private void btnTong_Click(object sender, EventArgs e)
        {
            ThongTin(out int a, out int b);
            int tong = a + b;
            MessageBox.Show("Tong hai so la: " + tong);

        }

        private void btnHieu_Click(object sender, EventArgs e)
        {
            ThongTin(out int a, out int b);
            int hieu = a - b;
            MessageBox.Show("Hieu hai so la: " + hieu);
        }

        private void btnTich_Click(object sender, EventArgs e)
        {
            ThongTin(out int a, out int b);
            int tich = a * b;
            MessageBox.Show("Tich hai so la: " + tich);
        }

        private void btnThuong_Click(object sender, EventArgs e)
        {
            ThongTin(out int a, out int b);
            if (b != 0)
            {
                float thuong = (float)a / b;
                MessageBox.Show("Thuong hai so la: " + thuong);
            }
            else
            {
                MessageBox.Show("Khong the chia cho 0");
            }
        }
    }
}
