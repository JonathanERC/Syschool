--Procedimiento Mostrar
create proc spmostrar_administrador
as
select top 200 * from administrador
order by id_administrador desc
go

--Procedimiento buscar Nombre
create proc spbuscar_administrador
@textobuscar int
as
select * from administrador
where id_usuario like @textobuscar + '%'
go   

--Procedimiento Insertar
create proc spinsertar_administrador
@id_administrador int output,
@id_usuario int
as 
insert into administrador(id_usuario)
values (@id_usuario)
go

--Procedimiento Editar
create proc speditar_administrador
@id_administrador int, 
@id_ususario int 
as
update administrador set id_usuario=@id_ususario
where id_administrador=@id_administrador
go

--Procedimiento Eliminar
create proc speliminar_administrador
@id_administrador int
as
delete from administrador
where id_administrador=@id_administrador
go
