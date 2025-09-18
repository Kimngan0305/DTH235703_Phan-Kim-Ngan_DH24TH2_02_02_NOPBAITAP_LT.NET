using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bai3._1TH2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnTinh_Click(object sender, EventArgs e)
        {
            double x = double.Parse(txtX.Text);
            double f;
            if (x >= 2)
                f = 8 * x * x * x - 12 * x - 1;
            else if (x > 1 && x < 2)
                f = x * x - 6 * x - 19;
            else
                f = 7 * x;
            txtF.Text = f.ToString();
        }
    }
}
