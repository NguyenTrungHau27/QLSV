﻿using System;
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
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string getStr = txtMSSV.Text;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //string path = Directory.GetCurrentDirectory();
            //path = path.Substring(0, path.LastIndexOf('\\') - 3);
            //cn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + path + @"App_data\QLSinhVien.mdf;Integrated Security=True;Connect Timeout=30");
            string s = ConfigurationManager.ConnectionStrings["ketnoi"].ConnectionString;
            cn = new SqlConnection(s);
        }

        private void btDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DangNhap_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn muốn thoát chương trình ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No)
                e.Cancel = true;
        }

        private void btDangNhap_Click(object sender, EventArgs e)
        {

            Connect();
            string sql = "SELECT ID FROM TaiKhoan WHERE ID = '" + txtMSSV.Text + "' and Pass = '" + txtMatKhau.Text + "'";
            SqlCommand cmd = new SqlCommand(sql, cn);
            cmd.CommandType = CommandType.Text;
            mssv = (string)cmd.ExecuteScalar();
            if (mssv != null)
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
