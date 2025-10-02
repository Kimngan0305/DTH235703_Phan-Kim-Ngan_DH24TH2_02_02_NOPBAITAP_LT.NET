using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai_5._7
{
    public partial class Form1 : Form
    {
        int[] arr;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnxuat_Click(object sender, EventArgs e)
        {
            string s = txtnhap.Text.Trim();
            arr = s.Select(ch => int.Parse(ch.ToString())).ToArray(); // chuyển từng ký tự thành số
            txtkq.Text = string.Join("", arr);
        }

        private void btnlamlai_Click(object sender, EventArgs e)
        {
            txtnhap.Clear();
            txtkq.Clear();
            txttongmang.Clear();
            txttongchan.Clear();
            txttongle.Clear();
            txtmax.Clear();
            txtmin.Clear();
            txtvitri.Clear();
            txtso.Clear();
            txtnhap.Focus();
        }

        private void btntong_Click(object sender, EventArgs e)
        {
            int tongMang = arr.Sum();
            int tongChan = arr.Where(x => x % 2 == 0).Sum();
            int tongLe = arr.Where(x => x % 2 != 0).Sum();

            txttongmang.Text = tongMang.ToString();
            txttongchan.Text = tongChan.ToString();
            txttongle.Text = tongLe.ToString();
        }

        private void btntim_Click(object sender, EventArgs e)
        {
            txtmax.Text = arr.Max().ToString();
            txtmin.Text = arr.Min().ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (rdotang.Checked)
                Array.Sort(arr); // tăng
            else if (rdogiam.Checked)
            {
                Array.Sort(arr);
                Array.Reverse(arr); // giảm
            }
            txtkq.Text = string.Join("", arr);
        }

        private void btnthaythe_Click(object sender, EventArgs e)
        {
            try
            {
                int vt = int.Parse(txtvitri.Text);
                int gt = int.Parse(txtso.Text);

                if (vt >= 0 && vt < arr.Length)
                {
                    arr[vt] = gt;
                    txtkq.Text = string.Join("", arr);
                }
                else
                {
                    MessageBox.Show("Vị trí không hợp lệ!");
                }
            }
            catch
            {
                MessageBox.Show("Dữ liệu không hợp lệ!");
            }
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
