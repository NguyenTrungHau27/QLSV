Create Proc TimLichThi
	@MaMH nvarchar(10), @MSSV nvarchar(10)
AS
	Select Thi.*, MonHoc.TenMH
	From Thi, Lop, MonHoc
	WHERE Lop.MaLop = Thi.MaLop and Lop.MaMH = MonHoc.MaMH AND Lop.MaMH =@MaMH AND Thi.MaSinhVien = @MSSV
