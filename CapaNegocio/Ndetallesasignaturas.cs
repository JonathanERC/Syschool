using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CapaDatos;
using System.Data;

namespace CapaNegocio
{
    public class Ndetallesasignaturas
    {
        //Metodo insertar clase Ddetallesasignaturas
        public static string Insertar(int id_curso, int id_asignatura, DateTime hora_inicio, DateTime hora_fin)
        {
            Ddetallesasignaturas obj = new Ddetallesasignaturas();
            obj.Id_curso = id_curso;
            obj.Id_asignatura = id_asignatura;
            obj.Hora_inicio = hora_inicio;
            obj.Hora_fin = hora_fin;
            return obj.Insertar(obj);
        }

        //Metodo editar
        public static string Editar(int id_detalleasignatura, int id_curso, int id_asignatura, DateTime hora_inicio, DateTime hora_fin)
        {
            Ddetallesasignaturas obj = new Ddetallesasignaturas();
            obj.Id_detalleasignatura = id_detalleasignatura;
            obj.Id_curso = id_curso;
            obj.Id_asignatura = id_asignatura;
            obj.Hora_inicio = hora_inicio;
            obj.Hora_fin = hora_fin;
            return obj.Editar(obj);
        }

        //Metodo eliminar
        public static string Eliminar(int id_detalleasignatura)
        {
            Ddetallesasignaturas obj = new Ddetallesasignaturas();
            obj.Id_detalleasignatura = id_detalleasignatura;
            return obj.Eliminar(obj);
        }

        //Metodo mostrar
        public static DataTable Mostrar()
        {
            return new Ddetallesasignaturas().Mostrar();
        }

        //Metodo buscar_nombre
        public static DataTable Buscarnombre(string textobuscar)
        {
            Ddetallesasignaturas obj = new Ddetallesasignaturas();
            obj.Textobuscar = textobuscar;
            return obj.Buscarnombre(obj);
        }
    }
}
