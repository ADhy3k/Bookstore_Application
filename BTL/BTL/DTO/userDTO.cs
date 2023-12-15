using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTL.DTO
{
    public class userDTO
    {
        String username;
        String password;
        String gmail;
        public String Username
        {
            get { return username; }
            set { username = value; }
        }
        public String Password
        {
            get { return password; }
            set { password = value; }
        }
        public String Gmail
        {
            get { return gmail; }
            set { gmail = value; }
        }
    }
}
