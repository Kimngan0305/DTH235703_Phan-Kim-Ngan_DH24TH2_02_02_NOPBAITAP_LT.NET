using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai4._5TH2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txtS_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnTinh_Click(object sender, EventArgs e)
        {

            int n = int.Parse(txtN.Text);
            long S = 0;
            for (int i = 1; i <= n; i++)
                S += 2 * i;       // số chẵn
            txtS.Text = S.ToString();
        }
    }
}
