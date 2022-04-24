
create database Office;
USE Office;
Create TABLE DIstrict(
id INT PRIMARY KEY IDENTITY,
name NVARCHAR(20) NOT NULL
);
Create TABLE Education(
id INT PRIMARY KEY IDENTITY,
name NVARCHAR(20) NOT NULL
);

Create TABLE Employer(
id INT PRIMARY KEY IDENTITY,
treaty NVARCHAR(30) NOT NULL
);

Create TABLE Firm(
id INT PRIMARY KEY IDENTITY,
name NVARCHAR(20) NOT NULL,
telephone NVARCHAR(20) NOT NULL,
address NVARCHAR(80) NOT NULL,
ownership NVARCHAR(30) NOT NULL,
legalForm NVARCHAR(50) NOT NULL,
inspector NVARCHAR(80) NOT NULL,
idEmployer INT,
FOREIGN KEY (idEmployer) REFERENCES Employer (id) ON DELETE CASCADE
);


Create TABLE Sentence(
id INT PRIMARY KEY IDENTITY,
numOfPlace INT,
pay INT,
sex NVARCHAR(1) NOT NULL,
age INT,
position NVARCHAR(50) NOT NULL,
idEmployer INT,
FOREIGN KEY (idEmployer) REFERENCES Employer (id) ON DELETE CASCADE,
idDistrict INT,
FOREIGN KEY (idDistrict) REFERENCES District (id),
idEducation INT,
FOREIGN KEY (idEducation) REFERENCES Education (id)
);
Create TABLE Client(
regNum INT PRIMARY KEY IDENTITY,
receipt NVARCHAR(50) NOT NULL,
firstName NVARCHAR(50) NOT NULL,
secondName NVARCHAR(50) NOT NULL,
thirdName NVARCHAR(50) NOT NULL,
telephone NVARCHAR(50) NOT NULL,
address NVARCHAR(80) NOT NULL,
sex NVARCHAR(1) NOT NULL,
idEducation INT,
FOREIGN KEY (idEducation) REFERENCES Education (id)
);
Create TABLE Application(
id INT PRIMARY KEY IDENTITY,
position NVARCHAR(30) NOT NULL,
pay INT,
idDistrict INT,
FOREIGN KEY (idDistrict) REFERENCES District (id),
idClient INT,
FOREIGN KEY (idClient) REFERENCES Client (regNum) ON DELETE CASCADE);

Create TABLE Account(
id INT PRIMARY KEY IDENTITY,
type INT,
login NVARCHAR(15) NOT NULL,
password NVARCHAR(20) NOT NULL,
fullName NVARCHAR(50) NOT NULL);

INSERT Account VALUES
(1,'admin','123789*','Селиванов В.А.'),
(2,'alex123','123789','Самолетов А.К.'),
(2,'dima288','123789','Зенько Д.Ю.'),
(3,'Виталий','Селиванов','Селиванов Виталий Александрович'),
(3,'Георгий','Залож','Залож Георгий Алексеевич'),
(3,'Артем','Писарчик','Писарчик Артем Дмитриевич'),
(3,'Никита','Гуцаленко','Гуцаленко Никита Ильич'),
(3,'Данила','Боровков','Боровков Данила Ильич')



INSERT Education VALUES
('высшее'),
('среднее'),
('средне-специальное'),
('магистратура'),
('докторская')

INSERT District VALUES
('8 район'),
('дом книги'),
('пралеска'),
('первая палатка'),
('детский мир')

INSERT Client Values
('123784','Виталий','Селиванов','Александрович','375447878818','Олимпийская11-82','m',1),
('123785','Георгий','Залож','Алексеевич','375333451650','Олимпийская 7-12','f',2),
('123786','Артем','Писарчик','Дмитриевич','375293700810','Дружная 1а-44','m',3),
('123787','Никита','Гуцаленко','Ильич','375445467374','Коласа 8-93','m',4),
('123788','Данила','Боровков','Ильич','375292169510','Молодежная 122-323','f',5)

INSERT Application Values
('qa jun',300,1,1),
('qa middle',750,2,2),
('qa aut middle',1200,3,3),
('qa senior',1900,4,4),
('qa aut senior',2500,5,5)

INSERT Employer Values
('123456'),
('123457'),
('123458'),
('123459'),
('123450')

INSERT Firm Values
('A1qa','375331234567','Олимпийская 2','ОАО','123456','Калинцев',1),
('ITechArt','375331234568','Дружная 11','ОАЭ','123455','Франценва',2),
('Epam','375331234569','Молодежная 88','ЧП','123454','Сергеевна',3),
('Яндекс','375331234560','Коласа 22','ЧП','123453','Вильсоныч',4),
('Google','375331234561','Купала 1','ЧК','123452','Васильевич',5)

INSERt Sentence Values
(10,400,'m',20,'qa jun',1,1,1),
(5,900,'f',17,'qa middle',2,2,2),
(2,1500,'m',33,'qa aut middle',3,3,3),
(8,2000,'m',25,'qa senior',4,4,4),
(33,3000,'f',20,'qa aut senior',5,5,5),
(5,500,'f',19,'qa jun',5,5,5)