using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BTL_QLNS.DTO
{
    public class NhanVien_DTO
    {
        String maNv;
        String tenNv;
        String luongNv;
        String diachiNv;
        DateTime ngaysinhNv;
        String ca;
        public String MaNv
        {
            get { return maNv; }
            set { maNv = value; }
        }
        public String TenNv
        {
            get { return tenNv; }
            set { tenNv = value; }
        }
        public String LuongNV
        {
            get { return luongNv; }
            set { luongNv = value; }
        }
        public String DiachiNv
        {
            get { return diachiNv; }
            set { diachiNv = value; }
        }
        public String Ca
        {
            get { return ca; }
            set { ca = value; }
        }
    }
}
