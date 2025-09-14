using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai2._8
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
            txtKetQua.Text = tong.ToString();
        }

        private void btnHieu_Click(object sender, EventArgs e)
        {
            ThongTin(out int a, out int b);
            int hieu = a - b;
            txtKetQua.Text = hieu.ToString();
        }

        private void btnTich_Click(object sender, EventArgs e)
        {
            ThongTin(out int a, out int b);
            int tich = a * b;
            txtKetQua.Text = tich.ToString();
        }

        private void btnThuong_Click(object sender, EventArgs e)
        {
            ThongTin(out int a, out int b);
            if (b != 0)
            {
                float thuong = (float)a / b;
                txtKetQua.Text = thuong.ToString();
            }
            else
            {
                MessageBox.Show("Khong the chia cho 0");
            }
        }
    }
}
