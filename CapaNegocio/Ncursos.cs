using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CapaDatos;
using System.Data;

namespace CapaNegocio
{
    public class Ncursos
    {
        //Metodo insertar clase Dcursos
        public static string Insertar(string nombre_curso)
        {
            Dcursos obj = new Dcursos();
            obj.Nombre_curso = nombre_curso;
            return obj.Insertar(obj);
        }

        //Metodo editar
        public static string Editar(int id_curso, string nombre_curso)
        {
            Dcursos obj = new Dcursos();
            obj.Id_curso = id_curso;
            obj.Nombre_curso = nombre_curso;
            return obj.Editar(obj);
        }

        //Metodo eliminar
        public static string Eliminar(int id_curso)
        {
            Dcursos obj = new Dcursos();
            obj.Id_curso = id_curso;
            return obj.Eliminar(obj);
        }

        //Metodo mostrar
        public static DataTable Mostrar()
        {
            return new Dcursos().Mostrar();
        }

        //Metodo buscar_nombre
        public static DataTable Buscarnombre(string textobuscar)
        {
            Dcursos obj = new Dcursos();
            obj.Textobuscar = textobuscar;
            return obj.Buscarnombre(obj);
        }
    }
}
