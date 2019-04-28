--Procedimiento mostrar
create proc spmostrar_usuarios
as
select top 200 *from usuarios
order by id_usuarios desc
go

--Procedimiento buscar Usuario
create proc spbuscar_usuarios
@textobuscar varchar(50)
as
select * from usuarios 
where usuario like @textobuscar + '%'
go

--Procedimiento Insertar 
create proc spinsertar_usuarios
@id_usuarios int output,
@id_rol int,
@usuario varchar(50),
@contraseña varchar(50),
@primer_nombre varchar(50),
@segundo_nombre varchar(50),
@primer_apellido varchar(50),
@segundo_apellido varchar(50),
@genero varchar(50),
@nacionalidad varchar(50),
@email nvarchar(90),
@cedula int,
@fecha_de_nacimiento date
as
insert into usuarios (id_rol,usuario,contraseña,primer_nombre,segundo_nombre,primer_apellido,segundo_apellido,genero,nacionalidad,email,cedula,fecha_de_nacimiento)
values (@id_rol, @usuario,@contraseña,@primer_nombre,@segundo_nombre,@primer_apellido,@segundo_apellido,@genero,@nacionalidad,@email,@cedula,@fecha_de_nacimiento)
go

--Procedimiento Editar
create proc speditar_usuarios
@id_usuarios int,
@id_rol int,
@usuario varchar(50),
@contraseña varchar(50),
@primer_nombre varchar(50),
@segundo_nombre varchar(50),
@primer_apellido varchar(50),
@segundo_apellido varchar(50),
@genero varchar(50),
@nacionalidad varchar(50),
@email nvarchar(90),
@cedula int,
@fecha_de_nacimiento date
as
update usuarios set id_rol=@id_rol,
usuario=@usuario,
contraseña=@contraseña,
primer_nombre=@primer_nombre,
primer_apellido=@primer_apellido,
segundo_nombre=@segundo_nombre,
segundo_apellido=@segundo_apellido,
genero=@genero,
nacionalidad=@nacionalidad,
email=@email,
cedula=@cedula,
fecha_de_nacimiento=@fecha_de_nacimiento
where id_usuarios=@id_usuarios
go

--Procedimiento Eliminar
create proc speliminar_usuarios
@id_usuarios int
as
delete from usuarios
where id_usuarios=@id_usuarios
go
