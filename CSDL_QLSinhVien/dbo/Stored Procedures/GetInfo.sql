--Lấy họ và tên của sinh viên
CREATE PROC GetInfo(@mssv nvarchar(10))
AS
	SELECT Ho + ' ' + Ten AS N'Họ và Tên' FROM SinhVien WHERE MaSinhVien = @mssv
