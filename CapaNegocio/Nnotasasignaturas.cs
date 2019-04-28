using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CapaDatos;
using System.Data;

namespace CapaNegocio
{
    public class Nnotasasignaturas
    {
        //Metodo insertar clase Dcursos
        public static string Insertar(int id_estudiante, int id_asignatura, int nota_primer_mes, int nota_segundo_mes,
            int nota_tercer_mes, int nota_cuarto_mes, int periodo, int ano)
        {
            Dnotasasignaturas obj = new Dnotasasignaturas();
            obj.Id_estudiante = id_estudiante;
            obj.Id_asignatura = id_asignatura;
            obj.Nota_primer_mes = nota_primer_mes;
            obj.Nota_segundo_mes = nota_segundo_mes;
            obj.Nota_tercer_mes = nota_tercer_mes;
            obj.Nota_cuarto_mes = nota_cuarto_mes;
            obj.Periodo = periodo;
            obj.Ano = ano;
            return obj.Insertar(obj);
        }

        //Metodo editar
        public static string Editar(int id_notasasignaturas, int id_estudiante, int id_asignatura, int nota_primer_mes, int nota_segundo_mes,
            int nota_tercer_mes, int nota_cuarto_mes, int periodo, int ano)
        {
            Dnotasasignaturas obj = new Dnotasasignaturas();
            obj.Id_notasasignaturas = id_notasasignaturas;
            obj.Id_estudiante = id_estudiante;
            obj.Id_asignatura = id_asignatura;
            obj.Nota_primer_mes = nota_primer_mes;
            obj.Nota_segundo_mes = nota_segundo_mes;
            obj.Nota_tercer_mes = nota_tercer_mes;
            obj.Nota_cuarto_mes = nota_cuarto_mes;
            obj.Periodo = periodo;
            obj.Ano = ano;
            return obj.Editar(obj);
        }

        //Metodo eliminar
        public static string Eliminar(int id_notasasignaturas)
        {
            Dnotasasignaturas obj = new Dnotasasignaturas();
            obj.Id_notasasignaturas = id_notasasignaturas;
            return obj.Eliminar(obj);
        }

        //Metodo mostrar
        public static DataTable Mostrar()
        {
            return new Dnotasasignaturas().Mostrar();
        }

        //Metodo buscar_nombre
        public static DataTable Buscarnombre(string textobuscar)
        {
            Dnotasasignaturas obj = new Dnotasasignaturas();
            obj.Textobuscar = textobuscar; 
            return obj.Buscarnombre(obj);
        }


    }
}
    
