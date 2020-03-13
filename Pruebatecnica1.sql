create database aplicacion1
go
use aplicacion1
go 


create table Roles
(
idrol int not null identity(1,1) primary key,
tiporol varchar(50) not null,
)

create table Membresias
(
idMembresia int not null identity(1,1) primary key,
tipoMembresia varchar(50) not null,
)


create table Usuario
(
idUsuario int not null identity(1,1) primary key,
nomUsuario varchar(50) not null,
apeUsuario varchar(50) not null,
correo varchar(50) not null,
idrol int foreign key references Roles(idrol) not null,
idMembresia int foreign key references Membresias(idMembresia) not null
)

insert into Roles values('Administrador')
insert into Roles values('Usuario')

insert into Membresias values('Basico')
insert into Membresias values('Platino')
insert into Membresias values('Premium')

insert into Usuario values('oscarA','colocho','colocho',1,1)

select * from Roles
select * from Membresias
select * from Usuario

