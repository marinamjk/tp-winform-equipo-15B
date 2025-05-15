CREATE DATABASE CATALOGO_P3_DB
GO

USE CATALOGO_P3_DB
GO

CREATE TABLE CATEGORIAS(
Id int primary key identity(1,1),
Descripcion varchar(100) not null
)

CREATE TABLE MARCAS(
Id int primary key identity(1,1),
Descripcion varchar(100) not null
)

CREATE TABLE ARTICULOS(
Id int not null primary key identity(1,1),
Codigo varchar(50) not null,
Nombre varchar(100) not null,
Descripcion varchar(500),
IdMarca int not null foreign key references MARCAS(Id),
IdCategoria int not null foreign key references CATEGORIAS(Id),
Precio decimal(19, 2) not null
)

CREATE TABLE IMAGENES(
Id int primary key identity(1,1),
IdArticulo int not null foreign key references ARTICULOS(Id),
ImagenUrl VARCHAR(1000) NOT NULL
)
go

INSERT INTO CATEGORIAS (Descripcion) VALUES ('Electrónica');
INSERT INTO CATEGORIAS (Descripcion) VALUES ('Hogar');
INSERT INTO CATEGORIAS (Descripcion) VALUES ('Deportes');

INSERT INTO MARCAS (Descripcion) VALUES ('Samsung');
INSERT INTO MARCAS (Descripcion) VALUES ('Philips');
INSERT INTO MARCAS (Descripcion) VALUES ('Nike');

INSERT INTO ARTICULOS (Codigo, Nombre, Descripcion, IdMarca, IdCategoria, Precio)
VALUES ('A100', 'Smart TV 55"', 'Smart TV 4K UHD con WiFi', 1, 1, 349999.99);

INSERT INTO ARTICULOS (Codigo, Nombre, Descripcion, IdMarca, IdCategoria, Precio)
VALUES ('A101', 'Aspiradora Philips', 'Aspiradora potente para el hogar', 2, 2, 89999.50);

INSERT INTO ARTICULOS (Codigo, Nombre, Descripcion, IdMarca, IdCategoria, Precio)
VALUES ('A102', 'Zapatillas Running', 'Zapatillas deportivas livianas', 3, 3, 59999.00);

INSERT INTO IMAGENES (IdArticulo, ImagenUrl)
VALUES (1, 'https://sampietroweb.com.ar/Image/0/700_700-0088112901_1.jpg');

INSERT INTO IMAGENES (IdArticulo, ImagenUrl)
VALUES (2, 'https://images.philips.com/is/image/philipsconsumer/vrs_a3999d072bab81012194cdac5125cc767cc9bdd2?$pnglarge$&wid=1250');

INSERT INTO IMAGENES (IdArticulo, ImagenUrl)
VALUES (3, 'https://www.dexter.com.ar/on/demandware.static/-/Sites-365-dabra-catalog/default/dw352b5686/products/NIFB2207-001/NIFB2207-001-1.JPG');