USE master
GO

/*Создание базы данных*/

CREATE DATABASE Cinema ON
    (NAME = 'Cinema', FILENAME = 'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\Cinema.mdf',
    SIZE = 5,MAXSIZE = 100, FILEGROWTH = 1)
LOG ON
    (NAME = 'CinemaLog', FILENAME = 'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\CinemaLog.ldf',
    SIZE = 5,MAXSIZE = 100, FILEGROWTH = 1)
GO

USE Cinema
GO

/*Создание типов, умолчаний и правил*/

/*Тип для типа клиента, который позволяет указывать тип клиента либо "Обычный", либо "VIP"*/

CREATE TYPE TypeClient
FROM NVARCHAR(7) NOT NULL;
GO

CREATE DEFAULT TypeClientDefault
AS 'Обычный'
GO

EXEC sp_bindefault 'TypeClientDefault', 'TypeClient'
GO

CREATE RULE TypeClientRule
AS @x IN ('Обычный', 'VIP')
GO

EXEC sp_bindrule 'TypeClientRule', 'TypeClient'
GO

/*Тип для формата фильма, который позволяет указывать формат фильма: "2D", "3D", "2D IMAX", "3D IMAX"*/

CREATE TYPE FormatFilm
FROM NVARCHAR(7) NOT NULL;
GO

CREATE RULE FormatFilmRule
AS @x IN ('2D', '3D', '2D IMAX', '3D IMAX')
GO

EXEC sp_bindrule 'FormatFilmRule', 'FormatFilm'
GO

/*Тип для рейтинга фильма, который позволяет указывать формат фильма: "G", "PG", "PG-13", "R", "NC-17"*/

CREATE TYPE RatingFilm
FROM NVARCHAR(5) NOT NULL;
GO

CREATE RULE RatingFilmRule
AS @x IN ('G', 'PG', 'PG-13', 'R', 'NC-17')
GO

EXEC sp_bindrule 'RatingFilmRule', 'RatingFilm'
GO

/*Тип для скидки клиента, который позволяет указывать скидку в размере 0, 5 или 10%"*/

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

/*Тип для формата телефона клиента"*/

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

/*Тип для формата пасспорта сотрудника"*/

CREATE RULE PassportRule
AS @x LIKE '[0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9]'
GO

EXEC sp_bindrule 'PassportRule', 'Passport'
GO

/*Тип для формата Email клиента"*/

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

/*Создание таблиц*/

CREATE TABLE Клиент
    (ФИО_клиента nvarchar(50) not null,
     Тип_клиента TypeClient not null,
	 Скидочная_карта int UNIQUE null,
	 Скидка Discount null,
	 Email Email null,
	 Телефон_клиента Phone not null,
	 CONSTRAINT PK_Клиент PRIMARY KEY (ФИО_клиента, Телефон_клиента)
    )

CREATE TABLE Лицензия
    (Номер_лицензии int primary key not null,
     Стоимость_лицензии CostLicense not null,
	 Описание_лицензии nvarchar(100) not null,
	 Срок_лицензии date null
    )

CREATE TABLE Должность
    (Название_должности nvarchar(50) primary key not null,
     Описание_должности nvarchar(150) not null,
	 Зарплата money not null
    )

CREATE TABLE Оборудование
    (ID_оборудования int primary key not null,
     Формат_оборудования nvarchar(50) not null,
	 Описание_оборудования nvarchar(50) not null
    )

CREATE TABLE Сеанс
    (Время_сеанса datetime primary key not null,
     Название_фильма nvarchar(50) not null,
	 Год_выпуска date not null
    )

CREATE TABLE Сотрудник
    (ФИО_сотрудника nvarchar(50) not null,
     Паспортные_данные_сотрудника Passport not null,
	 Название_должности nvarchar(50) not null,
	 Номер_телефона_сотрудника Phone null,
	 Адрес_сотрудника nvarchar(50) not null,
	 CONSTRAINT PK_Сотрудник PRIMARY KEY (ФИО_сотрудника, Паспортные_данные_сотрудника),
     CONSTRAINT FK_Сотрудник_Должность FOREIGN KEY (Название_должности) REFERENCES Должность(Название_должности)
    )

CREATE TABLE Фильм
    (Название_фильма nvarchar(50) not null,
	 Год_выпуска date not null,
	 Режиссёр nvarchar(50) not null,
	 Жанр nvarchar(50) not null,
	 Формат FormatFilm not null,
	 Рейтинг RatingFilm not null
	 CONSTRAINT PK_Фильм PRIMARY KEY (Название_фильма, Год_выпуска)
    )

CREATE TABLE Зал
    (Номер_зала int primary key not null,
     Описание_зала nvarchar(50) not null,
	 Количество_мест int not null
    )

CREATE TABLE Сотрудники_зала
    (Номер_зала int not null,
     ФИО_сотрудника nvarchar(50) not null,
     Паспортные_данные_сотрудника nvarchar(10) not null,
	 Название_должности nvarchar(50) not null
	 CONSTRAINT PK_Сотрудники_зала PRIMARY KEY (Номер_зала, ФИО_сотрудника, Паспортные_данные_сотрудника)
	 CONSTRAINT FK_Сотрудники_зала_Зал FOREIGN KEY (Номер_зала) REFERENCES Зал(Номер_зала),
	 CONSTRAINT FK_Сотрудники_зала_Сотрудник FOREIGN KEY (ФИО_сотрудника, Паспортные_данные_сотрудника) REFERENCES Сотрудник(ФИО_сотрудника, Паспортные_данные_сотрудника)
    )

CREATE TABLE Показывает_фильм
    (Номер_зала int not null,
	 Название_фильма nvarchar(50) not null,
	 Год_выпуска date not null,
	 CONSTRAINT PK_Показывает_фильм PRIMARY KEY (Номер_зала, Название_фильма, Год_выпуска),
	 CONSTRAINT FK_Показывает_фильм_Зал FOREIGN KEY (Номер_зала) REFERENCES Зал(Номер_зала),
	 CONSTRAINT FK_Показывает_фильм_Фильм FOREIGN KEY (Название_фильма, Год_выпуска) REFERENCES Фильм(Название_фильма, Год_выпуска)
	)

CREATE TABLE Сеансы_зала
    (Номер_зала int not null,
     Время_сеанса datetime not null,
	 CONSTRAINT PK_Сеансы_зала PRIMARY KEY (Номер_зала, Время_сеанса),
	 CONSTRAINT FK_Сеансы_зала_Зал FOREIGN KEY (Номер_зала) REFERENCES Зал(Номер_зала),
	 CONSTRAINT FK_Сеансы_зала_Сеанс FOREIGN KEY (Время_сеанса) REFERENCES Сеанс(Время_сеанса)
    )

CREATE TABLE Показ_фильма
    (ID_оборудования int not null,
	 Название_фильма nvarchar(50) not null,
	 Год_выпуска date not null,
	 ФИО_сотрудника nvarchar(50) not null,
     Паспортные_данные_сотрудника Passport not null,
	 Название_должности nvarchar(50) not null,
	 CONSTRAINT PK_Показ_фильма PRIMARY KEY (ID_оборудования, Название_фильма, Год_выпуска, ФИО_сотрудника, Паспортные_данные_сотрудника),
	 CONSTRAINT FK_Показ_фильма_Оборудование FOREIGN KEY (ID_оборудования) REFERENCES Оборудование(ID_оборудования),
	 CONSTRAINT FK_Показ_фильма_Сотрудник FOREIGN KEY (ФИО_сотрудника, Паспортные_данные_сотрудника) REFERENCES Сотрудник(ФИО_сотрудника, Паспортные_данные_сотрудника),
	 CONSTRAINT FK_Показ_фильма_Фильм FOREIGN KEY (Название_фильма, Год_выпуска) REFERENCES Фильм(Название_фильма, Год_выпуска)
    )

CREATE TABLE Приобретение_лицензии
    (Номер_лицензии int UNIQUE not null,
	 Название_фильма nvarchar(50) not null,
	 Год_выпуска date not null,
	 ФИО_сотрудника nvarchar(50) not null,
     Паспортные_данные_сотрудника nvarchar(10) not null,
	 Название_должности nvarchar(50) not null,
	 CONSTRAINT PK_Приобретение_лицензии PRIMARY KEY (Номер_лицензии, Название_фильма, Год_выпуска, ФИО_сотрудника, Паспортные_данные_сотрудника),
	 CONSTRAINT FK_Приобретение_лицензии_Лицензия FOREIGN KEY (Номер_лицензии) REFERENCES Лицензия(Номер_лицензии),
	 CONSTRAINT FK_Приобретение_лицензии_Сотрудник FOREIGN KEY (ФИО_сотрудника, Паспортные_данные_сотрудника) REFERENCES Сотрудник(ФИО_сотрудника, Паспортные_данные_сотрудника),
	 CONSTRAINT FK_Приобретение_лицензии_Фильм FOREIGN KEY (Название_фильма, Год_выпуска) REFERENCES Фильм(Название_фильма, Год_выпуска)
    )

CREATE TABLE Место
    (Номер_места int not null,
	 Номер_ряда int not null,
	 CONSTRAINT PK_Место PRIMARY KEY (Номер_места, Номер_ряда)
	)

CREATE TABLE Места_в_зале
    (Номер_места int not null,
	 Номер_ряда int not null,
	 Номер_зала int not null,
	 CONSTRAINT PK_Места_в_зале PRIMARY KEY (Номер_места, Номер_ряда, Номер_зала),
	 CONSTRAINT FK_Места_в_зале_Зал FOREIGN KEY (Номер_зала) REFERENCES Зал(Номер_зала),
	 CONSTRAINT FK_Места_в_зале_Место FOREIGN KEY (Номер_места, Номер_ряда) REFERENCES Место(Номер_места, Номер_ряда)
	)

CREATE TABLE Билет
    (Номер_билета int primary key not null,
	 Цена_билета money not null,
	 Дата_и_время_продажи_билета datetime not null
	)

CREATE TABLE Продажа_билетов
    (Название_фильма nvarchar(50) not null,
	 Год_выпуска date not null,
	 Номер_места int not null,
	 Номер_ряда int not null,
	 Номер_зала int not null,
	 ФИО_клиента nvarchar(50) not null,
	 Время_сеанса datetime not null,
	 Паспортные_данные_сотрудника nvarchar(10) not null,
	 ФИО_сотрудника nvarchar(50) not null,
	 Номер_билета int UNIQUE not null,
	 Телефон_клиента Phone not null,
     CONSTRAINT PK_Продажа_билетов PRIMARY KEY (Номер_ряда, Номер_места, ФИО_клиента, Время_сеанса, Паспортные_данные_сотрудника, ФИО_сотрудника, Номер_зала, Телефон_клиента),
	 CONSTRAINT FK_Продажа_билетов_Билет FOREIGN KEY (Номер_билета) REFERENCES Билет(Номер_билета),
	 CONSTRAINT FK_Продажа_билетов_Клиент FOREIGN KEY (ФИО_клиента, Телефон_клиента) REFERENCES Клиент(ФИО_клиента, Телефон_клиента),
	 CONSTRAINT FK_Продажа_билетов_Сеанс FOREIGN KEY (Время_сеанса) REFERENCES Сеанс(Время_сеанса),
	 CONSTRAINT FK_Продажа_билетов_Зал FOREIGN KEY (Номер_зала) REFERENCES Зал(Номер_зала),
	 CONSTRAINT FK_Продажа_билетов_Место FOREIGN KEY (Номер_места, Номер_ряда) REFERENCES Место(Номер_места, Номер_ряда),
     CONSTRAINT FK_Продажа_билетов_Сотрудник FOREIGN KEY (ФИО_сотрудника, Паспортные_данные_сотрудника) REFERENCES Сотрудник(ФИО_сотрудника, Паспортные_данные_сотрудника)
    )
GO

/*Создание представлений*/

/*Представление для отображения ТОП 5 клиентов кинотеатра по количеству купленных билетов*/

CREATE VIEW Топ_клиентов
AS
	SELECT TOP(5) ФИО_клиента, COUNT(Номер_билета) AS 'Количество_билетов'
	FROM Продажа_билетов
	GROUP BY ФИО_клиента
	ORDER BY COUNT(*) DESC
GO

/*Представление для отображения ТОП 5 кассиров кинотеатра по количеству проданных билетов*/

CREATE VIEW Топ_кассиров
AS
	SELECT TOP(5) ФИО_сотрудника, COUNT(Номер_билета) AS 'Количество_билетов'
	FROM Продажа_билетов
	GROUP BY ФИО_сотрудника
	ORDER BY COUNT(*) DESC
GO

/*Представление для отображения количества проданных билетов в каждом зале*/

CREATE VIEW Кол_билетов_зала
AS
	SELECT Номер_зала, COUNT(Номер_билета) AS 'Количество_билетов'
	FROM Продажа_билетов
	GROUP BY Номер_зала
GO

/*Представление для отображения ТОП 5 фильмов кинотеатра по количеству купленных билетов*/

CREATE VIEW Топ_фильмов
AS
	SELECT TOP(5) Название_фильма, COUNT(Номер_билета) AS 'Количество_билетов'
	FROM Продажа_билетов
	GROUP BY Название_фильма
	ORDER BY COUNT(*) DESC
GO

/*Представление для отображения ТОП 5 залов в которых не показываются фильмы и имеют большое количество свободных мест*/

CREATE VIEW Залы_без_фильмов
AS
	SELECT TOP(5) Номер_зала, Количество_мест
	FROM Зал
	WHERE Номер_зала NOT IN (SELECT Номер_зала
	                         FROM Показывает_фильм)
	GROUP BY Номер_зала, Количество_мест
	ORDER BY Количество_мест DESC
GO

/*Представление для отображения свободных мест в кинотеатре*/
CREATE VIEW Свободные_места
AS
	SELECT TOP(10000) Места_в_зале.Номер_зала, Название_фильма, Год_выпуска, Сеансы_зала.Время_сеанса, Номер_ряда, Номер_места
	FROM Сеансы_зала INNER JOIN Места_в_зале ON Сеансы_зала.Номер_зала = Места_в_зале.Номер_зала INNER JOIN Сеанс ON Сеанс.Время_сеанса = Сеансы_зала.Время_сеанса
	ORDER BY Места_в_зале.Номер_зала ASC
	EXCEPT
	SELECT Номер_зала, Название_фильма, Год_выпуска, Время_сеанса, Номер_ряда, Номер_места
	FROM Продажа_билетов
GO

     /*Создание процедур*/

     /*Процедуры для клиента*/

     CREATE PROC Insert_client
      (@ФИО_клиента nvarchar(50),
       @Тип_клиента TypeClient,
       @Скидочная_карта int,
       @Скидка Discount,
       @Email Email,
       @Телефон Phone
      )
     AS
      IF NOT EXISTS (SELECT *
                     FROM Клиент
                     WHERE ФИО_клиента = @ФИО_клиента)
      BEGIN
     	INSERT INTO Клиент
     	VALUES (@ФИО_клиента, @Тип_клиента, @Скидочная_карта, @Скидка, @Email, @Телефон);
      END
      ELSE PRINT N'Такой клиент существует!'
     GO

     CREATE PROC Update_client
      (@ФИО_клиента nvarchar(50),
       @Тип_клиента TypeClient,
       @Скидка Discount,
       @Email Email,
       @Телефон Phone
      )
     AS
      IF EXISTS (SELECT *
                 FROM Клиент
                 WHERE ФИО_клиента = @ФИО_клиента AND Телефон_клиента = @Телефон)
      BEGIN
        UPDATE Клиент
        SET Тип_клиента = @Тип_клиента,
     	   Скидка = @Скидка,
     	   Email = @Email,
     	   Телефон_клиента = @Телефон
        WHERE ФИО_клиента = @ФИО_клиента AND Телефон_клиента = @Телефон
      END
      ELSE PRINT N'Такого клиента не существует!'
     GO

     CREATE PROC Delete_client (@ФИО_клиента nvarchar(50), @Телефон_клиента Phone)
     AS
      IF EXISTS (SELECT *
                 FROM Клиент
                 WHERE ФИО_клиента = @ФИО_клиента AND Телефон_клиента = @Телефон_клиента)
      BEGIN
     	DELETE FROM Продажа_билетов
     	WHERE ФИО_клиента = @ФИО_клиента AND Телефон_клиента = @Телефон_клиента
     	DELETE FROM Клиент
     	WHERE ФИО_клиента = @ФИО_клиента AND Телефон_клиента = @Телефон_клиента
      END
      ELSE PRINT N'Такого клиента не существует!'
     GO

     /*Процедуры для должности*/

     CREATE PROC Insert_post
      (@Название_должности nvarchar(50),
       @Описание_должности nvarchar(150),
       @Зарплата money
      )
     AS
      IF NOT EXISTS (SELECT *
                     FROM Должность
                     WHERE Название_должности = @Название_должности)
      BEGIN
     	INSERT INTO Должность
     	VALUES (@Название_должности, @Описание_должности, @Зарплата);
      END
      ELSE PRINT N'Такая должность существует!'
     GO

     CREATE PROC Update_post
      (@Название_должности nvarchar(50),
       @Описание_должности nvarchar(150),
       @Зарплата money
      )
     AS
      IF EXISTS (SELECT *
                 FROM Должность
                 WHERE Название_должности = @Название_должности)
      BEGIN
        UPDATE Должность
        SET Описание_должности = @Описание_должности,
     	   Зарплата = @Зарплата
        WHERE Название_должности = @Название_должности
      END
      ELSE PRINT N'Такой должности не существует!'
     GO

     CREATE PROC Delete_post (@Название_должности nvarchar(50))
     AS
      IF EXISTS (SELECT *
                 FROM Должность
                 WHERE Название_должности = @Название_должности)
      BEGIN
     	DELETE FROM Сотрудник
     	WHERE Название_должности = @Название_должности
     	DELETE FROM Показ_фильма
     	WHERE Название_должности = @Название_должности
     	DELETE FROM Приобретение_лицензии
     	WHERE Название_должности = @Название_должности
     	DELETE FROM Сотрудники_зала
     	WHERE Название_должности = @Название_должности
     	DELETE FROM Должность
     	WHERE Название_должности = @Название_должности
      END
      ELSE PRINT N'Такой должности не существует!'
     GO

     /*Процедуры для лицензии*/

     CREATE PROC Insert_license
      (@Номер_лицензии int,
       @Стоимость_лицензии CostLicense,
       @Описание_лицензии nvarchar(100),
       @Срок_лицензии date
      )
     AS
      IF NOT EXISTS (SELECT *
                     FROM Лицензия
                     WHERE Номер_лицензии = @Номер_лицензии)
      BEGIN
     	INSERT INTO Лицензия
     	VALUES (@Номер_лицензии, @Стоимость_лицензии, @Описание_лицензии, @Срок_лицензии);
      END
      ELSE PRINT N'Такая лицензия существует!'
     GO

     CREATE PROC Update_license
      (@Номер_лицензии int,
       @Стоимость_лицензии CostLicense,
       @Описание_лицензии nvarchar(100),
       @Срок_лицензии date
      )
     AS
      IF EXISTS (SELECT *
                 FROM Лицензия
                 WHERE Номер_лицензии = @Номер_лицензии)
      BEGIN
        UPDATE Лицензия
        SET Стоимость_лицензии = @Стоимость_лицензии,
            Описание_лицензии = @Описание_лицензии,
            Срок_лицензии = @Срок_лицензии
        WHERE Номер_лицензии = @Номер_лицензии
      END
      ELSE PRINT N'Такой лицензии не существует!'
     GO

     CREATE PROC Delete_license (@Номер_лицензии int)
     AS
      IF EXISTS (SELECT *
                 FROM Лицензия
                 WHERE Номер_лицензии = @Номер_лицензии)
      BEGIN
     	DELETE FROM Приобретение_лицензии
     	WHERE Номер_лицензии = @Номер_лицензии
     	DELETE FROM Лицензия
     	WHERE Номер_лицензии = @Номер_лицензии
      END
      ELSE PRINT N'Такой лицензии не существует!'
     GO

     /*Процедуры для оборудования*/

     CREATE PROC Insert_equipment
      (@ID_оборудования int,
       @Формат_оборудования nvarchar(50),
       @Описание_оборудования nvarchar(50)
      )
     AS
      IF NOT EXISTS (SELECT *
                     FROM Оборудование
                     WHERE ID_оборудования = @ID_оборудования)
      BEGIN
     	INSERT INTO Оборудование
     	VALUES (@ID_оборудования, @Формат_оборудования, @Описание_оборудования);
      END
      ELSE PRINT N'Такое оборудование существует!'
     GO

     CREATE PROC Update_equipment
      (@ID_оборудования int,
       @Формат_оборудования nvarchar(50),
       @Описание_оборудования nvarchar(50)
      )
     AS
      IF EXISTS (SELECT *
                 FROM Оборудование
                 WHERE ID_оборудования = @ID_оборудования)
      BEGIN
        UPDATE Оборудование
        SET Формат_оборудования = @Формат_оборудования,
            Описание_оборудования = @Описание_оборудования
        WHERE ID_оборудования = @ID_оборудования
      END
      ELSE PRINT N'Такого оборудования не существует!'
     GO

     CREATE PROC Delete_equipment (@ID_оборудования int)
     AS
      IF EXISTS (SELECT *
                 FROM Оборудование
                 WHERE ID_оборудования = @ID_оборудования)
      BEGIN
     	DELETE FROM Показ_фильма
     	WHERE ID_оборудования = @ID_оборудования
     	DELETE FROM Оборудование
     	WHERE ID_оборудования = @ID_оборудования
      END
      ELSE PRINT N'Такого оборудования не существует!'
     GO

     /*Процедуры для билета*/

     CREATE PROC Insert_ticket
      (@Номер_билета int,
       @Цена_билета money,
       @Дата_и_время_продажи_билета datetime
      )
     AS
      IF NOT EXISTS (SELECT *
                     FROM Билет
                     WHERE Номер_билета = @Номер_билета)
      BEGIN
     	INSERT INTO Билет
     	VALUES (@Номер_билета, @Цена_билета, @Дата_и_время_продажи_билета);
      END
      ELSE PRINT N'Такой билет существует!'
     GO

     CREATE PROC Delete_ticket (@Номер_билета int)
     AS
      IF EXISTS (SELECT *
                 FROM Билет
                 WHERE Номер_билета = @Номер_билета)
      BEGIN
     	DELETE FROM Продажа_билетов
     	WHERE Номер_билета = @Номер_билета
     	DELETE FROM Билет
     	WHERE Номер_билета = @Номер_билета
      END
      ELSE PRINT N'Такого билета не существует!'
     GO

     /*Процедуры для фильмов*/

     CREATE PROC Insert_film
      (@Название_фильма nvarchar(50),
       @Год_выпуска date,
       @Режиссёр nvarchar(50),
       @Жанр nvarchar(50),
       @Формат FormatFilm,
       @Рейтинг RatingFilm
      )
     AS
      IF NOT EXISTS (SELECT *
                     FROM Фильм
                     WHERE Название_фильма = @Название_фильма AND Год_выпуска = @Год_выпуска)
      BEGIN
     	INSERT INTO Фильм
     	VALUES (@Название_фильма, @Год_выпуска, @Режиссёр, @Жанр, @Формат, @Рейтинг);
      END
      ELSE PRINT N'Такой фильм существует!'
     GO

     CREATE PROC Update_film
      (@Название_фильма nvarchar(50),
       @Год_выпуска date,
       @Режиссёр nvarchar(50),
       @Жанр nvarchar(50),
       @Формат FormatFilm,
       @Рейтинг RatingFilm
      )
     AS
      IF EXISTS (SELECT *
                 FROM Фильм
                 WHERE Название_фильма = @Название_фильма AND Год_выпуска = @Год_выпуска)
      BEGIN
        UPDATE Фильм
        SET Режиссёр = @Режиссёр, Жанр = @Жанр, Формат = @Формат, Рейтинг = @Рейтинг
        WHERE Название_фильма = @Название_фильма AND Год_выпуска = @Год_выпуска
      END
      ELSE PRINT N'Такого фильма не существует!'
     GO

     CREATE PROC Delete_film
      (@Название_фильма nvarchar(50),
       @Год_выпуска date
      )
     AS
      IF EXISTS (SELECT *
                 FROM Фильм
                 WHERE Название_фильма = @Название_фильма AND Год_выпуска = @Год_выпуска)
      BEGIN
     	DELETE FROM Показывает_фильм
     	WHERE Название_фильма = @Название_фильма AND Год_выпуска = @Год_выпуска
     	DELETE FROM Продажа_билетов
     	WHERE Название_фильма = @Название_фильма AND Год_выпуска = @Год_выпуска
     	DELETE FROM Приобретение_лицензии
     	WHERE Название_фильма = @Название_фильма AND Год_выпуска = @Год_выпуска
     	DELETE FROM Показ_фильма
     	WHERE Название_фильма = @Название_фильма AND Год_выпуска = @Год_выпуска
     	DELETE FROM Сеанс
     	WHERE Название_фильма = @Название_фильма AND Год_выпуска = @Год_выпуска
     	DELETE FROM Фильм
     	WHERE Название_фильма = @Название_фильма AND Год_выпуска = @Год_выпуска
      END
      ELSE PRINT N'Такого фильма не существует!'
     GO

     /*Процедуры для сотрудника*/

     CREATE PROC Insert_worker
      (@ФИО_сотрудника nvarchar(50),
       @Паспортные_данные_сотрудника Passport,
       @Название_должности nvarchar(50),
       @Номер_телефона_сотрудника Phone,
       @Адрес_сотрудника nvarchar(50)
      )
     AS
      IF NOT EXISTS (SELECT *
                     FROM Сотрудник
                     WHERE ФИО_сотрудника = @ФИО_сотрудника AND Паспортные_данные_сотрудника = @Паспортные_данные_сотрудника)
      BEGIN
     	INSERT INTO Сотрудник
     	VALUES (@ФИО_сотрудника, @Паспортные_данные_сотрудника, @Название_должности, @Номер_телефона_сотрудника, @Адрес_сотрудника);
      END
      ELSE PRINT N'Такой сотрудник существует!'
     GO

     CREATE PROC Update_worker
      (@ФИО_сотрудника nvarchar(50),
       @Паспортные_данные_сотрудника Passport,
       @Название_должности nvarchar(50),
       @Номер_телефона_сотрудника Phone,
       @Адрес_сотрудника nvarchar(50)
      )
     AS
      IF EXISTS (SELECT *
                 FROM Сотрудник
                 WHERE ФИО_сотрудника = @ФИО_сотрудника AND Паспортные_данные_сотрудника = @Паспортные_данные_сотрудника)
      BEGIN
        UPDATE Сотрудник
        SET Название_должности = @Название_должности,
     	   Номер_телефона_сотрудника = @Номер_телефона_сотрудника,
     	   Адрес_сотрудника = @Адрес_сотрудника
        WHERE ФИО_сотрудника = @ФИО_сотрудника AND Паспортные_данные_сотрудника = @Паспортные_данные_сотрудника
      END
      ELSE PRINT N'Такого сотрудника не существует!'
     GO

     CREATE PROC Delete_worker (@ФИО_сотрудника nvarchar(50), @Паспортные_данные_сотрудника Passport)
     AS
      IF EXISTS (SELECT *
                 FROM Сотрудник
                 WHERE ФИО_сотрудника = @ФИО_сотрудника AND Паспортные_данные_сотрудника = @Паспортные_данные_сотрудника)
      BEGIN
     	DELETE FROM Продажа_билетов
     	WHERE ФИО_сотрудника = @ФИО_сотрудника AND Паспортные_данные_сотрудника = @Паспортные_данные_сотрудника
     	DELETE FROM Показ_фильма
     	WHERE ФИО_сотрудника = @ФИО_сотрудника AND Паспортные_данные_сотрудника = @Паспортные_данные_сотрудника
     	DELETE FROM Сотрудники_зала
     	WHERE ФИО_сотрудника = @ФИО_сотрудника
     	DELETE FROM Приобретение_лицензии
     	WHERE ФИО_сотрудника = @ФИО_сотрудника AND Паспортные_данные_сотрудника = @Паспортные_данные_сотрудника
     	DELETE FROM Сотрудник
     	WHERE ФИО_сотрудника = @ФИО_сотрудника AND Паспортные_данные_сотрудника = @Паспортные_данные_сотрудника
      END
      ELSE PRINT N'Такого сотрудника не существует!'
     GO

     /*Процедуры для места*/

     CREATE PROC Insert_place
      (@Номер_места int,
       @Номер_ряда int
      )
     AS
      IF NOT EXISTS (SELECT *
                     FROM Место
                     WHERE Номер_места = @Номер_места AND Номер_ряда = @Номер_ряда)
      BEGIN
     	INSERT INTO Место
     	VALUES (@Номер_места, @Номер_ряда);
      END
      ELSE PRINT N'Такое место существует!'
     GO

     CREATE PROC Insert_place_in_Row
      (@Номер_ряда int,
       @Количество_мест int
      )
     AS
      DECLARE @Номер_места int
      SET @Номер_места = 1
      WHILE (@Количество_мест >= @Номер_места)
      BEGIN
     	 IF NOT EXISTS (SELECT *
                     FROM Место
                     WHERE Номер_места = @Номер_места AND Номер_ряда = @Номер_ряда)
     	 BEGIN
     		INSERT INTO Место
     		VALUES (@Номер_места, @Номер_ряда);
     	 END
     	 ELSE PRINT N'Такое место существует!'
     	 SET @Номер_места = @Номер_места + 1;
      END
     GO

     CREATE PROC Delete_place (@Номер_места int, @Номер_ряда int)
     AS
      IF EXISTS (SELECT *
                 FROM Место
                 WHERE Номер_места = @Номер_места AND Номер_ряда = @Номер_ряда)
      BEGIN
     	DELETE FROM Продажа_билетов
     	WHERE Номер_места = @Номер_места AND Номер_ряда = @Номер_ряда
     	DELETE FROM Место
     	WHERE Номер_места = @Номер_места AND Номер_ряда = @Номер_ряда
      END
      ELSE PRINT N'Такого места не существует!'
     GO

     /*Процедуры для мест в зале*/

     CREATE PROC Insert_place_in_Hall
      (@Номер_места int,
       @Номер_ряда int,
       @Номер_зала int
      )
     AS
      IF NOT EXISTS (SELECT *
                     FROM Места_в_зале
                     WHERE Номер_места = @Номер_места AND Номер_ряда = @Номер_ряда AND Номер_зала = @Номер_зала)
      BEGIN
     	IF EXISTS (SELECT *
                        FROM Зал
                        WHERE Номер_зала = @Номер_зала)
     	BEGIN
     		IF NOT EXISTS (SELECT *
     					   FROM Место
                            WHERE Номер_места = @Номер_места AND Номер_ряда = @Номер_ряда)
     		BEGIN
     			INSERT INTO Место
     			VALUES (@Номер_места, @Номер_ряда);
     		END
     		ELSE PRINT N'Такое место существует!'
     		INSERT INTO Места_в_зале
     		VALUES (@Номер_места, @Номер_ряда, @Номер_зала);
     	END
     	ELSE PRINT N'Такой зал не существует!'
      END
      ELSE PRINT N'Такое место в зале существует!'
     GO

     CREATE PROC Insert_place_in_Row_Hall
      (@Номер_зала int,
       @Номер_ряда int,
       @Количество_мест_в_ряду int
      )
     AS
      DECLARE @Номер_места int
      SET @Номер_места = 1
      WHILE (@Количество_мест_в_ряду >= @Номер_места)
      BEGIN
     	IF NOT EXISTS (SELECT *
     				   FROM Места_в_зале
                        WHERE Номер_места = @Номер_места AND Номер_ряда = @Номер_ряда AND Номер_зала = @Номер_зала)
     	BEGIN
     		IF EXISTS (SELECT *
     				   FROM Зал
                        WHERE Номер_зала = @Номер_зала)
     		BEGIN
     			IF NOT EXISTS (SELECT *
     						   FROM Место
                                WHERE Номер_места = @Номер_места AND Номер_ряда = @Номер_ряда)
     			BEGIN
     				INSERT INTO Место
     				VALUES (@Номер_места, @Номер_ряда);
     			END
     			ELSE PRINT N'Такое место существует!'
     			INSERT INTO Места_в_зале
     				VALUES (@Номер_места, @Номер_ряда, @Номер_зала);
     		END
     		ELSE PRINT N'Такой зал не существует!'
     	END
     	ELSE PRINT N'Такое место в зале существует!'
     	SET @Номер_места = @Номер_места + 1;
      END
     GO

     CREATE PROC Delete_place_in_Hall (@Номер_места int, @Номер_ряда int, @Номер_зала int)
     AS
      IF EXISTS (SELECT *
                 FROM Места_в_зале
                 WHERE Номер_места = @Номер_места AND Номер_ряда = @Номер_ряда AND Номер_зала = @Номер_зала)
      BEGIN
     	DELETE FROM Места_в_зале
     	WHERE Номер_места = @Номер_места AND Номер_ряда = @Номер_ряда AND Номер_зала = @Номер_зала
      END
      ELSE PRINT N'Такого места в зале не существует!'
     GO

     /*Процедуры для зала*/

     CREATE PROC Insert_Hall
      (@Номер_зала int,
       @Описание_зала nvarchar(50),
       @Количество_мест int
      )
     AS
      IF NOT EXISTS (SELECT *
                     FROM Зал
                     WHERE Номер_зала = @Номер_зала)
      BEGIN
     	INSERT INTO Зал
     	VALUES (@Номер_зала, @Описание_зала, @Количество_мест);
      END
      ELSE PRINT N'Такой зал существует!'
     GO

     CREATE PROC Update_Hall
      (@Номер_зала int,
       @Описание_зала nvarchar(50),
       @Количество_мест int
      )
     AS
      IF EXISTS (SELECT *
                 FROM Зал
                 WHERE Номер_зала = @Номер_зала)
      BEGIN
     	UPDATE Зал
     	SET Описание_зала = @Описание_зала,
     	    Количество_мест = @Количество_мест
     	WHERE Номер_зала = @Номер_зала
      END
      ELSE PRINT N'Такого зала не существует!'
     GO

     CREATE PROC Delete_Hall (@Номер_зала int)
     AS
      IF EXISTS (SELECT *
                 FROM Зал
                 WHERE Номер_зала = @Номер_зала)
      BEGIN
         DELETE FROM Сеансы_зала
     	WHERE Номер_зала = @Номер_зала
     	DELETE FROM Продажа_билетов
     	WHERE Номер_зала = @Номер_зала
     	DELETE FROM Показывает_фильм
     	WHERE Номер_зала = @Номер_зала
     	DELETE FROM Сотрудники_зала
     	WHERE Номер_зала = @Номер_зала
     	DELETE FROM Зал
     	WHERE Номер_зала = @Номер_зала
      END
      ELSE PRINT N'Такого зала не существует!'
     GO

     /*Процедуры для сеанса*/

     CREATE PROC Insert_session
      (@Время_сеанса datetime,
       @Название_фильма nvarchar(50),
       @Год_выпуска date
      )
     AS
      IF NOT EXISTS (SELECT *
                     FROM Сеанс
                     WHERE Время_сеанса = @Время_сеанса)
      BEGIN
     	INSERT INTO Сеанс
     	VALUES (@Время_сеанса, @Название_фильма, @Год_выпуска);
      END
      ELSE PRINT N'Такой сеанс существует!'
     GO

     CREATE PROC Update_session
      (@Время_сеанса datetime,
       @Название_фильма nvarchar(50),
       @Год_выпуска date
      )
     AS
      IF EXISTS (SELECT *
                 FROM Сеанс
                 WHERE Время_сеанса = @Время_сеанса)
      BEGIN
     	UPDATE Сеанс
     	SET Название_фильма = @Название_фильма,
     	    Год_выпуска = @Год_выпуска
     	WHERE Время_сеанса = @Время_сеанса
      END
      ELSE PRINT N'Такого сеанса не существует!'
     GO

     CREATE PROC Delete_session (@Время_сеанса datetime)
     AS
      IF EXISTS (SELECT *
                 FROM Сеанс
                 WHERE Время_сеанса = @Время_сеанса)
      BEGIN
         DELETE FROM Сеансы_зала
     	WHERE Время_сеанса = @Время_сеанса
     	DELETE FROM Продажа_билетов
     	WHERE Время_сеанса = @Время_сеанса
     	DELETE FROM Сеанс
     	WHERE Время_сеанса = @Время_сеанса
      END
      ELSE PRINT N'Такого сеанса не существует!'
     GO

     /*Процедуры для сеансов зала*/

     CREATE PROC Insert_session_in_Hall
      (@Время_сеанса datetime,
       @Номер_зала int,
       @Название_фильма nvarchar(50),
       @Год_выпуска date
      )
     AS
      IF NOT EXISTS (SELECT *
                     FROM Сеансы_зала
                     WHERE Номер_зала = @Номер_зала AND Время_сеанса = @Время_сеанса)
      BEGIN
     	IF EXISTS (SELECT *
                    FROM Зал
                    WHERE Номер_зала = @Номер_зала)
     	BEGIN
     		IF NOT EXISTS (SELECT *
     					   FROM Сеанс
     					   WHERE Время_сеанса = @Время_сеанса)
     		BEGIN
     			INSERT INTO Сеанс
     			VALUES (@Время_сеанса, @Название_фильма, @Год_выпуска);
     		END
     		ELSE PRINT N'Такой сеанс существует!'
     		INSERT INTO Сеансы_зала
     		VALUES (@Номер_зала, @Время_сеанса);
     	END
     	ELSE PRINT N'Такого зала не существует!'
      END
      ELSE PRINT N'Такой сеанс в зале существует!'
     GO

     CREATE PROC Delete_session_in_Hall (@Время_сеанса datetime, @Номер_зала int)
     AS
      IF EXISTS (SELECT *
                 FROM Сеансы_зала
                 WHERE Номер_зала = @Номер_зала AND Время_сеанса = @Время_сеанса)
      BEGIN
     	DELETE FROM Сеансы_зала
         WHERE Номер_зала = @Номер_зала AND Время_сеанса = @Время_сеанса
      END
      ELSE PRINT N'Такого сеанса в зале не существует!'
     GO

     /*Процедуры для сотрудников зала*/

     CREATE PROC Insert_worker_in_Hall
      (@Номер_зала int,
       @ФИО_сотрудника nvarchar(50),
       @Паспортные_данные_сотрудника Passport,
       @Название_должности nvarchar(50)
      )
     AS
      IF NOT EXISTS (SELECT *
                     FROM Сотрудники_зала
                     WHERE ФИО_сотрудника = @ФИО_сотрудника AND Паспортные_данные_сотрудника = @Паспортные_данные_сотрудника AND Номер_зала = @Номер_зала)
      BEGIN
         IF EXISTS (SELECT *
                    FROM Зал
                    WHERE Номер_зала = @Номер_зала)
     	BEGIN
     			INSERT INTO Сотрудники_зала
     			VALUES (@Номер_зала, @ФИО_сотрудника, @Паспортные_данные_сотрудника, @Название_должности);
     	END
     	ELSE PRINT N'Такого зала не существует!'
      END
      ELSE PRINT N'Такой сотрудник в зале существует!'
     GO

     CREATE PROC Update_worker_in_Hall
      (@Номер_зала int,
       @ФИО_сотрудника nvarchar(50),
       @Паспортные_данные_сотрудника Passport,
       @Название_должности nvarchar(50)
      )
     AS
      IF EXISTS (SELECT *
                 FROM Сотрудники_зала
                 WHERE ФИО_сотрудника = @ФИО_сотрудника AND Паспортные_данные_сотрудника = @Паспортные_данные_сотрудника AND Номер_зала = @Номер_зала)
      BEGIN
     	IF EXISTS (SELECT *
                    FROM Сотрудник
                    WHERE ФИО_сотрудника = @ФИО_сотрудника AND Паспортные_данные_сотрудника = @Паспортные_данные_сотрудника)
     	BEGIN
     		UPDATE Сотрудник
     		SET Название_должности = @Название_должности
     		UPDATE Сотрудники_зала
     		SET Название_должности = @Название_должности
     	END
     	ELSE PRINT N'Такой сотрудник существует!'
      END
      ELSE PRINT N'Такой сотрудник в зале существует!'
     GO

     CREATE PROC Delete_worker_in_Hall
      (@Номер_зала int,
       @ФИО_сотрудника nvarchar(50),
       @Паспортные_данные_сотрудника Passport
      )
     AS
      IF EXISTS (SELECT *
                 FROM Сотрудники_зала
                 WHERE ФИО_сотрудника = @ФИО_сотрудника AND Паспортные_данные_сотрудника = @Паспортные_данные_сотрудника AND Номер_зала = @Номер_зала)
      BEGIN
     	DELETE FROM Сотрудники_зала
         WHERE ФИО_сотрудника = @ФИО_сотрудника AND Паспортные_данные_сотрудника = @Паспортные_данные_сотрудника
      END
      ELSE PRINT N'Такого сотрудника в зале не существует!'
     GO

     /*Процедуры для таблицы "Показывает_фильм"*/

     CREATE PROC Insert_shows_the_film
      (@Номер_зала int,
       @Название_фильма nvarchar(50),
       @Год_выпуска date,
       @Режиссёр nvarchar(50),
       @Жанр nvarchar(50),
       @Формат FormatFilm,
       @Рейтинг RatingFilm
      )
     AS
      IF NOT EXISTS (SELECT *
                     FROM Показывает_фильм
                     WHERE Номер_зала = @Номер_зала AND Название_фильма = @Название_фильма AND Год_выпуска = @Год_выпуска)
      BEGIN
     	IF EXISTS (SELECT *
                    FROM Зал
                    WHERE Номер_зала = @Номер_зала)
     	BEGIN
     		IF NOT EXISTS (SELECT *
     					   FROM Фильм
     					   WHERE Название_фильма = @Название_фильма AND Год_выпуска = @Год_выпуска)
     		BEGIN
     			INSERT INTO Фильм
     			VALUES (@Название_фильма, @Год_выпуска, @Режиссёр, @Жанр, @Формат, @Рейтинг);
     		END
     		ELSE PRINT N'Такой фильм существует!'
     		INSERT INTO Показывает_фильм
     		VALUES (@Номер_зала, @Название_фильма, @Год_выпуска)
     	END
     	ELSE PRINT N'Такого зала не существует!'
      END
      ELSE PRINT N'Такой фильм в таблице "Показывает_фильм" существует!'
     GO

     CREATE PROC Delete_shows_the_film (@Номер_зала int,  @Название_фильма nvarchar(50), @Год_выпуска date)
     AS
      IF EXISTS (SELECT *
                 FROM Показывает_фильм
                 WHERE Номер_зала = @Номер_зала AND Название_фильма = @Название_фильма AND Год_выпуска = @Год_выпуска)
      BEGIN
     	DELETE FROM Показывает_фильм
         WHERE Номер_зала = @Номер_зала AND Название_фильма = @Название_фильма AND Год_выпуска = @Год_выпуска
      END
      ELSE PRINT N'Такого фильма в таблице "Показывает_фильм" не существует!'
     GO

     /*Процедуры для таблицы "Показ_фильма"*/

     CREATE PROC Insert_showing_a_film
      (@ID_оборудования int,
       @Название_фильма nvarchar(50),
       @Год_выпуска date,
       @ФИО_сотрудника nvarchar(50),
       @Паспортные_данные_сотрудника Passport,
       @Название_должности nvarchar(50)
      )
     AS
      IF EXISTS (SELECT *
     			FROM Сотрудник
     			WHERE ФИО_сотрудника = @ФИО_сотрудника AND Паспортные_данные_сотрудника = @Паспортные_данные_сотрудника)
      BEGIN
     	IF EXISTS (SELECT *
     			   FROM Фильм
     			   WHERE Год_выпуска = @Год_выпуска AND Название_фильма = @Название_фильма)
     	BEGIN
     		IF EXISTS (SELECT *
     				   FROM Оборудование
     			       WHERE ID_оборудования = @ID_оборудования)
     		BEGIN
     			INSERT INTO Показ_фильма
     			VALUES (@ID_оборудования, @Название_фильма, @Год_выпуска, @ФИО_сотрудника, @Паспортные_данные_сотрудника, @Название_должности)
     		END
     		ELSE PRINT N'Такого оборудования не существует!'
     	END
     	ELSE PRINT N'Такого фильма  не существует!'
      END
      ELSE PRINT N'Такого сотрудника не существует!'
     GO

     CREATE PROC Delete_showing_a_film
      (@Название_фильма nvarchar(50),
       @Год_выпуска date,
       @ФИО_сотрудника nvarchar(50),
       @Паспортные_данные_сотрудника Passport,
       @ID_оборудования int
      )
     AS
      IF EXISTS (SELECT *
                 FROM Показ_фильма
                 WHERE Название_фильма = @Название_фильма AND Год_выпуска = @Год_выпуска AND ID_оборудования = @ID_оборудования AND ФИО_сотрудника = @ФИО_сотрудника AND Паспортные_данные_сотрудника = @Паспортные_данные_сотрудника)
      BEGIN
     	DELETE FROM Показ_фильма
         WHERE Название_фильма = @Название_фильма AND Год_выпуска = @Год_выпуска AND ID_оборудования = @ID_оборудования AND ФИО_сотрудника = @ФИО_сотрудника AND Паспортные_данные_сотрудника = @Паспортные_данные_сотрудника
      END
      ELSE PRINT N'Такого фильма в таблице "Показ_фильма" не существует!'
     GO

     /*Процедуры для таблицы "Приобретение лицензии"*/

     CREATE PROC Insert_acquisition_of_a_license
      (@Номер_лицензии int,
       @Название_фильма nvarchar(50),
       @Год_выпуска date,
       @ФИО_сотрудника nvarchar(50),
       @Паспортные_данные_сотрудника Passport,
       @Название_должности nvarchar(50)
      )
     AS
      IF EXISTS (SELECT *
     			FROM Сотрудник
     			WHERE ФИО_сотрудника = @ФИО_сотрудника AND Паспортные_данные_сотрудника = @Паспортные_данные_сотрудника)
      BEGIN
     	IF EXISTS (SELECT *
     			   FROM Фильм
     			   WHERE Год_выпуска = @Год_выпуска AND Название_фильма = @Название_фильма)
     	BEGIN
     		IF EXISTS (SELECT *
     				   FROM Лицензия
     			       WHERE Номер_лицензии = @Номер_лицензии)
     		BEGIN
     			INSERT INTO Приобретение_лицензии
     			VALUES (@Номер_лицензии, @Название_фильма, @Год_выпуска, @ФИО_сотрудника, @Паспортные_данные_сотрудника, @Название_должности)
     		END
     		ELSE PRINT N'Такой лицензии не существует!'
     	END
     	ELSE PRINT N'Такого фильма  не существует!'
      END
      ELSE PRINT N'Такого сотрудника не существует!'
     GO

     CREATE PROC Delete_acquisition_of_a_license
      (@Название_фильма nvarchar(50),
       @Год_выпуска date,
       @ФИО_сотрудника nvarchar(50),
       @Паспортные_данные_сотрудника Passport,
       @Номер_лицензии int
      )
     AS
      IF EXISTS (SELECT *
                 FROM Приобретение_лицензии
                 WHERE Название_фильма = @Название_фильма AND Год_выпуска = @Год_выпуска AND Номер_лицензии = @Номер_лицензии AND ФИО_сотрудника = @ФИО_сотрудника AND Паспортные_данные_сотрудника = @Паспортные_данные_сотрудника)
      BEGIN
     	DELETE FROM Приобретение_лицензии
         WHERE Название_фильма = @Название_фильма AND Год_выпуска = @Год_выпуска AND Номер_лицензии = @Номер_лицензии AND ФИО_сотрудника = @ФИО_сотрудника AND Паспортные_данные_сотрудника = @Паспортные_данные_сотрудника
      END
      ELSE PRINT N'Такого фильма в таблице "Приобретение лицензии" не существует!'
     GO

     /*Процедуры для таблицы "Продажа_билетов"*/

     CREATE PROC Insert_ticket_selling
      (@Название_фильма nvarchar(50),
       @Год_выпуска date,
       @Номер_места int,
       @Номер_ряда int,
       @Номер_зала int,
       @ФИО_клиента nvarchar(50),
       @Время_сеанса datetime,
       @ФИО_сотрудника nvarchar(50),
       @Паспортные_данные_сотрудника Passport,
       @Номер_билета int,
       @Телефон Phone
      )
     AS
      IF EXISTS (SELECT *
     			FROM Сотрудник
     			WHERE ФИО_сотрудника = @ФИО_сотрудника AND Паспортные_данные_сотрудника = @Паспортные_данные_сотрудника)
      BEGIN
     	IF EXISTS (SELECT *
     			   FROM Билет
     			   WHERE Номер_билета = @Номер_билета)
     	BEGIN
     		IF EXISTS (SELECT *
     				   FROM Клиент
     			       WHERE ФИО_клиента = @ФИО_клиента)
     		BEGIN
     			IF EXISTS (SELECT *
     					   FROM Сеанс
     			           WHERE Время_сеанса = @Время_сеанса)
     			BEGIN
     				IF EXISTS (SELECT *
     						   FROM Место
     			               WHERE Номер_ряда = @Номер_ряда AND Номер_места = @Номер_места)
     				BEGIN
     					IF EXISTS (SELECT *
     							   FROM Зал
     			                   WHERE Номер_зала = @Номер_зала)
     					BEGIN
     						INSERT INTO Продажа_билетов
     						VALUES (@Название_фильма, @Год_выпуска, @Номер_места, @Номер_ряда, @Номер_зала, @ФИО_клиента, @Время_сеанса, @Паспортные_данные_сотрудника, @ФИО_сотрудника, @Номер_билета, @Телефон)
     					END
     					ELSE PRINT N'Такого зала не существует!'
     				END
     				ELSE PRINT N'Такого места не существует!'
     			END
     			ELSE PRINT N'Такого сеанса не существует!'
     		END
     		ELSE PRINT N'Такого клиента не существует!'
     	END
     	ELSE PRINT N'Такого билета не существует!'
      END
      ELSE PRINT N'Такого сотрудника не существует!'
     GO

     CREATE PROC Delete_ticket_selling
      (@Номер_места int,
       @Номер_ряда int,
       @Номер_зала int,
       @ФИО_клиента nvarchar(50),
       @Время_сеанса datetime,
       @ФИО_сотрудника nvarchar(50),
       @Паспортные_данные_сотрудника Passport,
       @Номер_билета int,
       @Телефон Phone
      )
     AS
      IF EXISTS (SELECT *
                 FROM Продажа_билетов
                 WHERE ФИО_сотрудника = @ФИО_сотрудника AND Паспортные_данные_сотрудника = @Паспортные_данные_сотрудника AND Номер_билета = @Номер_билета AND ФИО_клиента = @ФИО_клиента AND Время_сеанса = @Время_сеанса AND Номер_ряда = @Номер_ряда AND Номер_места = @Номер_места AND Номер_зала = @Номер_зала AND Телефон_клиента = @Телефон)
      BEGIN
     	DELETE FROM Продажа_билетов
         WHERE ФИО_сотрудника = @ФИО_сотрудника AND Паспортные_данные_сотрудника = @Паспортные_данные_сотрудника AND Номер_билета = @Номер_билета AND ФИО_клиента = @ФИО_клиента AND Время_сеанса = @Время_сеанса AND Номер_ряда = @Номер_ряда AND Номер_места = @Номер_места AND Номер_зала = @Номер_зала AND Телефон_клиента = @Телефон
      END
      ELSE PRINT N'Такой записи в таблице "Продажа_билетов" не существует!'
     GO

/*Триггеры*/

/*Триггер, который позволяет добавлять в таблицу "Показ_фильма" только сотрудника с должностью "Киномеханик"*/

CREATE TRIGGER Insert_worker_in_showing_a_film ON Показ_фильма
INSTEAD OF INSERT
AS
	DECLARE @ID_Оборудования int, @Название_фильма nvarchar(50), @Год_выпуска date, @ФИО_сотрудника nvarchar(50), @Паспортные_данные_сотрудника Passport, @Название_должности nvarchar(50)
	DECLARE Киномеханик CURSOR SCROLL FOR
	SELECT *
	FROM inserted
	OPEN Киномеханик
	FETCH FIRST FROM Киномеханик
	INTO @ID_Оборудования, @Название_фильма, @Год_выпуска, @ФИО_сотрудника, @Паспортные_данные_сотрудника, @Название_должности
	WHILE @@FETCH_STATUS = 0
		BEGIN
		IF EXISTS (SELECT *
				   FROM inserted
				   WHERE @Название_должности = 'Киномеханик')
			BEGIN
				INSERT INTO Показ_фильма
				SELECT * FROM inserted
			END
		ELSE PRINT N'Сотрудник с данной должностью не может показывать фильмы!'
		FETCH NEXT FROM Киномеханик
		INTO @ID_Оборудования, @Название_фильма, @Год_выпуска, @ФИО_сотрудника, @Паспортные_данные_сотрудника, @Название_должности
		END
	CLOSE Киномеханик
	DEALLOCATE Киномеханик
GO

/*Триггер, который позволяет добавлять в таблицу "Приобретение_лицензии" только сотрудника с должностью "Менеджер по закупкам лицензий"*/

CREATE TRIGGER Insert_worker_in_acquisition_of_a_license ON Приобретение_лицензии
INSTEAD OF INSERT
AS
	DECLARE @Номер_лицензии int, @Название_фильма nvarchar(50), @Год_выпуска date, @ФИО_сотрудника nvarchar(50), @Паспортные_данные_сотрудника Passport, @Название_должности nvarchar(50)
	DECLARE Менеджер_по_лицензиям CURSOR SCROLL FOR
	SELECT *
	FROM inserted
	OPEN Менеджер_по_лицензиям
	FETCH FIRST FROM Менеджер_по_лицензиям
	INTO @Номер_лицензии, @Название_фильма, @Год_выпуска, @ФИО_сотрудника, @Паспортные_данные_сотрудника, @Название_должности
	WHILE @@FETCH_STATUS = 0
		BEGIN
		IF EXISTS (SELECT *
				   FROM inserted
				   WHERE @Название_должности = 'Менеджер по закупкам лицензий')
			BEGIN
				INSERT INTO Приобретение_лицензии
				SELECT * FROM inserted
			END
		ELSE PRINT N'Сотрудник с данной должностью не может покупать лицензии!'
		FETCH NEXT FROM Менеджер_по_лицензиям
		INTO @Номер_лицензии, @Название_фильма, @Год_выпуска, @ФИО_сотрудника, @Паспортные_данные_сотрудника, @Название_должности
		END
	CLOSE Менеджер_по_лицензиям
	DEALLOCATE Менеджер_по_лицензиям
GO

/*Триггер, который позволяет добавлять в таблицу "Продажа_билетов" билеты до тех пор, пока зал не заполнен*/

CREATE TRIGGER Insert_selling_ticket ON Продажа_билетов
AFTER INSERT
AS
	DECLARE @Номер_зала int, @Количество_билетов int
	DECLARE Кол_билетов_зала CURSOR SCROLL FOR
	SELECT *
	FROM Кол_билетов_зала
	OPEN Кол_билетов_зала
	FETCH FIRST FROM Кол_билетов_зала
	INTO @Номер_зала, @Количество_билетов
	WHILE @@FETCH_STATUS = 0
		BEGIN
			IF EXISTS (SELECT Номер_зала FROM Зал WHERE Номер_зала = @Номер_зала) AND ((SELECT Количество_мест FROM Зал WHERE Номер_зала = @Номер_зала) - @Количество_билетов <= 0)
			BEGIN
				PRINT N'Билеты закончились!'
				ROLLBACK TRAN
			END
			FETCH NEXT FROM Кол_билетов_зала
			INTO @Номер_зала, @Количество_билетов
		END
	CLOSE Кол_билетов_зала
	DEALLOCATE Кол_билетов_зала
GO

/*Триггер, который при обновлении клиента определяет скидку клиента, если клиент обычный, то скидка 0%, если клиент VIP 5%, если клиент VIP и входит в ТОП 5 клиентов, то скидка 10%, если клиент
обычный, но появляется в таблице ТОП клиентов, то меняется его тип на VIP и устанавливается скидка в 10%.*/

CREATE TRIGGER Update_client_discount ON Клиент
AFTER UPDATE, INSERT
AS
	DECLARE @ФИО_клиента nvarchar(50), @Количество_билетов int
	DECLARE Топ_клиентов CURSOR SCROLL FOR
	SELECT *
	FROM Топ_клиентов
	OPEN Топ_клиентов
	FETCH FIRST FROM Топ_клиентов
	INTO @ФИО_клиента, @Количество_билетов
	WHILE @@FETCH_STATUS = 0
		BEGIN
			IF EXISTS (SELECT * FROM Клиент WHERE ФИО_клиента = @ФИО_клиента AND Тип_клиента = 'VIP')
				BEGIN
					UPDATE Клиент
					SET Скидка = '10'
					WHERE ФИО_клиента = @ФИО_клиента AND Тип_клиента = 'VIP'
				END
				ELSE IF EXISTS (SELECT * FROM Клиент WHERE ФИО_клиента = @ФИО_клиента AND Тип_клиента = 'Обычный')
												BEGIN
													UPDATE Клиент
													SET Скидка = '10', Тип_клиента = 'VIP'
													WHERE ФИО_клиента = @ФИО_клиента AND Тип_клиента = 'Обычный'
												END
			FETCH NEXT FROM Топ_клиентов
			INTO @ФИО_клиента, @Количество_билетов
		END
	CLOSE Топ_клиентов
	DEALLOCATE Топ_клиентов
	DECLARE @Тип_клиента TypeClient, @Скидочная_карта int, @Скидка Discount, @Email Email, @Телефон Phone
	DECLARE Тип_клиента CURSOR SCROLL FOR
	SELECT *
	FROM Клиент
	OPEN Тип_клиента
	FETCH FIRST FROM Тип_клиента
	INTO @ФИО_клиента, @Тип_клиента, @Скидочная_карта, @Скидка, @Email, @Телефон
	WHILE @@FETCH_STATUS = 0
		BEGIN
			IF EXISTS (SELECT * FROM Клиент WHERE ФИО_клиента NOT IN (SELECT ФИО_клиента FROM Топ_клиентов) AND Тип_клиента = 'VIP')
				BEGIN
					UPDATE Клиент
					SET Скидка = '5'
					WHERE ФИО_клиента NOT IN (SELECT ФИО_клиента FROM Топ_клиентов) AND Тип_клиента = 'VIP'
				END IF EXISTS (SELECT * FROM Клиент WHERE Тип_клиента = 'Обычный')
				BEGIN
					UPDATE Клиент
					SET Скидка = '0'
					WHERE Тип_клиента = 'Обычный'
				END
			FETCH NEXT FROM Тип_клиента
			INTO @ФИО_клиента, @Тип_клиента, @Скидочная_карта, @Скидка, @Email, @Телефон
		END
	CLOSE Тип_клиента
	DEALLOCATE Тип_клиента
GO

/*Триггер, который позволяет добавлять места до тех пор, пока зал не заполнен*/

CREATE TRIGGER Add_place_in_Hall ON Места_в_зале
AFTER INSERT
AS
	DECLARE @Номер_зала int, @Количество_мест int
	DECLARE Кол_мест_зала CURSOR SCROLL FOR
	SELECT Номер_зала, Количество_мест
	FROM Зал
	OPEN Кол_мест_зала
	FETCH FIRST FROM Кол_мест_зала
	INTO @Номер_зала, @Количество_мест
	WHILE @@FETCH_STATUS = 0
		BEGIN
			IF EXISTS (SELECT Номер_зала
					   FROM Зал
					   WHERE Номер_зала = @Номер_зала)
			   AND EXISTS(SELECT Номер_зала
			              FROM Места_в_зале
						  WHERE Номер_зала = @Номер_зала)
			   AND ((SELECT SUM(Номер_места)
					FROM Места_в_зале
					WHERE Номер_зала = @Номер_зала) > @Количество_мест)
			BEGIN
				PRINT N'Зал полон!'
				ROLLBACK TRAN
			END
			FETCH NEXT FROM Кол_мест_зала
			INTO @Номер_зала, @Количество_мест
		END
	CLOSE Кол_мест_зала
	DEALLOCATE Кол_мест_зала
GO

/*Триггер, который позволяет продавать билеты только кассирам*/
CREATE TRIGGER Insert_ticket_selling_cashier ON Продажа_билетов
INSTEAD OF INSERT
AS
	DECLARE @Название_фильма nvarchar(50),
    @Год_выпуска date,
    @Номер_места int,
    @Номер_ряда int,
    @Номер_зала int,
    @ФИО_клиента nvarchar(50),
    @Время_сеанса datetime,
    @ФИО_сотрудника nvarchar(50),
    @Паспортные_данные_сотрудника Passport,
    @Номер_билета int,
    @Телефон Phone

	DECLARE Кассир CURSOR SCROLL FOR
	SELECT Название_фильма, Год_выпуска, Номер_места, Номер_ряда, Номер_зала, ФИО_клиента, Время_сеанса, Паспортные_данные_сотрудника, ФИО_сотрудника, Номер_билета, Телефон_клиента
	FROM inserted
	OPEN Кассир
	FETCH FIRST FROM Кассир
	INTO @Название_фильма, @Год_выпуска, @Номер_места, @Номер_ряда, @Номер_зала, @ФИО_клиента, @Время_сеанса, @Паспортные_данные_сотрудника, @ФИО_сотрудника, @Номер_билета, @Телефон
	WHILE @@FETCH_STATUS = 0
	BEGIN
		if @Фио_сотрудника IN (SELECT ФИО_сотрудника
				   FROM Сотрудник
				   WHERE Название_должности = 'Кассир')
			BEGIN
			IF EXISTS (SELECT *
			FROM Сотрудник
			WHERE ФИО_сотрудника = @ФИО_сотрудника AND Паспортные_данные_сотрудника = @Паспортные_данные_сотрудника)
			 BEGIN
				IF EXISTS (SELECT *
						   FROM Билет
						   WHERE Номер_билета = @Номер_билета)
				BEGIN
					IF EXISTS (SELECT *
							   FROM Клиент
							   WHERE ФИО_клиента = @ФИО_клиента)
					BEGIN
						IF EXISTS (SELECT *
								   FROM Сеанс
								   WHERE Время_сеанса = @Время_сеанса)
						BEGIN
							IF EXISTS (SELECT *
									   FROM Место
									   WHERE Номер_ряда = @Номер_ряда AND Номер_места = @Номер_места)
							BEGIN
								IF EXISTS (SELECT *
										   FROM Зал
										   WHERE Номер_зала = @Номер_зала)
								BEGIN
									INSERT INTO Продажа_билетов
									VALUES (@Название_фильма, @Год_выпуска, @Номер_места, @Номер_ряда, @Номер_зала, @ФИО_клиента, @Время_сеанса, @Паспортные_данные_сотрудника, @ФИО_сотрудника, @Номер_билета, @Телефон)
								END
								ELSE PRINT N'Такого зала не существует!'
							END
							ELSE PRINT N'Такого места не существует!'
						END
						ELSE PRINT N'Такого сеанса не существует!'
					END
					ELSE PRINT N'Такого клиента не существует!'
				END
				ELSE PRINT N'Такого билета не существует!'
			 END
			 ELSE PRINT N'Такого сотрудника не существует!'
			END
		ELSE PRINT N'Сотрудник с данной должностью не может продавать билеты!'
	FETCH NEXT FROM Кассир
	INTO @Название_фильма, @Год_выпуска, @Номер_места, @Номер_ряда, @Номер_зала, @ФИО_клиента, @Время_сеанса, @Паспортные_данные_сотрудника, @ФИО_сотрудника, @Номер_билета, @Телефон
	END
	CLOSE Кассир
	DEALLOCATE Кассир
GO

/*Заполнение таблиц данными*/

INSERT INTO Билет
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

INSERT INTO Должность
VALUES ('Кассир', 'Занимается продажей билетов на сеансы фильмов и выдачей скидочных карт', '25000'),
       ('Администратор', 'Занимается добавлением фильмов в прокат и работой с ИС кинотеатра', '75000'),
	   ('Менеджер по персоналу', 'Занимается организацией работы с персоналом', '50000'),
	   ('Охранник', 'Занимается соблюдением порядка', '30000'),
	   ('Киномеханик', 'Занимается показом фильмов, настройкой и ремонтом оборудования', '60000'),
	   ('Менеджер по закупкам лицензий', 'Занимается покупкой лицензий на показ фильмов в кинотеатре', '55000'),
	   ('Уборщица', 'Занимается соблюдением чистоты в кинотеатре', '15000');
GO

INSERT INTO Зал
VALUES ('1', 'IMAX зал', '1000'),
	   ('2', 'Обычный зал', '1000'),
	   ('3', 'Обычный зал', '1000'),
	   ('4', 'Обычный зал', '1000'),
	   ('5', '3D зал', '1000')
GO

INSERT INTO Клиент (ФИО_клиента, Тип_клиента, Скидочная_карта, Email, Телефон_клиента)
VALUES ('Тарасов Геласий Улебович', 'Обычный', '22092788', 'ziejoo@ya.ru', '+79001234567'),
       ('Кириллов Кондрат Евсеевич', 'VIP', '22084749', 'zieerf@ya.ru', '+79001238888'),
	   ('Пономарёв Артём Ильяович', 'Обычный', '22091449', 'ziejoo1@ya.ru', '+79001234567'),
	   ('Коновалов Федот Дмитрьевич', 'Обычный', '22092149', 'ziejoo2@ya.ru', '+79001234566'),
	   ('Савельева Екатерина Данииловна', 'Обычный', '22097849', 'ziejoo3@ya.ru', '+79001234565'),
	   ('Петрова Пелагея Константиновна', 'Обычный', '22072749', 'ziejoo4@ya.ru', '+79001234564'),
	   ('Кузнецова Юлия Протасьевна', 'Обычный', '22021749', 'ziejoo5@ya.ru', '+79001234563'),
	   ('Харитонова Валерия Митрофановна', 'Обычный', '22722749', 'ziejoo6@ya.ru', '+79001234562'),
	   ('Николаева Марина Авдеевна', 'Обычный', '22092749', 'ziejoo7@ya.ru', '+79001234561'),
	   ('Аксёнова Наталья Демьяновна', 'Обычный', '22096749', 'ziejoo8@ya.ru', '+79001234560'),
	   ('Пахомов Никита Серапионович', 'Обычный', '22452749', 'ziejoo9@ya.ru', '+79001234559'),
	   ('Фомичёва Иванна Варламовна', 'Обычный', '22492749', 'ziejoo10@ya.ru', '+79001234558'),
	   ('Сорокин Куприян Никитевич', 'Обычный', '22012249', 'ziejoo11@ya.ru', '+79001234556'),
	   ('Давыдова Анжела Никитевна', 'Обычный', '22052749', 'ziejoo12@ya.ru', '+79001234555'),
	   ('Егоров Донат Донатович', 'Обычный', '22094749', 'ziejoo13@ya.ru', '+79001234554'),
	   ('Доронина Пелагея Альвиановна', 'Обычный', '22095449', 'ziejoo14@ya.ru', '+79001234553'),
	   ('Прохорова Нонна Антоновна', 'Обычный', '22094549', 'ziejoo77@ya.ru', '+79001234540'),
	   ('Соболев Фрол Фролович', 'Обычный', '23092749', 'ziejoo54@ya.ru', '+79001234527'),
	   ('Мишина Валентина Еремеевна', 'Обычный', '24092749', 'ziejoo64@ya.ru', '+79001237867'),
	   ('Харитонов Юлиан Христофорович', 'Обычный', '55092749', 'ziejoo543@ya.ru', '+79001278567'),
	   ('Макаров Кондрат Иринеевич', 'Обычный', '25092749', 'ziejoo43@ya.ru', '+79001234567'),
	   ('Виноградова Надежда Германновна', 'Обычный', '27092749', 'ziejoo34@ya.ru', '+79001234467'),
	   ('Мамонтов Валерьян Агафонович', 'Обычный', '57792749', 'ziejoo53@ya.ru', '+79001234547'),
	   ('Данилов Агафон Григорьевич', 'Обычный', '52592749', 'ziejoo23@ya.ru', '+79001544567'),
	   ('Веселов Авдей Борисович', 'Обычный', '22092771', 'ziejoo44@ya.ru', '+79001235467'),
	   ('Горбачёва Виктория Игнатьевна', 'Обычный', '52095749', 'ziejoo23@ya.ru', '+79001234567'),
	   ('Артемьева Олимпиада Евгеньевна', 'Обычный', '52092749', 'ziejoo21@ya.ru', '+79005424567'),
	   ('Прохорова Варвара Кимовна', 'Обычный', '25775749', 'ziejoo434@ya.ru', '+79004524567'),
	   ('Яковлев Лукий Игоревич', 'Обычный', '54492749', 'ziejoo324@ya.ru', '+79001245467');
GO

EXEC Insert_license '1', '25000', 'Годовая', '2018-04-16 22:19:00'
EXEC Insert_license '2', '35000', 'Годовая', '2018-04-16 22:19:00'
EXEC Insert_license '3', '45000', 'Годовая', '2018-04-16 22:19:00'
EXEC Insert_license '4', '55000', 'Годовая', '2018-04-16 22:19:00'
EXEC Insert_license '5', '65000', 'Годовая', '2018-04-16 22:19:00'
EXEC Insert_license '6', '75000', 'Годовая', '2018-04-16 22:19:00'
EXEC Insert_license '7', '85000', 'Годовая', '2018-04-16 22:19:00'
EXEC Insert_license '8', '95000', 'Годовая', '2018-04-16 22:19:00'
EXEC Insert_license '9', '105000', 'Годовая', '2018-04-16 22:19:00'
EXEC Insert_license '10', '115000', 'Годовая', '2018-04-16 22:19:00'

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

INSERT INTO Оборудование
VALUES ('1', '3D IMAX', 'Проектор'),
	   ('2', '2D', 'Проектор'),
	   ('3', '2D', 'Проектор'),
	   ('4', '2D', 'Проектор'),
	   ('5', '3D', 'Проектор');
GO

EXEC Insert_session '2017-06-07 10:00:00', 'Интерстеллар', '2014'
EXEC Insert_session '2017-06-07 12:00:00', 'Интерстеллар', '2014'
EXEC Insert_session '2017-06-07 15:50:00', 'Интерстеллар', '2014'
EXEC Insert_session '2017-06-07 16:00:00', 'Интерстеллар', '2014'
EXEC Insert_session '2017-06-07 17:40:00', 'Интерстеллар', '2014'
EXEC Insert_session '2017-06-07 18:30:00', 'Интерстеллар', '2014'
EXEC Insert_session '2017-06-07 10:30:00', 'Звёздный путь', '2009'
EXEC Insert_session '2017-06-07 15:40:00', 'Звёздный путь', '2009'
EXEC Insert_session '2017-06-08 14:20:00', 'Звёздный путь', '2009'
EXEC Insert_session '2017-06-08 15:00:00', 'Звёздный путь', '2009'
EXEC Insert_session '2017-06-08 18:30:00', 'Звёздный путь', '2009'
EXEC Insert_session '2017-06-09 15:00:00', 'Звёздный путь', '2009'
EXEC Insert_session '2017-06-09 17:00:00', 'Стражи галактики 2', '2017'
EXEC Insert_session '2017-06-09 15:20:00', 'Стражи галактики 2', '2017'
EXEC Insert_session '2017-06-10 13:20:00', 'Стражи галактики 2', '2017'
EXEC Insert_session '2017-06-11 15:20:00', 'Стражи галактики 2', '2017'
EXEC Insert_session '2017-06-11 17:00:00', 'Стражи галактики 2', '2017'
EXEC Insert_session '2017-06-11 19:20:00', 'Стражи галактики 2', '2017'
EXEC Insert_session '2017-06-10 15:00:00', 'Доктор Стрэндж', '2016'
EXEC Insert_session '2017-06-10 16:00:00', 'Доктор Стрэндж', '2016'
EXEC Insert_session '2017-06-10 17:00:00', 'Доктор Стрэндж', '2016'
EXEC Insert_session '2017-06-10 18:00:00', 'Доктор Стрэндж', '2016'
EXEC Insert_session '2017-06-10 20:00:00', 'Доктор Стрэндж', '2016'
EXEC Insert_session '2017-06-10 21:00:00', 'Доктор Стрэндж', '2016'
EXEC Insert_session '2017-06-06 10:30:00', 'Аватар', '2009'
EXEC Insert_session '2017-06-06 11:00:00', 'Аватар', '2009'
EXEC Insert_session '2017-06-06 12:30:00', 'Аватар', '2009'
EXEC Insert_session '2017-06-06 13:00:00', 'Аватар', '2009'
EXEC Insert_session '2017-06-06 14:30:00', 'Аватар', '2009'
EXEC Insert_session '2017-06-08 15:00:00', 'Аватар', '2009'
EXEC Insert_session '2017-06-08 11:00:00', 'Обливион', '2013'
EXEC Insert_session '2017-06-08 12:30:00', 'Обливион', '2013'
EXEC Insert_session '2017-06-08 13:00:00', 'Обливион', '2013'
EXEC Insert_session '2017-06-08 14:30:00', 'Обливион', '2013'
EXEC Insert_session '2017-06-08 15:00:00', 'Обливион', '2013'
EXEC Insert_session '2017-06-08 18:30:00', 'Обливион', '2013'

INSERT INTO Сотрудник
VALUES ('Сидоров Валентин Иринеевич', '5592622638', 'Киномеханик', '+79111232424', 'ул Гагарина, 48'),
	   ('Красильников Константин Филатович', '5592622639', 'Киномеханик', '+79111232425', 'ул Гагарина, 47'),
	   ('Григорьев Виктор Серапионович', '5592622640', 'Киномеханик', '+79111232426', 'ул Гагарина, 46'),
	   ('Дорофеева Евгения Пантелеймоновна', '5592622641', 'Киномеханик', '+79111232427', 'ул Гагарина, 45'),
	   ('Анисимова Синклитикия Игоревна', '5592622642', 'Киномеханик', '+79111232428', 'ул Гагарина, 44'),
	   ('Бобров Юлиан Гордеевич', '9485969289', 'Администратор', '+79209997788', 'ул Гагарина, 25'),
	   ('Меркушев Улеб Богданович', '9485969271', 'Менеджер по персоналу', '+79209997799', 'ул Гагарина, 20'),
       ('Шестаков Егор Евгеньевич', '9485969241', 'Менеджер по закупкам лицензий', '+79209999999', 'ул Гагарина, 48'),
	   ('Фокина Кира Арсеньевна', '5833926340', 'Кассир', '+79171225577', 'ул Бирюзова, 19'),
	   ('Степанова Пелагея Ивановна', '5833922277', 'Кассир', '+79181225599', 'ул Интернациональная, 29'),
	   ('Ермаков Ким Станиславович', '5833926385', 'Охранник', '+79003225577', 'ул Бирюзова, 19'),
	   ('Коновалов Ростислав Агафонович', '5833856340', 'Охранник', '+79007225577', 'ул Бирюзова, 18'),
	   ('Прохоров Мартын Даниилович', '5833928340', 'Охранник', '+79007725577', 'ул Бирюзова, 17'),
	   ('Лобанов Денис Мэлорович', '5833926850', 'Охранник', '+79001224277', 'ул Бирюзова, 16'),
	   ('Самойлов Евсей Станиславович', '5855926340', 'Охранник', '+79000225577', 'ул Бирюзова, 15'),
	   ('Лихачёва Мария Альвиановна', '7733926340', 'Уборщица', '+79779925577', 'ул Бирюзова, 20'),
	   ('Родионова Нина Ильяовна', '7833926340', 'Уборщица', '+79099985577', 'ул Бирюзова, 21'),
	   ('Романова Ксения Агафоновна', '7933926340', 'Уборщица', '+79009995577', 'ул Бирюзова, 25'),
	   ('Титова Марфа Игоревна', '9033926340', 'Уборщица', '+79001229977', 'ул Бирюзова, 14'),
	   ('Прохорова Анна Алексеевна', '9533926340', 'Уборщица', '+79009925577', 'ул Бирюзова, 10');
GO

EXEC Insert_film 'Интерстеллар', '2014', 'Кристофер Нолан', 'Фантастика', '2D IMAX', 'PG-13'
EXEC Insert_film 'Звёздный путь', '2009', 'Джей Джей Абрамс', 'Фантастика', '2D', 'PG-13'
EXEC Insert_film 'Стражи галактики', '2014', 'Джеймс Ганн', 'Фантастика', '3D IMAX', 'PG-13'
EXEC Insert_film 'Стражи галактики 2', '2017', 'Джеймс Ганн', 'Фантастика', '3D IMAX', 'PG-13'
EXEC Insert_film 'Аватар', '2009', 'Джеймс Кэмерон', 'Фантастика', '3D IMAX', 'PG-13'
EXEC Insert_film 'Пиксели', '2015', 'Крис Коламбус', 'Мультфильм', '3D', 'PG-13'
EXEC Insert_film 'Тихоокеанский рубеж', '2013', 'Гильермо дель Торо', 'Приключения', '3D IMAX', 'PG-13'
EXEC Insert_film 'Логан', '2017', 'Джеймс Мэнголд', 'Фантастика', '3D IMAX', 'R'
EXEC Insert_film 'Доктор Стрэндж', '2016', 'Скотт Дерриксон', 'Фантастика', '3D IMAX', 'PG-13'
EXEC Insert_film 'Обливион', '2013', 'Джозеф Косински', 'Фантастика', '3D IMAX', 'PG-13'

EXEC Insert_showing_a_film '1', 'Звёздный путь', '2009', 'Красильников Константин Филатович', '5592622639', 'Киномеханик'
EXEC Insert_showing_a_film '2', 'Интерстеллар', '2014', 'Сидоров Валентин Иринеевич', '5592622638', 'Киномеханик'
EXEC Insert_showing_a_film '3', 'Стражи галактики 2', '2017', 'Анисимова Синклитикия Игоревна', '5592622642', 'Киномеханик'
EXEC Insert_showing_a_film '4', 'Доктор Стрэндж', '2016', 'Григорьев Виктор Серапионович', '5592622640', 'Киномеханик'
EXEC Insert_showing_a_film '5', 'Аватар', '2009', 'Дорофеева Евгения Пантелеймоновна', '5592622641', 'Киномеханик'

EXEC Insert_shows_the_film 1, 'Интерстеллар', '2014', 'Кристофер Нолан', 'Фантастика', '2D IMAX', 'PG-13'
EXEC Insert_shows_the_film 2, 'Звёздный путь', '2009', 'Джей Джей Абрамс', 'Фантастика', '2D', 'PG-13'
EXEC Insert_shows_the_film 3, 'Стражи галактики 2', '2017', 'Джеймс Ганн', 'Фантастика', '3D IMAX', 'PG-13'
EXEC Insert_shows_the_film 4, 'Доктор Стрэндж', '2016', 'Скотт Дерриксон', 'Фантастика', '3D IMAX', 'PG-13'
EXEC Insert_shows_the_film 5, 'Аватар', '2009', 'Джеймс Кэмерон', 'Фантастика', '3D IMAX', 'PG-13'

EXEC Insert_session_in_Hall '2017-06-07 10:00:00',1,'Интерстеллар', '2014'
EXEC Insert_session_in_Hall '2017-06-07 12:00:00',1,'Интерстеллар', '2014'
EXEC Insert_session_in_Hall '2017-06-07 15:50:00',1,'Интерстеллар', '2014'
EXEC Insert_session_in_Hall '2017-06-07 16:00:00',1,'Интерстеллар', '2014'
EXEC Insert_session_in_Hall '2017-06-07 17:40:00',1,'Интерстеллар', '2014'
EXEC Insert_session_in_Hall '2017-06-07 18:30:00',1,'Интерстеллар', '2014'
EXEC Insert_session_in_Hall '2017-06-07 10:30:00',2,'Звёздный путь', '2009'
EXEC Insert_session_in_Hall '2017-06-07 15:40:00',2,'Звёздный путь', '2009'
EXEC Insert_session_in_Hall '2017-06-08 14:20:00',2,'Звёздный путь', '2009'
EXEC Insert_session_in_Hall '2017-06-08 15:00:00',2,'Звёздный путь', '2009'
EXEC Insert_session_in_Hall '2017-06-08 18:30:00',2,'Звёздный путь', '2009'
EXEC Insert_session_in_Hall '2017-06-09 15:00:00',2,'Звёздный путь', '2009'
EXEC Insert_session_in_Hall '2017-06-09 17:00:00',4,'Стражи галактики 2', '2017'
EXEC Insert_session_in_Hall '2017-06-09 15:20:00',4,'Стражи галактики 2', '2017'
EXEC Insert_session_in_Hall '2017-06-10 13:20:00',3, 'Стражи галактики 2', '2017'
EXEC Insert_session_in_Hall '2017-06-11 15:20:00',3,'Стражи галактики 2', '2017'
EXEC Insert_session_in_Hall '2017-06-11 17:00:00',3,'Стражи галактики 2', '2017'
EXEC Insert_session_in_Hall '2017-06-11 19:20:00',3,'Стражи галактики 2', '2017'
EXEC Insert_session_in_Hall '2017-06-10 15:00:00',4,'Доктор Стрэндж', '2016'
EXEC Insert_session_in_Hall '2017-06-10 16:00:00',4,'Доктор Стрэндж', '2016'
EXEC Insert_session_in_Hall '2017-06-10 17:00:00',4,'Доктор Стрэндж', '2016'
EXEC Insert_session_in_Hall '2017-06-10 18:00:00',4,'Доктор Стрэндж', '2016'
EXEC Insert_session_in_Hall '2017-06-10 20:00:00',4,'Доктор Стрэндж', '2016'
EXEC Insert_session_in_Hall '2017-06-10 21:00:00',4,'Доктор Стрэндж', '2016'
EXEC Insert_session_in_Hall '2017-06-06 10:30:00',1,'Аватар', '2009'
EXEC Insert_session_in_Hall '2017-06-06 11:00:00',1,'Аватар', '2009'
EXEC Insert_session_in_Hall '2017-06-06 12:30:00',1,'Аватар', '2009'
EXEC Insert_session_in_Hall '2017-06-06 13:00:00',1,'Аватар', '2009'
EXEC Insert_session_in_Hall '2017-06-06 14:30:00',1,'Аватар', '2009'
EXEC Insert_session_in_Hall '2017-06-08 15:00:00',5,'Аватар', '2009'
EXEC Insert_session_in_Hall '2017-06-08 11:00:00',5,'Обливион', '2013'
EXEC Insert_session_in_Hall '2017-06-08 12:30:00',5,'Обливион', '2013'
EXEC Insert_session_in_Hall '2017-06-08 13:00:00',5,'Обливион', '2013'
EXEC Insert_session_in_Hall '2017-06-08 14:30:00',5, 'Обливион', '2013'
EXEC Insert_session_in_Hall '2017-06-08 15:00:00',1,'Обливион', '2013'
EXEC Insert_session_in_Hall '2017-06-08 18:30:00', 5,'Обливион', '2013'

INSERT INTO Сотрудники_зала
VALUES ('1', 'Сидоров Валентин Иринеевич', '5592622638', 'Киномеханик'),
       ('2', 'Красильников Константин Филатович', '5592622639', 'Киномеханик'),
	   ('3', 'Григорьев Виктор Серапионович', '5592622640', 'Киномеханик'),
	   ('4', 'Дорофеева Евгения Пантелеймоновна', '5592622641', 'Киномеханик'),
	   ('5', 'Анисимова Синклитикия Игоревна', '5592622642', 'Киномеханик'),
	   ('1', 'Лихачёва Мария Альвиановна', '7733926340', 'Уборщица'),
       ('2', 'Родионова Нина Ильяовна', '7833926340', 'Уборщица'),
	   ('3', 'Романова Ксения Агафоновна', '7933926340', 'Уборщица'),
	   ('4', 'Титова Марфа Игоревна', '9033926340', 'Уборщица'),
	   ('5', 'Прохорова Анна Алексеевна', '9533926340', 'Уборщица'),
	   ('1', 'Ермаков Ким Станиславович', '5833926385', 'Охранник'),
       ('2', 'Коновалов Ростислав Агафонович', '5833856340', 'Охранник'),
	   ('3', 'Прохоров Мартын Даниилович', '5833928340', 'Охранник'),
	   ('4', 'Лобанов Денис Мэлорович', '5833926850', 'Охранник'),
	   ('5', 'Самойлов Евсей Станиславович', '5855926340', 'Охранник')
GO

EXEC Insert_acquisition_of_a_license '1', 'Интерстеллар', '2014', 'Шестаков Егор Евгеньевич', '9485969241', 'Менеджер по закупкам лицензий'
EXEC Insert_acquisition_of_a_license '2', 'Звёздный путь', '2009', 'Шестаков Егор Евгеньевич', '9485969241', 'Менеджер по закупкам лицензий'
EXEC Insert_acquisition_of_a_license '3', 'Стражи галактики', '2014', 'Шестаков Егор Евгеньевич', '9485969241', 'Менеджер по закупкам лицензий'
EXEC Insert_acquisition_of_a_license '4', 'Аватар', '2009', 'Шестаков Егор Евгеньевич', '9485969241', 'Менеджер по закупкам лицензий'
EXEC Insert_acquisition_of_a_license '5', 'Пиксели', '2015', 'Шестаков Егор Евгеньевич', '9485969241', 'Менеджер по закупкам лицензий'
EXEC Insert_acquisition_of_a_license '6', 'Тихоокеанский рубеж', '2013', 'Шестаков Егор Евгеньевич', '9485969241', 'Менеджер по закупкам лицензий'
EXEC Insert_acquisition_of_a_license '7', 'Логан', '2017', 'Шестаков Егор Евгеньевич', '9485969241', 'Менеджер по закупкам лицензий'
EXEC Insert_acquisition_of_a_license '8', 'Доктор Стрэндж', '2016', 'Шестаков Егор Евгеньевич', '9485969241', 'Менеджер по закупкам лицензий'
EXEC Insert_acquisition_of_a_license '9', 'Обливион', '2013', 'Шестаков Егор Евгеньевич', '9485969241', 'Менеджер по закупкам лицензий'
EXEC Insert_acquisition_of_a_license '10', 'Стражи галактики 2', '2017', 'Шестаков Егор Евгеньевич', '9485969241', 'Менеджер по закупкам лицензий'

EXEC Insert_ticket_selling 'Аватар', '2009', '1', '1', '1', 'Тарасов Геласий Улебович', '2017-06-06 10:30:00', 'Степанова Пелагея Ивановна', '5833922277', '1', '+79001234567'
EXEC Insert_ticket_selling 'Аватар', '2009', '3', '3', '1', 'Тарасов Геласий Улебович', '2017-06-06 10:30:00', 'Степанова Пелагея Ивановна', '5833922277', '2', '+79001234567'
EXEC Insert_ticket_selling 'Аватар', '2009', '5', '5', '1', 'Петрова Пелагея Константиновна', '2017-06-06 10:30:00', 'Степанова Пелагея Ивановна', '5833922277', '3', '+79001234564'
EXEC Insert_ticket_selling 'Аватар', '2009', '6', '4', '1', 'Петрова Пелагея Константиновна', '2017-06-06 10:30:00', 'Степанова Пелагея Ивановна', '5833922277', '4', '+79001234564'
EXEC Insert_ticket_selling 'Аватар', '2009', '7', '3', '1', 'Тарасов Геласий Улебович', '2017-06-06 10:30:00', 'Степанова Пелагея Ивановна', '5833922277', '5', '+79001234567'
EXEC Insert_ticket_selling 'Аватар', '2009', '2', '3', '1', 'Тарасов Геласий Улебович', '2017-06-06 10:30:00', 'Степанова Пелагея Ивановна', '5833922277', '6', '+79001234567'
EXEC Insert_ticket_selling 'Аватар', '2009', '4', '4', '1', 'Тарасов Геласий Улебович', '2017-06-06 10:30:00', 'Степанова Пелагея Ивановна', '5833922277', '7', '+79001234567'
EXEC Insert_ticket_selling 'Интерстеллар', '2014', '1', '1', '1', 'Тарасов Геласий Улебович', '2017-06-07 18:30:00', 'Фокина Кира Арсеньевна', '5833926340', '8', '+79001234567'
EXEC Insert_ticket_selling 'Интерстеллар', '2014', '2', '1', '1', 'Тарасов Геласий Улебович', '2017-06-07 18:30:00', 'Фокина Кира Арсеньевна', '5833926340', '9', '+79001234567'
EXEC Insert_ticket_selling 'Интерстеллар', '2014', '3', '1', '1', 'Тарасов Геласий Улебович', '2017-06-07 18:30:00', 'Фокина Кира Арсеньевна', '5833926340', '10', '+79001234567'
EXEC Insert_ticket_selling 'Интерстеллар', '2014', '1', '2', '1', 'Тарасов Геласий Улебович', '2017-06-07 18:30:00', 'Фокина Кира Арсеньевна', '5833926340', '11', '+79001234567'
EXEC Insert_ticket_selling 'Интерстеллар', '2014', '2', '2', '1', 'Тарасов Геласий Улебович', '2017-06-07 18:30:00', 'Фокина Кира Арсеньевна', '5833926340', '12', '+79001234567'
EXEC Insert_ticket_selling 'Интерстеллар', '2014', '3', '2', '1', 'Тарасов Геласий Улебович', '2017-06-07 18:30:00', 'Фокина Кира Арсеньевна', '5833926340', '13', '+79001234567'
EXEC Insert_ticket_selling 'Интерстеллар', '2014', '1', '3', '1', 'Тарасов Геласий Улебович', '2017-06-07 18:30:00', 'Фокина Кира Арсеньевна', '5833926340', '14', '+79001234567'
EXEC Insert_ticket_selling 'Интерстеллар', '2014', '2', '3', '1', 'Тарасов Геласий Улебович', '2017-06-07 18:30:00', 'Фокина Кира Арсеньевна', '5833926340', '15', '+79001234567'
EXEC Insert_ticket_selling 'Интерстеллар', '2014', '3', '3', '1', 'Тарасов Геласий Улебович', '2017-06-07 18:30:00', 'Фокина Кира Арсеньевна', '5833926340', '16', '+79001234567'
EXEC Insert_ticket_selling 'Интерстеллар', '2014', '4', '3', '1', 'Тарасов Геласий Улебович', '2017-06-07 18:30:00', 'Фокина Кира Арсеньевна', '5833926340', '17', '+79001234567'
EXEC Insert_ticket_selling 'Интерстеллар', '2014', '5', '3', '1', 'Тарасов Геласий Улебович', '2017-06-07 18:30:00', 'Фокина Кира Арсеньевна', '5833926340', '18', '+79001234567'
EXEC Insert_ticket_selling 'Интерстеллар', '2014', '1', '7', '1', 'Тарасов Геласий Улебович', '2017-06-07 18:30:00', 'Фокина Кира Арсеньевна', '5833926340', '19', '+79001234567'
EXEC Insert_ticket_selling 'Интерстеллар', '2014', '2', '7', '1', 'Тарасов Геласий Улебович', '2017-06-07 18:30:00', 'Фокина Кира Арсеньевна', '5833926340', '20', '+79001234567'
EXEC Insert_ticket_selling 'Интерстеллар', '2014', '5', '7', '1', 'Тарасов Геласий Улебович', '2017-06-07 18:30:00', 'Фокина Кира Арсеньевна', '5833926340', '21', '+79001234567'
