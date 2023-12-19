using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTL
{
    public partial class Quản_Lý_Nhân_Viên : Form
    {
        public Quản_Lý_Nhân_Viên()
        {
            InitializeComponent();
        }

        private void cbxDuan_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbxPhongban_SelectedIndexChanged(object sender, EventArgs e)
        {

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

        private void btnExportExcel_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Mã Nhân Viên : " + txtMaNv.Text + System.Environment.NewLine + System.Environment.NewLine + "Họ tên nhân viên : " + txtTenNv.Text + System.Environment.NewLine + System.Environment.NewLine + "Ngày Sinh : " + dtpNgaysinh.Value + System.Environment.NewLine + System.Environment.NewLine + " Địa chỉ : " + txtDiachi.Text + System.Environment.NewLine + System.Environment.NewLine + " Lương nhân viên : " + txtLuong.Text + System.Environment.NewLine + System.Environment.NewLine + " Ca Trực : " + values  + System.Environment.NewLine + System.Environment.NewLine, "Xuất Bill Thành Công", MessageBoxButtons.OK);
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

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            radioButton1.Checked = true;
            values = "sáng";

        }
        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            radioButton2.Checked = true;
            values = "Trưa";
        }
        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            radioButton3.Checked = true;
            values = "Tối";
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        string values;
        private void Quản_Lý_Nhân_Viên_Load(object sender, EventArgs e)
        {

        }
    }
}
