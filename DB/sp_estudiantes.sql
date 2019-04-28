--Procedimiento mostrar
create proc spmostrar_estudiantes
as
select top 200 * from estudiantes
order by id_estudiante desc
go

--Procedimiento buscar Nombre
create proc spbuscar_estudiantes
@textobuscar int
as
select * from estudiantes
where id_usuario like @textobuscar + '%'
go

--Procedimiento Insertar
create proc spinsertar_estudiantes
@id_estudiante int output,
@numero_estudiante int,
@id_curso int,
@id_usuario int 
as
insert into estudiantes (numero_estudiante, id_curso, id_usuario)
values (@numero_estudiante, @id_curso, @id_usuario)
go

--Procedimiento Editar
create proc speditar_estudiantes
@id_estudiante int,
@numero_estudiante int,
@id_curso int,
@id_usuario int
as
update estudiantes set numero_estudiante=@numero_estudiante,
id_curso=@id_curso,
id_usuario=@id_usuario
where id_estudiante=@id_estudiante
go

--Procedimeinto Eliminar
create proc speliminar_estudiantes
@id_estudiante int
as 
delete from estudiantes
where id_estudiante=@id_estudiante
go
