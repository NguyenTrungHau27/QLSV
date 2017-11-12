create proc TestXemDiem(@MSSV nvarchar(10))
as
begin
	select MonHoc.TenMH as N'Tên môn học', Thi.DiemThiGK as N'Điểm thi giữa kỳ', Thi.DiemThiCK as N'Điểm thi cuối kỳ' 
	from Lop, MonHoc, Thi 
    where MonHoc.MaMH = Lop.MaMH and Lop.MaLop = Thi.MaLop and Thi.MaSinhVien = @MSSV
end
