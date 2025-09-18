using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai3._3TH2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private bool NamNhuan(int year)
        {
            return (year % 400 == 0 || (year % 4 == 0 && year % 100 != 0));
        }
        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnKiemTra_Click(object sender, EventArgs e)
        {

            int ngay, thang, nam;

            // Kiểm tra nhập số
            if (!int.TryParse(txtNgay.Text.Trim(), out ngay) ||
                !int.TryParse(txtThang.Text.Trim(), out thang) ||
                !int.TryParse(txtNam.Text.Trim(), out nam))
            {
                MessageBox.Show("Vui lòng nhập số nguyên cho Ngày, Tháng, Năm!");
                return;
            }

            bool hopLe = true;
            int soNgayTrongThang = 31; // mặc định

            // Xác định số ngày trong tháng
            switch (thang)
            {
                case 4:
                case 6:
                case 9:
                case 11:
                    soNgayTrongThang = 30;
                    break;
                case 2:
                    // Kiểm tra năm nhuận
                    if ((nam % 400 == 0) || (nam % 4 == 0 && nam % 100 != 0))
                        soNgayTrongThang = 29;
                    else
                        soNgayTrongThang = 28;
                    break;
                case 1:
                case 3:
                case 5:
                case 7:
                case 8:
                case 10:
                case 12:
                    soNgayTrongThang = 31;
                    break;
                default:
                    hopLe = false; // Tháng không hợp lệ
                    break;
            }

            // Kiểm tra ngày
            if (hopLe && (ngay < 1 || ngay > soNgayTrongThang))
            {
                hopLe = false;
            }

            // Thông báo
            if (hopLe)
                MessageBox.Show("Ngày hợp lệ!");
            else
                MessageBox.Show("Ngày KHÔNG hợp lệ!");
        }
    }
}