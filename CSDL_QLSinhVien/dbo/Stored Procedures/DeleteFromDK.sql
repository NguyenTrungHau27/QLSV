--Hủy đăng ký 1 môn học
CREATE PROC DeleteFromDK(@mssv nvarchar(10))
AS
BEGIN
	IF(EXISTS(SELECT * FROM DangKy WHERE MaSinhVien = @mssv))
		DELETE FROM DangKy WHERE MaSinhVien = @mssv
	ELSE
		PRINT N'Không tìm thấy mssv ' + @mssv
END
