--Procedimiento Mostrar
create proc spmpstrar_asignaturas
as
select top 200 * from asignaturas
order by id_asignatura desc
go

--Procedimiento buscar asignatura
create proc spbuscar_asignaturas
@textobuscar varchar(50)
as
select * from asignaturas
where nombre like @textobuscar + '%'
go

--Procedimiento Insertar
create proc spinsertar_asignaturas
@id_asignatura int output,
@nombre varchar (50),
@codigo varchar (20)
as
insert into asignaturas (nombre, codigo)
values (@nombre, @codigo)
go

--Provedimiento Editar
create proc speditar_asignaturas
@id_asignatura int,
@nombre varchar(50),
@codigo varchar(20)
as
update asignaturas set nombre=@nombre,
codigo=@codigo
where id_asignatura=@id_asignatura
go

--Procedimiento Eliminar
create proc speliminar_asignaturas
@id_asignatura int 
as 
delete from asignaturas
where id_asignatura=@id_asignatura 
go