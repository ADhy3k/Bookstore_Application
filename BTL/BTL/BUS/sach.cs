using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BTL.connect;
using System.Data.SqlClient;
using System.Data;

namespace BTL.BUS
{
    public class sach
    {
        CNT dt = new CNT();
        public DataTable getSach()
        {
            DataTable da = null;
            String sql = "Select * from SACH ";
            da = dt.getTable(sql);
            return da;
        }
        public void insertS(String masach, String tensach, String ngayxb, String theloai, String tacgia, int gia, String so)
        {
            String sql = " insert into SACH values('" + masach + "',N'" + tensach + "',N'" + ngayxb + "',N'" + theloai + "',N'" + tacgia + "',N'" + gia + "', N'" + so + "')";
            try
            {
                dt.ExcuteNonQuery(sql);
                MessageBox.Show("Thêm thành công !");
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Thêm thất bại !");
                MessageBox.Show(ex.Message);
            }
        }
        public void updateSach(String masach, String tensach, String ngayxb, String theloai, String tacgia, int gia, String so)
        {
            String sql = "UPDATE SACH set maSach=N'" + masach + "',tenSach=N'" + tensach + "',manph=N'" + ngayxb + "',theLoai=N'" + theloai + "',tacGia=N'" + tacgia + "', giaTien='" + gia + "', so='" + so + "' where maSach='" + masach + "'";
            try
            {
                dt.ExcuteNonQuery(sql);
                MessageBox.Show("Sửa thành công !");
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Sửa thất bại !");
                MessageBox.Show(ex.Message);
            }
        }
        public void deleteSach(String masach)
        {
            String sql = "delete SACH where maSach='" + masach + "'";
            try
            {
                dt.ExcuteNonQuery(sql);
                MessageBox.Show("Xóa thành công !");
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Lỗi CSDL !" + ex.Message);

            }
        }
        public DataTable Search(String condi)
        {
            DataTable da = null;
            String sql = "Select * from SACH where maSach like N'%" + condi + "%' OR theLoai like N'%" + condi + "%'";
            da = dt.getTable(sql);
            return da;
        }
    }
}
