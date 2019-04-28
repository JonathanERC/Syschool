using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CapaDatos;
using System.Data;

namespace CapaNegocio
{
    public class Nasignaturaprofesor
    {
        //Metodo insertar clase Dcursos
        public static string Insertar(int id_asignatura, int id_profesor)
        {
            Dasignaturaprofesor obj = new Dasignaturaprofesor();
            obj.Id_asignatura = id_asignatura;
            obj.Id_profesor = id_profesor;
            return obj.Insertar(obj);
        }

        //Metodo editar
        public static string Editar(int id_asignatura, int id_profesor)
        {
            Dasignaturaprofesor obj = new Dasignaturaprofesor();
            obj.Id_asignatura = id_asignatura;
            obj.Id_profesor = id_profesor;
            return obj.Editar(obj);
        }

        //Metodo eliminar
        public static string Eliminar(int id_asignaturaprofesor)
        {
            Dasignaturaprofesor obj = new Dasignaturaprofesor();
            obj.Id_asignaturaprofesor = id_asignaturaprofesor;
            return obj.Eliminar(obj);
        }

        //Metodo mostrar
        public static DataTable Mostrar()
        {
            return new Dasignaturaprofesor().Mostrar();
        }

        //Metodo buscar_nombre
        public static DataTable Buscarnombre(string textobuscar)
        {
            Dasignaturaprofesor obj = new Dasignaturaprofesor();
            obj.Textobuscar = textobuscar;
            return obj.Buscarnombre(obj);
        }


    }
}
    
