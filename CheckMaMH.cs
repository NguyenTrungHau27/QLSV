using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace QLSV
{
    public class Check
    {
        private string MSSV;
        private string MaMH;
        public Check(string MSSV)
        {
            this.MSSV = MSSV;
        }
        public bool CheckMaMH(string MaMH)
        {
            if (MaMH == "" || MaMH == null)
                return false;
            if (MaMH.Length > 10)
                return false;
            return true;
        }

        public List<Object> TimMonHoc(string MaMH)
        {
            DangNhap.cn.Open();
            string sql = "dbo.TimLichThi";
            SqlCommand cmd = new SqlCommand(sql, DangNhap.cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@MSSV", MSSV);
            cmd.Parameters.AddWithValue("@MaMH", MaMH);
            SqlDataReader da = cmd.ExecuteReader();
            List<Object> list = new List<Object>();
            if (da.Read())
            {
                var pro = new
                {
                    Mã_Lớp = da.GetString(0),
                    Môn_Học = da.GetString(8),
                    Ngày_Thi = da.GetDateTime(2),
                    Lần_Thi = da.GetInt32(3),
                    Phòng_Thi = da.GetString(4),
                    Ca_Thi = da.GetString(5)
                };
                list.Add(pro);
            }
            else
                list = null;
            DangNhap.cn.Close();
            return list;
        }

    }
}
