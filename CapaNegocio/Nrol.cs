using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CapaDatos;
using System.Data;

namespace CapaNegocio
{
    public class Nrol
    {
        //Metodo insertar clase Ddetallesasignaturas
        public static string Insertar(string descripcion)
        {
            Drol obj = new Drol();
            obj.Descripcion = descripcion;
            return obj.Insertar(obj);
        }

        //Metodo editar
        public static string Editar(int id_rol, string descripcion)
        {
            Drol obj = new Drol();
            obj.Id_rol = id_rol;
            obj.Descripcion = descripcion;
            return obj.Editar(obj);
        }

        //Metodo eliminar
        public static string Eliminar(int id_rol)
        {
            Drol obj = new Drol();
            obj.Id_rol = id_rol;
            return obj.Eliminar(obj);
        }

        //Metodo mostrar
        public static DataTable Mostrar()
        {
            return new Drol().Mostrar();
        }

        //Metodo buscar_nombre
        public static DataTable Buscarnombre(string textobuscar)
        {
            Drol obj = new Drol();
            obj.Textobuscar = textobuscar;
            return obj.Buscarnombre(obj);
        }
    }
}
    
