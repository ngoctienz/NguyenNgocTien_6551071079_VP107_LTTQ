CREATE DATABASE DuLieu;
GO

USE DuLieu;
GO

CREATE TABLE MonHoc(
	MaMonHoc NVARCHAR(10) PRIMARY KEY,
	TenMonHoc NTEXT NOT NULL,
	SoTinChi NVARCHAR(5) NOT NULL
);
GO

INSERT INTO MonHoc 
VALUES
	(N'MH001', N'Lập trình C# cơ bản', '3'),
	(N'MH002', N'Cơ sở dữ liệu', '4'),
	(N'MH003', N'Phân tích thiết kế hệ thống', '3'),
	(N'MH004', N'Mạng máy tính', '3');