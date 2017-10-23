using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;
using System.IO;

namespace QLSV
{
    public partial class XemLichThi : Form
    {
        public XemLichThi()
        {
            InitializeComponent();
        }

        private void XemLichThi_Load(object sender, EventArgs e)
        {
            loadThongTinSinhVien();
            dataGvLichThi.DataSource = getData();
        }
        private void getAvatar()
        {
            string path = Application.StartupPath + @"\Images\";
            picSinhVien.Image = Image.FromFile(path + DangNhap.mssv.ToString() + ".jpg");
        }
        public void loadThongTinSinhVien()
        {
            getAvatar();
            DangNhap.cn.Open();
            lbMSSV.Text = DangNhap.mssv;
            string sql = "Select * From SinhVien WHERE MaSinhVien =" + DangNhap.mssv.ToString();
            SqlCommand cmd = new SqlCommand(sql, DangNhap.cn);
            SqlDataReader da = cmd.ExecuteReader();
            while (da.Read())
            {
                lbHoTen.Text = da.GetString(1) + " " + da.GetString(2);
                break;
            }
            DangNhap.cn.Close();
        }
        public List<Object> getData()
        {
            DangNhap.cn.Open();
            string sql = "Select * From Thi WHERE MaSinhVien =" + DangNhap.mssv.ToString();
            SqlCommand cmd = new SqlCommand(sql, DangNhap.cn);
            SqlDataReader da = cmd.ExecuteReader();
            List<Object> list = new List<Object>();
            while (da.Read())
            {
                var pro = new
                {
                    Mã_Lớp = da.GetString(0),
                    Ngày_Thi = da.GetDateTime(2),
                    Lần_Thi = da.GetInt32(3),
                    Phòng_Thi = da.GetString(4),
                    Ca_Thi = da.GetString(5)
                };
                list.Add(pro);
            }
                DangNhap.cn.Close();
                return list;
        }
    }
}
