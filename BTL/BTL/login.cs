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
        user cn = new user();
        public login()
        {
            InitializeComponent();
        }
        user ub = new user();
        private void button1_Click(object sender, EventArgs e)
        {
            String a = "Select * from DANGNHAP";
            DataTable db = ub.getUser(a); ;
            if(db.Rows.Count==0)
            {
                MessageBox.Show("sai");
            }
            bool isMatchFound = false;
            foreach (DataRow it in db.Rows)
            {
                string us = it["username"].ToString();
                string pw = it["password"].ToString();
                
                if (us == textBox1.Text && pw == textBox2.Text)
                {
                    MessageBox.Show(" Đăng nhập Thành Công ");
                    Trang_Chủ dia = new Trang_Chủ();
                    dia.Show();
                    this.Hide();
                }


            }
            if (!isMatchFound)
            {
                MessageBox.Show(" Thông tin chưa chính xác");
                textBox1.Focus();
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

        private void login_Load(object sender, EventArgs e)
        {

        }
    }
}
