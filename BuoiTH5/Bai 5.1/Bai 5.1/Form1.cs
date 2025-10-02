using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai_5._1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private bool LaSoNguyenTo(int n)
        {
            if (n < 2) return false;
            for (int i = 2; i <= Math.Sqrt(n); i++)
                if (n % i == 0)
                    return false;
            return true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {
            int n;
            if (int.TryParse(txtN.Text, out n))
            {
                if (LaSoNguyenTo(n))
                    txtKq1.Text = $"{n} là số nguyên tố.";
                else
                    txtKq2.Text = $"{n} không phải là số nguyên tố.";
            }
            else
            {
                MessageBox.Show("Vui lòng nhập số nguyên hợp lệ!");
            }
        }

        private void lbltim_Click(object sender, EventArgs e)
        {
            
            int n;
            if (int.TryParse(txtN.Text, out n))
            {
                txtKq2.Clear();
                txtKq2.AppendText($"Các số nguyên tố nhỏ hơn {n} là:\r\n");

                for (int i = 2; i < n; i++)
                {
                    if (LaSoNguyenTo(i))
                        txtKq2.AppendText(i + " ");
                }
            }
            else
            {
                MessageBox.Show("Vui lòng nhập số nguyên hợp lệ!");
            }
        }

        

        private void btnlamlai_Click(object sender, EventArgs e)
        {
            txtN.Clear();
            txtKq1.Clear();
            txtN.Focus();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult rs = MessageBox.Show("Bạn có chắc muốn thoát không?", "Xác nhận", MessageBoxButtons.YesNo);
            if (rs == DialogResult.Yes)
                this.Close();
        }
    }
}
