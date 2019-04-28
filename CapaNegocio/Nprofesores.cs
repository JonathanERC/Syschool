using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CapaDatos;
using System.Data;

namespace CapaNegocio
{
    public class Nprofesores
    {
            //Metodo insertar clase Ddetallesasignaturas
            public static string Insertar(int id_usuario)
            {
                Dprofesores obj = new Dprofesores();
                obj.Id_usuario = id_usuario;
                return obj.Insertar(obj);
            }

            //Metodo editar
            public static string Editar(int id_profesor, int id_usuario)
            {
                Dprofesores obj = new Dprofesores();
                obj.Id_usuario = id_usuario;
                obj.Id_profesor = id_profesor;
                return obj.Editar(obj);
            }

            //Metodo eliminar
            public static string Eliminar(int id_profesor)
            {
                Dprofesores obj = new Dprofesores();
                obj.Id_profesor = id_profesor;
                return obj.Eliminar(obj);
            }

            //Metodo mostrar
            public static DataTable Mostrar()
            {
                return new Dprofesores().Mostrar();
            }

            //Metodo buscar_nombre
            public static DataTable Buscarnombre(string textobuscar)
            {
                Dprofesores obj = new Dprofesores();
                obj.Textobuscar = textobuscar;
                return obj.Buscarnombre(obj);
            }
        }
    }

