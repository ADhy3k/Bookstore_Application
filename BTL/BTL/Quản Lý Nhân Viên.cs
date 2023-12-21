using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;
using BTL.BUS;
using BTL.connect;

namespace BTL
{
    public partial class Quản_Lý_Nhân_Viên : Form
    {
        public Quản_Lý_Nhân_Viên()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Trang_Chủ frmdn = new Trang_Chủ();
            frmdn.Show();
            this.Hide();
        }

        private void txtMaNv_TextChanged(object sender, EventArgs e)
        {

        }
        nhanVien nvb = new nhanVien();
        private void btnThem_Click(object sender, EventArgs e)
        {
            int luongnv = 0;
            try
            {
                luongnv = int.Parse(txtLuong.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show("Kiểu dữ liệu của lương phải là kiểu số !");
            }
            if (txtMaNv.Text.Trim() == "")
                MessageBox.Show("Mã nhân viên không được để trống !");
            else if (txtTenNv.Text.Trim() == "")
                MessageBox.Show("Tên nhân viên không được để trống !");
            else if (txtDiachi.Text.Trim() == "")
                MessageBox.Show("Địa chỉ không được để trống !");
            else if (textBox1.Text.Trim() == "")
                MessageBox.Show("số điện thoại không được để trống !");
            else if (luongnv == 0)
                MessageBox.Show("Thêm thất bại !");
            else
                nvb.insertNV(txtMaNv.Text, txtTenNv.Text, dtpNgaysinh.Value.ToString("dd/MM/yyyy"), txtDiachi.Text, luongnv, comboBox1.Text, textBox1.Text);
            label2.Text = dtpNgaysinh.Value.ToString("dd/MM/yyyy");
        }
        
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Quản_Lý_Nhân_Viên_Load(object sender, EventArgs e)
        {
            CNT cn = new CNT();
            string query;
            query = "SELECT ca FROM CA";
            DataTable dt = new DataTable();
            SqlConnection conn = cn.getConnect();
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
            SqlDataAdapter da = new SqlDataAdapter(query, conn);
            da.Fill(dt);
            comboBox1.DataSource = dt;
            comboBox1.DisplayMember = "ca";
            comboBox1.ValueMember = "ca";
            conn.Close();
        }
        
        private void btnExportExcel_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Mã Nhân Viên: " + txtMaNv.Text + System.Environment.NewLine + System.Environment.NewLine + "Họ Tên NV: " + txtTenNv.Text + System.Environment.NewLine + System.Environment.NewLine + "Ngày Sinh NV: " + label2.Text + System.Environment.NewLine + System.Environment.NewLine + " Địa Chỉ Thường Trú: " + txtDiachi.Text + System.Environment.NewLine + System.Environment.NewLine + " Lương Tháng: " + txtLuong.Text + System.Environment.NewLine + System.Environment.NewLine + " Ca Trực: " + comboBox1.Text + System.Environment.NewLine + System.Environment.NewLine + " Số Điện Thoại: " + textBox1.Text + System.Environment.NewLine + System.Environment.NewLine, "Xuất Thông Tin Nhân Viên", MessageBoxButtons.OK);
        }

        private void txtTenNv_TextChanged(object sender, EventArgs e)
        {

        }

        private void dtpNgaysinh_ValueChanged(object sender, EventArgs e)
        {

        }

        private void txtDiachi_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtLuong_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void dgvNhanVien_Click(object sender, EventArgs e)
        {
            
        }
        private void dgvNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void dgvNhanVien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int row = e.RowIndex;
            if (row >= 0)
            {
                txtMaNv.Text = dgvNhanVien.Rows[row].Cells[0].Value.ToString();
                txtTenNv.Text = dgvNhanVien.Rows[row].Cells[1].Value.ToString();
                label2.Text = dgvNhanVien.Rows[row].Cells[2].Value.ToString();
                txtDiachi.Text = dgvNhanVien.Rows[row].Cells[3].Value.ToString();
                txtLuong.Text = dgvNhanVien.Rows[row].Cells[4].Value.ToString();
                comboBox1.Text = dgvNhanVien.Rows[row].Cells[5].Value.ToString();
                textBox1.Text = dgvNhanVien.Rows[row].Cells[6].Value.ToString();
            }
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            dgvNhanVien.DataSource = nvb.Search(txtSearch.Text);
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            int luongnv = 0;
            try
            {
                luongnv = int.Parse(txtLuong.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show("Kiểu dữ liệu của lương phải là kiểu số !");
            }
            if (txtMaNv.Text.Trim() == "")
                MessageBox.Show("Mã nhân viên không được để trống !");
            else if (txtTenNv.Text.Trim() == "")
                MessageBox.Show("Tên nhân viên không được để trống !");
            else if (txtDiachi.Text.Trim() == "")
                MessageBox.Show("địa chỉ không được để trống !");
            else if (textBox1.Text.Trim() == "")
                MessageBox.Show("số điện thoại không được để trống !");
                   
            else if (luongnv == 0)
                MessageBox.Show("Sửa thất bại !");
            else
                nvb.updateNV(txtMaNv.Text, txtTenNv.Text, dtpNgaysinh.Value.ToString("dd/MM/yyyy"), txtDiachi.Text, luongnv, comboBox1.Text, textBox1.Text);
            label2.Text = dtpNgaysinh.Value.ToString("dd/MM/yyyy");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CNT cn = new CNT();
            string query;
            query = "SELECT maNV, tenNV, ngaysinh, diachi, luong, ca, sdt FROM NHANVIEN";
            DataTable dt = new DataTable();
            SqlConnection conn = cn.getConnect();
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
            SqlDataAdapter da = new SqlDataAdapter(query, conn);
            da.Fill(dt);
            dgvNhanVien.DataSource = dt;
            conn.Close();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            nvb.deleteNV(txtMaNv.Text);
        }

        private void btnreset_Click(object sender, EventArgs e)
        {
            txtDiachi.Text = "";
            txtLuong.Text = "";
            txtMaNv.Text = "";
            txtSearch.Text = "";
            txtTenNv.Text = "";
            textBox1.Text = "";

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lblLuong_Click(object sender, EventArgs e)
        {

        }

        private void lblDiachi_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblNgaysinh_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
