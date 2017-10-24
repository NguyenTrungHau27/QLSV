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
            getAvatar();
            //ho
            txtMSSV.Text = DangNhap.mssv;
            string sqlHo = "SELECT Ho FROM SinhVien WHERE MaSinhVien ='" + DangNhap.mssv + "'";
            SqlCommand cmd1 = new SqlCommand(sqlHo, DangNhap.cn);
            string ho = (string)cmd1.ExecuteScalar();
            //ten
            string sqlTen = "SELECT Ten FROM SinhVien WHERE MaSinhVien ='" + DangNhap.mssv + "'";
            SqlCommand cmd2 = new SqlCommand(sqlTen, DangNhap.cn);
            cmd2.CommandType = CommandType.Text;
            string ten = (string)cmd2.ExecuteScalar();
            txtNameSV.Text = ho + " " + ten;
           //Lay du lieu
            DataTable table = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(@"select MonHoc.TenMH as N'Tên môn học', Thi.DiemThiGK as N'Điểm thi giữa kỳ', Thi.DiemThiCK as N'Điểm thi cuối kỳ' 
                                                      from Lop, MonHoc, Thi 
                                                      where MonHoc.MaMH = Lop.MaMH and Lop.MaLop = Thi.MaLop and Thi.MaSinhVien = '" + DangNhap.mssv + "'", DangNhap.cn);
            da.Fill(table);
            dlgData.DataSource = table;
            
        }
        private void getAvatar()
        {
            string path = Application.StartupPath + @"\Images\";
            picAvatar.Image = Image.FromFile(path + DangNhap.mssv.ToString() + ".jpg");
        }

        private void Xemdiem_FormClosed(object sender, FormClosedEventArgs e)
        {
            DangNhap.cn.Close();
        }

        private void Xemdiem_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Thoát chương trình ?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No)
            {
                e.Cancel = true;
            }
            DangNhap.cn.Close();
            
        }
    }
}
