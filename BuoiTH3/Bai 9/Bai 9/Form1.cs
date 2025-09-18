using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai_9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtemail_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void btnhien_Click(object sender, EventArgs e)
        {
            string hoTen = txthoten.Text;
            string gioiTinh = rdonam.Checked ? "Nam" : "Nữ";
            string ngaySinh = dtpNgaySinh.Text;
            string diaChi = txtdiachi.Text;
            string dienThoai = txtdienthoai.Text;
            string email = txtemail.Text;
            string tinhTrang = rdohoc.Checked ? "Đang đi học" : "Đang đi làm";

            string thongTin = "Họ tên: " + hoTen +
                              "\nGiới tính: " + gioiTinh +
                              "\nNgày sinh: " + ngaySinh +
                              "\nĐịa chỉ: " + diaChi +
                              "\nĐiện thoại: " + dienThoai +
                              "\nEmail: " + email +
                              "\nTình trạng: " + tinhTrang;

            MessageBox.Show(thongTin, "Thông tin cá nhân");
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
