using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CapaDatos;
using System.Data;

namespace CapaNegocio
{
    public class Nestudiantes
    {
        //Metodo insertar clase Destudiantes
        public static string Insertar(int numero_estudiante, int id_curso, int id_usuario)
        {
            Destudiantes obj = new Destudiantes();
            obj.Numero_estudiante = numero_estudiante;
            obj.Id_curso = id_curso;
            obj.Id_usuario = id_usuario;
            return obj.Insertar(obj);
        }

        //Metodo editar
        public static string Editar(int id_estudiante, int numero_estudiante, int id_curso, int id_usuario )
        {
            Destudiantes obj = new Destudiantes();
            obj.Id_estudiante = id_estudiante;
            obj.Id_usuario = id_usuario;
            obj.Id_curso = id_curso;
            obj.Numero_estudiante = numero_estudiante;
            return obj.Editar(obj);
        }

        //Metodo eliminar
        public static string Eliminar(int id_estudiante)
        {
            Destudiantes obj = new Destudiantes();
            obj.Id_estudiante = id_estudiante;
            return obj.Eliminar(obj);
        }

        //Metodo mostrar
        public static DataTable Mostrar()
        {
            return new Destudiantes().Mostrar();
        }

        //Metodo buscar_nombre
        public static DataTable Buscarnombre(string textobuscar)
        {
            Destudiantes obj = new Destudiantes();
            obj.Textobuscar = textobuscar;
            return obj.Buscarnombre(obj);
        }


    }
}


   