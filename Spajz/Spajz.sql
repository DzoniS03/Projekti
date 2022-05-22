create database Spajz
use Spajz

create table Korisnik(
id int primary key identity(1,1),
ime nvarchar(50) not null,
prezime nvarchar(50) not null,
email nvarchar(50) not null,
pass nvarchar(100) not null
)

create table Proizvodjac(
id int primary key identity(1,1),
naziv nvarchar(60) not null
)

create table Kategorija(
id int primary key identity(1,1),
naziv nvarchar(60) not null
)

create table Proizvod(
id int primary key identity(1,1),
naziv nvarchar(50) not null,
proizvodjac_id int foreign key references Proizvodjac(id),
kategorija_id int foreign key references Kategorija(id),
cena int not null
)

insert into Proizvodjac values
('Frikom'),
('Lidl'),
('Imlek'),
('Bambi'),
('Stark'),
('Barilla')

insert into Kategorija values
('Mlecni proizvod'),
('Sladoled'),
('Smrznuto povrce'),
('Testenina'),
('Keks'),
('Grickalice')

insert into Korisnik values
('Petar', 'Petrovic', 'pera.peric@gmail.com', '1234'), 
('Katarina', 'Simic', 'keti673@yahoo.com', '5678'),
('Jovan', 'Savic', 'belazebra5@gmail.com', 'zebra'),
('Nikola', 'Simikic', 'simikic.nikola@gmail.com', '0000')

insert into Proizvod values
('Smrznuti grasak', 1, 3, 100),
('Smoki', 5, 6, 45),
('Beli Macho', 1, 2, 90),
('Plazma', 4, 5, 85),
('Jogurt', 2, 1, 90),
('Jogurt', 3, 1, 95),
('Mleko', 3, 1, 95),
('Fusilli', 6, 4, 115),
('Napolitanke Kokos', 5, 5, 105)

drop database Spajz