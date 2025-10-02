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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            int n = Form1.N;
            int tong = 0;

            for (int i = 1; i <= n / 2; i++)
                if (n % i == 0)
                    tong += i;

            if (tong == n)
                lblketqua.Text = n + " là số hoàn hảo";
            else
                lblketqua.Text = n + " không phải là số hoàn hảo";
        }

        private void btndong_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
