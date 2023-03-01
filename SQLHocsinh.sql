CREATE TABLE HocSinh(
	MaHS varchar(100) not null,
	Ten varchar(100) not null,
	Quequan varchar(255) not null,
	Ngay date not null,
	Cmnd varchar(100) not null,
	Email varchar(100) not null,
	Sdt varchar(100) not null
);

INSERT INTO HocSinh(MaHS, Ten, Quequan, Ngay, Cmnd, Email, Sdt) 
VALUES ('hs01','nva','Ha Noi','2003-05-12','12458','abc123@gmail.com','0325468523');
INSERT INTO HocSinh(MaHS, Ten, Quequan, Ngay, Cmnd, Email, Sdt) 
VALUES ('hs02','nva1','Ha Noi','2003-05-12','12458','abc456@gmail.com','0326588523');
INSERT INTO HocSinh(MaHS, Ten, Quequan, Ngay, Cmnd, Email, Sdt) 
VALUES ('hs03','nva2','Ha Noi','2003-05-12','12458','abc258@gmail.com','0325432623');
INSERT INTO HocSinh(MaHS, Ten, Quequan, Ngay, Cmnd, Email, Sdt) 
VALUES ('hs04','nva3','Ha Noi','2003-05-12','12458','abc369@gmail.com','0325447213');
INSERT INTO HocSinh(MaHS, Ten, Quequan, Ngay, Cmnd, Email, Sdt) 
VALUES ('hs05','nva4','Ha Noi','2003-05-12','12458','abc789@gmail.com','0366468523');

select*from HocSinh