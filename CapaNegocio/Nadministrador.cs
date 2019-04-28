using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CapaDatos;
using System.Data;

namespace CapaNegocio
{
    public class Nadministrador
    {
        //Metodo insertar clase Dcursos
        public static string Insertar(int id_usuario)
        {
            Dadministrador obj = new Dadministrador();
            obj.Id_usuario = id_usuario;
            return obj.Insertar(obj);
        }

        //Metodo editar
        public static string Editar(int id_administrador, int id_usuario)
        {
            Dadministrador obj = new Dadministrador();
            obj.Id_administrador = id_administrador;
            obj.Id_usuario = id_usuario;
            return obj.Editar(obj);
        }

        //Metodo eliminar
        public static string Eliminar(int id_administrador)
        {
            Dadministrador obj = new Dadministrador();
            obj.Id_administrador = id_administrador;
            return obj.Eliminar(obj);
        }

        //Metodo mostrar
        public static DataTable Mostrar()
        {
            return new Dadministrador().Mostrar();
        }

        //Metodo buscar_nombre
        public static DataTable Buscarnombre(string textobuscar)
        {
            Dadministrador obj = new Dadministrador();
            obj.Textobuscar = textobuscar;
            return obj.Buscarnombre(obj);
        }


    }
}
   
