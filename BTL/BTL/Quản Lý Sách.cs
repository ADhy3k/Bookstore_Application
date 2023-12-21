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
using BTL.connect;
using System.Data.Sql;
using System.Data.SqlClient;

namespace BTL
{
    public partial class Quản_Lý_Sách : Form
    {
        public Quản_Lý_Sách()
        {
            InitializeComponent();
        }
        sach s = new sach();
        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Trang_Chủ frmdn = new Trang_Chủ();
            frmdn.Show();
            this.Hide();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            s.deleteSach(textBox1.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = s.Search(textBox5.Text);
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int giatien = 0;
            try
            {
                giatien = int.Parse(textBox4.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show("Kiểu dữ liệu của giá tiền phải là kiểu số !");
            }
            if (textBox1.Text.Trim() == "")
                MessageBox.Show("Mã Sách không được để trống !");
            else if (textBox2.Text.Trim() == "")
                MessageBox.Show("Tên Sách không được để trống !");
            else if (textBox3.Text.Trim() == "")
                MessageBox.Show("Ngày Xuất Bản không được để trống !");
            else if (giatien == 0)
                MessageBox.Show("Thêm thất bại !");
            else
                s.insertS(textBox1.Text, textBox2.Text, textBox3.Text, comboBox1.Text, textBox6.Text, giatien, textBox7.Text);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void Quản_Lý_Sách_Load(object sender, EventArgs e)
        {
            CNT cn = new CNT();
            string query;
            query = "SELECT theLoai FROM THELOAI";
            DataTable dt = new DataTable();
            SqlConnection conn = cn.getConnect();
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
            SqlDataAdapter da = new SqlDataAdapter(query, conn);
            da.Fill(dt);
            comboBox1.DataSource = dt;
            comboBox1.DisplayMember = "theLoai";
            comboBox1.ValueMember = "theLoai";
            conn.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int giatien = 0;
            try
            {
                giatien = int.Parse(textBox4.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show("Kiểu dữ liệu của giá tiền phải là kiểu số !");
            }
            if (textBox1.Text.Trim() == "")
                MessageBox.Show("Mã Sách không được để trống !");
            else if (textBox2.Text.Trim() == "")
                MessageBox.Show("Tên Sách không được để trống !");
            else if (textBox3.Text.Trim() == "")
                MessageBox.Show("Ngày Xuất Bản không được để trống !");
            else if (giatien == 0)
                MessageBox.Show("Thêm thất bại !");
            else
                s.updateSach(textBox1.Text, textBox2.Text, textBox3.Text, comboBox1.Text, textBox6.Text, giatien, textBox7.Text);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            CNT cn = new CNT();
            string query;
            query = "SELECT * FROM SACH";
            DataTable dt = new DataTable();
            SqlConnection conn = cn.getConnect();
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
            SqlDataAdapter da = new SqlDataAdapter(query, conn);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            conn.Close();
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            int row = e.RowIndex;
            if (row >= 0)
            {
                textBox1.Text = dataGridView1.Rows[row].Cells[0].Value.ToString();
                textBox2.Text = dataGridView1.Rows[row].Cells[1].Value.ToString();
                textBox3.Text = dataGridView1.Rows[row].Cells[2].Value.ToString();
                comboBox1.Text = dataGridView1.Rows[row].Cells[3].Value.ToString();
                textBox6.Text = dataGridView1.Rows[row].Cells[4].Value.ToString();
                textBox4.Text = dataGridView1.Rows[row].Cells[5].Value.ToString();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {

            MessageBox.Show("NHÀ SÁCH ABC "+ System.Environment.NewLine + System.Environment.NewLine + "Mã Sách: " + textBox1.Text + System.Environment.NewLine + System.Environment.NewLine + "Tên Sách: " + textBox2.Text + System.Environment.NewLine + System.Environment.NewLine + "Số: " + textBox7.Text + System.Environment.NewLine + System.Environment.NewLine + "Ngày Xuất Bản: " + textBox3.Text + System.Environment.NewLine + System.Environment.NewLine + " Thể Loại: " + comboBox1.Text + System.Environment.NewLine + System.Environment.NewLine + " Tác Giả: " + textBox6.Text + System.Environment.NewLine + System.Environment.NewLine + " Giá Tiền: " + textBox4.Text + System.Environment.NewLine + System.Environment.NewLine, "Xuất Thông Tin Sách", MessageBoxButtons.OK);
            
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            textBox7.Text = "";
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
