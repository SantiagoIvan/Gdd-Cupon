--!!!!!!!
--CREACION DE TABLAS
USE [GD2C2019]
GO
create schema RE_GDDIENTOS authorization  gdCupon2019
go
create table [RE_GDDIENTOS].Funcionalidades(
	funcionalidad_id smallint identity(1,1) primary key,
	funcionalidad_nombre nvarchar(100) not null unique
)

create table [RE_GDDIENTOS].Roles(
	rol_id smallint identity(1,1) primary key,
	rol_nombre nvarchar(100) not null unique,
	habilitado bit default 1
)

create table [RE_GDDIENTOS].FuncionalidadPorRol(
	rol_id smallint foreign key references [RE_GDDIENTOS].Roles(rol_id),
	funcionalidad_id smallint foreign key references [RE_GDDIENTOS].Funcionalidades(funcionalidad_id),
	primary key(rol_id, funcionalidad_id)
)

create table [RE_GDDIENTOS].Usuarios(
	nombre_usuario nvarchar(255) primary key,
	password nvarchar(255) not null,
	intentos smallint default 0,
	habilitado bit default 1
)

create table [RE_GDDIENTOS].UsuarioPorRol(
	rol_id smallint foreign key references [RE_GDDIENTOS].Roles(rol_id),
	nombre_usuario nvarchar(255) foreign key references [RE_GDDIENTOS].Usuarios(nombre_usuario),
	primary key(rol_id,nombre_usuario)
)

create table [RE_GDDIENTOS].Administradores(
	administrativo_id smallint identity(1,1) primary key,
	nombre_usuario nvarchar(255) not null foreign key references [RE_GDDIENTOS].Usuarios(nombre_usuario)
)

create table [RE_GDDIENTOS].Clientes (
	dni numeric(18,0) primary key,
	cliente_nombre nvarchar(255) not null,
	cliente_apellido nvarchar(255) not null,
	fecha_nacimiento datetime not null,
	ciudad nvarchar(255) not null,
	codigo_postal nvarchar(20),
	telefono numeric(18,0) not null,
	email nvarchar(255) not null,
	direccion nvarchar(255) not null,
	piso smallint,
	dpto char,
	habilitado bit default 1,
	nombre_usuario nvarchar(255),
	saldo numeric(18,2) default 200
)

create table [RE_GDDIENTOS].Rubros(
	rubro_id int identity(1,1) primary key,
	rubro_nombre nvarchar(50) not null unique
)

create table [RE_GDDIENTOS].Proveedores(
	cuit nvarchar(20)  primary key,
	rs nvarchar(100) not null,
	email nvarchar(255),
	telefono numeric(18,0) not null,
	ciudad nvarchar(255) not null,
	codigo_postal nvarchar(20),
	rubro_id int not null,
	nombre_contacto nvarchar(100),
	direccion nvarchar(255) not null,
	piso smallint,
	dpto char,
	habilitado bit default 1,
	nombre_usuario nvarchar(255)
)

create table [RE_GDDIENTOS].Ofertas(
	oferta_id nvarchar(50) primary key,
	fecha_publicacion datetime not null,
	fecha_vto datetime not null,
	precio_oferta numeric(18,2) not null,
	precio_viejo numeric(18,2) not null,
	proveedor_cuit nvarchar(20) not null,
	stock smallint,
	oferta_descripcion nvarchar(255) not null,
	limite_compra_por_us smallint default 100
)

create table [RE_GDDIENTOS].Detalles_Tarjeta(
	tarjeta_id numeric(18,0) primary key,
	titular nvarchar(255) not null,
	fecha_vto datetime not null
)

create table [RE_GDDIENTOS].Cargas_credito(
	carga_id int identity(1,1) primary key,
	carga_fecha datetime not null,
	monto numeric(18,2) not null,
	cliente_dni numeric(18,0),
	forma_de_pago nvarchar(100) not null,
	tarjeta_id numeric (18,0)
)

create table [RE_GDDIENTOS].Reportes_Facturacion(
	reporte_id numeric(18,0) primary key,
	proveedor_cuit nvarchar(20) not null,
	fecha_minima datetime,
	fecha_maxima datetime not null,
	importe_total numeric(18,2) not null
)

create table [RE_GDDIENTOS].Cupones(
	cupon_id int identity(1,1) primary key,
	fecha_consumo datetime,
	fecha_compra datetime not null,
	cliente_comprador_dni numeric(18,0) not null,
	cliente_canjeador_dni numeric(18,0),
	oferta_id nvarchar(50) not null,
	reporte_id numeric(18,0)
)
go

--Migración
use GD2C2019
go
create procedure [RE_GDDIENTOS].migrar_clientes
as
begin
	insert into [RE_GDDIENTOS].Clientes (dni,cliente_nombre, cliente_apellido, fecha_nacimiento, ciudad,telefono, email, direccion)
		select Cli_Dni,Cli_Nombre,Cli_Apellido, Cli_Fecha_Nac, Cli_Ciudad, Cli_Telefono, Cli_Mail, Cli_Direccion
		from gd_esquema.Maestra where Cli_Apellido is not null
		group by Cli_Nombre,Cli_Apellido,Cli_Dni, Cli_Fecha_Nac, Cli_Ciudad, Cli_Telefono, Cli_Mail, Cli_Direccion
end
go

use GD2C2019
go
create procedure [RE_GDDIENTOS].migrar_rubros
as
begin
	insert into [RE_GDDIENTOS].Rubros (rubro_nombre)
		select distinct Provee_Rubro from gd_esquema.Maestra where Provee_Rubro is not null
end
go

use GD2C2019
go
create procedure [RE_GDDIENTOS].migrar_proveedores
as
begin
	insert into [RE_GDDIENTOS].Proveedores (rs, telefono, ciudad, cuit, rubro_id, direccion)
		select distinct Provee_RS, Provee_Telefono, Provee_Ciudad, Provee_CUIT, rubro_id, Provee_Dom
		from gd_esquema.Maestra,Rubros where Provee_CUIT is not null and rubro_nombre=Provee_Rubro
end
go

use GD2C2019
go
create procedure [RE_GDDIENTOS].migrar_ofertas
as
begin
	insert into [RE_GDDIENTOS].ofertas (oferta_id, fecha_publicacion, fecha_vto, precio_oferta, precio_viejo, proveedor_cuit, stock, oferta_descripcion)
		select Oferta_Codigo, Oferta_Fecha, Oferta_Fecha_Venc, Oferta_Precio, Oferta_Precio_Ficticio, cuit,Oferta_Cantidad, Oferta_Descripcion
		from gd_esquema.Maestra join [RE_GDDIENTOS].Proveedores on (provee_rs=rs) where Oferta_Codigo is not null
		group by Oferta_Codigo, Oferta_Fecha, Oferta_Fecha_Venc, Oferta_Precio, Oferta_Precio_Ficticio, cuit, Oferta_Cantidad, Oferta_Descripcion
	
end
go

use GD2C2019
go
create procedure [RE_GDDIENTOS].migrar_cargas
as
begin
	insert into [RE_GDDIENTOS].Cargas_credito (carga_fecha,monto,cliente_dni,forma_de_pago)
		select Carga_Fecha,Carga_Credito,dni,Tipo_Pago_Desc
		from gd_esquema.Maestra join [RE_GDDIENTOS].Clientes c on (Cli_Dni=c.dni) where Carga_Fecha is not null
end
go

use GD2C2019
go
create procedure [RE_GDDIENTOS].migrar_reportes
as
begin
	insert into [RE_GDDIENTOS].Reportes_Facturacion (reporte_id, proveedor_cuit, fecha_maxima, importe_total)
		select Factura_Nro, cuit, Factura_Fecha,sum(oferta_precio)
		from gd_esquema.Maestra join [RE_GDDIENTOS].Proveedores on (cuit=Provee_CUIT)
		where Factura_Nro is not null
		group by Factura_Nro, cuit, Factura_Fecha

end
go

use GD2C2019
go
create procedure [RE_GDDIENTOS].migrar_cupones
as
begin
	insert into [RE_GDDIENTOS].Cupones (fecha_consumo,fecha_compra, cliente_comprador_dni,cliente_canjeador_dni,oferta_id,reporte_id)
		select (select Oferta_Entregado_Fecha from gd_esquema.Maestra t1 
				where t1.Factura_Nro is null and t1.Oferta_Fecha_Compra=t2.Oferta_Fecha_Compra 
				and t1.Cli_Dni=t2.Cli_Dni and t1.Oferta_Codigo=t2.Oferta_Codigo and Oferta_Entregado_Fecha is not null),Oferta_Fecha_Compra, Cli_Dni,Cli_Dni, Oferta_Codigo,Factura_Nro
		from gd_esquema.Maestra t2
		where Oferta_Fecha_Compra is not null and Factura_Nro is not null
end
go

use GD2C2019
go
create procedure [RE_GDDIENTOS].migrar_tablas
as
begin
	exec [RE_GDDIENTOS].migrar_clientes;
	exec [RE_GDDIENTOS].migrar_rubros;
	exec [RE_GDDIENTOS].migrar_proveedores;
	exec [RE_GDDIENTOS].migrar_ofertas;
	exec [RE_GDDIENTOS].migrar_cargas;
	exec [RE_GDDIENTOS].migrar_reportes;
	exec [RE_GDDIENTOS].migrar_cupones;

end
go

exec [RE_GDDIENTOS].migrar_tablas;
go

--Agregando constraints
alter table [RE_GDDIENTOS].Clientes
add constraint fk_usuario foreign key (nombre_usuario) references [RE_GDDIENTOS].Usuarios(nombre_usuario);
go

alter table [RE_GDDIENTOS].proveedores
add constraint fk_rubro foreign key (rubro_id) references [RE_GDDIENTOS].Rubros(rubro_id),
	constraint fk_proveedor_usuario foreign key (nombre_usuario) references [RE_GDDIENTOS].Usuarios(nombre_usuario);
go

alter table [RE_GDDIENTOS].ofertas
add constraint fk_proveedor_of  foreign key (proveedor_cuit) references [RE_GDDIENTOS].Proveedores(cuit);
go

alter table [RE_GDDIENTOS].cargas_credito
add constraint fk_cliente foreign key (cliente_dni) references [RE_GDDIENTOS].Clientes(dni),
	constraint fk_tarjeta foreign key (tarjeta_id) references [RE_GDDIENTOS].Detalles_Tarjeta(tarjeta_id);
go

alter table [RE_GDDIENTOS].reportes_facturacion
add constraint fk_proveedor_rep foreign key (proveedor_cuit) references [RE_GDDIENTOS].Proveedores(cuit);
go

alter table [RE_GDDIENTOS].cupones
add	constraint fk_comprador foreign key (cliente_comprador_dni) references [RE_GDDIENTOS].Clientes(dni),
	constraint fk_canjeador foreign key (cliente_canjeador_dni) references [RE_GDDIENTOS].Clientes(dni),
	constraint fk_oferta foreign key (oferta_id) references [RE_GDDIENTOS].Ofertas(oferta_id),
	constraint fk_reporte foreign key (reporte_id) references [RE_GDDIENTOS].Reportes_facturacion(reporte_id)
go

--Indices para las búsquedas por usuario que realizamos en muchas ocasiones para obtener algún dato como por ejemplo el saldo del cliente.
create nonclustered index ix_Clientes_username
on [RE_GDDIENTOS].Clientes(dni,nombre_usuario)

create nonclustered index ix_Proveedores_username
on [RE_GDDIENTOS].Proveedores(cuit,nombre_usuario)

--Procedures
use GD2C2019
go

-------------------------Si el usuario existe, devuelve 1, sino (-1)
create procedure [RE_GDDIENTOS].usuario_existente (
	@name nvarchar(255)
)
as
begin
	declare @returned smallint
	if(exists(select * from [RE_GDDIENTOS].Usuarios where nombre_usuario=@name))
	begin
		set @returned= 1
	end
	else
	begin
		set @returned= (-1)
	end
	return @returned
end
go

use GD2C2019
go
-------------------------Si existe el cliente, devuelve 1, sino (-1)
create procedure [RE_GDDIENTOS].cliente_existente (
	@dni nvarchar(255)
)
as
begin
	declare @v numeric(18,0) = (select TRY_CONVERT(numeric(18,0),@dni))
	declare @returned smallint
	if(exists(select * from [RE_GDDIENTOS].Clientes where dni=@v))
	begin
		set @returned= 1
	end
	else
	begin
		set @returned= (-1)
	end
	return @returned
end
go

use GD2C2019
go
-------------------------Si existe el proveedor, devuelve 1, sino (-1)
create procedure [RE_GDDIENTOS].proveedor_existente (
	@cuit nvarchar(20)
)
as
begin
	declare @returned smallint
	if(exists(select * from [RE_GDDIENTOS].Proveedores where cuit=@cuit))
	begin
		set @returned= 1
	end
	else
	begin
		set @returned= (-1)
	end
	return @returned
end
go

use GD2C2019
go
create procedure [RE_GDDIENTOS].cargar_usuario_con_rol(
	@user nvarchar(255),
	@pass nvarchar(255),
	@rol_id smallint
)
as
begin
	begin transaction
	insert into [RE_GDDIENTOS].Usuarios (nombre_usuario,password) values (@user,@pass);
	insert into [RE_GDDIENTOS].UsuarioPorRol (nombre_usuario,rol_id) values (@user,@rol_id);
	commit transaction
end
go

use GD2C2019
go
------------------------------Primero verifico que el cliente no exista, luego chequeo que el usuario sea distinto de null.
------------------------------Si es distinto de null quiere decir que estoy registrando a un usuario, por lo tanto primero lo cargo
------------------------------en su tabla. Por otro lado, si es igual a null, quiere decir que estoy cargando un cliente sin usuario
------------------------------desde el abm del admin.
create procedure [RE_GDDIENTOS].alta_cliente (
	@dni numeric(18,0),
	@nom nvarchar(255),
	@ap nvarchar(255),
	@fecha datetime,
	@ciudad nvarchar(255),
	@cp nvarchar(20),
	@tel numeric(18,0),
	@email nvarchar(255),
	@direccion nvarchar(255),
	@piso smallint,
	@depto char,
	@user nvarchar(255),
	@pass nvarchar(255),
	@rol_id smallint
)
as
begin
	declare @aux int;
	begin transaction
	exec @aux= [RE_GDDIENTOS].cliente_existente @dni;
	if(@aux>1)
	begin
		rollback;
		throw 50044,'Ya existe un cliente con ese DNI',16;
	end
	if(@user is not null)
	begin
		--significa que tengo que cargar al usuario primero, con su respectivo rol
		exec [RE_GDDIENTOS].cargar_usuario_con_rol @user,@pass,@rol_id
	end

	INSERT INTO [RE_GDDIENTOS].Clientes (dni,cliente_nombre,cliente_apellido,fecha_nacimiento,ciudad,codigo_postal,telefono,email,direccion,piso,dpto,nombre_usuario)
	VALUES (@dni,@nom,@ap,@fecha,@ciudad,@cp,@tel,@email,@direccion,@piso,@depto,@user)
	
	commit transaction
end
go

use GD2C2019
go
create procedure [RE_GDDIENTOS].alta_proveedor (
	@rs nvarchar(100),
	@email nvarchar(255),
	@telefono numeric(18,0),
	@ciudad nvarchar(255),
	@codigo_postal nvarchar(20),
	@cuit nvarchar(20),
	@rubro_id smallint,
	@contacto nvarchar(255),
	@direccion nvarchar(255),
	@piso smallint,
	@depto char,
	@user nvarchar(255),
	@pass nvarchar(255),
	@rol_id smallint
)
as
begin
	declare @aux int;
	
	begin transaction
	exec @aux = [RE_GDDIENTOS].proveedor_existente @cuit;
	if(@aux>0)
	begin
		rollback;
		throw 50032,'Ya existe un proveedor con ese CUIT',16;
	end
	if(@user is not null)
	begin
		--significa que tengo que cargar al usuario primero, con su respectivo rol
		exec [RE_GDDIENTOS].cargar_usuario_con_rol @user,@pass,@rol_id
	end

	INSERT INTO [RE_GDDIENTOS].Proveedores (rs,email,telefono,ciudad,codigo_postal,cuit,rubro_id,nombre_contacto,direccion,piso,dpto,nombre_usuario)
	VALUES (@rs,@email,@telefono,@ciudad,@codigo_postal,@cuit,@rubro_id,@contacto,@direccion,@piso,@depto,@user)

	commit transaction

end
go



use	GD2C2019
go
-------------------------Si existe un usuario con ese rol, devuelve 1, sino (-1)
create procedure [RE_GDDIENTOS].usuario_con_rol_existente(
	@rol_id smallint,
	@username nvarchar(255)
)
as
begin
	declare @returned smallint
	if(exists(select * from [RE_GDDIENTOS].UsuarioPorRol where rol_id=@rol_id and nombre_usuario=@username))
	begin
		set @returned= 1
	end
	else
	begin
		set @returned= (-1)
	end
	return @returned
end
go

use GD2C2019
go
-------------------------Obtiene todas las funcionalidades de un rol dado
create procedure [RE_GDDIENTOS].obtener_funcionalidades_del_rol  (@r smallint)
as
	select f1.funcionalidad_id,funcionalidad_nombre from [RE_GDDIENTOS].FuncionalidadPorRol f1 join [RE_GDDIENTOS].Funcionalidades f2 on (f1.funcionalidad_id=f2.funcionalidad_id) where rol_id=@r;
go

use GD2C2019
go
-------------------------Si el rol se encuentra habilitado, devuelve 1, sino (-1)
create procedure [RE_GDDIENTOS].rol_habilitado (
	@id smallint
)
as
begin
	declare @returned smallint
	if(exists(select * from [RE_GDDIENTOS].Roles where rol_id=@id and habilitado=1))
	begin
		set @returned = 1
	end
	else
	begin
		set @returned = (-1)
	end
	return @returned
end
go

use GD2C2019
go
create view [RE_GDDIENTOS].FuncionalidadesPorRolView
as
	select r.rol_id,rol_nombre,habilitado, f.funcionalidad_id, funcionalidad_nombre 
	from [RE_GDDIENTOS].Roles r join [RE_GDDIENTOS].FuncionalidadPorRol fr on(r.rol_id=fr.rol_id)
				 join [RE_GDDIENTOS].Funcionalidades f on (fr.funcionalidad_id=f.funcionalidad_id)
go

use GD2C2019
go
create procedure [RE_GDDIENTOS].buscar_cliente_segun_usuario(
	@user nvarchar(255)
)
as

	declare @returned numeric(18,0) = (select dni from [RE_GDDIENTOS].Clientes where nombre_usuario=@user)
	return @returned
go

use GD2C2019
go
-------------------------Primero, si no existe la tarjeta ingresada, la carga al sistema, y luego realiza la carga de credito
-------------------------
create procedure [RE_GDDIENTOS].cargar_credito (
	@dni numeric(18,0),
	@monto numeric(18,2),
	@fecha_de_carga datetime,
	@forma_pago nvarchar(100),
	@tarj_num numeric(18,0),
	@fecha_venc datetime,
	@titular nvarchar(255)
)
as
begin
	begin transaction
		begin try
			if(not exists(select tarjeta_id from Detalles_Tarjeta where tarjeta_id=@tarj_num))
			begin
				insert into [RE_GDDIENTOS].Detalles_Tarjeta (tarjeta_id,titular,fecha_vto) values (@tarj_num,@titular,@fecha_venc)
			end
			insert into [RE_GDDIENTOS].Cargas_credito (carga_fecha,monto,cliente_dni,forma_de_pago,tarjeta_id)
				   values (@fecha_de_carga,@monto,@dni,@forma_pago,@tarj_num)
			update [RE_GDDIENTOS].Clientes set saldo=saldo+@monto where dni=@dni
			commit transaction
		end try
		begin catch
			rollback
		end catch
end
go

use GD2C2019
go
create procedure [RE_GDDIENTOS].publicar_oferta (
	@stock smallint,
	@limite_de_compra smallint,
	@precio_viejo numeric(18,2),
	@precio_nuevo numeric(18,2),
	@cuit nvarchar(20),
	@descr nvarchar(255),
	@fecha_pub datetime,
	@fecha_venc datetime
)
as
begin
	declare @oferta_id nvarchar(50) = (select convert(nvarchar(50),newid()));
	while(exists(select oferta_id from [RE_GDDIENTOS].Ofertas where oferta_id=@oferta_id))
	begin
		set @oferta_id = (select convert(nvarchar(50),newid()));
	end

	begin try
		insert into [RE_GDDIENTOS].Ofertas values(@oferta_id,@fecha_pub,@fecha_venc,@precio_nuevo,@precio_viejo,@cuit,@stock,@descr,@limite_de_compra)
	end try
	begin catch
		throw 50001,'Error inesperado intentando insertar la oferta',16;
	end catch
end
go

use	GD2C2019
go
create procedure [RE_GDDIENTOS].saldo_disponible(
	@user_name nvarchar(255)
)
as
begin
	declare @returned numeric(18,2);
	set @returned = (select saldo from [RE_GDDIENTOS].Clientes where nombre_usuario=@user_name)
	return @returned
end
go

use GD2C2019
go
-------------------------1- Recupero el saldo actual del cliente para compararlo con el precio de la oferta
-------------------------2- Recupero el stock actual de la mercaderia y el limite de compra por usuario
-------------------------3- Recupero la cantidad de veces que compro ese usuario esa oferta, para compararla por el limite de compra
-------------------------4- Se lanza error si el saldo actual del cliente es menor al precio de la compra, si no hay mas stock, y si el usuario ya compro
-------------------------   suficientes veces esa oferta
-------------------------5- Si no hay errores, se actualiza el saldo, el stock y se crea un cupon
create procedure [RE_GDDIENTOS].comprar_oferta (
	@user_name nvarchar(255),
	@oferta_id nvarchar(50),
	@fecha_actual datetime
)
as
begin
	begin transaction

	declare @saldo_disponible numeric(18,2), @precio numeric(18,2), @limite_por_us smallint,@dni_comprador numeric(18,0),@compras_realizadas_del_cliente smallint,@stock smallint

	exec @saldo_disponible = [RE_GDDIENTOS].saldo_disponible @user_name;
	select @precio=precio_oferta,@limite_por_us=limite_compra_por_us,@stock=stock from [RE_GDDIENTOS].Ofertas where oferta_id = @oferta_id;
	set @dni_comprador = (select dni from [RE_GDDIENTOS].Clientes where nombre_usuario=@user_name)
	set @compras_realizadas_del_cliente  = (select count(*) from [RE_GDDIENTOS].Cupones where cliente_comprador_dni=@dni_comprador and oferta_id=@oferta_id)
	
	if(@stock<0)
	begin
		rollback;
		throw 50003,'Stock insuficiente',16;
	end
	if(@saldo_disponible< @precio)
	begin
		rollback;
		throw 50002,'No hay saldo suficiente',16;
	end
	if(@compras_realizadas_del_cliente>=@limite_por_us)
	begin
		rollback;
		throw 50004,'Ha realizado demasiadas compras de dicha oferta',16;
	end
	insert into [RE_GDDIENTOS].Cupones (fecha_compra,cliente_comprador_dni,oferta_id) values (@fecha_actual,@dni_comprador,@oferta_id);
	update [RE_GDDIENTOS].Clientes set saldo = (@saldo_disponible-@precio) where nombre_usuario=@user_name;
	update [RE_GDDIENTOS].Ofertas set stock = stock-1 where oferta_id=@oferta_id
	commit transaction;
end
go

use GD2C2019
go
-------------------------Se busca al cupon comprado por el cliente ingresado, se fija si no fue consumido ( es decir, fecha_consumo de la tabla is not null),
-------------------------si el proveedor ingresado fue el correcto, si el cliente existe en el sistema,o si se vencio el cupon.
-------------------------En caso de no haber errores se actualiza la fecha de consumo del cupon al dia de consumo.
create procedure [RE_GDDIENTOS].cargar_consumo_de_cupon (
	@dni numeric(18,0),
	@fecha_consumo datetime,
	@cuit nvarchar(20),
	@cupon_id int
)
as
begin
	begin transaction
	declare @cup int, @oferta nvarchar(50),@proveedor nvarchar(20), @fecha_limite datetime, @consumido datetime;

	if(not exists(select * from [RE_GDDIENTOS].Cupones where cupon_id=@cupon_id))
	begin
		rollback;
		throw 50005,'No existe un cupon con ese código',16;
	end
	select @oferta=c.oferta_id,@proveedor=proveedor_cuit,@cup=cupon_id,@fecha_limite=fecha_vto,@consumido=fecha_consumo 
	from [RE_GDDIENTOS].Cupones c join [RE_GDDIENTOS].Ofertas o on(c.oferta_id=o.oferta_id and c.cupon_id=@cupon_id)
	if(@cuit!=@proveedor)
	begin
		rollback;
		throw 50008,'El proveedor ingresado no realizo la oferta del cupon',16;
	end
	if(not exists(select dni from [RE_GDDIENTOS].Clientes where dni=@dni))
	begin
		rollback;
		throw 50009,'No existe un cliente con ese dni',16;
	end
	if(@consumido is not null)
	begin
		rollback;
		throw 50006,'El cupon ya ha sido consumido',16;
	end
	if(@fecha_consumo>@fecha_limite)
	begin
		rollback;
		throw 50007,'El cupon se ha vencido.',16;
	end
	update [RE_GDDIENTOS].Cupones set fecha_consumo=@fecha_consumo,cliente_canjeador_dni=@dni where cupon_id=@cupon_id
	commit transaction;
end
go

use GD2C2019
go
create procedure [RE_GDDIENTOS].ofertas_vendidas_en_intervalo (
	@cuit nvarchar(20),
	@fecha_minima datetime,
	@fecha_maxima datetime
)
as
	select o.oferta_id,oferta_descripcion,precio_oferta from [RE_GDDIENTOS].Ofertas o join [RE_GDDIENTOS].Cupones c on (o.oferta_id=c.oferta_id)
	where o.proveedor_cuit=@cuit and fecha_compra>=@fecha_minima and fecha_compra<=@fecha_maxima
go

use GD2C2019
go
-------------------------1- Recupero el importe total de todas las ofertas de un proveedor dado que fueron compradas
-------------------------2- Genero el numero de reporte_id que sera un numero random. Si este numero generado ya existe, genera otro nuevo
-------------------------3- Luego genera el reporte y actualiza todos los cupones que pertenezcan a la oferta del proveedor.
create procedure [RE_GDDIENTOS].realizar_facturacion (
	@cuit nvarchar(20),
	@fecha_minima datetime,
	@fecha_maxima datetime
)
as
begin
	begin transaction
	declare @importe_total numeric(18,2);
	if(not exists(select * from [RE_GDDIENTOS].Ofertas o join [RE_GDDIENTOS].Cupones c on (o.oferta_id=c.oferta_id)
	where o.proveedor_cuit=@cuit and fecha_compra>=@fecha_minima and fecha_compra<=@fecha_maxima))
	begin
		rollback;
		throw 50042,'No hay ofertas para facturar',16;
	end
	set @importe_total =(select sum(precio_oferta)
						 from [RE_GDDIENTOS].Ofertas o join [RE_GDDIENTOS].Cupones c on (o.oferta_id=c.oferta_id)
						 where o.proveedor_cuit=@cuit and fecha_compra>=@fecha_minima and fecha_compra<=@fecha_maxima)
	declare @reporte_id numeric(18,0);
	
	begin try
		set @reporte_id = RAND()*999999999999999999;
		while(exists(select * from [RE_GDDIENTOS].Reportes_Facturacion where reporte_id = @reporte_id))
		begin
			set @reporte_id = RAND()*999999999999999999;
		end
		--Inserto en la tabla reportes la facturacion
		insert into [RE_GDDIENTOS].Reportes_Facturacion values(@reporte_id,@cuit,@fecha_minima,@fecha_maxima,@importe_total)
		
		--actualizo en la tabla cupones el reporte_id
		update [RE_GDDIENTOS].Cupones set reporte_id=@reporte_id
								where cupon_id in  (select cupon_id
													from [RE_GDDIENTOS].Ofertas o join [RE_GDDIENTOS].Cupones c on (o.oferta_id=c.oferta_id)
													where o.proveedor_cuit=@cuit and fecha_compra>=@fecha_minima and fecha_compra<=@fecha_maxima)
		commit transaction
	end try
	begin catch
		rollback;
		throw 50010,'Error inesperado al cargar el reporte de facturacion',16;
	end catch
end
go

use GD2C2019
go
-------------------------
create procedure [RE_GDDIENTOS].proveedores_con_mayor_facturacion (
	@year int,
	@semestre nvarchar(20)
)
as
begin
	declare @mes_lim_inferior int;
	declare @mes_lim_superior int;
	if(@semestre='Primer semestre')
	begin
		set @mes_lim_inferior = 1;
		set @mes_lim_superior = 6;
	end
	else
	begin
		set @mes_lim_inferior = 7;
		set @mes_lim_superior = 12;
	end
	
	select distinct top 5 proveedor_cuit, sum(importe_total) as Total_facturado,count(*) as Cantidad_de_facturas from [RE_GDDIENTOS].Reportes_Facturacion
		   where year(fecha_maxima)=@year and MONTH(fecha_maxima) between @mes_lim_inferior and (@mes_lim_superior+1)
		   group by proveedor_cuit
		   order by 2 desc
end
go

use GD2C2019
go
create procedure [RE_GDDIENTOS].proveedores_con_mayor_descuento_ofrecido (
	@year int,
	@semestre nvarchar(20)
)
as
begin
	declare @mes_lim_inferior int;
	declare @mes_lim_superior int;
	if(@semestre='Primer semestre')
	begin
		set @mes_lim_inferior = 1;
		set @mes_lim_superior = 6;
	end
	else
	begin
		set @mes_lim_inferior = 7;
		set @mes_lim_superior = 12;
	end
	select distinct top 5 proveedor_cuit,max(cast((100-(precio_oferta/precio_viejo)*100) as decimal(5,2))) as Porcentaje_de_descuento from [RE_GDDIENTOS].Ofertas
		   where year(fecha_publicacion)=@year and MONTH(fecha_publicacion) between @mes_lim_inferior and (@mes_lim_superior+1)
		   group by proveedor_cuit
		   order by 2 desc
		   
end
go

use GD2C2019
go
-------------------------devuelve las ofertas disponibles a la fecha ingresada por parametro, asi le puedo pasar por parametro la fecha del config
create procedure [RE_GDDIENTOS].ofertas_disponibles_a_la_fecha (
	@fecha datetime
)
as
	select * from [RE_GDDIENTOS].Ofertas where @fecha<fecha_vto
go

use GD2C2019
go
-------------------------Devuelve 1 si hay usuarios duplicados, sino (-1)
create procedure [RE_GDDIENTOS].usuario_duplicado (
	@name nvarchar(255)
)
as
begin
	declare @returned int;
	if(exists(select * from [RE_GDDIENTOS].Usuarios where nombre_usuario=@name))
	begin
		set @returned = 1
	end
	else
	begin
		set @returned = (-1)
	end
	return @returned
end
go


--Carga inicial del Sistema!!!!!!!
-------------------------------------------------------------------------------
-------------------------Acá se carga al admin con su contraseña guardada segun el algoritmo sha256.
-------------------------Los demas usuarios tienen la contraseña clasica de 1234.
-------------------------El usuario 1 es solamente cliente.
-------------------------El usuario 2 es solamente proveedor.
-------------------------El usuario 3 es cliente y proveedor. cuando se ingresa al sistema se elige con qué rol ingresar.
-------------------------Al admin no le agregué la funcionalidad de 'Comprar oferta' ya que no le veo el sentido, porque no va a poseer saldo.
--Usuario admin
	insert into [RE_GDDIENTOS].Usuarios (nombre_usuario,password) values ('admin','e79bdc0fdce8b1d14a2a3edd4d900dd09edca47001dbb8fc4381cbbf5070b8e6')
	
--Usuario Cliente
	insert into [RE_GDDIENTOS].Usuarios (nombre_usuario,password) values ('user1','f446c8d778f9139e45b488b3c823369567f055e2a5e11e765ce1f3164267ac03')

--Usuario Proveedor
	insert into [RE_GDDIENTOS].Usuarios (nombre_usuario,password) values ('user2','f446c8d778f9139e45b488b3c823369567f055e2a5e11e765ce1f3164267ac03')

--Usuario Con mas de un rol
	insert into [RE_GDDIENTOS].Usuarios (nombre_usuario,password) values ('user3','f446c8d778f9139e45b488b3c823369567f055e2a5e11e765ce1f3164267ac03')
	
--Roles
	insert into [RE_GDDIENTOS].Roles (rol_nombre) values ('administrador general')
	insert into [RE_GDDIENTOS].Roles (rol_nombre) values ('proveedor')
	insert into [RE_GDDIENTOS].Roles (rol_nombre) values ('cliente')

--Usuario Por Rol
	insert into [RE_GDDIENTOS].UsuarioPorRol select rol_id,'admin' from [RE_GDDIENTOS].Roles where rol_nombre='administrador general'
	insert into [RE_GDDIENTOS].UsuarioPorRol select rol_id,'user1' from [RE_GDDIENTOS].Roles where rol_nombre='cliente'
	insert into [RE_GDDIENTOS].UsuarioPorRol select rol_id,'user2' from [RE_GDDIENTOS].Roles where rol_nombre='proveedor'
	insert into [RE_GDDIENTOS].UsuarioPorRol select rol_id,'user3' from [RE_GDDIENTOS].Roles where rol_nombre='cliente' or rol_nombre='proveedor'

--Funcionalidades
	insert into [RE_GDDIENTOS].Funcionalidades (funcionalidad_nombre) values ('Registrar usuario')
	insert into [RE_GDDIENTOS].Funcionalidades (funcionalidad_nombre) values ('Abm de cliente')
	insert into [RE_GDDIENTOS].Funcionalidades (funcionalidad_nombre) values ('Abm de proveedor')
	insert into [RE_GDDIENTOS].Funcionalidades (funcionalidad_nombre) values ('Crear oferta')
	insert into [RE_GDDIENTOS].Funcionalidades (funcionalidad_nombre) values ('Comprar oferta')
	insert into [RE_GDDIENTOS].Funcionalidades (funcionalidad_nombre) values ('Registrar consumo')
	insert into [RE_GDDIENTOS].Funcionalidades (funcionalidad_nombre) values ('Listar estadisticas')
	insert into [RE_GDDIENTOS].Funcionalidades (funcionalidad_nombre) values ('Realizar reporte de facturacion')
	insert into [RE_GDDIENTOS].Funcionalidades (funcionalidad_nombre) values ('Abm de rol')
	insert into [RE_GDDIENTOS].Funcionalidades (funcionalidad_nombre) values ('Carga de credito')
	
	
 --Funcionalidad Por Rol
	insert into [RE_GDDIENTOS].FuncionalidadPorRol (rol_id,funcionalidad_id) values (3,5)
	insert into [RE_GDDIENTOS].FuncionalidadPorRol (rol_id,funcionalidad_id) values (1,1)
	insert into [RE_GDDIENTOS].FuncionalidadPorRol (rol_id,funcionalidad_id) values (1,2)
	insert into [RE_GDDIENTOS].FuncionalidadPorRol (rol_id,funcionalidad_id) values (1,3)
	insert into [RE_GDDIENTOS].FuncionalidadPorRol (rol_id,funcionalidad_id) values (1,4)
	insert into [RE_GDDIENTOS].FuncionalidadPorRol (rol_id,funcionalidad_id) values (1,7)
	insert into [RE_GDDIENTOS].FuncionalidadPorRol (rol_id,funcionalidad_id) values (1,8)
	insert into [RE_GDDIENTOS].FuncionalidadPorRol (rol_id,funcionalidad_id) values (2,4)
	insert into [RE_GDDIENTOS].FuncionalidadPorRol (rol_id,funcionalidad_id) values (2,6)
	insert into [RE_GDDIENTOS].FuncionalidadPorRol (rol_id,funcionalidad_id) values (1,9)
	insert into [RE_GDDIENTOS].FuncionalidadPorRol (rol_id,funcionalidad_id) values (3,10)
	insert into [RE_GDDIENTOS].FuncionalidadPorRol (rol_id,funcionalidad_id) values (1,10)
	insert into [RE_GDDIENTOS].FuncionalidadPorRol (rol_id,funcionalidad_id) values (1,6)
	
--Cliente asociado a user1
	insert into [RE_GDDIENTOS].Clientes (dni,cliente_nombre,cliente_apellido,fecha_nacimiento,ciudad,codigo_postal,telefono,email,direccion,nombre_usuario)
	values (39655888,'santiago','feijoo',GETDATE(),'london','1406',46258745,'something@somethingelse.com','somewhere over the rainbow 123','user1')

--Proveedor asociado a user2
	insert into [RE_GDDIENTOS].Proveedores (rs,email,telefono,codigo_postal,ciudad,cuit,rubro_id,nombre_contacto,direccion,nombre_usuario)
	values
	('Stratovarius sa','someproveedor@algunlugar.com',12365478,'cp de london','Manchester','20.120312933',1,'ivan','Quirno 9888','user2')

--Cliente y proveedor asociado a user3
	insert into [RE_GDDIENTOS].Clientes (dni,cliente_nombre,cliente_apellido,fecha_nacimiento,ciudad,codigo_postal,telefono,email,direccion,nombre_usuario)
	values (396888,'john','nhoj',getdate(),'london de nuevo','1406',48425857,'nosoyjohn@john.com','quirno 9888','user3')

	insert into [RE_GDDIENTOS].Proveedores (rs,email,telefono,codigo_postal,ciudad,cuit,rubro_id,nombre_contacto,direccion,nombre_usuario)
	values
	('que S.A d','mail@casilla.com',45875645,'cp del london','helsinki','20.1312933',1,'ivan','Quirno 98888s','user3')
go
