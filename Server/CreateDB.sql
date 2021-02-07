USE master
GO

/*�������� ���� ������*/

CREATE DATABASE Cinema ON
    (NAME = 'Cinema', FILENAME = 'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\Cinema.mdf',
    SIZE = 5,MAXSIZE = 100, FILEGROWTH = 1)
LOG ON
    (NAME = 'CinemaLog', FILENAME = 'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\CinemaLog.ldf',
    SIZE = 5,MAXSIZE = 100, FILEGROWTH = 1)
GO

USE Cinema
GO

/*�������� �����, ��������� � ������*/

/*��� ��� ���� �������, ������� ��������� ��������� ��� ������� ���� "�������", ���� "VIP"*/

CREATE TYPE TypeClient
FROM NVARCHAR(7) NOT NULL;
GO

CREATE DEFAULT TypeClientDefault
AS '�������'
GO

EXEC sp_bindefault 'TypeClientDefault', 'TypeClient'
GO

CREATE RULE TypeClientRule
AS @x IN ('�������', 'VIP')
GO

EXEC sp_bindrule 'TypeClientRule', 'TypeClient'
GO

/*��� ��� ������� ������, ������� ��������� ��������� ������ ������: "2D", "3D", "2D IMAX", "3D IMAX"*/

CREATE TYPE FormatFilm
FROM NVARCHAR(7) NOT NULL;
GO

CREATE RULE FormatFilmRule
AS @x IN ('2D', '3D', '2D IMAX', '3D IMAX')
GO

EXEC sp_bindrule 'FormatFilmRule', 'FormatFilm'
GO

/*��� ��� �������� ������, ������� ��������� ��������� ������ ������: "G", "PG", "PG-13", "R", "NC-17"*/

CREATE TYPE RatingFilm
FROM NVARCHAR(5) NOT NULL;
GO

CREATE RULE RatingFilmRule
AS @x IN ('G', 'PG', 'PG-13', 'R', 'NC-17')
GO

EXEC sp_bindrule 'RatingFilmRule', 'RatingFilm'
GO

/*��� ��� ������ �������, ������� ��������� ��������� ������ � ������� 0, 5 ��� 10%"*/

CREATE TYPE Discount
FROM NVARCHAR(2) NOT NULL;
GO

CREATE DEFAULT DiscountDefault
AS '0'
GO

EXEC sp_bindefault 'DiscountDefault', 'Discount'
GO

CREATE RULE DiscountRule
AS @x IN ('0', '5', '10')
GO

EXEC sp_bindrule 'DiscountRule', 'Discount'
GO

/*��� ��� ������� �������� �������"*/

CREATE TYPE Phone
FROM NVARCHAR(12) NOT NULL;
GO

CREATE RULE PhoneRule
AS @x LIKE '+7[0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9]'
GO

EXEC sp_bindrule 'PhoneRule', 'Phone'
GO

CREATE TYPE Passport
FROM NVARCHAR(10) NOT NULL;
GO

/*��� ��� ������� ��������� ����������"*/

CREATE RULE PassportRule
AS @x LIKE '[0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9]'
GO

EXEC sp_bindrule 'PassportRule', 'Passport'
GO

/*��� ��� ������� Email �������"*/

CREATE TYPE Email
FROM NVARCHAR(50) NOT NULL;
GO

CREATE RULE EmailRule
AS @x LIKE '[a-z,0-9,_,-]%@[a-z,0-9,_,-]%.[a-z][a-z]%'
GO

EXEC sp_bindrule 'EmailRule', 'Email'
GO

CREATE TYPE CostLicense
FROM money NOT NULL;
GO

CREATE DEFAULT CostLicenseDefault
AS '25000'
GO

EXEC sp_bindefault 'CostLicenseDefault', 'CostLicense'
GO

/*�������� ������*/

CREATE TABLE ������
    (���_������� nvarchar(50) not null,
     ���_������� TypeClient not null,
	 ���������_����� int UNIQUE null,
	 ������ Discount null,
	 Email Email null,
	 �������_������� Phone not null,
	 CONSTRAINT PK_������ PRIMARY KEY (���_�������, �������_�������)
    )

CREATE TABLE ��������
    (�����_�������� int primary key not null,
     ���������_�������� CostLicense not null,
	 ��������_�������� nvarchar(100) not null,
	 ����_�������� date null
    )

CREATE TABLE ���������
    (��������_��������� nvarchar(50) primary key not null,
     ��������_��������� nvarchar(150) not null,
	 �������� money not null
    )

CREATE TABLE ������������
    (ID_������������ int primary key not null,
     ������_������������ nvarchar(50) not null,
	 ��������_������������ nvarchar(50) not null
    )

CREATE TABLE �����
    (�����_������ datetime primary key not null,
     ��������_������ nvarchar(50) not null,
	 ���_������� date not null
    )

CREATE TABLE ���������
    (���_���������� nvarchar(50) not null,
     ����������_������_���������� Passport not null,
	 ��������_��������� nvarchar(50) not null,
	 �����_��������_���������� Phone null,
	 �����_���������� nvarchar(50) not null,
	 CONSTRAINT PK_��������� PRIMARY KEY (���_����������, ����������_������_����������),
     CONSTRAINT FK_���������_��������� FOREIGN KEY (��������_���������) REFERENCES ���������(��������_���������)
    )

CREATE TABLE �����
    (��������_������ nvarchar(50) not null,
	 ���_������� date not null,
	 ������� nvarchar(50) not null,
	 ���� nvarchar(50) not null,
	 ������ FormatFilm not null,
	 ������� RatingFilm not null
	 CONSTRAINT PK_����� PRIMARY KEY (��������_������, ���_�������)
    )

CREATE TABLE ���
    (�����_���� int primary key not null,
     ��������_���� nvarchar(50) not null,
	 ����������_���� int not null
    )

CREATE TABLE ����������_����
    (�����_���� int not null,
     ���_���������� nvarchar(50) not null,
     ����������_������_���������� nvarchar(10) not null,
	 ��������_��������� nvarchar(50) not null
	 CONSTRAINT PK_����������_���� PRIMARY KEY (�����_����, ���_����������, ����������_������_����������)
	 CONSTRAINT FK_����������_����_��� FOREIGN KEY (�����_����) REFERENCES ���(�����_����),
	 CONSTRAINT FK_����������_����_��������� FOREIGN KEY (���_����������, ����������_������_����������) REFERENCES ���������(���_����������, ����������_������_����������)
    )

CREATE TABLE ����������_�����
    (�����_���� int not null,
	 ��������_������ nvarchar(50) not null,
	 ���_������� date not null,
	 CONSTRAINT PK_����������_����� PRIMARY KEY (�����_����, ��������_������, ���_�������),
	 CONSTRAINT FK_����������_�����_��� FOREIGN KEY (�����_����) REFERENCES ���(�����_����),
	 CONSTRAINT FK_����������_�����_����� FOREIGN KEY (��������_������, ���_�������) REFERENCES �����(��������_������, ���_�������)
	)

CREATE TABLE ������_����
    (�����_���� int not null,
     �����_������ datetime not null,
	 CONSTRAINT PK_������_���� PRIMARY KEY (�����_����, �����_������),
	 CONSTRAINT FK_������_����_��� FOREIGN KEY (�����_����) REFERENCES ���(�����_����),
	 CONSTRAINT FK_������_����_����� FOREIGN KEY (�����_������) REFERENCES �����(�����_������)
    )

CREATE TABLE �����_������
    (ID_������������ int not null,
	 ��������_������ nvarchar(50) not null,
	 ���_������� date not null,
	 ���_���������� nvarchar(50) not null,
     ����������_������_���������� Passport not null,
	 ��������_��������� nvarchar(50) not null,
	 CONSTRAINT PK_�����_������ PRIMARY KEY (ID_������������, ��������_������, ���_�������, ���_����������, ����������_������_����������),
	 CONSTRAINT FK_�����_������_������������ FOREIGN KEY (ID_������������) REFERENCES ������������(ID_������������),
	 CONSTRAINT FK_�����_������_��������� FOREIGN KEY (���_����������, ����������_������_����������) REFERENCES ���������(���_����������, ����������_������_����������),
	 CONSTRAINT FK_�����_������_����� FOREIGN KEY (��������_������, ���_�������) REFERENCES �����(��������_������, ���_�������)
    )

CREATE TABLE ������������_��������
    (�����_�������� int UNIQUE not null,
	 ��������_������ nvarchar(50) not null,
	 ���_������� date not null,
	 ���_���������� nvarchar(50) not null,
     ����������_������_���������� nvarchar(10) not null,
	 ��������_��������� nvarchar(50) not null,
	 CONSTRAINT PK_������������_�������� PRIMARY KEY (�����_��������, ��������_������, ���_�������, ���_����������, ����������_������_����������),
	 CONSTRAINT FK_������������_��������_�������� FOREIGN KEY (�����_��������) REFERENCES ��������(�����_��������),
	 CONSTRAINT FK_������������_��������_��������� FOREIGN KEY (���_����������, ����������_������_����������) REFERENCES ���������(���_����������, ����������_������_����������),
	 CONSTRAINT FK_������������_��������_����� FOREIGN KEY (��������_������, ���_�������) REFERENCES �����(��������_������, ���_�������)
    )

CREATE TABLE �����
    (�����_����� int not null,
	 �����_���� int not null,
	 CONSTRAINT PK_����� PRIMARY KEY (�����_�����, �����_����)
	)

CREATE TABLE �����_�_����
    (�����_����� int not null,
	 �����_���� int not null,
	 �����_���� int not null,
	 CONSTRAINT PK_�����_�_���� PRIMARY KEY (�����_�����, �����_����, �����_����),
	 CONSTRAINT FK_�����_�_����_��� FOREIGN KEY (�����_����) REFERENCES ���(�����_����),
	 CONSTRAINT FK_�����_�_����_����� FOREIGN KEY (�����_�����, �����_����) REFERENCES �����(�����_�����, �����_����)
	)

CREATE TABLE �����
    (�����_������ int primary key not null,
	 ����_������ money not null,
	 ����_�_�����_�������_������ datetime not null
	)

CREATE TABLE �������_�������
    (��������_������ nvarchar(50) not null,
	 ���_������� date not null,
	 �����_����� int not null,
	 �����_���� int not null,
	 �����_���� int not null,
	 ���_������� nvarchar(50) not null,
	 �����_������ datetime not null,
	 ����������_������_���������� nvarchar(10) not null,
	 ���_���������� nvarchar(50) not null,
	 �����_������ int UNIQUE not null,
	 �������_������� Phone not null,
     CONSTRAINT PK_�������_������� PRIMARY KEY (�����_����, �����_�����, ���_�������, �����_������, ����������_������_����������, ���_����������, �����_����, �������_�������),
	 CONSTRAINT FK_�������_�������_����� FOREIGN KEY (�����_������) REFERENCES �����(�����_������),
	 CONSTRAINT FK_�������_�������_������ FOREIGN KEY (���_�������, �������_�������) REFERENCES ������(���_�������, �������_�������),
	 CONSTRAINT FK_�������_�������_����� FOREIGN KEY (�����_������) REFERENCES �����(�����_������),
	 CONSTRAINT FK_�������_�������_��� FOREIGN KEY (�����_����) REFERENCES ���(�����_����),
	 CONSTRAINT FK_�������_�������_����� FOREIGN KEY (�����_�����, �����_����) REFERENCES �����(�����_�����, �����_����),
     CONSTRAINT FK_�������_�������_��������� FOREIGN KEY (���_����������, ����������_������_����������) REFERENCES ���������(���_����������, ����������_������_����������)
    )
GO

/*�������� �������������*/

/*������������� ��� ����������� ��� 5 �������� ���������� �� ���������� ��������� �������*/

CREATE VIEW ���_��������
AS
	SELECT TOP(5) ���_�������, COUNT(�����_������) AS '����������_�������'
	FROM �������_�������
	GROUP BY ���_�������
	ORDER BY COUNT(*) DESC
GO

/*������������� ��� ����������� ��� 5 �������� ���������� �� ���������� ��������� �������*/

CREATE VIEW ���_��������
AS
	SELECT TOP(5) ���_����������, COUNT(�����_������) AS '����������_�������'
	FROM �������_�������
	GROUP BY ���_����������
	ORDER BY COUNT(*) DESC
GO

/*������������� ��� ����������� ���������� ��������� ������� � ������ ����*/

CREATE VIEW ���_�������_����
AS
	SELECT �����_����, COUNT(�����_������) AS '����������_�������'
	FROM �������_�������
	GROUP BY �����_����
GO

/*������������� ��� ����������� ��� 5 ������� ���������� �� ���������� ��������� �������*/

CREATE VIEW ���_�������
AS
	SELECT TOP(5) ��������_������, COUNT(�����_������) AS '����������_�������'
	FROM �������_�������
	GROUP BY ��������_������
	ORDER BY COUNT(*) DESC
GO

/*������������� ��� ����������� ��� 5 ����� � ������� �� ������������ ������ � ����� ������� ���������� ��������� ����*/

CREATE VIEW ����_���_�������
AS
	SELECT TOP(5) �����_����, ����������_����
	FROM ���
	WHERE �����_���� NOT IN (SELECT �����_����
	                         FROM ����������_�����)
	GROUP BY �����_����, ����������_����
	ORDER BY ����������_���� DESC
GO

/*������������� ��� ����������� ��������� ���� � ����������*/
CREATE VIEW ���������_�����
AS
	SELECT TOP(10000) �����_�_����.�����_����, ��������_������, ���_�������, ������_����.�����_������, �����_����, �����_�����
	FROM ������_���� INNER JOIN �����_�_���� ON ������_����.�����_���� = �����_�_����.�����_���� INNER JOIN ����� ON �����.�����_������ = ������_����.�����_������
	ORDER BY �����_�_����.�����_���� ASC
	EXCEPT
	SELECT �����_����, ��������_������, ���_�������, �����_������, �����_����, �����_�����
	FROM �������_�������
GO

     /*�������� ��������*/

     /*��������� ��� �������*/

     CREATE PROC Insert_client
      (@���_������� nvarchar(50),
       @���_������� TypeClient,
       @���������_����� int,
       @������ Discount,
       @Email Email,
       @������� Phone
      )
     AS
      IF NOT EXISTS (SELECT *
                     FROM ������
                     WHERE ���_������� = @���_�������)
      BEGIN
     	INSERT INTO ������
     	VALUES (@���_�������, @���_�������, @���������_�����, @������, @Email, @�������);
      END
      ELSE PRINT N'����� ������ ����������!'
     GO

     CREATE PROC Update_client
      (@���_������� nvarchar(50),
       @���_������� TypeClient,
       @������ Discount,
       @Email Email,
       @������� Phone
      )
     AS
      IF EXISTS (SELECT *
                 FROM ������
                 WHERE ���_������� = @���_������� AND �������_������� = @�������)
      BEGIN
        UPDATE ������
        SET ���_������� = @���_�������,
     	   ������ = @������,
     	   Email = @Email,
     	   �������_������� = @�������
        WHERE ���_������� = @���_������� AND �������_������� = @�������
      END
      ELSE PRINT N'������ ������� �� ����������!'
     GO

     CREATE PROC Delete_client (@���_������� nvarchar(50), @�������_������� Phone)
     AS
      IF EXISTS (SELECT *
                 FROM ������
                 WHERE ���_������� = @���_������� AND �������_������� = @�������_�������)
      BEGIN
     	DELETE FROM �������_�������
     	WHERE ���_������� = @���_������� AND �������_������� = @�������_�������
     	DELETE FROM ������
     	WHERE ���_������� = @���_������� AND �������_������� = @�������_�������
      END
      ELSE PRINT N'������ ������� �� ����������!'
     GO

     /*��������� ��� ���������*/

     CREATE PROC Insert_post
      (@��������_��������� nvarchar(50),
       @��������_��������� nvarchar(150),
       @�������� money
      )
     AS
      IF NOT EXISTS (SELECT *
                     FROM ���������
                     WHERE ��������_��������� = @��������_���������)
      BEGIN
     	INSERT INTO ���������
     	VALUES (@��������_���������, @��������_���������, @��������);
      END
      ELSE PRINT N'����� ��������� ����������!'
     GO

     CREATE PROC Update_post
      (@��������_��������� nvarchar(50),
       @��������_��������� nvarchar(150),
       @�������� money
      )
     AS
      IF EXISTS (SELECT *
                 FROM ���������
                 WHERE ��������_��������� = @��������_���������)
      BEGIN
        UPDATE ���������
        SET ��������_��������� = @��������_���������,
     	   �������� = @��������
        WHERE ��������_��������� = @��������_���������
      END
      ELSE PRINT N'����� ��������� �� ����������!'
     GO

     CREATE PROC Delete_post (@��������_��������� nvarchar(50))
     AS
      IF EXISTS (SELECT *
                 FROM ���������
                 WHERE ��������_��������� = @��������_���������)
      BEGIN
     	DELETE FROM ���������
     	WHERE ��������_��������� = @��������_���������
     	DELETE FROM �����_������
     	WHERE ��������_��������� = @��������_���������
     	DELETE FROM ������������_��������
     	WHERE ��������_��������� = @��������_���������
     	DELETE FROM ����������_����
     	WHERE ��������_��������� = @��������_���������
     	DELETE FROM ���������
     	WHERE ��������_��������� = @��������_���������
      END
      ELSE PRINT N'����� ��������� �� ����������!'
     GO

     /*��������� ��� ��������*/

     CREATE PROC Insert_license
      (@�����_�������� int,
       @���������_�������� CostLicense,
       @��������_�������� nvarchar(100),
       @����_�������� date
      )
     AS
      IF NOT EXISTS (SELECT *
                     FROM ��������
                     WHERE �����_�������� = @�����_��������)
      BEGIN
     	INSERT INTO ��������
     	VALUES (@�����_��������, @���������_��������, @��������_��������, @����_��������);
      END
      ELSE PRINT N'����� �������� ����������!'
     GO

     CREATE PROC Update_license
      (@�����_�������� int,
       @���������_�������� CostLicense,
       @��������_�������� nvarchar(100),
       @����_�������� date
      )
     AS
      IF EXISTS (SELECT *
                 FROM ��������
                 WHERE �����_�������� = @�����_��������)
      BEGIN
        UPDATE ��������
        SET ���������_�������� = @���������_��������,
            ��������_�������� = @��������_��������,
            ����_�������� = @����_��������
        WHERE �����_�������� = @�����_��������
      END
      ELSE PRINT N'����� �������� �� ����������!'
     GO

     CREATE PROC Delete_license (@�����_�������� int)
     AS
      IF EXISTS (SELECT *
                 FROM ��������
                 WHERE �����_�������� = @�����_��������)
      BEGIN
     	DELETE FROM ������������_��������
     	WHERE �����_�������� = @�����_��������
     	DELETE FROM ��������
     	WHERE �����_�������� = @�����_��������
      END
      ELSE PRINT N'����� �������� �� ����������!'
     GO

     /*��������� ��� ������������*/

     CREATE PROC Insert_equipment
      (@ID_������������ int,
       @������_������������ nvarchar(50),
       @��������_������������ nvarchar(50)
      )
     AS
      IF NOT EXISTS (SELECT *
                     FROM ������������
                     WHERE ID_������������ = @ID_������������)
      BEGIN
     	INSERT INTO ������������
     	VALUES (@ID_������������, @������_������������, @��������_������������);
      END
      ELSE PRINT N'����� ������������ ����������!'
     GO

     CREATE PROC Update_equipment
      (@ID_������������ int,
       @������_������������ nvarchar(50),
       @��������_������������ nvarchar(50)
      )
     AS
      IF EXISTS (SELECT *
                 FROM ������������
                 WHERE ID_������������ = @ID_������������)
      BEGIN
        UPDATE ������������
        SET ������_������������ = @������_������������,
            ��������_������������ = @��������_������������
        WHERE ID_������������ = @ID_������������
      END
      ELSE PRINT N'������ ������������ �� ����������!'
     GO

     CREATE PROC Delete_equipment (@ID_������������ int)
     AS
      IF EXISTS (SELECT *
                 FROM ������������
                 WHERE ID_������������ = @ID_������������)
      BEGIN
     	DELETE FROM �����_������
     	WHERE ID_������������ = @ID_������������
     	DELETE FROM ������������
     	WHERE ID_������������ = @ID_������������
      END
      ELSE PRINT N'������ ������������ �� ����������!'
     GO

     /*��������� ��� ������*/

     CREATE PROC Insert_ticket
      (@�����_������ int,
       @����_������ money,
       @����_�_�����_�������_������ datetime
      )
     AS
      IF NOT EXISTS (SELECT *
                     FROM �����
                     WHERE �����_������ = @�����_������)
      BEGIN
     	INSERT INTO �����
     	VALUES (@�����_������, @����_������, @����_�_�����_�������_������);
      END
      ELSE PRINT N'����� ����� ����������!'
     GO

     CREATE PROC Delete_ticket (@�����_������ int)
     AS
      IF EXISTS (SELECT *
                 FROM �����
                 WHERE �����_������ = @�����_������)
      BEGIN
     	DELETE FROM �������_�������
     	WHERE �����_������ = @�����_������
     	DELETE FROM �����
     	WHERE �����_������ = @�����_������
      END
      ELSE PRINT N'������ ������ �� ����������!'
     GO

     /*��������� ��� �������*/

     CREATE PROC Insert_film
      (@��������_������ nvarchar(50),
       @���_������� date,
       @������� nvarchar(50),
       @���� nvarchar(50),
       @������ FormatFilm,
       @������� RatingFilm
      )
     AS
      IF NOT EXISTS (SELECT *
                     FROM �����
                     WHERE ��������_������ = @��������_������ AND ���_������� = @���_�������)
      BEGIN
     	INSERT INTO �����
     	VALUES (@��������_������, @���_�������, @�������, @����, @������, @�������);
      END
      ELSE PRINT N'����� ����� ����������!'
     GO

     CREATE PROC Update_film
      (@��������_������ nvarchar(50),
       @���_������� date,
       @������� nvarchar(50),
       @���� nvarchar(50),
       @������ FormatFilm,
       @������� RatingFilm
      )
     AS
      IF EXISTS (SELECT *
                 FROM �����
                 WHERE ��������_������ = @��������_������ AND ���_������� = @���_�������)
      BEGIN
        UPDATE �����
        SET ������� = @�������, ���� = @����, ������ = @������, ������� = @�������
        WHERE ��������_������ = @��������_������ AND ���_������� = @���_�������
      END
      ELSE PRINT N'������ ������ �� ����������!'
     GO

     CREATE PROC Delete_film
      (@��������_������ nvarchar(50),
       @���_������� date
      )
     AS
      IF EXISTS (SELECT *
                 FROM �����
                 WHERE ��������_������ = @��������_������ AND ���_������� = @���_�������)
      BEGIN
     	DELETE FROM ����������_�����
     	WHERE ��������_������ = @��������_������ AND ���_������� = @���_�������
     	DELETE FROM �������_�������
     	WHERE ��������_������ = @��������_������ AND ���_������� = @���_�������
     	DELETE FROM ������������_��������
     	WHERE ��������_������ = @��������_������ AND ���_������� = @���_�������
     	DELETE FROM �����_������
     	WHERE ��������_������ = @��������_������ AND ���_������� = @���_�������
     	DELETE FROM �����
     	WHERE ��������_������ = @��������_������ AND ���_������� = @���_�������
     	DELETE FROM �����
     	WHERE ��������_������ = @��������_������ AND ���_������� = @���_�������
      END
      ELSE PRINT N'������ ������ �� ����������!'
     GO

     /*��������� ��� ����������*/

     CREATE PROC Insert_worker
      (@���_���������� nvarchar(50),
       @����������_������_���������� Passport,
       @��������_��������� nvarchar(50),
       @�����_��������_���������� Phone,
       @�����_���������� nvarchar(50)
      )
     AS
      IF NOT EXISTS (SELECT *
                     FROM ���������
                     WHERE ���_���������� = @���_���������� AND ����������_������_���������� = @����������_������_����������)
      BEGIN
     	INSERT INTO ���������
     	VALUES (@���_����������, @����������_������_����������, @��������_���������, @�����_��������_����������, @�����_����������);
      END
      ELSE PRINT N'����� ��������� ����������!'
     GO

     CREATE PROC Update_worker
      (@���_���������� nvarchar(50),
       @����������_������_���������� Passport,
       @��������_��������� nvarchar(50),
       @�����_��������_���������� Phone,
       @�����_���������� nvarchar(50)
      )
     AS
      IF EXISTS (SELECT *
                 FROM ���������
                 WHERE ���_���������� = @���_���������� AND ����������_������_���������� = @����������_������_����������)
      BEGIN
        UPDATE ���������
        SET ��������_��������� = @��������_���������,
     	   �����_��������_���������� = @�����_��������_����������,
     	   �����_���������� = @�����_����������
        WHERE ���_���������� = @���_���������� AND ����������_������_���������� = @����������_������_����������
      END
      ELSE PRINT N'������ ���������� �� ����������!'
     GO

     CREATE PROC Delete_worker (@���_���������� nvarchar(50), @����������_������_���������� Passport)
     AS
      IF EXISTS (SELECT *
                 FROM ���������
                 WHERE ���_���������� = @���_���������� AND ����������_������_���������� = @����������_������_����������)
      BEGIN
     	DELETE FROM �������_�������
     	WHERE ���_���������� = @���_���������� AND ����������_������_���������� = @����������_������_����������
     	DELETE FROM �����_������
     	WHERE ���_���������� = @���_���������� AND ����������_������_���������� = @����������_������_����������
     	DELETE FROM ����������_����
     	WHERE ���_���������� = @���_����������
     	DELETE FROM ������������_��������
     	WHERE ���_���������� = @���_���������� AND ����������_������_���������� = @����������_������_����������
     	DELETE FROM ���������
     	WHERE ���_���������� = @���_���������� AND ����������_������_���������� = @����������_������_����������
      END
      ELSE PRINT N'������ ���������� �� ����������!'
     GO

     /*��������� ��� �����*/

     CREATE PROC Insert_place
      (@�����_����� int,
       @�����_���� int
      )
     AS
      IF NOT EXISTS (SELECT *
                     FROM �����
                     WHERE �����_����� = @�����_����� AND �����_���� = @�����_����)
      BEGIN
     	INSERT INTO �����
     	VALUES (@�����_�����, @�����_����);
      END
      ELSE PRINT N'����� ����� ����������!'
     GO

     CREATE PROC Insert_place_in_Row
      (@�����_���� int,
       @����������_���� int
      )
     AS
      DECLARE @�����_����� int
      SET @�����_����� = 1
      WHILE (@����������_���� >= @�����_�����)
      BEGIN
     	 IF NOT EXISTS (SELECT *
                     FROM �����
                     WHERE �����_����� = @�����_����� AND �����_���� = @�����_����)
     	 BEGIN
     		INSERT INTO �����
     		VALUES (@�����_�����, @�����_����);
     	 END
     	 ELSE PRINT N'����� ����� ����������!'
     	 SET @�����_����� = @�����_����� + 1;
      END
     GO

     CREATE PROC Delete_place (@�����_����� int, @�����_���� int)
     AS
      IF EXISTS (SELECT *
                 FROM �����
                 WHERE �����_����� = @�����_����� AND �����_���� = @�����_����)
      BEGIN
     	DELETE FROM �������_�������
     	WHERE �����_����� = @�����_����� AND �����_���� = @�����_����
     	DELETE FROM �����
     	WHERE �����_����� = @�����_����� AND �����_���� = @�����_����
      END
      ELSE PRINT N'������ ����� �� ����������!'
     GO

     /*��������� ��� ���� � ����*/

     CREATE PROC Insert_place_in_Hall
      (@�����_����� int,
       @�����_���� int,
       @�����_���� int
      )
     AS
      IF NOT EXISTS (SELECT *
                     FROM �����_�_����
                     WHERE �����_����� = @�����_����� AND �����_���� = @�����_���� AND �����_���� = @�����_����)
      BEGIN
     	IF EXISTS (SELECT *
                        FROM ���
                        WHERE �����_���� = @�����_����)
     	BEGIN
     		IF NOT EXISTS (SELECT *
     					   FROM �����
                            WHERE �����_����� = @�����_����� AND �����_���� = @�����_����)
     		BEGIN
     			INSERT INTO �����
     			VALUES (@�����_�����, @�����_����);
     		END
     		ELSE PRINT N'����� ����� ����������!'
     		INSERT INTO �����_�_����
     		VALUES (@�����_�����, @�����_����, @�����_����);
     	END
     	ELSE PRINT N'����� ��� �� ����������!'
      END
      ELSE PRINT N'����� ����� � ���� ����������!'
     GO

     CREATE PROC Insert_place_in_Row_Hall
      (@�����_���� int,
       @�����_���� int,
       @����������_����_�_���� int
      )
     AS
      DECLARE @�����_����� int
      SET @�����_����� = 1
      WHILE (@����������_����_�_���� >= @�����_�����)
      BEGIN
     	IF NOT EXISTS (SELECT *
     				   FROM �����_�_����
                        WHERE �����_����� = @�����_����� AND �����_���� = @�����_���� AND �����_���� = @�����_����)
     	BEGIN
     		IF EXISTS (SELECT *
     				   FROM ���
                        WHERE �����_���� = @�����_����)
     		BEGIN
     			IF NOT EXISTS (SELECT *
     						   FROM �����
                                WHERE �����_����� = @�����_����� AND �����_���� = @�����_����)
     			BEGIN
     				INSERT INTO �����
     				VALUES (@�����_�����, @�����_����);
     			END
     			ELSE PRINT N'����� ����� ����������!'
     			INSERT INTO �����_�_����
     				VALUES (@�����_�����, @�����_����, @�����_����);
     		END
     		ELSE PRINT N'����� ��� �� ����������!'
     	END
     	ELSE PRINT N'����� ����� � ���� ����������!'
     	SET @�����_����� = @�����_����� + 1;
      END
     GO

     CREATE PROC Delete_place_in_Hall (@�����_����� int, @�����_���� int, @�����_���� int)
     AS
      IF EXISTS (SELECT *
                 FROM �����_�_����
                 WHERE �����_����� = @�����_����� AND �����_���� = @�����_���� AND �����_���� = @�����_����)
      BEGIN
     	DELETE FROM �����_�_����
     	WHERE �����_����� = @�����_����� AND �����_���� = @�����_���� AND �����_���� = @�����_����
      END
      ELSE PRINT N'������ ����� � ���� �� ����������!'
     GO

     /*��������� ��� ����*/

     CREATE PROC Insert_Hall
      (@�����_���� int,
       @��������_���� nvarchar(50),
       @����������_���� int
      )
     AS
      IF NOT EXISTS (SELECT *
                     FROM ���
                     WHERE �����_���� = @�����_����)
      BEGIN
     	INSERT INTO ���
     	VALUES (@�����_����, @��������_����, @����������_����);
      END
      ELSE PRINT N'����� ��� ����������!'
     GO

     CREATE PROC Update_Hall
      (@�����_���� int,
       @��������_���� nvarchar(50),
       @����������_���� int
      )
     AS
      IF EXISTS (SELECT *
                 FROM ���
                 WHERE �����_���� = @�����_����)
      BEGIN
     	UPDATE ���
     	SET ��������_���� = @��������_����,
     	    ����������_���� = @����������_����
     	WHERE �����_���� = @�����_����
      END
      ELSE PRINT N'������ ���� �� ����������!'
     GO

     CREATE PROC Delete_Hall (@�����_���� int)
     AS
      IF EXISTS (SELECT *
                 FROM ���
                 WHERE �����_���� = @�����_����)
      BEGIN
         DELETE FROM ������_����
     	WHERE �����_���� = @�����_����
     	DELETE FROM �������_�������
     	WHERE �����_���� = @�����_����
     	DELETE FROM ����������_�����
     	WHERE �����_���� = @�����_����
     	DELETE FROM ����������_����
     	WHERE �����_���� = @�����_����
     	DELETE FROM ���
     	WHERE �����_���� = @�����_����
      END
      ELSE PRINT N'������ ���� �� ����������!'
     GO

     /*��������� ��� ������*/

     CREATE PROC Insert_session
      (@�����_������ datetime,
       @��������_������ nvarchar(50),
       @���_������� date
      )
     AS
      IF NOT EXISTS (SELECT *
                     FROM �����
                     WHERE �����_������ = @�����_������)
      BEGIN
     	INSERT INTO �����
     	VALUES (@�����_������, @��������_������, @���_�������);
      END
      ELSE PRINT N'����� ����� ����������!'
     GO

     CREATE PROC Update_session
      (@�����_������ datetime,
       @��������_������ nvarchar(50),
       @���_������� date
      )
     AS
      IF EXISTS (SELECT *
                 FROM �����
                 WHERE �����_������ = @�����_������)
      BEGIN
     	UPDATE �����
     	SET ��������_������ = @��������_������,
     	    ���_������� = @���_�������
     	WHERE �����_������ = @�����_������
      END
      ELSE PRINT N'������ ������ �� ����������!'
     GO

     CREATE PROC Delete_session (@�����_������ datetime)
     AS
      IF EXISTS (SELECT *
                 FROM �����
                 WHERE �����_������ = @�����_������)
      BEGIN
         DELETE FROM ������_����
     	WHERE �����_������ = @�����_������
     	DELETE FROM �������_�������
     	WHERE �����_������ = @�����_������
     	DELETE FROM �����
     	WHERE �����_������ = @�����_������
      END
      ELSE PRINT N'������ ������ �� ����������!'
     GO

     /*��������� ��� ������� ����*/

     CREATE PROC Insert_session_in_Hall
      (@�����_������ datetime,
       @�����_���� int,
       @��������_������ nvarchar(50),
       @���_������� date
      )
     AS
      IF NOT EXISTS (SELECT *
                     FROM ������_����
                     WHERE �����_���� = @�����_���� AND �����_������ = @�����_������)
      BEGIN
     	IF EXISTS (SELECT *
                    FROM ���
                    WHERE �����_���� = @�����_����)
     	BEGIN
     		IF NOT EXISTS (SELECT *
     					   FROM �����
     					   WHERE �����_������ = @�����_������)
     		BEGIN
     			INSERT INTO �����
     			VALUES (@�����_������, @��������_������, @���_�������);
     		END
     		ELSE PRINT N'����� ����� ����������!'
     		INSERT INTO ������_����
     		VALUES (@�����_����, @�����_������);
     	END
     	ELSE PRINT N'������ ���� �� ����������!'
      END
      ELSE PRINT N'����� ����� � ���� ����������!'
     GO

     CREATE PROC Delete_session_in_Hall (@�����_������ datetime, @�����_���� int)
     AS
      IF EXISTS (SELECT *
                 FROM ������_����
                 WHERE �����_���� = @�����_���� AND �����_������ = @�����_������)
      BEGIN
     	DELETE FROM ������_����
         WHERE �����_���� = @�����_���� AND �����_������ = @�����_������
      END
      ELSE PRINT N'������ ������ � ���� �� ����������!'
     GO

     /*��������� ��� ����������� ����*/

     CREATE PROC Insert_worker_in_Hall
      (@�����_���� int,
       @���_���������� nvarchar(50),
       @����������_������_���������� Passport,
       @��������_��������� nvarchar(50)
      )
     AS
      IF NOT EXISTS (SELECT *
                     FROM ����������_����
                     WHERE ���_���������� = @���_���������� AND ����������_������_���������� = @����������_������_���������� AND �����_���� = @�����_����)
      BEGIN
         IF EXISTS (SELECT *
                    FROM ���
                    WHERE �����_���� = @�����_����)
     	BEGIN
     			INSERT INTO ����������_����
     			VALUES (@�����_����, @���_����������, @����������_������_����������, @��������_���������);
     	END
     	ELSE PRINT N'������ ���� �� ����������!'
      END
      ELSE PRINT N'����� ��������� � ���� ����������!'
     GO

     CREATE PROC Update_worker_in_Hall
      (@�����_���� int,
       @���_���������� nvarchar(50),
       @����������_������_���������� Passport,
       @��������_��������� nvarchar(50)
      )
     AS
      IF EXISTS (SELECT *
                 FROM ����������_����
                 WHERE ���_���������� = @���_���������� AND ����������_������_���������� = @����������_������_���������� AND �����_���� = @�����_����)
      BEGIN
     	IF EXISTS (SELECT *
                    FROM ���������
                    WHERE ���_���������� = @���_���������� AND ����������_������_���������� = @����������_������_����������)
     	BEGIN
     		UPDATE ���������
     		SET ��������_��������� = @��������_���������
     		UPDATE ����������_����
     		SET ��������_��������� = @��������_���������
     	END
     	ELSE PRINT N'����� ��������� ����������!'
      END
      ELSE PRINT N'����� ��������� � ���� ����������!'
     GO

     CREATE PROC Delete_worker_in_Hall
      (@�����_���� int,
       @���_���������� nvarchar(50),
       @����������_������_���������� Passport
      )
     AS
      IF EXISTS (SELECT *
                 FROM ����������_����
                 WHERE ���_���������� = @���_���������� AND ����������_������_���������� = @����������_������_���������� AND �����_���� = @�����_����)
      BEGIN
     	DELETE FROM ����������_����
         WHERE ���_���������� = @���_���������� AND ����������_������_���������� = @����������_������_����������
      END
      ELSE PRINT N'������ ���������� � ���� �� ����������!'
     GO

     /*��������� ��� ������� "����������_�����"*/

     CREATE PROC Insert_shows_the_film
      (@�����_���� int,
       @��������_������ nvarchar(50),
       @���_������� date,
       @������� nvarchar(50),
       @���� nvarchar(50),
       @������ FormatFilm,
       @������� RatingFilm
      )
     AS
      IF NOT EXISTS (SELECT *
                     FROM ����������_�����
                     WHERE �����_���� = @�����_���� AND ��������_������ = @��������_������ AND ���_������� = @���_�������)
      BEGIN
     	IF EXISTS (SELECT *
                    FROM ���
                    WHERE �����_���� = @�����_����)
     	BEGIN
     		IF NOT EXISTS (SELECT *
     					   FROM �����
     					   WHERE ��������_������ = @��������_������ AND ���_������� = @���_�������)
     		BEGIN
     			INSERT INTO �����
     			VALUES (@��������_������, @���_�������, @�������, @����, @������, @�������);
     		END
     		ELSE PRINT N'����� ����� ����������!'
     		INSERT INTO ����������_�����
     		VALUES (@�����_����, @��������_������, @���_�������)
     	END
     	ELSE PRINT N'������ ���� �� ����������!'
      END
      ELSE PRINT N'����� ����� � ������� "����������_�����" ����������!'
     GO

     CREATE PROC Delete_shows_the_film (@�����_���� int,  @��������_������ nvarchar(50), @���_������� date)
     AS
      IF EXISTS (SELECT *
                 FROM ����������_�����
                 WHERE �����_���� = @�����_���� AND ��������_������ = @��������_������ AND ���_������� = @���_�������)
      BEGIN
     	DELETE FROM ����������_�����
         WHERE �����_���� = @�����_���� AND ��������_������ = @��������_������ AND ���_������� = @���_�������
      END
      ELSE PRINT N'������ ������ � ������� "����������_�����" �� ����������!'
     GO

     /*��������� ��� ������� "�����_������"*/

     CREATE PROC Insert_showing_a_film
      (@ID_������������ int,
       @��������_������ nvarchar(50),
       @���_������� date,
       @���_���������� nvarchar(50),
       @����������_������_���������� Passport,
       @��������_��������� nvarchar(50)
      )
     AS
      IF EXISTS (SELECT *
     			FROM ���������
     			WHERE ���_���������� = @���_���������� AND ����������_������_���������� = @����������_������_����������)
      BEGIN
     	IF EXISTS (SELECT *
     			   FROM �����
     			   WHERE ���_������� = @���_������� AND ��������_������ = @��������_������)
     	BEGIN
     		IF EXISTS (SELECT *
     				   FROM ������������
     			       WHERE ID_������������ = @ID_������������)
     		BEGIN
     			INSERT INTO �����_������
     			VALUES (@ID_������������, @��������_������, @���_�������, @���_����������, @����������_������_����������, @��������_���������)
     		END
     		ELSE PRINT N'������ ������������ �� ����������!'
     	END
     	ELSE PRINT N'������ ������  �� ����������!'
      END
      ELSE PRINT N'������ ���������� �� ����������!'
     GO

     CREATE PROC Delete_showing_a_film
      (@��������_������ nvarchar(50),
       @���_������� date,
       @���_���������� nvarchar(50),
       @����������_������_���������� Passport,
       @ID_������������ int
      )
     AS
      IF EXISTS (SELECT *
                 FROM �����_������
                 WHERE ��������_������ = @��������_������ AND ���_������� = @���_������� AND ID_������������ = @ID_������������ AND ���_���������� = @���_���������� AND ����������_������_���������� = @����������_������_����������)
      BEGIN
     	DELETE FROM �����_������
         WHERE ��������_������ = @��������_������ AND ���_������� = @���_������� AND ID_������������ = @ID_������������ AND ���_���������� = @���_���������� AND ����������_������_���������� = @����������_������_����������
      END
      ELSE PRINT N'������ ������ � ������� "�����_������" �� ����������!'
     GO

     /*��������� ��� ������� "������������ ��������"*/

     CREATE PROC Insert_acquisition_of_a_license
      (@�����_�������� int,
       @��������_������ nvarchar(50),
       @���_������� date,
       @���_���������� nvarchar(50),
       @����������_������_���������� Passport,
       @��������_��������� nvarchar(50)
      )
     AS
      IF EXISTS (SELECT *
     			FROM ���������
     			WHERE ���_���������� = @���_���������� AND ����������_������_���������� = @����������_������_����������)
      BEGIN
     	IF EXISTS (SELECT *
     			   FROM �����
     			   WHERE ���_������� = @���_������� AND ��������_������ = @��������_������)
     	BEGIN
     		IF EXISTS (SELECT *
     				   FROM ��������
     			       WHERE �����_�������� = @�����_��������)
     		BEGIN
     			INSERT INTO ������������_��������
     			VALUES (@�����_��������, @��������_������, @���_�������, @���_����������, @����������_������_����������, @��������_���������)
     		END
     		ELSE PRINT N'����� �������� �� ����������!'
     	END
     	ELSE PRINT N'������ ������  �� ����������!'
      END
      ELSE PRINT N'������ ���������� �� ����������!'
     GO

     CREATE PROC Delete_acquisition_of_a_license
      (@��������_������ nvarchar(50),
       @���_������� date,
       @���_���������� nvarchar(50),
       @����������_������_���������� Passport,
       @�����_�������� int
      )
     AS
      IF EXISTS (SELECT *
                 FROM ������������_��������
                 WHERE ��������_������ = @��������_������ AND ���_������� = @���_������� AND �����_�������� = @�����_�������� AND ���_���������� = @���_���������� AND ����������_������_���������� = @����������_������_����������)
      BEGIN
     	DELETE FROM ������������_��������
         WHERE ��������_������ = @��������_������ AND ���_������� = @���_������� AND �����_�������� = @�����_�������� AND ���_���������� = @���_���������� AND ����������_������_���������� = @����������_������_����������
      END
      ELSE PRINT N'������ ������ � ������� "������������ ��������" �� ����������!'
     GO

     /*��������� ��� ������� "�������_�������"*/

     CREATE PROC Insert_ticket_selling
      (@��������_������ nvarchar(50),
       @���_������� date,
       @�����_����� int,
       @�����_���� int,
       @�����_���� int,
       @���_������� nvarchar(50),
       @�����_������ datetime,
       @���_���������� nvarchar(50),
       @����������_������_���������� Passport,
       @�����_������ int,
       @������� Phone
      )
     AS
      IF EXISTS (SELECT *
     			FROM ���������
     			WHERE ���_���������� = @���_���������� AND ����������_������_���������� = @����������_������_����������)
      BEGIN
     	IF EXISTS (SELECT *
     			   FROM �����
     			   WHERE �����_������ = @�����_������)
     	BEGIN
     		IF EXISTS (SELECT *
     				   FROM ������
     			       WHERE ���_������� = @���_�������)
     		BEGIN
     			IF EXISTS (SELECT *
     					   FROM �����
     			           WHERE �����_������ = @�����_������)
     			BEGIN
     				IF EXISTS (SELECT *
     						   FROM �����
     			               WHERE �����_���� = @�����_���� AND �����_����� = @�����_�����)
     				BEGIN
     					IF EXISTS (SELECT *
     							   FROM ���
     			                   WHERE �����_���� = @�����_����)
     					BEGIN
     						INSERT INTO �������_�������
     						VALUES (@��������_������, @���_�������, @�����_�����, @�����_����, @�����_����, @���_�������, @�����_������, @����������_������_����������, @���_����������, @�����_������, @�������)
     					END
     					ELSE PRINT N'������ ���� �� ����������!'
     				END
     				ELSE PRINT N'������ ����� �� ����������!'
     			END
     			ELSE PRINT N'������ ������ �� ����������!'
     		END
     		ELSE PRINT N'������ ������� �� ����������!'
     	END
     	ELSE PRINT N'������ ������ �� ����������!'
      END
      ELSE PRINT N'������ ���������� �� ����������!'
     GO

     CREATE PROC Delete_ticket_selling
      (@�����_����� int,
       @�����_���� int,
       @�����_���� int,
       @���_������� nvarchar(50),
       @�����_������ datetime,
       @���_���������� nvarchar(50),
       @����������_������_���������� Passport,
       @�����_������ int,
       @������� Phone
      )
     AS
      IF EXISTS (SELECT *
                 FROM �������_�������
                 WHERE ���_���������� = @���_���������� AND ����������_������_���������� = @����������_������_���������� AND �����_������ = @�����_������ AND ���_������� = @���_������� AND �����_������ = @�����_������ AND �����_���� = @�����_���� AND �����_����� = @�����_����� AND �����_���� = @�����_���� AND �������_������� = @�������)
      BEGIN
     	DELETE FROM �������_�������
         WHERE ���_���������� = @���_���������� AND ����������_������_���������� = @����������_������_���������� AND �����_������ = @�����_������ AND ���_������� = @���_������� AND �����_������ = @�����_������ AND �����_���� = @�����_���� AND �����_����� = @�����_����� AND �����_���� = @�����_���� AND �������_������� = @�������
      END
      ELSE PRINT N'����� ������ � ������� "�������_�������" �� ����������!'
     GO

/*��������*/

/*�������, ������� ��������� ��������� � ������� "�����_������" ������ ���������� � ���������� "�����������"*/

CREATE TRIGGER Insert_worker_in_showing_a_film ON �����_������
INSTEAD OF INSERT
AS
	DECLARE @ID_������������ int, @��������_������ nvarchar(50), @���_������� date, @���_���������� nvarchar(50), @����������_������_���������� Passport, @��������_��������� nvarchar(50)
	DECLARE ����������� CURSOR SCROLL FOR
	SELECT *
	FROM inserted
	OPEN �����������
	FETCH FIRST FROM �����������
	INTO @ID_������������, @��������_������, @���_�������, @���_����������, @����������_������_����������, @��������_���������
	WHILE @@FETCH_STATUS = 0
		BEGIN
		IF EXISTS (SELECT *
				   FROM inserted
				   WHERE @��������_��������� = '�����������')
			BEGIN
				INSERT INTO �����_������
				SELECT * FROM inserted
			END
		ELSE PRINT N'��������� � ������ ���������� �� ����� ���������� ������!'
		FETCH NEXT FROM �����������
		INTO @ID_������������, @��������_������, @���_�������, @���_����������, @����������_������_����������, @��������_���������
		END
	CLOSE �����������
	DEALLOCATE �����������
GO

/*�������, ������� ��������� ��������� � ������� "������������_��������" ������ ���������� � ���������� "�������� �� �������� ��������"*/

CREATE TRIGGER Insert_worker_in_acquisition_of_a_license ON ������������_��������
INSTEAD OF INSERT
AS
	DECLARE @�����_�������� int, @��������_������ nvarchar(50), @���_������� date, @���_���������� nvarchar(50), @����������_������_���������� Passport, @��������_��������� nvarchar(50)
	DECLARE ��������_��_��������� CURSOR SCROLL FOR
	SELECT *
	FROM inserted
	OPEN ��������_��_���������
	FETCH FIRST FROM ��������_��_���������
	INTO @�����_��������, @��������_������, @���_�������, @���_����������, @����������_������_����������, @��������_���������
	WHILE @@FETCH_STATUS = 0
		BEGIN
		IF EXISTS (SELECT *
				   FROM inserted
				   WHERE @��������_��������� = '�������� �� �������� ��������')
			BEGIN
				INSERT INTO ������������_��������
				SELECT * FROM inserted
			END
		ELSE PRINT N'��������� � ������ ���������� �� ����� �������� ��������!'
		FETCH NEXT FROM ��������_��_���������
		INTO @�����_��������, @��������_������, @���_�������, @���_����������, @����������_������_����������, @��������_���������
		END
	CLOSE ��������_��_���������
	DEALLOCATE ��������_��_���������
GO

/*�������, ������� ��������� ��������� � ������� "�������_�������" ������ �� ��� ���, ���� ��� �� ��������*/

CREATE TRIGGER Insert_selling_ticket ON �������_�������
AFTER INSERT
AS
	DECLARE @�����_���� int, @����������_������� int
	DECLARE ���_�������_���� CURSOR SCROLL FOR
	SELECT *
	FROM ���_�������_����
	OPEN ���_�������_����
	FETCH FIRST FROM ���_�������_����
	INTO @�����_����, @����������_�������
	WHILE @@FETCH_STATUS = 0
		BEGIN
			IF EXISTS (SELECT �����_���� FROM ��� WHERE �����_���� = @�����_����) AND ((SELECT ����������_���� FROM ��� WHERE �����_���� = @�����_����) - @����������_������� <= 0)
			BEGIN
				PRINT N'������ �����������!'
				ROLLBACK TRAN
			END
			FETCH NEXT FROM ���_�������_����
			INTO @�����_����, @����������_�������
		END
	CLOSE ���_�������_����
	DEALLOCATE ���_�������_����
GO

/*�������, ������� ��� ���������� ������� ���������� ������ �������, ���� ������ �������, �� ������ 0%, ���� ������ VIP 5%, ���� ������ VIP � ������ � ��� 5 ��������, �� ������ 10%, ���� ������
�������, �� ���������� � ������� ��� ��������, �� �������� ��� ��� �� VIP � ��������������� ������ � 10%.*/

CREATE TRIGGER Update_client_discount ON ������
AFTER UPDATE, INSERT
AS
	DECLARE @���_������� nvarchar(50), @����������_������� int
	DECLARE ���_�������� CURSOR SCROLL FOR
	SELECT *
	FROM ���_��������
	OPEN ���_��������
	FETCH FIRST FROM ���_��������
	INTO @���_�������, @����������_�������
	WHILE @@FETCH_STATUS = 0
		BEGIN
			IF EXISTS (SELECT * FROM ������ WHERE ���_������� = @���_������� AND ���_������� = 'VIP')
				BEGIN
					UPDATE ������
					SET ������ = '10'
					WHERE ���_������� = @���_������� AND ���_������� = 'VIP'
				END
				ELSE IF EXISTS (SELECT * FROM ������ WHERE ���_������� = @���_������� AND ���_������� = '�������')
												BEGIN
													UPDATE ������
													SET ������ = '10', ���_������� = 'VIP'
													WHERE ���_������� = @���_������� AND ���_������� = '�������'
												END
			FETCH NEXT FROM ���_��������
			INTO @���_�������, @����������_�������
		END
	CLOSE ���_��������
	DEALLOCATE ���_��������
	DECLARE @���_������� TypeClient, @���������_����� int, @������ Discount, @Email Email, @������� Phone
	DECLARE ���_������� CURSOR SCROLL FOR
	SELECT *
	FROM ������
	OPEN ���_�������
	FETCH FIRST FROM ���_�������
	INTO @���_�������, @���_�������, @���������_�����, @������, @Email, @�������
	WHILE @@FETCH_STATUS = 0
		BEGIN
			IF EXISTS (SELECT * FROM ������ WHERE ���_������� NOT IN (SELECT ���_������� FROM ���_��������) AND ���_������� = 'VIP')
				BEGIN
					UPDATE ������
					SET ������ = '5'
					WHERE ���_������� NOT IN (SELECT ���_������� FROM ���_��������) AND ���_������� = 'VIP'
				END IF EXISTS (SELECT * FROM ������ WHERE ���_������� = '�������')
				BEGIN
					UPDATE ������
					SET ������ = '0'
					WHERE ���_������� = '�������'
				END
			FETCH NEXT FROM ���_�������
			INTO @���_�������, @���_�������, @���������_�����, @������, @Email, @�������
		END
	CLOSE ���_�������
	DEALLOCATE ���_�������
GO

/*�������, ������� ��������� ��������� ����� �� ��� ���, ���� ��� �� ��������*/

CREATE TRIGGER Add_place_in_Hall ON �����_�_����
AFTER INSERT
AS
	DECLARE @�����_���� int, @����������_���� int
	DECLARE ���_����_���� CURSOR SCROLL FOR
	SELECT �����_����, ����������_����
	FROM ���
	OPEN ���_����_����
	FETCH FIRST FROM ���_����_����
	INTO @�����_����, @����������_����
	WHILE @@FETCH_STATUS = 0
		BEGIN
			IF EXISTS (SELECT �����_����
					   FROM ���
					   WHERE �����_���� = @�����_����)
			   AND EXISTS(SELECT �����_����
			              FROM �����_�_����
						  WHERE �����_���� = @�����_����)
			   AND ((SELECT SUM(�����_�����)
					FROM �����_�_����
					WHERE �����_���� = @�����_����) > @����������_����)
			BEGIN
				PRINT N'��� �����!'
				ROLLBACK TRAN
			END
			FETCH NEXT FROM ���_����_����
			INTO @�����_����, @����������_����
		END
	CLOSE ���_����_����
	DEALLOCATE ���_����_����
GO

/*�������, ������� ��������� ��������� ������ ������ ��������*/
CREATE TRIGGER Insert_ticket_selling_cashier ON �������_�������
INSTEAD OF INSERT
AS
	DECLARE @��������_������ nvarchar(50),
    @���_������� date,
    @�����_����� int,
    @�����_���� int,
    @�����_���� int,
    @���_������� nvarchar(50),
    @�����_������ datetime,
    @���_���������� nvarchar(50),
    @����������_������_���������� Passport,
    @�����_������ int,
    @������� Phone

	DECLARE ������ CURSOR SCROLL FOR
	SELECT ��������_������, ���_�������, �����_�����, �����_����, �����_����, ���_�������, �����_������, ����������_������_����������, ���_����������, �����_������, �������_�������
	FROM inserted
	OPEN ������
	FETCH FIRST FROM ������
	INTO @��������_������, @���_�������, @�����_�����, @�����_����, @�����_����, @���_�������, @�����_������, @����������_������_����������, @���_����������, @�����_������, @�������
	WHILE @@FETCH_STATUS = 0
	BEGIN
		if @���_���������� IN (SELECT ���_����������
				   FROM ���������
				   WHERE ��������_��������� = '������')
			BEGIN
			IF EXISTS (SELECT *
			FROM ���������
			WHERE ���_���������� = @���_���������� AND ����������_������_���������� = @����������_������_����������)
			 BEGIN
				IF EXISTS (SELECT *
						   FROM �����
						   WHERE �����_������ = @�����_������)
				BEGIN
					IF EXISTS (SELECT *
							   FROM ������
							   WHERE ���_������� = @���_�������)
					BEGIN
						IF EXISTS (SELECT *
								   FROM �����
								   WHERE �����_������ = @�����_������)
						BEGIN
							IF EXISTS (SELECT *
									   FROM �����
									   WHERE �����_���� = @�����_���� AND �����_����� = @�����_�����)
							BEGIN
								IF EXISTS (SELECT *
										   FROM ���
										   WHERE �����_���� = @�����_����)
								BEGIN
									INSERT INTO �������_�������
									VALUES (@��������_������, @���_�������, @�����_�����, @�����_����, @�����_����, @���_�������, @�����_������, @����������_������_����������, @���_����������, @�����_������, @�������)
								END
								ELSE PRINT N'������ ���� �� ����������!'
							END
							ELSE PRINT N'������ ����� �� ����������!'
						END
						ELSE PRINT N'������ ������ �� ����������!'
					END
					ELSE PRINT N'������ ������� �� ����������!'
				END
				ELSE PRINT N'������ ������ �� ����������!'
			 END
			 ELSE PRINT N'������ ���������� �� ����������!'
			END
		ELSE PRINT N'��������� � ������ ���������� �� ����� ��������� ������!'
	FETCH NEXT FROM ������
	INTO @��������_������, @���_�������, @�����_�����, @�����_����, @�����_����, @���_�������, @�����_������, @����������_������_����������, @���_����������, @�����_������, @�������
	END
	CLOSE ������
	DEALLOCATE ������
GO

/*���������� ������ �������*/

INSERT INTO �����
VALUES ('1', '300', '2017-04-24 15:00:00'),
       ('2', '500', '2017-04-25 15:00:00'),
	   ('3', '600', '2017-04-26 15:00:00'),
	   ('4', '250', '2017-04-27 15:00:00'),
	   ('5', '500', '2017-04-28 15:00:00'),
	   ('6', '500', '2017-04-25 15:00:00'),
	   ('7', '370', '2017-04-25 15:00:00'),
	   ('8', '500', '2017-04-25 15:00:00'),
	   ('9', '500', '2017-04-25 15:00:00'),
	   ('10', '500', '2017-04-25 15:00:00'),
	   ('11', '500', '2017-04-25 15:00:00'),
	   ('12', '500', '2017-04-25 15:00:00'),
	   ('13', '500', '2017-04-25 15:00:00'),
	   ('14', '370', '2017-04-25 15:00:00'),
	   ('15', '500', '2017-04-25 15:00:00'),
	   ('16', '500', '2017-04-25 15:00:00'),
	   ('17', '250', '2017-04-25 15:00:00'),
	   ('18', '500', '2017-04-25 15:00:00'),
	   ('19', '500', '2017-04-25 15:00:00'),
	   ('20', '500', '2017-04-25 15:00:00'),
	   ('21', '370', '2017-04-25 15:00:00');
GO

INSERT INTO ���������
VALUES ('������', '���������� �������� ������� �� ������ ������� � ������� ��������� ����', '25000'),
       ('�������������', '���������� ����������� ������� � ������ � ������� � �� ����������', '75000'),
	   ('�������� �� ���������', '���������� ������������ ������ � ����������', '50000'),
	   ('��������', '���������� ����������� �������', '30000'),
	   ('�����������', '���������� ������� �������, ���������� � �������� ������������', '60000'),
	   ('�������� �� �������� ��������', '���������� �������� �������� �� ����� ������� � ����������', '55000'),
	   ('��������', '���������� ����������� ������� � ����������', '15000');
GO

INSERT INTO ���
VALUES ('1', 'IMAX ���', '1000'),
	   ('2', '������� ���', '1000'),
	   ('3', '������� ���', '1000'),
	   ('4', '������� ���', '1000'),
	   ('5', '3D ���', '1000')
GO

INSERT INTO ������ (���_�������, ���_�������, ���������_�����, Email, �������_�������)
VALUES ('������� ������� ��������', '�������', '22092788', 'ziejoo@ya.ru', '+79001234567'),
       ('�������� ������� ��������', 'VIP', '22084749', 'zieerf@ya.ru', '+79001238888'),
	   ('�������� ���� ��������', '�������', '22091449', 'ziejoo1@ya.ru', '+79001234567'),
	   ('��������� ����� ����������', '�������', '22092149', 'ziejoo2@ya.ru', '+79001234566'),
	   ('��������� ��������� ����������', '�������', '22097849', 'ziejoo3@ya.ru', '+79001234565'),
	   ('������� ������� ��������������', '�������', '22072749', 'ziejoo4@ya.ru', '+79001234564'),
	   ('��������� ���� �����������', '�������', '22021749', 'ziejoo5@ya.ru', '+79001234563'),
	   ('���������� ������� ������������', '�������', '22722749', 'ziejoo6@ya.ru', '+79001234562'),
	   ('��������� ������ ��������', '�������', '22092749', 'ziejoo7@ya.ru', '+79001234561'),
	   ('������� ������� ����������', '�������', '22096749', 'ziejoo8@ya.ru', '+79001234560'),
	   ('������� ������ ������������', '�������', '22452749', 'ziejoo9@ya.ru', '+79001234559'),
	   ('�������� ������ ����������', '�������', '22492749', 'ziejoo10@ya.ru', '+79001234558'),
	   ('������� ������� ���������', '�������', '22012249', 'ziejoo11@ya.ru', '+79001234556'),
	   ('�������� ������ ���������', '�������', '22052749', 'ziejoo12@ya.ru', '+79001234555'),
	   ('������ ����� ���������', '�������', '22094749', 'ziejoo13@ya.ru', '+79001234554'),
	   ('�������� ������� �����������', '�������', '22095449', 'ziejoo14@ya.ru', '+79001234553'),
	   ('��������� ����� ���������', '�������', '22094549', 'ziejoo77@ya.ru', '+79001234540'),
	   ('������� ���� ��������', '�������', '23092749', 'ziejoo54@ya.ru', '+79001234527'),
	   ('������ ��������� ���������', '�������', '24092749', 'ziejoo64@ya.ru', '+79001237867'),
	   ('��������� ����� �������������', '�������', '55092749', 'ziejoo543@ya.ru', '+79001278567'),
	   ('������� ������� ���������', '�������', '25092749', 'ziejoo43@ya.ru', '+79001234567'),
	   ('����������� ������� �����������', '�������', '27092749', 'ziejoo34@ya.ru', '+79001234467'),
	   ('�������� �������� ����������', '�������', '57792749', 'ziejoo53@ya.ru', '+79001234547'),
	   ('������� ������ �����������', '�������', '52592749', 'ziejoo23@ya.ru', '+79001544567'),
	   ('������� ����� ���������', '�������', '22092771', 'ziejoo44@ya.ru', '+79001235467'),
	   ('��������� �������� ����������', '�������', '52095749', 'ziejoo23@ya.ru', '+79001234567'),
	   ('��������� ��������� ����������', '�������', '52092749', 'ziejoo21@ya.ru', '+79005424567'),
	   ('��������� ������� �������', '�������', '25775749', 'ziejoo434@ya.ru', '+79004524567'),
	   ('������� ����� ��������', '�������', '54492749', 'ziejoo324@ya.ru', '+79001245467');
GO

EXEC Insert_license '1', '25000', '�������', '2018-04-16 22:19:00'
EXEC Insert_license '2', '35000', '�������', '2018-04-16 22:19:00'
EXEC Insert_license '3', '45000', '�������', '2018-04-16 22:19:00'
EXEC Insert_license '4', '55000', '�������', '2018-04-16 22:19:00'
EXEC Insert_license '5', '65000', '�������', '2018-04-16 22:19:00'
EXEC Insert_license '6', '75000', '�������', '2018-04-16 22:19:00'
EXEC Insert_license '7', '85000', '�������', '2018-04-16 22:19:00'
EXEC Insert_license '8', '95000', '�������', '2018-04-16 22:19:00'
EXEC Insert_license '9', '105000', '�������', '2018-04-16 22:19:00'
EXEC Insert_license '10', '115000', '�������', '2018-04-16 22:19:00'

EXEC Insert_place_in_Row_Hall 1, 1, 10
EXEC Insert_place_in_Row_Hall 1, 2, 10
EXEC Insert_place_in_Row_Hall 1, 3, 10
EXEC Insert_place_in_Row_Hall 1, 4, 10
EXEC Insert_place_in_Row_Hall 1, 5, 10
EXEC Insert_place_in_Row_Hall 1, 6, 10
EXEC Insert_place_in_Row_Hall 1, 7, 10
EXEC Insert_place_in_Row_Hall 1, 8, 10
EXEC Insert_place_in_Row_Hall 1, 9, 10
EXEC Insert_place_in_Row_Hall 1, 10, 10

EXEC Insert_place_in_Row_Hall 2, 1, 10
EXEC Insert_place_in_Row_Hall 2, 2, 10
EXEC Insert_place_in_Row_Hall 2, 3, 10
EXEC Insert_place_in_Row_Hall 2, 4, 10
EXEC Insert_place_in_Row_Hall 2, 5, 10
EXEC Insert_place_in_Row_Hall 2, 6, 10
EXEC Insert_place_in_Row_Hall 2, 7, 10

EXEC Insert_place_in_Row_Hall 3, 1, 10
EXEC Insert_place_in_Row_Hall 3, 2, 10
EXEC Insert_place_in_Row_Hall 3, 3, 10
EXEC Insert_place_in_Row_Hall 3, 4, 10
EXEC Insert_place_in_Row_Hall 3, 5, 10
EXEC Insert_place_in_Row_Hall 3, 6, 10
EXEC Insert_place_in_Row_Hall 3, 7, 10

EXEC Insert_place_in_Row_Hall 4, 1, 10
EXEC Insert_place_in_Row_Hall 4, 2, 10
EXEC Insert_place_in_Row_Hall 4, 3, 10
EXEC Insert_place_in_Row_Hall 4, 4, 10
EXEC Insert_place_in_Row_Hall 4, 5, 10
EXEC Insert_place_in_Row_Hall 4, 6, 10
EXEC Insert_place_in_Row_Hall 4, 7, 10

EXEC Insert_place_in_Row_Hall 5, 1, 10
EXEC Insert_place_in_Row_Hall 5, 2, 10
EXEC Insert_place_in_Row_Hall 5, 3, 10
EXEC Insert_place_in_Row_Hall 5, 4, 10
EXEC Insert_place_in_Row_Hall 5, 5, 10
EXEC Insert_place_in_Row_Hall 5, 6, 10
EXEC Insert_place_in_Row_Hall 5, 7, 10
EXEC Insert_place_in_Row_Hall 5, 8, 10
EXEC Insert_place_in_Row_Hall 5, 9, 10
EXEC Insert_place_in_Row_Hall 5, 10, 10

INSERT INTO ������������
VALUES ('1', '3D IMAX', '��������'),
	   ('2', '2D', '��������'),
	   ('3', '2D', '��������'),
	   ('4', '2D', '��������'),
	   ('5', '3D', '��������');
GO

EXEC Insert_session '2017-06-07 10:00:00', '������������', '2014'
EXEC Insert_session '2017-06-07 12:00:00', '������������', '2014'
EXEC Insert_session '2017-06-07 15:50:00', '������������', '2014'
EXEC Insert_session '2017-06-07 16:00:00', '������������', '2014'
EXEC Insert_session '2017-06-07 17:40:00', '������������', '2014'
EXEC Insert_session '2017-06-07 18:30:00', '������������', '2014'
EXEC Insert_session '2017-06-07 10:30:00', '������� ����', '2009'
EXEC Insert_session '2017-06-07 15:40:00', '������� ����', '2009'
EXEC Insert_session '2017-06-08 14:20:00', '������� ����', '2009'
EXEC Insert_session '2017-06-08 15:00:00', '������� ����', '2009'
EXEC Insert_session '2017-06-08 18:30:00', '������� ����', '2009'
EXEC Insert_session '2017-06-09 15:00:00', '������� ����', '2009'
EXEC Insert_session '2017-06-09 17:00:00', '������ ��������� 2', '2017'
EXEC Insert_session '2017-06-09 15:20:00', '������ ��������� 2', '2017'
EXEC Insert_session '2017-06-10 13:20:00', '������ ��������� 2', '2017'
EXEC Insert_session '2017-06-11 15:20:00', '������ ��������� 2', '2017'
EXEC Insert_session '2017-06-11 17:00:00', '������ ��������� 2', '2017'
EXEC Insert_session '2017-06-11 19:20:00', '������ ��������� 2', '2017'
EXEC Insert_session '2017-06-10 15:00:00', '������ �������', '2016'
EXEC Insert_session '2017-06-10 16:00:00', '������ �������', '2016'
EXEC Insert_session '2017-06-10 17:00:00', '������ �������', '2016'
EXEC Insert_session '2017-06-10 18:00:00', '������ �������', '2016'
EXEC Insert_session '2017-06-10 20:00:00', '������ �������', '2016'
EXEC Insert_session '2017-06-10 21:00:00', '������ �������', '2016'
EXEC Insert_session '2017-06-06 10:30:00', '������', '2009'
EXEC Insert_session '2017-06-06 11:00:00', '������', '2009'
EXEC Insert_session '2017-06-06 12:30:00', '������', '2009'
EXEC Insert_session '2017-06-06 13:00:00', '������', '2009'
EXEC Insert_session '2017-06-06 14:30:00', '������', '2009'
EXEC Insert_session '2017-06-08 15:00:00', '������', '2009'
EXEC Insert_session '2017-06-08 11:00:00', '��������', '2013'
EXEC Insert_session '2017-06-08 12:30:00', '��������', '2013'
EXEC Insert_session '2017-06-08 13:00:00', '��������', '2013'
EXEC Insert_session '2017-06-08 14:30:00', '��������', '2013'
EXEC Insert_session '2017-06-08 15:00:00', '��������', '2013'
EXEC Insert_session '2017-06-08 18:30:00', '��������', '2013'

INSERT INTO ���������
VALUES ('������� �������� ���������', '5592622638', '�����������', '+79111232424', '�� ��������, 48'),
	   ('������������ ���������� ���������', '5592622639', '�����������', '+79111232425', '�� ��������, 47'),
	   ('��������� ������ ������������', '5592622640', '�����������', '+79111232426', '�� ��������, 46'),
	   ('��������� ������� ���������������', '5592622641', '�����������', '+79111232427', '�� ��������, 45'),
	   ('��������� ����������� ��������', '5592622642', '�����������', '+79111232428', '�� ��������, 44'),
	   ('������ ����� ���������', '9485969289', '�������������', '+79209997788', '�� ��������, 25'),
	   ('�������� ���� ����������', '9485969271', '�������� �� ���������', '+79209997799', '�� ��������, 20'),
       ('�������� ���� ����������', '9485969241', '�������� �� �������� ��������', '+79209999999', '�� ��������, 48'),
	   ('������ ���� ����������', '5833926340', '������', '+79171225577', '�� ��������, 19'),
	   ('��������� ������� ��������', '5833922277', '������', '+79181225599', '�� �����������������, 29'),
	   ('������� ��� �������������', '5833926385', '��������', '+79003225577', '�� ��������, 19'),
	   ('��������� ��������� ����������', '5833856340', '��������', '+79007225577', '�� ��������, 18'),
	   ('�������� ������ ����������', '5833928340', '��������', '+79007725577', '�� ��������, 17'),
	   ('������� ����� ���������', '5833926850', '��������', '+79001224277', '�� ��������, 16'),
	   ('�������� ����� �������������', '5855926340', '��������', '+79000225577', '�� ��������, 15'),
	   ('�������� ����� �����������', '7733926340', '��������', '+79779925577', '�� ��������, 20'),
	   ('��������� ���� ��������', '7833926340', '��������', '+79099985577', '�� ��������, 21'),
	   ('�������� ������ ����������', '7933926340', '��������', '+79009995577', '�� ��������, 25'),
	   ('������ ����� ��������', '9033926340', '��������', '+79001229977', '�� ��������, 14'),
	   ('��������� ���� ����������', '9533926340', '��������', '+79009925577', '�� ��������, 10');
GO

EXEC Insert_film '������������', '2014', '��������� �����', '����������', '2D IMAX', 'PG-13'
EXEC Insert_film '������� ����', '2009', '���� ���� ������', '����������', '2D', 'PG-13'
EXEC Insert_film '������ ���������', '2014', '������ ����', '����������', '3D IMAX', 'PG-13'
EXEC Insert_film '������ ��������� 2', '2017', '������ ����', '����������', '3D IMAX', 'PG-13'
EXEC Insert_film '������', '2009', '������ �������', '����������', '3D IMAX', 'PG-13'
EXEC Insert_film '�������', '2015', '���� ��������', '����������', '3D', 'PG-13'
EXEC Insert_film '������������� �����', '2013', '�������� ���� ����', '�����������', '3D IMAX', 'PG-13'
EXEC Insert_film '�����', '2017', '������ �������', '����������', '3D IMAX', 'R'
EXEC Insert_film '������ �������', '2016', '����� ���������', '����������', '3D IMAX', 'PG-13'
EXEC Insert_film '��������', '2013', '������ ��������', '����������', '3D IMAX', 'PG-13'

EXEC Insert_showing_a_film '1', '������� ����', '2009', '������������ ���������� ���������', '5592622639', '�����������'
EXEC Insert_showing_a_film '2', '������������', '2014', '������� �������� ���������', '5592622638', '�����������'
EXEC Insert_showing_a_film '3', '������ ��������� 2', '2017', '��������� ����������� ��������', '5592622642', '�����������'
EXEC Insert_showing_a_film '4', '������ �������', '2016', '��������� ������ ������������', '5592622640', '�����������'
EXEC Insert_showing_a_film '5', '������', '2009', '��������� ������� ���������������', '5592622641', '�����������'

EXEC Insert_shows_the_film 1, '������������', '2014', '��������� �����', '����������', '2D IMAX', 'PG-13'
EXEC Insert_shows_the_film 2, '������� ����', '2009', '���� ���� ������', '����������', '2D', 'PG-13'
EXEC Insert_shows_the_film 3, '������ ��������� 2', '2017', '������ ����', '����������', '3D IMAX', 'PG-13'
EXEC Insert_shows_the_film 4, '������ �������', '2016', '����� ���������', '����������', '3D IMAX', 'PG-13'
EXEC Insert_shows_the_film 5, '������', '2009', '������ �������', '����������', '3D IMAX', 'PG-13'

EXEC Insert_session_in_Hall '2017-06-07 10:00:00',1,'������������', '2014'
EXEC Insert_session_in_Hall '2017-06-07 12:00:00',1,'������������', '2014'
EXEC Insert_session_in_Hall '2017-06-07 15:50:00',1,'������������', '2014'
EXEC Insert_session_in_Hall '2017-06-07 16:00:00',1,'������������', '2014'
EXEC Insert_session_in_Hall '2017-06-07 17:40:00',1,'������������', '2014'
EXEC Insert_session_in_Hall '2017-06-07 18:30:00',1,'������������', '2014'
EXEC Insert_session_in_Hall '2017-06-07 10:30:00',2,'������� ����', '2009'
EXEC Insert_session_in_Hall '2017-06-07 15:40:00',2,'������� ����', '2009'
EXEC Insert_session_in_Hall '2017-06-08 14:20:00',2,'������� ����', '2009'
EXEC Insert_session_in_Hall '2017-06-08 15:00:00',2,'������� ����', '2009'
EXEC Insert_session_in_Hall '2017-06-08 18:30:00',2,'������� ����', '2009'
EXEC Insert_session_in_Hall '2017-06-09 15:00:00',2,'������� ����', '2009'
EXEC Insert_session_in_Hall '2017-06-09 17:00:00',4,'������ ��������� 2', '2017'
EXEC Insert_session_in_Hall '2017-06-09 15:20:00',4,'������ ��������� 2', '2017'
EXEC Insert_session_in_Hall '2017-06-10 13:20:00',3, '������ ��������� 2', '2017'
EXEC Insert_session_in_Hall '2017-06-11 15:20:00',3,'������ ��������� 2', '2017'
EXEC Insert_session_in_Hall '2017-06-11 17:00:00',3,'������ ��������� 2', '2017'
EXEC Insert_session_in_Hall '2017-06-11 19:20:00',3,'������ ��������� 2', '2017'
EXEC Insert_session_in_Hall '2017-06-10 15:00:00',4,'������ �������', '2016'
EXEC Insert_session_in_Hall '2017-06-10 16:00:00',4,'������ �������', '2016'
EXEC Insert_session_in_Hall '2017-06-10 17:00:00',4,'������ �������', '2016'
EXEC Insert_session_in_Hall '2017-06-10 18:00:00',4,'������ �������', '2016'
EXEC Insert_session_in_Hall '2017-06-10 20:00:00',4,'������ �������', '2016'
EXEC Insert_session_in_Hall '2017-06-10 21:00:00',4,'������ �������', '2016'
EXEC Insert_session_in_Hall '2017-06-06 10:30:00',1,'������', '2009'
EXEC Insert_session_in_Hall '2017-06-06 11:00:00',1,'������', '2009'
EXEC Insert_session_in_Hall '2017-06-06 12:30:00',1,'������', '2009'
EXEC Insert_session_in_Hall '2017-06-06 13:00:00',1,'������', '2009'
EXEC Insert_session_in_Hall '2017-06-06 14:30:00',1,'������', '2009'
EXEC Insert_session_in_Hall '2017-06-08 15:00:00',5,'������', '2009'
EXEC Insert_session_in_Hall '2017-06-08 11:00:00',5,'��������', '2013'
EXEC Insert_session_in_Hall '2017-06-08 12:30:00',5,'��������', '2013'
EXEC Insert_session_in_Hall '2017-06-08 13:00:00',5,'��������', '2013'
EXEC Insert_session_in_Hall '2017-06-08 14:30:00',5, '��������', '2013'
EXEC Insert_session_in_Hall '2017-06-08 15:00:00',1,'��������', '2013'
EXEC Insert_session_in_Hall '2017-06-08 18:30:00', 5,'��������', '2013'

INSERT INTO ����������_����
VALUES ('1', '������� �������� ���������', '5592622638', '�����������'),
       ('2', '������������ ���������� ���������', '5592622639', '�����������'),
	   ('3', '��������� ������ ������������', '5592622640', '�����������'),
	   ('4', '��������� ������� ���������������', '5592622641', '�����������'),
	   ('5', '��������� ����������� ��������', '5592622642', '�����������'),
	   ('1', '�������� ����� �����������', '7733926340', '��������'),
       ('2', '��������� ���� ��������', '7833926340', '��������'),
	   ('3', '�������� ������ ����������', '7933926340', '��������'),
	   ('4', '������ ����� ��������', '9033926340', '��������'),
	   ('5', '��������� ���� ����������', '9533926340', '��������'),
	   ('1', '������� ��� �������������', '5833926385', '��������'),
       ('2', '��������� ��������� ����������', '5833856340', '��������'),
	   ('3', '�������� ������ ����������', '5833928340', '��������'),
	   ('4', '������� ����� ���������', '5833926850', '��������'),
	   ('5', '�������� ����� �������������', '5855926340', '��������')
GO

EXEC Insert_acquisition_of_a_license '1', '������������', '2014', '�������� ���� ����������', '9485969241', '�������� �� �������� ��������'
EXEC Insert_acquisition_of_a_license '2', '������� ����', '2009', '�������� ���� ����������', '9485969241', '�������� �� �������� ��������'
EXEC Insert_acquisition_of_a_license '3', '������ ���������', '2014', '�������� ���� ����������', '9485969241', '�������� �� �������� ��������'
EXEC Insert_acquisition_of_a_license '4', '������', '2009', '�������� ���� ����������', '9485969241', '�������� �� �������� ��������'
EXEC Insert_acquisition_of_a_license '5', '�������', '2015', '�������� ���� ����������', '9485969241', '�������� �� �������� ��������'
EXEC Insert_acquisition_of_a_license '6', '������������� �����', '2013', '�������� ���� ����������', '9485969241', '�������� �� �������� ��������'
EXEC Insert_acquisition_of_a_license '7', '�����', '2017', '�������� ���� ����������', '9485969241', '�������� �� �������� ��������'
EXEC Insert_acquisition_of_a_license '8', '������ �������', '2016', '�������� ���� ����������', '9485969241', '�������� �� �������� ��������'
EXEC Insert_acquisition_of_a_license '9', '��������', '2013', '�������� ���� ����������', '9485969241', '�������� �� �������� ��������'
EXEC Insert_acquisition_of_a_license '10', '������ ��������� 2', '2017', '�������� ���� ����������', '9485969241', '�������� �� �������� ��������'

EXEC Insert_ticket_selling '������', '2009', '1', '1', '1', '������� ������� ��������', '2017-06-06 10:30:00', '��������� ������� ��������', '5833922277', '1', '+79001234567'
EXEC Insert_ticket_selling '������', '2009', '3', '3', '1', '������� ������� ��������', '2017-06-06 10:30:00', '��������� ������� ��������', '5833922277', '2', '+79001234567'
EXEC Insert_ticket_selling '������', '2009', '5', '5', '1', '������� ������� ��������������', '2017-06-06 10:30:00', '��������� ������� ��������', '5833922277', '3', '+79001234564'
EXEC Insert_ticket_selling '������', '2009', '6', '4', '1', '������� ������� ��������������', '2017-06-06 10:30:00', '��������� ������� ��������', '5833922277', '4', '+79001234564'
EXEC Insert_ticket_selling '������', '2009', '7', '3', '1', '������� ������� ��������', '2017-06-06 10:30:00', '��������� ������� ��������', '5833922277', '5', '+79001234567'
EXEC Insert_ticket_selling '������', '2009', '2', '3', '1', '������� ������� ��������', '2017-06-06 10:30:00', '��������� ������� ��������', '5833922277', '6', '+79001234567'
EXEC Insert_ticket_selling '������', '2009', '4', '4', '1', '������� ������� ��������', '2017-06-06 10:30:00', '��������� ������� ��������', '5833922277', '7', '+79001234567'
EXEC Insert_ticket_selling '������������', '2014', '1', '1', '1', '������� ������� ��������', '2017-06-07 18:30:00', '������ ���� ����������', '5833926340', '8', '+79001234567'
EXEC Insert_ticket_selling '������������', '2014', '2', '1', '1', '������� ������� ��������', '2017-06-07 18:30:00', '������ ���� ����������', '5833926340', '9', '+79001234567'
EXEC Insert_ticket_selling '������������', '2014', '3', '1', '1', '������� ������� ��������', '2017-06-07 18:30:00', '������ ���� ����������', '5833926340', '10', '+79001234567'
EXEC Insert_ticket_selling '������������', '2014', '1', '2', '1', '������� ������� ��������', '2017-06-07 18:30:00', '������ ���� ����������', '5833926340', '11', '+79001234567'
EXEC Insert_ticket_selling '������������', '2014', '2', '2', '1', '������� ������� ��������', '2017-06-07 18:30:00', '������ ���� ����������', '5833926340', '12', '+79001234567'
EXEC Insert_ticket_selling '������������', '2014', '3', '2', '1', '������� ������� ��������', '2017-06-07 18:30:00', '������ ���� ����������', '5833926340', '13', '+79001234567'
EXEC Insert_ticket_selling '������������', '2014', '1', '3', '1', '������� ������� ��������', '2017-06-07 18:30:00', '������ ���� ����������', '5833926340', '14', '+79001234567'
EXEC Insert_ticket_selling '������������', '2014', '2', '3', '1', '������� ������� ��������', '2017-06-07 18:30:00', '������ ���� ����������', '5833926340', '15', '+79001234567'
EXEC Insert_ticket_selling '������������', '2014', '3', '3', '1', '������� ������� ��������', '2017-06-07 18:30:00', '������ ���� ����������', '5833926340', '16', '+79001234567'
EXEC Insert_ticket_selling '������������', '2014', '4', '3', '1', '������� ������� ��������', '2017-06-07 18:30:00', '������ ���� ����������', '5833926340', '17', '+79001234567'
EXEC Insert_ticket_selling '������������', '2014', '5', '3', '1', '������� ������� ��������', '2017-06-07 18:30:00', '������ ���� ����������', '5833926340', '18', '+79001234567'
EXEC Insert_ticket_selling '������������', '2014', '1', '7', '1', '������� ������� ��������', '2017-06-07 18:30:00', '������ ���� ����������', '5833926340', '19', '+79001234567'
EXEC Insert_ticket_selling '������������', '2014', '2', '7', '1', '������� ������� ��������', '2017-06-07 18:30:00', '������ ���� ����������', '5833926340', '20', '+79001234567'
EXEC Insert_ticket_selling '������������', '2014', '5', '7', '1', '������� ������� ��������', '2017-06-07 18:30:00', '������ ���� ����������', '5833926340', '21', '+79001234567'
