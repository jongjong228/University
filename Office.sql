
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
(1,'admin','123789*','��������� �.�.'),
(2,'alex123','123789','��������� �.�.'),
(2,'dima288','123789','������ �.�.'),
(3,'�������','���������','��������� ������� �������������'),
(3,'�������','�����','����� ������� ����������'),
(3,'�����','��������','�������� ����� ����������'),
(3,'������','���������','��������� ������ �����'),
(3,'������','��������','�������� ������ �����')



INSERT Education VALUES
('������'),
('�������'),
('������-�����������'),
('������������'),
('����������')

INSERT District VALUES
('8 �����'),
('��� �����'),
('��������'),
('������ �������'),
('������� ���')

INSERT Client Values
('123784','�������','���������','�������������','375447878818','�����������11-82','m',1),
('123785','�������','�����','����������','375333451650','����������� 7-12','f',2),
('123786','�����','��������','����������','375293700810','������� 1�-44','m',3),
('123787','������','���������','�����','375445467374','������ 8-93','m',4),
('123788','������','��������','�����','375292169510','���������� 122-323','f',5)

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
('A1qa','375331234567','����������� 2','���','123456','��������',1),
('ITechArt','375331234568','������� 11','���','123455','���������',2),
('Epam','375331234569','���������� 88','��','123454','���������',3),
('������','375331234560','������ 22','��','123453','���������',4),
('Google','375331234561','������ 1','��','123452','����������',5)

INSERt Sentence Values
(10,400,'m',20,'qa jun',1,1,1),
(5,900,'f',17,'qa middle',2,2,2),
(2,1500,'m',33,'qa aut middle',3,3,3),
(8,2000,'m',25,'qa senior',4,4,4),
(33,3000,'f',20,'qa aut senior',5,5,5),
(5,500,'f',19,'qa jun',5,5,5)