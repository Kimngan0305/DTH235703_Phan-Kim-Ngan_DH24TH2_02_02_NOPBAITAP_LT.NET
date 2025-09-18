using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bai3._4TH2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGiai_Click(object sender, EventArgs e)
        {
            try
            {
                double a = double.Parse(txtA.Text);
                double b = double.Parse(txtB.Text);
                double c = double.Parse(txtC.Text);

                string ketqua = "";

                if (a == 0)
                {
                    // Phương trình bậc 1
                    if (b == 0)
                    {
                        if (c == 0) ketqua = "PT có vô số nghiệm";
                        else ketqua = "PT vô nghiệm";
                    }
                    else
                    {
                        double x = -c / b;
                        ketqua = "PT bậc 1, nghiệm x = " + x;
                    }
                }
                else
                {
                    double delta = b * b - 4 * a * c;
                    if (delta < 0)
                        ketqua = "PT vô nghiệm";
                    else if (delta == 0)
                    {
                        double x = -b / (2 * a);
                        ketqua = "PT có nghiệm kép: x = " + x;
                    }
                    else
                    {
                        double x1 = (-b + Math.Sqrt(delta)) / (2 * a);
                        double x2 = (-b - Math.Sqrt(delta)) / (2 * a);
                        ketqua = $"PT có 2 nghiệm: x1 = {x1}; x2 = {x2}";
                    }
                }

                txtKq.Text = ketqua;
            }
            catch
            {
                MessageBox.Show("Vui lòng nhập số hợp lệ!", "Lỗi");
            }
        }
    }
}
   
