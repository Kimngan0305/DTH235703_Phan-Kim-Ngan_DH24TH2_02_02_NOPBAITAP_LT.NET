using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai_5._4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void radvuong_CheckedChanged(object sender, EventArgs e)
        {
            AnTatCa();
            lblcanh.Visible = txtcanh.Visible = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            AnTatCa();
        }
        private void AnTatCa()
        {
            lblcanh.Visible = txtcanh.Visible = false;
            lblbankinh.Visible = txtbankinh.Visible = false;
            lblchieudai.Visible = txtchieudai.Visible = false;
            lblchieurong.Visible = txtchieurong.Visible = false;
            lbla.Visible = txta.Visible = false;
            lblb.Visible = txtb.Visible = false;
            lblc.Visible = txtc.Visible = false;
        }

        private void radtron_CheckedChanged(object sender, EventArgs e)
        {
            AnTatCa();
            lblbankinh.Visible = txtbankinh.Visible = true;    
        }

        private void radtamgiac_CheckedChanged(object sender, EventArgs e)
        {
            AnTatCa();
            lbla.Visible = txta.Visible = true;
            lblb.Visible = txtb.Visible = true;
            lblc.Visible = txtc.Visible = true;
        }

        private void radchunhat_CheckedChanged(object sender, EventArgs e)
        {
            AnTatCa();
            lblchieudai.Visible = txtchieudai.Visible = true;
            lblchieurong.Visible = txtchieurong.Visible = true;
        }

        private void btnthuchien_Click(object sender, EventArgs e)
        {
            double chuVi = 0, dienTich = 0;
            string kq = "";

            try
            {
                if (radvuong.Checked)
                {
                    double a = double.Parse(txtcanh.Text);
                    chuVi = 4 * a;
                    dienTich = a * a;
                    kq = $"Hình vuông\nChu vi = {chuVi}\nDiện tích = {dienTich}";
                }
                else if (radtron.Checked)
                {
                    double r = double.Parse(txtbankinh.Text);
                    chuVi = 2 * Math.PI * r;
                    dienTich = Math.PI * r * r;
                    kq = $"Hình tròn\nChu vi = {chuVi:F2}\nDiện tích = {dienTich:F2}";
                }
                else if (radchunhat.Checked)
                {
                    double dai = double.Parse(txtchieudai.Text);
                    double rong = double.Parse(txtchieurong.Text);
                    chuVi = 2 * (dai + rong);
                    dienTich = dai * rong;
                    kq = $"Hình chữ nhật\nChu vi = {chuVi}\nDiện tích = {dienTich}";
                }
                else if (radtamgiac.Checked)
                {
                    double a = double.Parse(txta.Text);
                    double b = double.Parse(txtb.Text);
                    double c = double.Parse(txtc.Text);

                    if (a + b > c && a + c > b && b + c > a)
                    {
                        chuVi = a + b + c;
                        double p = chuVi / 2;
                        dienTich = Math.Sqrt(p * (p - a) * (p - b) * (p - c));

                        string loai = "";
                        if (a == b && b == c) loai = "tam giác đều";
                        else if (a == b || a == c || b == c) loai = "tam giác cân";
                        else if (Math.Abs(a * a + b * b - c * c) < 1e-6 ||
                                 Math.Abs(a * a + c * c - b * b) < 1e-6 ||
                                 Math.Abs(b * b + c * c - a * a) < 1e-6)
                            loai = "tam giác vuông";
                        else loai = "tam giác thường";

                        kq = $"Hình tam giác ({loai})\nChu vi = {chuVi}\nDiện tích = {dienTich:F2}";
                    }
                    else
                    {
                        MessageBox.Show("Ba cạnh không hợp lệ để tạo tam giác!");
                        return;
                    }
                }
                else
                {
                    MessageBox.Show("Vui lòng chọn loại hình!");
                    return;
                }

                txtkq.Text = kq;
            }
            catch
            {
                MessageBox.Show("Vui lòng nhập dữ liệu hợp lệ!");
            }

        }

        private void btnreset_Click(object sender, EventArgs e)
        {
            txtcanh.Clear();
            txtbankinh.Clear();
            txtchieudai.Clear();
            txtchieurong.Clear();
            txta.Clear();
            txtb.Clear();
            txtc.Clear();
            txtkq.Clear();

            radvuong.Checked = false;
            radtron.Checked = false;
            radchunhat.Checked = false;
            radtamgiac.Checked = false;

            AnTatCa();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
