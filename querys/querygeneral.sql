
--CREATE DATABASE ProyectoTPII_MoraesLeandro

use ProyectoTPII_MoraesLeandro

CREATE TABLE tipo_rol(
id_rol int primary key,
descripcion varchar(50)
)

insert into tipo_rol(id_rol,descripcion)
values(1,'administrador'),(2,'gerente'),(3,'vendedor')

CREATE TABLE usuario(
DNI_usuario int primary key,
id_rol int,
nombre_usuario varchar(50),
apellido_usuario varchar(50),
direccion_usuario varchar(50),
contraseña_usuario varchar(50),
avatar image,
estado int CHECK (estado in (0,1)),
CONSTRAINT FK_id_rol Foreign Key (id_rol) references tipo_rol(id_rol)
)

CREATE TABLE cliente(
DNI_cliente int primary key,
nombre_cliente varchar(50),
apellido_cliente varchar(50),
direccion varchar(50),
telefono varchar(15),
avatar image,
estado int CHECK (estado in (0,1)), 
)

select * from cliente


