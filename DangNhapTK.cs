using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace QLSV
{
    public class DangNhapTK
    {
      
        public bool CheckUser(string user)
        {
            if (user == null || user =="")
                return false;
            if (user.Length != 10)
                return false;
            foreach (char a in user)
            {
                if (((int)a) < 48 || ((int)a) > 57)
                    return false;
            }
            return true;
        }
        public bool KTDangnhap(string user, string pass)
        {
            string sql = "SELECT ID FROM TaiKhoan WHERE ID = @User and Pass = @Pass";
            SqlCommand cmd = new SqlCommand(sql, DangNhap.cn);
            cmd.CommandType = CommandType.Text;
            if (CheckUser(user))
            {
                cmd.Parameters.Add(new SqlParameter("User", user));
                cmd.Parameters.Add(new SqlParameter("Pass", pass));
                DangNhap.mssv = (string)cmd.ExecuteScalar();
                if (DangNhap.mssv != null)      
                    return true;
            }
            return false;
        }
    }
}
