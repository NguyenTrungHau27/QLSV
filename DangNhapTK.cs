using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace QLSV
{
    class DangNhapTK
    {
        string pass;
        string tk;
        public DangNhapTK(string user, string password)
        {
            this.tk = user;
            this.pass = password;
        }
        public string Dangnhap()
        {
            string sql = "SELECT ID FROM TaiKhoan WHERE ID = @User and Pass = @Pass";
            SqlCommand cmd = new SqlCommand(sql, DangNhap.cn);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add(new SqlParameter("User", tk));
            cmd.Parameters.Add(new SqlParameter("Pass", pass));

            return DangNhap.mssv = (string)cmd.ExecuteScalar();
            
        }
    }
}
