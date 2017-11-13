using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace QLSV
{
    public partial class Xemdiem : Form
    {
        public Xemdiem()
        {
            InitializeComponent();
        }

        private void Xemdiem_Load(object sender, EventArgs e)
        {
            DangNhap.cn.Open();
            string path = Application.StartupPath + @"\Images\";
            picSinhVien.Image = Image.FromFile(path + DangNhap.mssv.ToString() + ".jpg");
            lbMSSV.Text = DangNhap.mssv;

            //Lấy họ và tên của sinh viên
            string s = "EXEC GetInfo '" + DangNhap.mssv + "'";
            SqlCommand cmd = new SqlCommand(s, DangNhap.cn);
            lbHoTen.Text = cmd.ExecuteScalar().ToString();

            DataTable table = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("EXEC TestXemDiem '" + DangNhap.mssv + "'", DangNhap.cn);
            da.Fill(table);
            dlgXemdiem.DataSource = table;
            
        }

        private void Xemdiem_FormClosed(object sender, FormClosedEventArgs e)
        {
            DangNhap.cn.Close();
        }
    }
}
