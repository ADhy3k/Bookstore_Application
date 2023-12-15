using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;
using BTL.BUS;
using BTL.connect;

namespace BTL
{
    public partial class Quên_Mật_Khẩu : Form
    {
        public Quên_Mật_Khẩu()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            login frmdn = new login();
            frmdn.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            
        }
    }
}
