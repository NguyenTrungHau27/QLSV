﻿CREATE TABLE [dbo].[GiangVien] (
    [MaGV]  NVARCHAR (10) NOT NULL,
    [HoGV]  NVARCHAR (50) NULL,
    [TenGV] NVARCHAR (20) NULL,
    CONSTRAINT [PK_GiangVien] PRIMARY KEY CLUSTERED ([MaGV] ASC)
);

