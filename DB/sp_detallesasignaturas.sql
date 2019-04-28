--Procedimiento mostrar
create proc spmostrar_detallesasignaturas
as
select top 200 * from detallesasignaturas
order by id_detalleasignatura desc
go

--Procedimiento buscar Nombre
create proc spbuscar_detallesasignaturas
@textobuscar int
as
select * from detallesasignaturas
where id_asignatura like @textobuscar + '%'
go

--Procedimiento Insertar
create proc spinsertar_detallesasignaturas
@id_detalleasignatura int output,
@id_curso int,
@id_asignatura int,
@hora_inicio datetime,
@hora_fin datetime
as
insert into detallesasignaturas (id_curso, id_asignatura, hora_inicio, hora_fin)
values (@id_curso, @id_asignatura, @hora_inicio, @hora_fin)
go

--Procedimiento Editar
create proc speditar_detallesasignaturas
@id_detalleasignatura int,
@id_curso int,
@id_asignatura int,
@hora_inicio datetime,
@hora_fin datetime
as
update detallesasignaturas set id_curso=@id_curso,
id_asignatura=@id_asignatura,
hora_inicio=@hora_inicio,
hora_fin=@hora_fin
where id_detalleasignatura=@id_detalleasignatura
go

--Procedimeinto Eliminar
create proc speliminar_detallesasignaturas
@id_detalleasignatura int
as 
delete from detallesasignaturas
where id_detalleasignatura=@id_detalleasignatura
go
