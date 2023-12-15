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
    public class nhanVien
    {
        CNT dt = new CNT();
        public DataTable getNhanvien()
        {
            DataTable da = null;
            String sql = "Select * from NhanVien ";
            da = dt.getTable(sql);
            return da;
        }
        public void insertNV(String manv, String tennv, String ngaysinh, String diachi, int luong, String ca)
        {
            String sql = " insert into NHANVIEN values('" + manv + "',N'" + tennv + "','" + ngaysinh + "',N'" + diachi + "','" + luong + "',N'" + ca + "')";
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
        public void updateNV(String manv, String tennv, String ngaysinh, String diachi, int luong, String ca)
        {
            String sql = "UPDATE NHANVIEN set tenNV=N'" + tennv + "',ngaysinh='" + ngaysinh + "',diachi=N'" + diachi + "',luong='" + luong + "',ca='"+ ca + "' where maNV='" + manv + "'";
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
        public void deleteNV(String manv)
        {
            String sql = "delete NHANVIEN where maNV='" + manv + "'";
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
            String sql = "Select * from NhanVien where maNV like N'%" + condi + "%' OR tenNV like N'%" + condi + "%'";
            da = dt.getTable(sql);
            return da;
        }
    }
}
