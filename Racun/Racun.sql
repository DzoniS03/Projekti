create database Racun
use Racun

create table racun(
	id int identity(1,1),
	br_racuna int,
	kupac nvarchar(40),
	datum date,
	vrednost int,
	br_stavki int
)

insert into racun
values(11111, 'Pera Periæ', '12/13/2021', 654, 6)
insert into racun
values(12354, 'Mika Mikiæ', '11/13/2021', 3647, 27)
