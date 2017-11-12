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
    public partial class DangNhap : Form
    {
        public DangNhap()
        {
            InitializeComponent();
        }
        public static SqlConnection cn = null;
        public static string mssv = null;


        private void Form1_Load(object sender, EventArgs e)
        {
            cn = new SqlConnection(ConfigurationManager.ConnectionStrings["ketnoi"].ConnectionString);
        }

        private void btDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DangNhap_FormClosing(object sender, FormClosingEventArgs e)
        {
            //if (MessageBox.Show("Bạn muốn thoát chương trình ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No)
            //    e.Cancel = true;
        }

        private void btDangNhap_Click(object sender, EventArgs e)
        {
            Connect();
            DangNhapTK dangnhap = new DangNhapTK();
            if (dangnhap.KTDangnhap(txtMSSV.Text, txtMatKhau.Text))
            {
                ChucNang dvsv = new ChucNang();
                dvsv.Show();
            }
            else
                MessageBox.Show("Đăng nhập thất bại");
            disConnect();
        }


        public void Connect()
        {
            try
            {
                if (DangNhap.cn != null && DangNhap.cn.State == ConnectionState.Closed)
                {
                    DangNhap.cn.Open();
                }
                else
                    MessageBox.Show("Server hiện đã được kết nối!");
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Lỗi kết nối \n\n" + ex.Message);
            }
            catch (ConfigurationErrorsException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (InvalidOperationException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void disConnect()
        {
            if (DangNhap.cn != null && DangNhap.cn.State == ConnectionState.Open)
                DangNhap.cn.Close();
        }


    }
}
