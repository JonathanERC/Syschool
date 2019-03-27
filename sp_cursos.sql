--Procedimiento mostrar
create proc spmostrar_cursos
as
select top 200 * from cursos
order by id_curso desc
go

--Procedimiento buscar nombre
create proc spbuscar_cursos
@textobuscar varchar(50)
as
select * from cursos
where nombre_curso like @textobuscar + '%'
go

--Procedimiento insertar
create proc spinsertar_cursos
@id_curso int output,
@nombre_curso varchar(50)
as
insert into cursos (nombre_curso)
values (@nombre_curso)
go

--Procedimiento editar
create proc speditar_cursos
@id_curso int,
@nombre_curso varchar(50)
as
update cursos set nombre_curso=@nombre_curso
where id_curso=@id_curso
go

--Procedimiento eliminar
create proc speliminar_cursos
@id_curso int
as
delete from cursos
where id_curso=@id_curso
go