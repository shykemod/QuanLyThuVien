create database DuAn1
go
use DuAn1
go
create table Sach
(
	barCodeSach varchar(13) not null primary key,
	tenSach nvarchar(100),
	soLuong int,
	giaTien money,
	namXuatBan date
);
go
create table TacGiaSach
(
	barCodeSach varchar(13) references Sach(barCodeSach),
	hoTen nvarchar(50),
	PRIMARY KEY (barCodeSach, hoTen)
);
go
create table TheLoaiSach
(
	viTriKeSach varchar(10) primary key,
	tenTheLoai nvarchar(50)
);
go
create table chiTietTheLoai
(
	viTriKeSach varchar(10) references TheLoaiSach(viTriKeSach),
	barCode varchar(13) references Sach(barCodeSach)
	primary key (viTriKeSach, barCode)
);
go
create table NhanVien
(
	idNhanVien varchar(10) primary key,
	hoTen nvarchar(50),
	gioiTinh bit,
	soDienThoai varchar(10),
	diaChi nvarchar(150),
	ngaySinh Date,
	email varchar(100),
	trangThai int ---1: hoạt động, 0: nghỉ việc
);
go
create table TaiKhoan
(
	idTaiKhoan uniqueidentifier primary key,
	userName varchar(50),
	[passWord] varchar(50),
	idNhanVien varchar(10) unique references NhanVien(idNhanVien),
	[role] bit ----1: nhân viên, ---2: quản lý
)
go
create table TheThuVien 
(
	idTheThuVien varchar(10) primary key,
	hoTen nvarchar(50),
	soDienThoai varchar(10), 
	diemUyTin int,
	trangThai int, ---1: hoạt động|| 0: khóa thẻ || 2: ngưng hoạt động||
);
go
create table LichSuNap
(
	idLichSu int identity(1,1) primary key,
	soTienNap money,
	diemCongUyTin int,
	ngayNap date,
	idTheThuVien varchar(10) references TheThuVien(idTheThuVien)
);
go
create table MucDiemCong
(
	id int identity(1,1) primary key,
	mucTien money,
	soDiemCong int
);
go
create table PhieuMuon
(	
	idPhieuMuon varchar(10) primary key,
	idTheThuVien varchar(10) unique references TheThuVien(idTheThuVien),
	tongSachMuon int, 
	ngayTaoPhieu date,
	trangThai bit --0: full sách không thể mượn|| 1: còn có thể mượn sách
);
go
create table NhaXuatBan
(
	idNXB varchar(10) primary key,
	tenNXB nvarchar(100),
	diaChi nvarchar(150),
	soDienThoai nvarchar(10)
);
go
create table SachChiTiet
(
	barCodeMaSach varchar(13) primary key,
	barCodeSach varchar(13) references Sach(barCodeSach),
	tinhTrangSach nvarchar(50),
	lanTaiBan int,
	kichCo varchar(20),
	namTaiBan int,
	diemUyTinMin int,
	idNXB varchar(10) references NhaXuatBan(idNXB)
);
go
create table PhieuMuonChiTiet
(
	idPhieuMuonChiTiet int identity(1,1) primary key,
	idPhieuMuon varchar(10) references PhieuMuon(idPhieuMuon),
	idNhanVien varchar(10) references NhanVien(idNhanVien),
	barCodeMaSach varchar(13) references SachChiTiet(barCodeMaSach),
	soLuongSach int,
	ngayMuonSach date,
	ngayTraSach date,
	soLanGiaHan int,
	trangThai int ---0: mượn thành công, -1: mượn thất bại, 2: gia hạn thành công, 3: quá số lần gia hạn
);
go
create table PhieuTraSach
(
	idPhieuTra varchar(10) primary key,
	soLuongTra int,
	thoiGianTraSach date,
	tinhTrangSach nvarchar(50),
	barCodeMaSach varchar(13) references SachChiTiet(barCodeMaSach),
	idPhieuMuon varchar(10) references PhieuMuon(idPhieuMuon),
	trangThai bit
);
go
create table ThietHai
(
	idThietHai varchar(10) primary key,
	tenThietHai nvarchar(50),
	diemTruUyTin int
);
go
create table ThietHaiChiTiet
(
	idThietHai varchar(10) references ThietHai(idThietHai),
	idPhieuTra varchar(10) references PhieuTraSach(idPhieuTra),
	moTa nvarchar(100),
	primary key ( idThietHai, idPhieuTra)
);

go

INSERT INTO Sach (barCodeSach, tenSach, giaTien, namXuatBan)
VALUES
  ('1234567890123', 'Sach 1', 100000, '2020-01-01'),
  ('2345678901234', 'Sach 2', 150000, '2018-03-20')
  
go
INSERT INTO TacGiaSach (barCodeSach, hoTen)
VALUES
  ('1234567890123', 'Nguyen Van A'),
  ('1234567890123', 'Nguyen Van E'),
  ('1234567890123', 'Nguyen Van G'),
  ('2345678901234', 'Nguyen Van B')

go
INSERT INTO TheLoaiSach (viTriKeSach, tenTheLoai)
VALUES
  ('A1', 'Khoa Hoc'),
  ('B2', 'Van Hoc')

go
INSERT INTO chiTietTheLoai (viTriKeSach, barCode)
VALUES
  ('A1', '1234567890123'),
  ('B2', '2345678901234')

go
INSERT INTO NhanVien (idNhanVien, hoTen, gioiTinh, soDienThoai, diaChi, ngaySinh, email, trangThai)
VALUES
  ('NV000', 'Admin', 0, '', '', '', '', 1),
  ('NV001', 'Le Thi C', 0, '0987654321', 'Da Nang', '1988-10-05', 'lethi.c@email.com', 1),
  ('NV002', 'Pham Van D', 1, '0123456789', 'Hue', '1995-02-15', 'phamvan.d@email.com', 1)

go
INSERT INTO TaiKhoan (idTaiKhoan, userName, passWord, idNhanVien, [role])
VALUES
  (NEWID(), 'admin', 'admin', 'NV000', 1),
  (NEWID(), 'user1', 'pass1', 'NV001', 0),
  (NEWID(), 'user2', 'pass2', 'NV002', 0)

go
INSERT INTO TheThuVien (idTheThuVien, hoTen, soDienThoai, diemUyTin, trangThai)
VALUES
  ('TV001', 'Nguyen Van E', '0978123456', 100, 1),
  ('TV002', 'Tran Van F', '0934567890', 80, 0)

go
INSERT INTO LichSuNap (soTienNap, diemCongUyTin, ngayNap, idTheThuVien)
VALUES
  (500000, 50, '2023-01-15', 'TV001'),
  (300000, 30, '2023-02-20', 'TV002')

go
INSERT INTO MucDiemCong (mucTien, soDiemCong)
VALUES
  (100000, 10),
  (50000, 5)

go
INSERT INTO PhieuMuon (idPhieuMuon, idTheThuVien, tongSachMuon, ngayTaoPhieu, trangThai)
VALUES
  ('PM001', 'TV001', 2, '2023-03-01', 1),
  ('PM002', 'TV002', 1, '2023-03-05', 0)


go
INSERT INTO NhaXuatBan (idNXB, tenNXB, diaChi, soDienThoai)
VALUES
  ('NXB001', 'NXB A', 'Hanoi', '0987654321'),
  ('NXB002', 'NXB B', 'Ho Chi Minh City', '0123456789')

go
INSERT INTO SachChiTiet (barCodeMaSach, barCodeSach, tinhTrangSach, lanTaiBan, kichCo, namTaiBan, diemUyTinMin, idNXB)
VALUES
  ('S0001', '1234567890123', 'Moi', 1, '13cm x 19cm', 2022, 80, 'NXB001'),
  ('S0002', '2345678901234', 'Cu', 2, '16cm x 24cm', 2020, 70, 'NXB002')

INSERT INTO PhieuMuonChiTiet (idPhieuMuon, idNhanVien, barCodeMaSach, soLuongSach, ngayMuonSach, ngayTraSach, soLanGiaHan, trangThai)
VALUES
  ('PM001', 'NV001', 'S0001', 1, '2023-03-01', '2023-03-15', 0, 0),
  ('PM002', 'NV002', 'S0001', 1, '2023-03-05', NULL, 0, 1)

INSERT INTO PhieuTraSach (idPhieuTra, soLuongTra, thoiGianTraSach, tinhTrangSach, barCodeMaSach, idPhieuMuon, trangThai)
VALUES
  ('PTS001', 1, '2023-03-15', 'Tot', 'S0002', 'PM001', 1),
  ('PTS002', 1, '2023-03-10', 'Hoi', 'S0002', 'PM002', 0)

INSERT INTO ThietHai (idThietHai, tenThietHai, diemTruUyTin)
VALUES
  ('TH001', 'Mat Sach', 30),
  ('TH002', 'Sach Bi Hu Hong', 20)

INSERT INTO ThietHaiChiTiet (idThietHai, idPhieuTra, moTa)
VALUES
  ('TH001', 'PTS001', 'Mat 1 cuon sach'),
  ('TH002', 'PTS002', 'Sach bi nut gai')

