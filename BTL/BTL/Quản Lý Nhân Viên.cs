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
    }
}
