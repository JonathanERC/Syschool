--Procedimiento Mostrar
Create proc spnotas
as
SELECT a.nombre, n.nota_primer_periodo, n.nota_segundo_periodo, n.nota_tercer_periodo, n.nota_cuarto_periodo FROM asignaturas a, notasasignaturas n
WHERE a.id_asignatura = n.id_asignatura
order by id_notasasignaturas desc
go