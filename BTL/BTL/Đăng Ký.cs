using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BTL.BUS;
using System.Data.SqlClient;

namespace BTL
{
    public partial class Đăng_Ký : Form
    {
        public Đăng_Ký()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            login frmdn = new login();
            frmdn.Show();
            this.Hide();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void Đăng_Ký_Load(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            login frmdn = new login();
            frmdn.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            user ub = new user();
            try
            {
                if (textBox2.Text == textBox3.Text)
                {
                    ub.insertUser(textBox1.Text, textBox3.Text, textBox4.Text);
                    MessageBox.Show("Đăng ký tài khoản thành công !");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Mật khẩu nhập lại không đúng !");
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Bạn nhập sai cú pháp !");
            }
            catch (SqlException)
            {
                MessageBox.Show("Lỗi kết nối CSDL!");
            }
        }
    }
}
