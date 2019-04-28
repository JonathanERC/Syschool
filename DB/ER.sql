
alter table dbo.estudiantes add foreign key (id_notasasignadas) references dbo.nostasasignadas(id_estudiante)