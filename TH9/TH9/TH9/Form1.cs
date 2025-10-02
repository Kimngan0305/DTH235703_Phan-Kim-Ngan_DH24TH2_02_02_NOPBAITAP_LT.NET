using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TH9
{
    public partial class Form1 : Form
    {
        public static int N;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnkiemtra_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtnhap.Text, out N))
            {
                Form2 f2 = new Form2();
                f2.ShowDialog();
            }
            else
            {
                MessageBox.Show("Vui lòng nhập số nguyên hợp lệ!");
            }
        }

        private void btntaomang_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtnhap.Text, out N))
            {
                Form3 f3 = new Form3();
                f3.ShowDialog();
            }
            else
            {
                MessageBox.Show("Vui lòng nhập số nguyên hợp lệ!");
            }
        }

        private void btnlamlai_Click(object sender, EventArgs e)
        {
            txtnhap.Clear();
            txtnhap.Focus();
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void mnuKiemTra_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtnhap.Text, out Form1.N))
            {
                Form2 f2 = new Form2();
                f2.ShowDialog();
            }
            else
            {
                MessageBox.Show("Vui lòng nhập số N hợp lệ!");
            }
        }

        private void mnuTaoMang_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtnhap.Text, out Form1.N))
            {
                Form3 f3 = new Form3();
                f3.ShowDialog();
            }
            else
            {
                MessageBox.Show("Vui lòng nhập số N hợp lệ!");
            }
        }

        private void mnuThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
