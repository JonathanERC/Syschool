--Procedimiento mostrar
create proc spmostrar_asignaturaprofesor
as
select top 200 * from asignaturaprofesor
order by id_asignaturaprofesor desc
go

--Procedimiento buscar Nombre
create proc spbuscar_asignaturaprofesor
@textobuscar int
as
select * from asignaturaprofesor
where id_profesor like @textobuscar + '%'
go

--Procedimiento Insertar
create proc spinsertar_asignaturaprofesor
@id_asignaturaprofesor int output,
@id_asignatura int,
@id_profesor int 
as
insert into asignaturaprofesor (id_asignatura, id_profesor)
values (@id_asignatura, @id_profesor)
go

--Procedimiento Editar
create proc speditar_asignaturaprofesor
@id_asignaturaprofesor int,
@id_asignatura int,
@id_profesor int
as
update asignaturaprofesor set id_asignatura=@id_asignatura,
id_profesor=@id_profesor
where id_asignaturaprofesor=@id_asignaturaprofesor
go

--Procedimeinto Eliminar
create proc speliminar_asignaturaprofesor
@id_asignaturaprofesor int
as 
delete from asignaturaprofesor
where id_asignaturaprofesor=@id_asignaturaprofesor
go
