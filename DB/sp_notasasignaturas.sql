--Procedimiento Mostrar
Create proc spmotrar_notasasignaturas
as
select top 200 *from notasasignaturas
order by id_notasasignaturas desc
go

--Procedimiento Buscar notas
create proc spbuscar_notasasignaturas
@textobuscar int 
as 
select *from notasasignaturas
where id_estudiante like @textobuscar + '%'
go

--Procedimiento Insertar 
Create proc spinsertar_notasasignaturas
@id_notasasignaturas int output,
@id_estudiante int,
@id_asignatura int,
@nota_primer_mes int,
@nota_segundo_mes int,
@nota_tercer_mes int,
@nota_cuarto_mes int,
@periodo int,
@ano int
as 
insert into notasasignaturas (id_estudiante,id_asignatura,nota_primer_mes,nota_segundo_mes,nota_tercer_mes,nota_cuarto_mes, periodo, ano)
values (@id_estudiante,@id_asignatura,@nota_primer_mes,@nota_segundo_mes,@nota_tercer_mes,@nota_cuarto_mes, @periodo, @ano)
go

 --Procedimiento Editar 
 create proc speditar_notasasignaturas
@id_notasasignaturas int,
@id_estudiante int,
@id_asignatura int,
@nota_primer_mes int,
@nota_segundo_mes int,
@nota_tercer_mes int,
@nota_cuarto_mes int,
@periodo int,
@ano int
 as
 update notasasignaturas set id_estudiante=@id_estudiante,
 id_asignatura=@id_asignatura,
 nota_primer_mes=@nota_primer_mes,
 nota_segundo_mes=@nota_segundo_mes,
 nota_tercer_mes=@nota_tercer_mes,
 nota_cuarto_mes=@nota_cuarto_mes,
 periodo=@periodo,
 ano=@ano
 where id_notasasignaturas=@id_notasasignaturas
 go

 --Procedimiento Eliminar 
 create proc speliminar_notasasignaturas
 @id_notasasignaturas int 
 as 
 delete from notasasignaturas 
 where id_notasasignaturas=@id_notasasignaturas
 go