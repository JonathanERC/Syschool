--Procedimiento mostrar
create proc spmostrar_rol
as
select top 200 * from rol
order by id_rol desc
go

--Procedimiento buscar nombre
create proc spbuscar_rol
@textobuscar varchar (50)
as
select * from rol
where descripcion like @textobuscar + '%' 
go

--Procedimiento Insertar
create proc spinsertar_rol
@id_rol int output,
@descripcion varchar(50)
as
insert into rol (descripcion)
values (@descripcion)
go

--Procedimiento Editar
create proc speditar_rol
@id_rol int,
@descripcion varchar(50)
as
update rol set descripcion=@descripcion
where id_rol=@id_rol
go

--Procedimeinto Eliminar
create proc speliminar_rol
@id_rol int
as
delete from rol
where id_rol=@id_rol 
go
