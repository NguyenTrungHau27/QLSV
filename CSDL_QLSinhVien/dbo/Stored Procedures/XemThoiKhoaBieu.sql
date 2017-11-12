create proc [XemThoiKhoaBieu](@MSSV nvarchar(10))
as
begin
	select MonHoc.TenMH as N'Môn học',Lop.NgayBatDauHoc as N'Ngày bắt đầu học', Datename(DW,Lop.NgayBatDauHoc) as N'Thứ', Lop.PhongHoc as N'Phòng Học',Lop.TietBatDau as N'Tiết bắt đầu'
    from Lop, MonHoc , DangKy
    where Lop.MaMH = MonHoc.MaMH and DangKy.MaLop = Lop.MaLop and DangKy.MaSinhVien = @MSSV
end
