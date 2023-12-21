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
    public partial class Trang_Chủ : Form
    {
        public Trang_Chủ()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Quản_Lý_Sách frmdn = new Quản_Lý_Sách();
            frmdn.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Quản_Lý_Nhân_Viên frmdn = new Quản_Lý_Nhân_Viên();
            frmdn.Show();
            this.Hide();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            login frmdn = new login();
            frmdn.Show();
            this.Hide();
        }
    }
}
