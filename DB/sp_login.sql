create proc splogin
 @usuario varchar(50),
 @password varchar (50)
 as
 select id_usuarios, id_rol, primer_nombre, primer_apellido 
 from usuarios 
 where usuario=@usuario and contraseña=@password
 go 