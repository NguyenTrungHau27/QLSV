CREATE TABLE [dbo].[Thi] (
    [MaLop]      NVARCHAR (10) NOT NULL,
    [MaSinhVien] NVARCHAR (10) NOT NULL,
    [NgayThi]    DATE          NOT NULL,
    [LanThi]     INT           NOT NULL,
    [PhongThi]   NVARCHAR (10) NULL,
    [CaThi]      NVARCHAR (10) NULL,
    [DiemThiGK]  FLOAT (53)    NULL,
    [DiemThiCK]  FLOAT (53)    NULL,
    CONSTRAINT [PK__Thi1__3B98D273E0937924] PRIMARY KEY CLUSTERED ([MaLop] ASC, [MaSinhVien] ASC, [NgayThi] ASC),
    CONSTRAINT [FK_Thi_Lop] FOREIGN KEY ([MaLop]) REFERENCES [dbo].[Lop] ([MaLop]),
    CONSTRAINT [FK_Thi_SinhVien] FOREIGN KEY ([MaSinhVien]) REFERENCES [dbo].[SinhVien] ([MaSinhVien])
);

