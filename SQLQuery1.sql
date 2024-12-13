use ClinicManagement
CREATE TABLE PhanQuyen (
    MaQuyen INT IDENTITY(1,1) PRIMARY KEY,
    TenQuyen VARCHAR(100) NOT NULL
);

CREATE TABLE TaiKhoan (
    MaTK INT IDENTITY(1,1) PRIMARY KEY,
    TaiKhoan VARCHAR(100) NOT NULL,
    MatKhau VARCHAR(100) NOT NULL,
    MaQuyen INT,
    FOREIGN KEY (MaQuyen) REFERENCES PhanQuyen(MaQuyen)
);