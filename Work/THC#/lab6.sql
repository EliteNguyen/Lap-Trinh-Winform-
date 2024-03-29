
------------------------------------ Tao Database quan li sinh vien -----------------------------------
Use Master
GO
create database QLSV
--drop database QLSV
GO
use QLSV
--------------------------------------- Tao table SinhVien ----------------------------------------

create table Login
(
	username nvarchar(20) primary key,
	password nvarchar(20) 
)
insert into Login (username, password) values (N'1',N'1')
insert into Login (username, password) values (N'admin',N'admin')

select * from login
create table SinhVien
	(
	 MaSo 		int	not null primary key,
	 Hoten		nvarchar(50),	
	 NgaySinh 	datetime,
	 GioiTinh 	bit, 
	 DiaChi 	nvarchar(50),
	 Dienthoai	int,
	 MaKhoa 	nchar(6) 	not null
	)


----------------------------------------- Tao table Khoa ------------------------------------------

create table Khoa
	(
	 MaKhoa 	nchar(6) 	not null primary key,
	 TenKhoa 	nchar(50)
	)


----------------------------------------- Tao table MonHoc ----------------------------------------
-- drop table Mon
go
create table Mon
	(
	 MaMH 		nchar(6) primary key,
	 TenMH 		nchar(50),
	 SoTiet 		int
	)


---------------------------------------- Tao table KetQua -----------------------------------------

create table KetQua
	(
	 MaSo 		int not null,
	 MaMH 		nchar(6) not null,
	 LanThi 		int	not null,
	 Diem 		int
	)

---------------------------------- Tao rang buoc ve Primary Key -----------------------------------
alter table KetQua 		add constraint 	PK_KQ 	primary key(MaSo,MaMH)

---------------------------------- Tao rang buoc ve Foreign Key -----------------------------------

alter table SinhVien 	add constraint 	F_SV_KH foreign key(MaKhoa) references Khoa(MaKhoa)
alter table KetQua 	add constraint 	F_KQ_SV foreign key(MaSo)   references SinhVien(MaSo)
alter table KetQua 	add constraint 	F_KQ_MH foreign key(MaMH)   references Mon(MaMH)   

------------------------------- Nhap du lieu cho table Khoa ----------------------------------------

insert into Khoa(MaKhoa,TenKhoa) values ('CNTT','Cong nghe thong tin')
insert into Khoa(MaKhoa,TenKhoa) values ('Av','Anh van')
insert into Khoa(MaKhoa,TenKhoa) values ('TR','Triet hoc')


------------------------------- Nhap du lieu cho table Mon ----------------------------------------

insert into Mon(MaMH,TenMH,SoTiet) values ('CSDL','Co so du lieu',45)
insert into Mon(MaMH,TenMH,SoTiet) values ('CTDL','Cau truc du lieu',60)
insert into Mon(MaMH,TenMH,SoTiet) values ('VP','Van phong',60)
insert into Mon(MaMH,TenMH,SoTiet) values ('DT','Dam thoai',60)
insert into Mon(MaMH,TenMH,SoTiet) values ('TH','Triet hoc',60)
insert into Mon(MaMH,TenMH,SoTiet) values ('AV','Anh van so cap',50)


------------------------------- Nhap du lieu cho table SinhVien ----------------------------------------
set dateformat dmy
go


insert into SinhVien values ('91002','Tran Thi Thu','12/04/1975',0,'215/47/20 Tan Hoi',12346,'CNTT')
insert into SinhVien values ('91007','Nguyen Thi Thu Thao','04/02/1975',0,'115 Nguyen Du',44545,'CNTT')
insert into SinhVien values ('91023','Pham Nguyen Anh Huy','05/03/1974',1,'17/6 Tran Phu',657878,'CNTT')
insert into SinhVien  values ('91024','Nguyen Ngoc Thuan','15/06/1975',1,'52 Bau Cat Q.TB',099999,'CNTT')
insert into SinhVien values ('91045','Le Thanh Trung','22/06/1975',1,'23/18 Le Hoang P',66666,'AV')
insert into SinhVien values ('91088','Nguyen Hong Van','12/07/1975',0,'43/17 Tran Hong I',77777,'AV')
insert into SinhVien values ('91102','Vo Thi Kim Loan','04/02/1974',0,'69 Trung Nho',888,'AV')
insert into SinhVien values ('91109','Truong Kim Quang','21/04/1972',1,'Le Quang Noi',9999,'AV')
insert into SinhVien values ('91120','Tran That Quyen','26/06/1971',1,'340/4 Nhon Hoa',676767,'AV')
insert into SinhVien values ('91133','Ha Thi Giang Long','23/07/1976',0,'43A Trang Tien',67777,'AV')
insert into SinhVien values ('92001','Bui Van Thanh','30/09/1977',1,'466 Hong Phuc',56565,'CNTT')
insert into SinhVien values ('92013','Le Huu Chi','19/11/1977',1,'236 Vo Thi Sau',78778,'AV')
insert into SinhVien values ('92002','Vo Thanh Cong','27/06/1977',1,'B8 Cx 155 Ton Hien',899898,'CNTT')
insert into SinhVien values ('92025','Tran Quang Cuong','25/03/1978',1,'516 Le Van Sy',65656,'CNTT')
insert into SinhVien values ('92027','Phan Van Hai','04/01/1977',1,'322 Xo Viet Nghe Tinh',67676,'AV')
insert into SinhVien values ('92031','Phan Van Hoang','05/01/1977',1,'28 Binh Giao',95555,'CNTT')
insert into SinhVien values ('92048','Huynh Thanh Lam','20/10/1977',1,'243/16 Phu My',6565,'Av')
insert into SinhVien values ('92173','Tran Minh Sang','16/06/1977',1,'49/1 Ho Bieu Chanh',564543,'CNTT')
insert into SinhVien values ('92188','Pham Van Hien','19/05/1976',1,'17/6 Tran Phu',7878787,'AV')
insert into SinhVien values ('92242','Phan Thi Anh Thu','21/12/1977',0,'134 Lac Long Quan',334534,'CNTT')


------------------------------- Nhap du lieu cho table KetQua ----------------------------------------

insert into KetQua(MASO,MaMH,LanThi,Diem) values ('91045','VP',1,7)
insert into KetQua(MASO,MaMH,LanThi,Diem) values ('91088','VP',1,0)
insert into KetQua(MASO,MaMH,LanThi,Diem) values ('91102','VP',1,7)
insert into KetQua(MASO,MaMH,LanThi,Diem) values ('91109','VP',1,9)
insert into KetQua(MASO,MaMH,LanThi,Diem) values ('91120','VP',1,8)
insert into KetQua(MASO,MaMH,LanThi,Diem) values ('91133','VP',1,8)
insert into KetQua(MASO,MaMH,LanThi,Diem) values ('92013','DT',1,4)
insert into KetQua(MASO,MaMH,LanThi,Diem) values ('92027','DT',1,6)
insert into KetQua(MASO,MaMH,LanThi,Diem) values ('92048','DT',1,7)
insert into KetQua(MASO,MaMH,LanThi,Diem) values ('92188','DT',1,9)
insert into KetQua(MASO,MaMH,LanThi,Diem) values ('91023','CSDL',1,4)
insert into KetQua(MASO,MaMH,LanThi,Diem) values ('91024','CSDL',1,7)
insert into KetQua(MASO,MaMH,LanThi,Diem) values ('91007','CSDL',2,6)
insert into KetQua(MASO,MaMH,LanThi,Diem) values ('92001','CTDL',1,5)
insert into KetQua(MASO,MaMH,LanThi,Diem) values ('92013','CTDL',1,7)
insert into KetQua(MASO,MaMH,LanThi,Diem) values ('92025','CTDL',1,6)
insert into KetQua(MASO,MaMH,LanThi,Diem) values ('92031','CTDL',1,9)
insert into KetQua(MASO,MaMH,LanThi,Diem) values ('92173','CTDL',1,7)
insert into KetQua(MASO,MaMH,LanThi,Diem) values ('92242','CTDL',1,8)
-----------------------
--------------------------


--xem tung bang du lieu
select *from Khoa
select *from Mon
select *from SinhVien
select *from KetQua

--xoa tung bang du lieu ---Dung chay cac cau lenh nay

