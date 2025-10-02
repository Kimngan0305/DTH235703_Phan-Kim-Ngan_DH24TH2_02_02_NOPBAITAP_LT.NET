using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLNV
{
  

    public partial class Form1 : Form
    {
        // Các biến toàn cục
        SqlConnection conn;
        SqlDataAdapter daChucVu, daNhanVien;
        DataSet ds = new DataSet("dsQLNV");
        SqlCommandBuilder cmbNhanVien;
        bool themMoi = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Kết nối CSDL
            conn = new SqlConnection(@"Data Source=(local);Initial Catalog=QLNV;Integrated Security=True");
            conn.Open();
            try
            {
                conn.Open();
                MessageBox.Show("Kết nối thành công!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi kết nối: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
            // Đổ dữ liệu combobox Chức vụ
            string queryChucVu = "SELECT * FROM chucvu";
            daChucVu = new SqlDataAdapter(queryChucVu, conn);
            daChucVu.Fill(ds, "tblChucVu");

            cbochucvu.DataSource = ds.Tables["tblChucVu"];
            cbochucvu.DisplayMember = "tencv";
            cbochucvu.ValueMember = "macv";

            // Đổ dữ liệu bảng Nhân viên
            string queryNhanVien = @"SELECT n.manv, n.holot, n.tennv, n.phai, n.ngaysinh, c.tencv, n.macv
                                     FROM nhanvien n JOIN chucvu c ON n.macv = c.macv";
            daNhanVien = new SqlDataAdapter(queryNhanVien, conn);
            daNhanVien.Fill(ds, "tblDSNhanVien");

            // Cấu hình datagrid
            dgDSNhanVien.DataSource = ds.Tables["tblDSNhanVien"];
            dgDSNhanVien.Columns["manv"].HeaderText = "Mã NV";
            dgDSNhanVien.Columns["holot"].HeaderText = "Họ lót";
            dgDSNhanVien.Columns["tennv"].HeaderText = "Tên";
            dgDSNhanVien.Columns["phai"].HeaderText = "Phái";
            dgDSNhanVien.Columns["ngaysinh"].HeaderText = "Ngày sinh";
            dgDSNhanVien.Columns["tencv"].HeaderText = "Chức vụ";
            dgDSNhanVien.Columns["macv"].Visible = false;

            dgDSNhanVien.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgDSNhanVien.ReadOnly = true;

            // Command thêm nhân viên
            SqlCommand cmThemNV = new SqlCommand(
                "INSERT INTO nhanvien VALUES(@MaNV,@HoLot,@TenNV,@Phai,@NgaySinh,@MaCV)", conn);
            cmThemNV.Parameters.Add("@MaNV", SqlDbType.NVarChar, 10, "manv");
            cmThemNV.Parameters.Add("@HoLot", SqlDbType.NVarChar, 30, "holot");
            cmThemNV.Parameters.Add("@TenNV", SqlDbType.NVarChar, 10, "tennv");
            cmThemNV.Parameters.Add("@Phai", SqlDbType.NVarChar, 3, "phai");
            cmThemNV.Parameters.Add("@NgaySinh", SqlDbType.SmallDateTime, 10, "ngaysinh");
            cmThemNV.Parameters.Add("@MaCV", SqlDbType.NVarChar, 5, "macv");
            daNhanVien.InsertCommand = cmThemNV;

            cmbNhanVien = new SqlCommandBuilder(daNhanVien);
        }

        private void dgDSNhanVien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgDSNhanVien.CurrentRow == null) return;

            DataGridViewRow dr = dgDSNhanVien.CurrentRow;
            txtmaso.Text = dr.Cells["manv"].Value.ToString();
            txtho.Text = dr.Cells["holot"].Value.ToString();
            txtten.Text = dr.Cells["tennv"].Value.ToString();
            if (dr.Cells["phai"].Value.ToString() == "Nam")
                radonam.Checked = true;
            else
                radonu.Checked = true;
            dtpngaysinh.Text = dr.Cells["ngaysinh"].Value.ToString();
            cbochucvu.SelectedValue = dr.Cells["macv"].Value.ToString();
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            themMoi = true;
            txtmaso.Clear();
            txtho.Clear();
            txtten.Clear();
            radonam.Checked = true;
            dtpngaysinh.Value = DateTime.Now;
            cbochucvu.SelectedIndex = 0;
            txtmaso.Focus();
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            themMoi = false;
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            if (dgDSNhanVien.CurrentRow == null)
            {
                MessageBox.Show("Vui lòng chọn nhân viên cần xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (MessageBox.Show("Bạn có chắc muốn xóa nhân viên này?", "Xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                dgDSNhanVien.Rows.RemoveAt(dgDSNhanVien.CurrentRow.Index);
            }
        }

        private void btnluu_Click(object sender, EventArgs e)
        {
            if (themMoi)
            {
                DataRow row = ds.Tables["tblDSNhanVien"].NewRow();
                row["manv"] = txtmaso.Text;
                row["holot"] = txtho.Text;
                row["tennv"] = txtten.Text;
                row["phai"] = radonam.Checked ? "Nam" : "Nữ";
                row["ngaysinh"] = dtpngaysinh.Value;
                row["macv"] = cbochucvu.SelectedValue.ToString();
                ds.Tables["tblDSNhanVien"].Rows.Add(row);
            }
            try
            {
                daNhanVien.Update(ds, "tblDSNhanVien");
                MessageBox.Show("Lưu dữ liệu thành công!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi lưu: " + ex.Message);
            }

        }

        private void btnhuy_Click(object sender, EventArgs e)
        {
            ds.Tables["tblDSNhanVien"].RejectChanges();
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
