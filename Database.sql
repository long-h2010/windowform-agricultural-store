create database QUANLYNONGSAN
go

use QUANLYNONGSAN
go

--Sanpham
--Taikhoan
--Khuyenmai
--Tintuc
--Hoadon
--Chitiethoadon

create table TAIKHOAN
(
	tendangnhap varchar(50) PRIMARY KEY,
	hoten nvarchar(100) not null,
	sodienthoai varchar(15) not null,
	matkhau varchar(1000) not null,
	loaitaikhoan int not null default 0,
)
go

create table DANHMUC
(
	id INT IDENTITY PRIMARY KEY,
	tendanhmuc nvarchar(100) not null default N'Chưa đặt tên',
	soluongsanpham int default 0,
)
go

create table SANPHAM
(
	id INT IDENTITY PRIMARY KEY,
	tensanpham nvarchar(100) not null default N'Chưa đặt tên',
	idloaisanpham int not null,
	giasanpham int not null,
	ghichu nvarchar(100),
	hinhanh image default null,

	foreign key (idloaisanpham)  references dbo.DANHMUC(id)
)
go

create table GIOHANG
(
	id INT IDENTITY PRIMARY KEY,
	idsanpham int not null,
	soluong int default 1,

	foreign key (idsanpham)  references dbo.SANPHAM(id)
)
go

create table KHUYENMAI
(
	makhuyenmai varchar(10) not null PRIMARY KEY,
	phantramkm int not null,
	noidungkm nvarchar(max),
)
go

create table TINTUC
(
	id INT IDENTITY PRIMARY KEY,
	tenbaiviet nvarchar(100) not null default N'Chưa đặt tên',
	noidungtt nvarchar(max),
)
go

create table HOADON
(
	id char(12) PRIMARY KEY,
	khachhang varchar(50) not null,
	ngaytao date not null default getdate(),
	tongtien int not null default 0,
	giamgia int default 0,
	thanhtien float default 0,

	foreign key (khachhang)  references dbo.TAIKHOAN(tendangnhap)
)
go

create table CHITIETHOADON
(
	idhoadon char(12),
	idsanpham int,
	soluong int not null default 0,
	dongia int,

	PRIMARY KEY (idhoadon, idsanpham),
	foreign key (idhoadon)  references dbo.HOADON(id),
	foreign key (idsanpham)  references dbo.SANPHAM(id)
)
go

insert into dbo.TAIKHOAN(tendangnhap, hoten, sodienthoai, matkhau, loaitaikhoan)
values ('thaoyi', N'Nguyễn Thị Thanh Thảo', '0939152748', '12345', 0)

insert into dbo.TAIKHOAN(tendangnhap, hoten, sodienthoai, matkhau, loaitaikhoan)
values ('long', N'Huỳnh Đình Long', '09193566328', 'long123', 0)
go

insert into dbo.KHUYENMAI
values ('KM001', 20, N'Khuyến mãi 20% nhân ngày khai trương')
go

insert into dbo.DANHMUC(tendanhmuc)
values (N'Sản phẩm loại 1')
go

insert into dbo.DANHMUC(tendanhmuc)
values (N'Sản phẩm loại 2')
go
/*
Insert dbo.SANPHAM(tensanpham, idloaisanpham, giasanpham, ghichu) 
values (N'Sản phẩm 1', 1, 3000, N'x')
go

Insert dbo.SANPHAM(tensanpham, idloaisanpham, giasanpham, ghichu) 
values (N'Sản phẩm 2', 1, 1000, N'a')
go

Insert dbo.SANPHAM(tensanpham, idloaisanpham, giasanpham, ghichu) 
values (N'Sản phẩm 3', 2, 6000, N'b')
go

Insert dbo.SANPHAM(tensanpham, idloaisanpham, giasanpham, ghichu) 
values (N'Sản phẩm 4', 1, 2000, N'c')
go

Insert dbo.SANPHAM(tensanpham, idloaisanpham, giasanpham, ghichu) 
values (N'Sản phẩm 5', 2, 4000, N'd')
go
*/

create function soluongsanpham(@iddanhmuc int)
returns int
as
begin
	declare @sl int
	set @sl = (select count(id) from dbo.SANPHAM where idloaisanpham = @iddanhmuc)
	return @sl
end
go

/*
update dbo.DANHMUC set soluongsanpham = dbo.soluongsanpham(1) where id = 1
update dbo.DANHMUC set soluongsanpham = dbo.soluongsanpham(2) where id = 2
go
*/
create function createmahoadon(@date date)
returns char(12)
as
begin
	declare @mts char(12)
	declare @d char(8)
	set @d = cast(@date as char(12))
	set @d = replace(@date, '-', '') 
	declare @c int
	set @c = (select count(ngaytao) from dbo.HOADON where ngaytao = @d)
	if @c < 10
		set @mts = @d + '00' + convert(char,@c + 1)
	else if @c < 100
		set @mts = @d + '0' + convert(char,@c + 1)
	else
		set @mts = @d + convert(char,@c + 1)
	return @mts
end
go

set dateformat dmy
insert dbo.HOADON(id, khachhang, ngaytao, giamgia)
values (dbo.createmahoadon('20/10/2022'), 'long', '20/10/2022', 20)
go

create proc usp_GetAccountByUserName
@username varchar(50)
as
begin
	select *from dbo.TAIKHOAN where tendangnhap = @username
end
go

exec dbo.usp_GetAccountByUserName @username = N'thaoyi'

go
create proc usp_Login
@username varchar(50), @password varchar(1000)
as
begin
	select *from dbo.TAIKHOAN where tendangnhap = @username and matkhau = @password
end
go

CREATE FUNCTION [dbo].[non_unicode_convert](@inputVar NVARCHAR(MAX))
RETURNS NVARCHAR(MAX)
AS
BEGIN    
    IF (@inputVar IS NULL OR @inputVar = '')  RETURN ''
   
    DECLARE @RT NVARCHAR(MAX)
    DECLARE @SIGN_CHARS NCHAR(256)
    DECLARE @UNSIGN_CHARS NCHAR (256)
 
    SET @SIGN_CHARS = N'ăâđêôơưàảãạáằẳẵặắầẩẫậấèẻẽẹéềểễệếìỉĩịíòỏõọóồổỗộốờởỡợớùủũụúừửữựứỳỷỹỵýĂÂĐÊÔƠƯÀẢÃẠÁẰẲẴẶẮẦẨẪẬẤÈẺẼẸÉỀỂỄỆẾÌỈĨỊÍÒỎÕỌÓỒỔỖỘỐỜỞỠỢỚÙỦŨỤÚỪỬỮỰỨỲỶỸỴÝ' + NCHAR(272) + NCHAR(208)
    SET @UNSIGN_CHARS = N'aadeoouaaaaaaaaaaaaaaaeeeeeeeeeeiiiiiooooooooooooooouuuuuuuuuuyyyyyAADEOOUAAAAAAAAAAAAAAAEEEEEEEEEEIIIIIOOOOOOOOOOOOOOOUUUUUUUUUUYYYYYDD'
 
    DECLARE @COUNTER int
    DECLARE @COUNTER1 int
   
    SET @COUNTER = 1
    WHILE (@COUNTER <= LEN(@inputVar))
    BEGIN  
        SET @COUNTER1 = 1
        WHILE (@COUNTER1 <= LEN(@SIGN_CHARS) + 1)
        BEGIN
            IF UNICODE(SUBSTRING(@SIGN_CHARS, @COUNTER1,1)) = UNICODE(SUBSTRING(@inputVar,@COUNTER ,1))
            BEGIN          
                IF @COUNTER = 1
                    SET @inputVar = SUBSTRING(@UNSIGN_CHARS, @COUNTER1,1) + SUBSTRING(@inputVar, @COUNTER+1,LEN(@inputVar)-1)      
                ELSE
                    SET @inputVar = SUBSTRING(@inputVar, 1, @COUNTER-1) +SUBSTRING(@UNSIGN_CHARS, @COUNTER1,1) + SUBSTRING(@inputVar, @COUNTER+1,LEN(@inputVar)- @COUNTER)
                BREAK
            END
            SET @COUNTER1 = @COUNTER1 +1
        END
        SET @COUNTER = @COUNTER +1
    END
    -- SET @inputVar = replace(@inputVar,' ','-')
    RETURN @inputVar
END