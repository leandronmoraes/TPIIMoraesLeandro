
--CREATE DATABASE ProyectoTPII_MoraesLeandro

use ProyectoTPII_MoraesLeandro

--Creamos tabla tipo rol que se encuentra relacionada con USUARIO
CREATE TABLE tipo_rol(
id_rol int primary key,
descripcion_rol varchar(50)
)

--Insertamos los valores a tipo rol
insert into tipo_rol(id_rol,descripcion_rol)
values(1,'administrador'),(2,'gerente'),(3,'vendedor')

--Creamos la tabla usuario
CREATE TABLE usuario (
    id_usuario INT IDENTITY(1,1) PRIMARY KEY, -- Configurar como identidad y autoincremental
    DNI_usuario INT,
    id_rol INT,
    nombre_usuario VARCHAR(50),
    apellido_usuario VARCHAR(50),
    direccion_usuario VARCHAR(50),
    contraseña_usuario VARCHAR(200),
    estado INT CHECK (estado IN (0, 1)),
    CONSTRAINT FK_id_rol FOREIGN KEY (id_rol) REFERENCES tipo_rol(id_rol)
);

-- Agregar restricción NOT NULL a DNI_usuario
ALTER TABLE usuario
ALTER COLUMN DNI_usuario VARCHAR(15) NOT NULL;

-- Agregar restricción UNIQUE a DNI_usuario
ALTER TABLE usuario
ADD CONSTRAINT UQ_DNI_usuario UNIQUE (DNI_usuario);
-- Se eliminaron las columnas fecha_ingreso y fecha_salida ya que se creo otra Tabla RegistroUsuario para almacenar los datos.
ALTER TABLE usuario
DROP COLUMN fecha_ingreso, fecha_salida;

--Creamos la tabla RegistroUsuario que se encuentra relacionado cuando un Usuario (empleado se conecta o se desconecta)
CREATE TABLE RegistroUsuario (
    id_registro INT IDENTITY(1,1) PRIMARY KEY,
    id_usuario INT, -- Hace referencia al ID del usuario
    fecha_ingreso DATETIME,
    fecha_salida DATETIME
);

ALTER TABLE RegistroUsuario
ADD CONSTRAINT FK_id_usuario FOREIGN KEY (id_usuario)
REFERENCES usuario (id_usuario);

--Creamos la tabla Cliente
CREATE TABLE cliente (
    id_cliente INT IDENTITY(1,1) PRIMARY KEY,
    DNI_cliente INT,
    nombre_cliente VARCHAR(50),
    apellido_cliente VARCHAR(50),
    direccion VARCHAR(50),
    telefono VARCHAR(15),
    estado INT DEFAULT 1, -- Establecer un valor predeterminado de 1
    CHECK (estado IN (0, 1))
);

ALTER TABLE cliente
ALTER COLUMN DNI_cliente VARCHAR(15);

-- Agregar restricción UNIQUE y NOT NULL a DNI_cliente
ALTER TABLE cliente
ADD CONSTRAINT UQ_DNI_cliente UNIQUE (DNI_cliente);

-- Modificar la longitud de la columna direccion
ALTER TABLE cliente
ALTER COLUMN direccion VARCHAR(255);

-- Agregar restricción CHECK para el formato del teléfono
ALTER TABLE cliente
ADD CONSTRAINT CK_telefono CHECK (telefono LIKE '[0-9]%');


--Creamos la tabla producto.
CREATE TABLE producto (
    id_producto INT IDENTITY(1,1) PRIMARY KEY,
    nombre_producto VARCHAR(100),
    descripcion_producto VARCHAR(MAX),
    id_categoria INT,
    id_proveedor INT,
    precio_producto DECIMAL(10, 2),
    stock_producto INT,
    imagen_producto IMAGE,
    
    FOREIGN KEY (id_categoria) REFERENCES categoria(id_categoria),
    FOREIGN KEY (id_proveedor) REFERENCES proveedor(id_proveedor)
);

ALTER TABLE producto
ADD estado INT DEFAULT 1 CHECK (estado IN (0, 1));

--Creamos la tabla categoria.
CREATE TABLE categoria (
    id_categoria INT PRIMARY KEY,
    descripcion_categoria VARCHAR(50)
);

--Insertamos los datos a categoria.
insert into categoria(id_categoria,descripcion_categoria)
values(1,'comics'),(2,'libros'),(3,'mangas')

--Creamos la tabla proveedor
	CREATE TABLE proveedor (
    id_proveedor INT IDENTITY(1,1) PRIMARY KEY,
    nombre_proveedor VARCHAR(100),
    telefono_proveedor VARCHAR(20),
    cuit_proveedor VARCHAR(20),
    email_proveedor VARCHAR(100),
    direccion_proveedor VARCHAR(255),
    IVA VARCHAR(50) CHECK (IVA IN ('Responsable inscripto', 'Consumidor final', 'Responsable no inscripto'))
);

select *from proveedor
ALTER TABLE proveedor
ADD estado INT DEFAULT 1 CHECK (estado IN (0, 1));

--Creamos la tabla Venta
CREATE TABLE venta (
 id_venta INT IDENTITY(1,1) PRIMARY KEY,
 id_cliente int,
 fecha_venta DATE,
 total_venta DECIMAL(10, 2),
 FOREIGN KEY (id_cliente) REFERENCES cliente(id_cliente)
 );

--Se agrego como modificación el estado.
ALTER TABLE venta
ADD estado INT DEFAULT 1 CHECK (estado IN (0, 1));

--Se modifico la tabla venta para poder incluir la información del vendedor y el tipo de pago.
ALTER TABLE venta
ADD id_vendedor INT, -- Agregar el campo para el vendedor
	id_tipo_pago INT;

--Creamos la tabla detalle
 CREATE TABLE venta_detalle (
	id_ventaDetalle INT IDENTITY(1,1) PRIMARY KEY,
	id_venta INT,
	id_producto INT,
	cantidad INT,
	precioUnitario DECIMAL(10,2),
	subTotal DECIMAL(10,2),
	FOREIGN KEY (id_venta) REFERENCES venta(id_venta),
	FOREIGN KEY (id_producto) REFERENCES producto(id_producto)
);


-- Establecer la relación con la tabla usuario para el vendedor 
ALTER TABLE venta
ADD CONSTRAINT FK_id_vendedor FOREIGN KEY (id_vendedor) REFERENCES usuario(id_usuario);

-- la relación con el método de pago
ALTER TABLE venta
ADD CONSTRAINT FK_id_tipo_pago FOREIGN KEY (id_tipo_pago) REFERENCES tipo_pago(id_tipo_pago);

CREATE TABLE tipo_pago (
    id_tipo_pago INT IDENTITY(1,1) PRIMARY KEY,
    descripcion_tipo_pago VARCHAR(50)
);

--Insertamos los datos de tipo_pago
INSERT INTO tipo_pago (descripcion_tipo_pago)
VALUES ('Efectivo'), ('Tarjeta de crédito'), ('Tarjeta de débito'), ('Transferencia bancaria');

select * from usuario
select * from producto
select * from proveedor
select * from RegistroUsuario
select * from cliente
select * from pedido
select * from venta
select * from venta_detalle


ALTER TABLE producto
DROP COLUMN cod_producto;

--Creamos la tabla de pedido que se encuentra relacionada con Proveedor
CREATE TABLE pedido (
    id_pedido INT IDENTITY(1,1) PRIMARY KEY,
    cantidad_pedido INT,
	nombre_producto_pedido VARCHAR(255);
    descripcion_pedido VARCHAR(255),
    direccion_pedido VARCHAR(255),
    fecha_pedido DATE,
    id_proveedor INT,
    FOREIGN KEY (id_proveedor) REFERENCES proveedor(id_proveedor)
);

ALTER TABLE pedido
ADD nombre_producto_pedido VARCHAR(255);

-- Agregar la columna estado con valor predeterminado y restricción CHECK
ALTER TABLE pedido
ADD estado INT DEFAULT 1 CHECK (estado IN (0, 1, 2));


ALTER TABLE pedido
ADD id_producto INT;

-- Establecemos la relación con la tabla producto
ALTER TABLE pedido
ADD CONSTRAINT FK_id_producto_pedido FOREIGN KEY (id_producto) REFERENCES producto(id_producto);

