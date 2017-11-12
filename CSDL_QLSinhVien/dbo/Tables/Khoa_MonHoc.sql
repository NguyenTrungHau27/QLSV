CREATE TABLE [dbo].[Khoa_MonHoc] (
    [MaKhoa] NVARCHAR (10) NOT NULL,
    [MaMH]   NVARCHAR (10) NOT NULL,
    CONSTRAINT [PK_Khoa_MonHoc] PRIMARY KEY CLUSTERED ([MaKhoa] ASC, [MaMH] ASC),
    CONSTRAINT [FK_Khoa_MonHoc_Khoa1] FOREIGN KEY ([MaKhoa]) REFERENCES [dbo].[Khoa] ([MaKhoa]),
    CONSTRAINT [FK_Khoa_MonHoc_MonHoc] FOREIGN KEY ([MaMH]) REFERENCES [dbo].[MonHoc] ([MaMH])
);

