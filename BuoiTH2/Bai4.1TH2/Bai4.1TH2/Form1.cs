using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai4._1TH2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnTinh_Click(object sender, EventArgs e)
        {
            try
            {
                int n = int.Parse(txtN.Text);
                long S = 0;

                // Bài 4.1: S = 1 + 2 + ... + n
                for (int i = 1; i <= n; i++)
                {
                    S += i;
                }

                txtS.Text = S.ToString();
            }
            catch
            {
                MessageBox.Show("Vui lòng nhập số nguyên hợp lệ!");
            }
        }
    }
}
    