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

namespace QLSV
{
    public partial class DKMH : Form
    {
        //SqlConnection cn = null;
        SqlCommand cmd = null;
        private int value = 0; //Biến đếm số lượng sinh viên đã đăng ký (tối đa là 4)
        //Query cho dgvDK (Danh sách những môn học có thể đăng ký)
        string sql = "SELECT Lop.MaLop , Lop.MaMH, MonHoc.TenMH, GiangVien.HoGV + ' ' + GiangVien.TenGV AS N'Giảng viên giảng dạy' FROM Lop, MonHoc, GiangVien WHERE Lop.MaMH = MonHoc.MaMH AND Lop.MaGV = GiangVien.MaGV";
        //Query cho dgvListDK (Danh sách môn học đã được đăng ký)
        string sql1 = "SELECT MonHoc.* FROM MonHoc, Lop WHERE MonHoc.MaMH = Lop.MaMH AND Lop.MaLop IN(SELECT DangKy.MaLop FROM Lop, DangKy WHERE Lop.MaLop = DangKy.MaLop AND DangKy.MaSinhVien = '"+ DangNhap.mssv +"')";
        public DKMH()
        {
            InitializeComponent();
        }

        private void DKMH_Load(object sender, EventArgs e)
        {
            //Kết nối
            Connect();
            //Lấy thông thông tin sinh viên
            GetInfo();
            //Lấy ảnh đại diện của sinh viên
            getAvatar();
            //Lấy danh sách môn học
            dgvDK.DataSource = GetData(sql);
            //Lấy danh sách môn học đã đăng ký
            dgvListDK.DataSource = GetData(sql1);
        }
        private void getAvatar()
        {
            string path = Application.StartupPath + @"\Images\";
            picAvatar.Image = Image.FromFile(path + DangNhap.mssv.ToString() + ".jpg");
        }
        //Hàm kết nối
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

        //Hàm ngắt kết nối
        public void disConnect()
        {
            if (DangNhap.cn != null && DangNhap.cn.State == ConnectionState.Open)
                DangNhap.cn.Close();
        }
        //Lấy 1 bảng bất kỳ từ CSDL
        public DataTable GetData(string sql)
        {
            SqlDataAdapter SDA = new SqlDataAdapter(sql, DangNhap.cn);
            DataTable tb = new DataTable();
            SDA.Fill(tb);
            return tb;
        }
        //Lấy dữ liệu từ DataGridView cho TextBox
        private void dgvDK_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                txtIDMH.Text = dgvDK.CurrentRow.Cells["MaMH"].Value.ToString();
                txtNameMH.Text = dgvDK.CurrentRow.Cells["TenMH"].Value.ToString();
                txtClassID.Text = dgvDK.CurrentRow.Cells["MaLop"].Value.ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Hiện tại lỗi này mình chưa biết sửa nên hãy nhấn OK để bỏ qua nhé hì hí hi hì hi :)))))");
            }
        }
        public void GetInfo()
        {
            //Lấy họ và tên của sinh viên
            txtMSSV.Text = DangNhap.mssv;
            string sql = "SELECT [Ho] + ' ' + [Ten] FROM SinhVien WHERE MaSinhVien = '" + txtMSSV.Text + "'";
            cmd = new SqlCommand(sql, DangNhap.cn);
            txtNameSV.Text = cmd.ExecuteScalar().ToString();
        }

        private void btSubmit_Click(object sender, EventArgs e)
        {

            //Query cho thêm vào bảng "Đăng Ký"
            string dk = "INSERT INTO DangKy(MaLop,MaSinhVien,NgayDangky) VALUES(N'" + txtClassID.Text + "',N'" + txtMSSV.Text + "',N'" + dateTimePicker.Value.ToShortTimeString() + "')";
            if (checkClass() <= 4)
            {
                
                if (!FindSubject(txtIDMH.Text)) //Không tìm thấy môn học (Chưa đăng ký)
                {
                    try
                    {
                        //Thêm dữ liệu vào bảng Đăng ký
                        cmd = new SqlCommand(dk, DangNhap.cn);
                        cmd.ExecuteNonQuery();
                        //Cập nhật lại danh sách môn học đã đăng ký thành công
                        dgvListDK.DataSource = GetData(sql1);
                    }
                    catch (SqlException)
                    {
                        MessageBox.Show("Không thể đăng ký lớp " + txtClassID.Text + " vì đã đăng ký rồi" );
                    }
                }
                //Đã đăng ký rồi
                else
                    MessageBox.Show("Môn học này đã được đăng ký!");
            }
            else
                MessageBox.Show("Lớp đã đủ sỉ số");
        }
        //Kiểm tra lớp học đã đc đăng ký hay chưa
        public bool FindSubject(string text)
        {
            for (int i = 0; i < dgvListDK.Rows.Count; i++)
            {
                if (dgvListDK.Rows[i].Cells[0].Value != null && dgvListDK.Rows[i].Cells[0].Value.ToString() == text)
                {
                    return true;
                }
            }
            return false;
        }
        //Kiểm tra sỉ số lớp
        public int checkClass()
        {
            string count = "SELECT COUNT(MaLop) FROM DangKy WHERE MaLop = N'" + txtClassID.Text + "'";
            //Connect();
            cmd = new SqlCommand(count, DangNhap.cn);
            return value = Int32.Parse(cmd.ExecuteScalar().ToString());
        }

        private void btDelete_Click(object sender, EventArgs e)
        {
            try
            {
                //Hủy đăng ký 1 môn học
                string c = dgvListDK.CurrentRow.Cells["MaMH"].Value.ToString();
                string delClass = "DELETE FROM DangKy WHERE MaSinhVien = '" + DangNhap.mssv + "' AND Malop IN(SELECT MaLop FROM Lop WHERE MaMH ='" + c + "')";
                cmd = new SqlCommand(delClass, DangNhap.cn);
                cmd.ExecuteNonQuery();
                //Cập nhật lại danh sách môn học đã đăng ký thành công
                dgvListDK.DataSource = GetData(sql1);
            }
            catch (Exception)
            {
                MessageBox.Show("Hiện tại chưa có môn học nào được đăng ký.");
            }

        }
        private void DKMH_FormClosing(object sender, FormClosingEventArgs e)
        {
            //if (MessageBox.Show("Thoát chương trình ?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No)
            //{
            //    e.Cancel = true;
            //}
            DangNhap.cn.Close();
        }

     
       
    }
}
