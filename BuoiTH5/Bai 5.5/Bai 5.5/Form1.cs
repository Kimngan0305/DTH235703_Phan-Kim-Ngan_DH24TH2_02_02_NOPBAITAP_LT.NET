using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai_5._5
{
    public partial class Form1 : Form
    {
        int[] arr;
        Random rand = new Random();
        public Form1()
        {
            InitializeComponent();
        }

        private void btntim_Click(object sender, EventArgs e)
        {
            if (arr == null) return;
            lblkq.Text = $"Phần tử nhỏ nhất = {arr.Min()}";
        }

        private void btnxuat_Click(object sender, EventArgs e)
        {
            arr = new int[10];
            for (int i = 0; i < arr.Length; i++)
                arr[i] = rand.Next(1, 100);

            lblmang.Text = string.Join("  ", arr);
            lblkq.Text = "Đã tạo mảng ngẫu nhiên.";
        }

        private void btntinhtong_Click(object sender, EventArgs e)
        {
            if (arr == null) return;
            lblkq.Text = $"Tổng giá trị mảng = {arr.Sum()}";
        }

        private void btndem_Click(object sender, EventArgs e)
        {
            if (arr == null) return;
            int demLe = arr.Count(x => x % 2 != 0);
            lblkq.Text = $"Số phần tử lẻ = {demLe}";
        }

        private void btntong_Click(object sender, EventArgs e)
        {
            if (arr == null) return;
            int tongLe = arr.Where(x => x % 2 != 0).Sum();
            lblkq.Text = $"Tổng các phần tử lẻ = {tongLe}";
        }

        private void btntang_Click(object sender, EventArgs e)
        {
            if (arr == null) return;
            for (int i = 0; i < arr.Length; i++)
                arr[i] += 2;

            lblmang.Text = string.Join("  ", arr);
            lblkq.Text = "Đã tăng mỗi phần tử lên 2.";
        }

        private void btnsaptang_Click(object sender, EventArgs e)
        {
            if (arr == null) return;
            Array.Sort(arr);
            lblmang.Text = string.Join("  ", arr);
            lblkq.Text = "Mảng đã sắp xếp tăng dần.";
        }

        private void btnsapgiam_Click(object sender, EventArgs e)
        {
            if (arr == null) return;
            Array.Sort(arr);
            Array.Reverse(arr);
            lblmang.Text = string.Join("  ", arr);
            lblkq.Text = "Mảng đã sắp xếp giảm dần.";
        }
    }
}
