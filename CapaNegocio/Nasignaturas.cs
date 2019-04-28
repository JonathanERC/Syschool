using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CapaDatos;
using System.Data;

namespace CapaNegocio
{
    public class Nasignaturas
    {
        //Metodo insertar clase Dcursos
        public static string Insertar(string nombre, string codigo)
        {
            Dasignatura obj = new Dasignatura();
            obj.Nombre = nombre;
            obj.Codigo = codigo;
            return obj.Insertar(obj);
        }

        //Metodo editar
        public static string Editar(int id_asignatura, string nombre, string codigo)
        {
            Dasignatura obj = new Dasignatura();
            obj.Id_asignatura = id_asignatura;
            obj.Nombre = nombre;
            obj.Codigo = codigo;
            return obj.Editar(obj);
        }

        //Metodo eliminar
        public static string Eliminar(int id_asignatura)
        {
            Dasignatura obj = new Dasignatura();
            obj.Id_asignatura = id_asignatura;
            return obj.Eliminar(obj);
        }

        //Metodo mostrar
        public static DataTable Mostrar()
        {
            return new Dasignatura().Mostrar();
        }

        //Metodo buscar_nombre
        public static DataTable Buscarnombre(string textobuscar)
        {
            Dasignatura obj = new Dasignatura();
            obj.Textobuscar = textobuscar;
            return obj.Buscarnombre(obj);
        }


    }
}
    
