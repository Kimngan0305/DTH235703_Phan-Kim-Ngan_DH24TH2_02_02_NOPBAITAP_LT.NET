using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai2._9
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
        private void btnChuVi_Click(object sender, EventArgs e)
        {
            ThongTin(out int a, out int b);
            int chuVi = (a + b) * 2;
            txtKetQua.Text = chuVi.ToString();
        }

        private void btnDienTich_Click(object sender, EventArgs e)
        {
            ThongTin(out int a, out int b);
            int dienTich = a * b;
            txtKetQua.Text = dienTich.ToString();
        }

        private void btnDuongCheo_Click(object sender, EventArgs e)
        {
            ThongTin(out int a, out int b);
            double duongCheo = Math.Sqrt(a * a + b * b);    
            txtKetQua.Text = duongCheo.ToString();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
