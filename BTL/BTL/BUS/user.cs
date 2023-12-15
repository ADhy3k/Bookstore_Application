using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data.Sql;
using System.Data;
using BTL.connect;
using BTL.DTO;

namespace BTL.BUS
{
    public class user
    {
        userDTO U = new userDTO();
        CNT cn = new CNT();
        public DataTable getUser(String condition)
        {
            DataTable dt = null;
            String sql = "Select * from DANGNHAP where " + condition;
            dt = cn.getTable(sql);
            return dt;
        }
        public void insertUser(String username, String pass, String gmail)
        {
            String sql = "insert into DANGNHAP values('" + username + "','" + pass + "','" + gmail + "')";
            cn.ExcuteNonQuery(sql);
        }
    }
}
