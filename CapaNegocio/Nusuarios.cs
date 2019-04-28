using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CapaDatos;
using System.Data;

namespace CapaNegocio
{
    public class Nusuarios
    {
        //Metodo insertar clase Dcursos
        public static string Insertar(int id_rol, string usuario, string contraseña, string primer_nombre, string segundo_nombre, string primer_apellido, 
            string segundo_apellido, string genero, string nacionalidad, string email, int cedula, DateTime fecha_de_nacimiento)
           
        {
            Dusuarios obj = new Dusuarios();
            obj.Id_rol = id_rol;
            obj.Usuario = usuario;
            obj.Contraseña = contraseña;
            obj.Primer_nombre = primer_nombre;
            obj.Segundo_nombre = segundo_nombre;
            obj.Primer_apellido = primer_apellido;
            obj.Segundo_apellido = segundo_apellido;
            obj.Genero = genero;
            obj.Nacionalidad = nacionalidad;
            obj.Email = email;
            obj.Cedula = cedula;
            obj.Fecha_de_nacimiento = fecha_de_nacimiento;
          return obj.Insertar(obj);
        }

        //Metodo editar
        public static string Editar(int id_usuarios, int id_rol, string usuario, string contraseña, string primer_nombre,
            string segundo_nombre, string primer_apellido, string  segundo_apellido, string genero, string nacionalidad, string email, int cedula, DateTime fecha_de_nacimiento)
        {
            Dusuarios obj = new Dusuarios();
            obj.Id_usuarios= id_usuarios;
            obj.Id_rol= id_rol;
            obj.Usuario = usuario;
            obj.Contraseña= contraseña;
            obj.Primer_nombre =primer_nombre;
            obj.Segundo_nombre = segundo_nombre;
            obj.Primer_apellido= primer_apellido;
            obj.Segundo_apellido= segundo_apellido;
            obj.Genero= genero;
            obj.Nacionalidad = nacionalidad;
            obj.Email = email;
            obj.Cedula = cedula;
            obj.Fecha_de_nacimiento = fecha_de_nacimiento;
            return obj.Editar(obj);
        }

        //Metodo eliminar
        public static string Eliminar(int id_usuarios)
        {
            Dusuarios obj = new Dusuarios();
            obj.Id_usuarios = id_usuarios;
            return obj.Eliminar(obj);
        }

        //Metodo mostrar
        public static DataTable Mostrar()
        {
            return new Dusuarios().Mostrar();
        }

        //Metodo buscar_nombre
        public static DataTable Buscarnombre(string textobuscar)
        {
            Dusuarios obj = new Dusuarios();
            obj.Textobuscar = textobuscar;
            return obj.Buscarnombre(obj);
        }
        
        //Metodo login
        public static DataTable Login(string usuario, string contraseña)
        {
            Dusuarios obj = new Dusuarios();
            obj.Usuario = usuario;
            obj.Contraseña = contraseña;
            return obj.Login(obj);
        }
    }
}
    
