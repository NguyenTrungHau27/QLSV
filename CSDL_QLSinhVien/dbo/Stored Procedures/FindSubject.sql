--Tìm kiếm môn học
CREATE PROC FindSubject(
	@SubID nvarchar(10),
	@mssv nvarchar(10))
AS
	SELECT MonHoc.* FROM MonHoc, Lop 
	WHERE MonHoc.MaMH = @SubID
	AND MonHoc.MaMH = Lop.MaMH 
	AND Lop.MaLop IN(
	SELECT DangKy.MaLop FROM Lop, DangKy 
	WHERE Lop.MaLop = DangKy.MaLop 
	AND DangKy.MaSinhVien = @mssv)
