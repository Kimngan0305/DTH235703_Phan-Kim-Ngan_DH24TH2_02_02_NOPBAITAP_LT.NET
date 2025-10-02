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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            int n = Form1.N;
            Random rnd = new Random();

            int[] arr = new int[n];
            for (int i = 0; i < n; i++)
                arr[i] = rnd.Next(n, n + 12);

            txtmang.Text = string.Join(" ", arr);

            var soChan = arr.Where(x => x % 2 == 0).ToArray();
            txtsochan.Text = string.Join(" ", soChan);
        }

        private void btndong_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }

}
