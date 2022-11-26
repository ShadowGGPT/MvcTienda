CREATE DATABASE MvcTienda
GO
USE MvcTienda
GO

-------------------------CONFIGURACIONES BASICAS-------------------------

GO 
CREATE TABLE ROL(
IdRol int primary key identity(1,1),
Descripcion nvarchar(50),
FechaRegistro datetime default getdate(),
Activo bit default 1)


GO 
CREATE TABLE USUARIO(
IdUsuario int primary key identity(1,1),
Nombres nvarchar(50),
Apellidos nvarchar(50),
Correo nvarchar(100),
Telefono varchar(15) not null default '',
Clave nvarchar(100),
--IdTienda int references TIENDA(IdTienda),
IdRol int references ROL(IdRol),
UrlFoto nvarchar(500),
NombreFoto nvarchar(100),
FechaRegistro datetime default getdate(),
Activo bit default 1)


GO 
CREATE TABLE METODO_PAGO(
IdMetodoPago int primary key identity(1,1),
IdNombre nvarchar(50),
UrlFoto nvarchar(500),
NombreFoto nvarchar(100))


-------------------------PRODUCTO-------------------------

GO 
CREATE TABLE CATEGORIA(
IdCategoria int primary key identity(1,1),
Nombre nvarchar(100),
UrlFoto nvarchar(500),
NombreFoto nvarchar(100),
Activo bit default 1)


GO 
CREATE TABLE MARCA(
IdMarca int primary key identity,
Nombre nvarchar(100),
UrlFoto nvarchar(500),
NombreFoto nvarchar(100),
Activo bit default 1)


GO 
CREATE TABLE PRODUCTO(
IdProducto int primary key identity(1,1),
Codigo char(4),
CodigoBarra varchar(50),
Nombre nvarchar(100),
Descripcion nvarchar(500),
IdMarca int references Marca(IdMarca),
IdCategoria int references Categoria(IdCategoria),
Precio decimal(10,2) default 0,
Stock int,
UrlFoto nvarchar(500),
NombreFoto nvarchar(100),
FechaRegistro datetime default getdate(),
Activo bit default 1)


GO
CREATE TABLE DESCRIPCION_PRODUCTO(
IdDescripcion int primary key identity(1,1),
IdProducto int references PRODUCTO(IdProducto),
Nombre nvarchar(100),
Descripcion nvarchar(100)
)

GO 
CREATE TABLE CARRITO(
IdCarrito int primary key identity(1,1),
IdUsuario int references USUARIO(IdUsuario),
IdProducto int references PRODUCTO(IdProducto),
Cantidad int)

-------------------------COMPRAS-------------------------

GO 
CREATE TABLE PROVEEDOR(
IdProveedor int primary key identity(1,1),
Telefono varchar(15) not null default '',
Correo nvarchar(50),
Direccion nvarchar(100),
Descripcion nvarchar(100),
UrlFoto nvarchar(500),
NombreFoto nvarchar(100),
FechaRegistro datetime default getdate(),
Activo bit default 1)


GO 
CREATE TABLE COMPRA(
IdCompra int primary key identity(1,1),
NumeroCompra varchar(6),
IdUsuario int references USUARIO(IdUsuario),
IdProveedor int references PROVEEDOR(IdProveedor),
IdMetodoPago int references METODO_PAGO(IdMetodoPago),
Total decimal (10,2),
FechaCompra datetime default getdate())


GO 
CREATE TABLE DETALLE_COMPRA(
IdDetalleCompra int primary key identity,
IdCompra int references Compra(IdCompra),
IdProducto int references PRODUCTO(IdProducto),
Cantidad int,
PrecioUnitario decimal(10,2))

-------------------------VENTAS-------------------------

GO 
CREATE TABLE CLIENTE(
IdCliente int primary key identity(1,1),
Nombres nvarchar(50),
Apellidos nvarchar(50),
Telefono varchar(15) not null default '',
Direccion nvarchar(100),
Correo nvarchar(100),
Clave nvarchar(100),
FechaRegistro datetime default getdate())


GO 
CREATE TABLE DEPARTAMENTO(
IdDepartamento int primary key identity(1,1),
Nombre nvarchar(100),
Activo bit default 1)


GO 
CREATE TABLE MUNICIPIO(
IdMunicipio int primary key identity(1,1),
IdDepartamento int references DEPARTAMENTO(IdDepartamento),
Nombre nvarchar(100),
Activo bit default 1)


GO 
CREATE TABLE DOMICILIO(
IdDomicilio int primary key identity (1,1),
IdCliente int references Cliente(IdCliente),
IdDepartamento int references DEPARTAMENTO(IdDepartamento),
IdMunicipio int references MUNICIPIO(IdMunicipio),
Direccion nvarchar(100),
Activo bit default 1)


GO 
CREATE TABLE VENTA(
IdVenta int primary key identity(1,1),
NumeroVenta varchar(6),
IdUsuario int references USUARIO(IdUsuario),
IdCliente int references CLIENTE(IdCliente),
IdDomicilio int references DOMICILIO(IdDomicilio),
IdMetodoPago int references METODO_PAGO(IdMetodoPago),
IdTransaccion varchar(50),
Total decimal(10,2),
FechaRegistro datetime default getdate())


GO 
CREATE TABLE DETALLE_VENTA(
IdDetalleVenta int primary key identity(1,1),
IdVenta int references VENTA(IdVenta),
IdProducto int references PRODUCTO(IdProducto),
Cantidad int,
PrecioUnitario decimal(10,2),
FechaRegistro datetime default getdate())


GO
CREATE TABLE NUMERO_CORRELATIVO(
IdNumeroCorrelativo int primary key identity(1,1),
UltimoNumero int,
CantidadDigitos int,
Gestion nvarchar(100),
FechaActualizacion datetime
)



GO
CREATE TABLE MENU(
IdMenu int primary key identity(1,1),
Descripcion varchar(30),
IdMenuPadre int references Menu(idMenu),
Icono varchar(30),
Controlador varchar(30),
PaginaAccion varchar(30),
Activo bit default 1,
FechaRegistro datetime default getdate()
)

GO
CREATE TABLE ROL_MENU(
IdRolMenu int primary key identity(1,1),
IdRol int references Rol(idRol),
IdMenu int references Menu(idMenu),
Activo bit default 1,
FechaRegistro datetime default getdate()
 )

GO
CREATE TABLE NEGOCIO(
IdNegocio int primary key,
UrlLogo varchar(500),
NombreLogo varchar(100),
NumeroDocumento varchar(50),
Nombre varchar(50),
Correo varchar(50),
Direccion varchar(50),
Telefono varchar(50),
PorcentajeImpuesto decimal(10,2),
SimboloMoneda varchar(5)
)

go

create table Configuracion(
recurso varchar(50),
propiedad varchar(50),
valor varchar(60)
)