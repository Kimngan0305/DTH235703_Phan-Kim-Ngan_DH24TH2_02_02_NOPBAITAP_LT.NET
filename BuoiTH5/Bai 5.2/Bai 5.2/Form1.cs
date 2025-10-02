using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai_5._2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnsohoanhao_Click(object sender, EventArgs e)
        {
            int n;
            if (!int.TryParse(txtnhap.Text, out n))
            {
                MessageBox.Show("Vui lòng nhập số nguyên hợp lệ!");
                return;
            }

            if (LaSoHoanHao(n))
                MessageBox.Show($"{n} là số hoàn hảo.");
            else
                MessageBox.Show($"{n} không phải là số hoàn hảo.");
        }

        private bool LaSoHoanHao(int n)
        {
            if (n <= 0) return false;

            int tong = 0;
            for (int i = 1; i <= n / 2; i++)
            {
                if (n % i == 0)
                    tong += i;
            }

            return tong == n;
        }
    }
}
