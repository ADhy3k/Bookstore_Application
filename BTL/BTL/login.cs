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
using System.Data.Sql;
using BTL.BUS;

namespace BTL
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }
        user ub = new user();
        private void button1_Click(object sender, EventArgs e)
        {
            String condition;
            condition = " username ='" + textBox1.Text + "' AND password ='" + textBox2.Text + "'";
            DataTable dt = new DataTable();
            try
            {
                dt = ub.getUser(condition);
                if (dt.Rows.Count > 0)
                {
                    MessageBox.Show("Đăng nhập thành công !");
                    Trang_Chủ frmmhc = new Trang_Chủ();
                    frmmhc.FormClosed += new FormClosedEventHandler(frmmhc_Closed);
                    frmmhc.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Bạn chưa có tài khoản, hãy đăng ký !");
                    Đăng_Ký frmdk = new Đăng_Ký();
                    frmdk.FormClosed += new FormClosedEventHandler(frmdangky_Closed);
                    frmdk.Show();
                    this.Hide();
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Bạn đã nhập sai cú pháp");
            }
            catch (SqlException)
            {
                MessageBox.Show("Lỗi kết nối CSDL !");
            }
        }

        private void frmmhc_Closed(object sender, FormClosedEventArgs e)
        {
            this.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Đăng_Ký frmdk = new Đăng_Ký();
            frmdk.FormClosed += new FormClosedEventHandler(frmdangky_Closed);
            frmdk.Show();
            this.Hide();
        }

        private void frmdangky_Closed(object sender, FormClosedEventArgs e)
        {
            this.Show();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Quên_Mật_Khẩu frmdn = new Quên_Mật_Khẩu();
            frmdn.Show();
            this.Hide();
        }
    }
}
