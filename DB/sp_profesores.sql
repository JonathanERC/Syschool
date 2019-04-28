--Procedimiento Mostrar
create proc spmostrar_profesores
as
select top 200 * from profesores
order by id_profesor desc
go

--Procedimiento buscar Nombre
create proc spbuscar_profesores
@textobuscar int
as
select * from profesores
where id_usuario like @textobuscar + '%'
go   

--Procedimiento Insertar
create proc spinsertar_profesores
@id_profesor int output,
@id_usuario int
as 
insert into profesores(id_usuario)
values (@id_usuario)
go

--Procedimiento Editar
create proc speditar_profesores
@id_profesor int, 
@id_ususario int 
as
update profesores set id_usuario=@id_ususario
where id_profesor=@id_profesor
go

--Procedimiento Eliminar
create proc speliminar_profesores
@id_profesor int
as
delete from profesores
where id_profesor=@id_profesor
go
