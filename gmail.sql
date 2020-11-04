create database gmaiil
use gmaiil

create table compte
(
	email varchar(50) primary key,
	nom varchar(50) ,
	prenom varchar(50) ,
	mdps varchar(50),
	sexe varchar(30),
	daten DateTime,
	qs varchar(30),
	qr varchar(30),
	img image
)
create table msg
(
idm int primary key identity(1,1)  ,
adrexp varchar(50) references compte(email) ,
adrdes varchar(50) references compte(email) ,
corps varchar(30) ,
objet varchar(30),
important int default 0,
datemsg datetime default GetDate(),
lu int default 0,
supex bit ,
supdes bit,
img image,
important1 int default 0,
lu1 int default 0
)
--drop table compte
drop table msg
select * from compte
select * from msg
drop table msg
delete  msg