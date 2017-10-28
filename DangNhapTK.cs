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
        string pass;
        string tk;
        public DangNhapTK(string user, string password)
        {
            this.tk = user;
            this.pass = password;
        }
        public bool KTDangnhap()
        {
            DangNhap.cn.Open();
            string sql = "SELECT ID FROM TaiKhoan WHERE ID = @User and Pass = @Pass";
            SqlCommand cmd = new SqlCommand(sql, DangNhap.cn);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add(new SqlParameter("User", tk));
            cmd.Parameters.Add(new SqlParameter("Pass", pass));

            DangNhap.mssv = (string)cmd.ExecuteScalar();
            if (DangNhap.mssv != null)
                return true;
            else
                return false;
            
        }
    }
}
