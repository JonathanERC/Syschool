using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;


namespace CapaDatos
{
    public class Dcursos
    {
        private int _Id_curso;
        private string _nombre_curso;

        private string _textobuscar;

        public int Id_curso { get => _Id_curso; set => _Id_curso = value; }
        public string Nombre_curso { get => _nombre_curso; set => _nombre_curso = value; }
        public string Textobuscar { get => _textobuscar; set => _textobuscar = value; }

        //Constructor vacio
        public Dcursos()
        {

        }

        //Constructor con parametros
        public Dcursos(int Id_curso, string nombre_curso, string textobuscar)
        {
            this.Id_curso = Id_curso;
            this.Nombre_curso = nombre_curso;
            this.Textobuscar = textobuscar;
        }

        //Metodo insertar
        public string Insertar(Dcursos Curso)
        {
            string rpta = "";
            SqlConnection sqlcon = new SqlConnection();
            try
            {
                //codigo
                sqlcon.ConnectionString = Conexion.Cn;
                sqlcon.Open();
                SqlCommand sqlcmd = new SqlCommand();
                sqlcmd.Connection = sqlcon;
                sqlcmd.CommandText = "spinsertar_cursos";
                sqlcmd.CommandType = CommandType.StoredProcedure;

                SqlParameter parId_curso = new SqlParameter();
                parId_curso.ParameterName = "@id_curso";
                parId_curso.SqlDbType = SqlDbType.Int;
                parId_curso.Direction = ParameterDirection.Output;
                sqlcmd.Parameters.Add(parId_curso);

                SqlParameter parnombre_curso = new SqlParameter();
                parnombre_curso.ParameterName = "@nombre_curso";
                parnombre_curso.SqlDbType = SqlDbType.VarChar;
                parnombre_curso.Size = 50;
                parnombre_curso.Value = Curso.Nombre_curso;
                sqlcmd.Parameters.Add(parnombre_curso);

                //Ejecutar comando
                rpta = sqlcmd.ExecuteNonQuery() == 1 ? "Ok" : "No se Ingreso el Registro";

            }
            catch (Exception ex)
            {
                rpta = ex.Message;
            }

            finally
            {
                if (sqlcon.State==ConnectionState.Open)
                {
                    sqlcon.Close();
                }
            }
            return rpta;
        }

        //Metodo editar
        public string Editar(Dcursos Curso)
        {
            string rpta = "";
            SqlConnection sqlcon = new SqlConnection();
            try
            {
                //codigo
                sqlcon.ConnectionString = Conexion.Cn;
                sqlcon.Open();
                SqlCommand sqlcmd = new SqlCommand();
                sqlcmd.Connection = sqlcon;
                sqlcmd.CommandText = "speditar_cursos";
                sqlcmd.CommandType = CommandType.StoredProcedure;

                SqlParameter parId_curso = new SqlParameter();
                parId_curso.ParameterName = "@id_curso";
                parId_curso.SqlDbType = SqlDbType.Int;
                parId_curso.Value = Curso.Id_curso;
                sqlcmd.Parameters.Add(parId_curso);

                SqlParameter parnombre_curso = new SqlParameter();
                parnombre_curso.ParameterName = "@nombre_curso";
                parnombre_curso.SqlDbType = SqlDbType.VarChar;
                parnombre_curso.Size = 50;
                parnombre_curso.Value = Curso.Nombre_curso;
                sqlcmd.Parameters.Add(parnombre_curso);

                //Ejecutar comando
                rpta = sqlcmd.ExecuteNonQuery() == 1 ? "Ok" : "No se Actualizo el Registro";

            }
            catch (Exception ex)
            {
                rpta = ex.Message;
            }

            finally
            {
                if (sqlcon.State == ConnectionState.Open)
                {
                    sqlcon.Close();
                }
            }
            return rpta;
        }

        //Metodo eliminar
        public string Eliminar(Dcursos Curso)
        {
            string rpta = "";
            SqlConnection sqlcon = new SqlConnection();
            try
            {
                //codigo
                sqlcon.ConnectionString = Conexion.Cn;
                sqlcon.Open();
                SqlCommand sqlcmd = new SqlCommand();
                sqlcmd.Connection = sqlcon;
                sqlcmd.CommandText = "speliminar_cursos";
                sqlcmd.CommandType = CommandType.StoredProcedure;

                SqlParameter parId_curso = new SqlParameter();
                parId_curso.ParameterName = "@id_curso";
                parId_curso.SqlDbType = SqlDbType.Int;
                parId_curso.Value = Curso.Id_curso;
                sqlcmd.Parameters.Add(parId_curso);

                //Ejecutar comando
                rpta = sqlcmd.ExecuteNonQuery() == 1 ? "Ok" : "No se Elimino el Registro";

            }
            catch (Exception ex)
            {
                rpta = ex.Message;
            }

            finally
            {
                if (sqlcon.State == ConnectionState.Open)
                {
                    sqlcon.Close();
                }
            }
            return rpta;
        }

        //Metodo mostrar
        public DataTable Mostrar()
        {
            DataTable dtresultado = new DataTable("cursos");
            SqlConnection sqlcon = new SqlConnection();
            try
            {
                sqlcon.ConnectionString = Conexion.Cn;
                SqlCommand sqlcmd = new SqlCommand();
                sqlcmd.Connection = sqlcon;
                sqlcmd.CommandText = "spmostrar_cursos";
                sqlcmd.CommandType = CommandType.StoredProcedure;

                SqlDataAdapter sqldat = new SqlDataAdapter(sqlcmd);
                sqldat.Fill(dtresultado);
            }
            catch (Exception ex)
            {
                dtresultado = null;
            }
            return dtresultado;

        }

        //Metodo buscarnombre
        public DataTable Buscarnombre(Dcursos Curso)
        {
            DataTable dtresultado = new DataTable("cursos");
            SqlConnection sqlcon = new SqlConnection();
            try
            {
                sqlcon.ConnectionString = Conexion.Cn;
                SqlCommand sqlcmd = new SqlCommand();
                sqlcmd.Connection = sqlcon;
                sqlcmd.CommandText = "spbuscar_cursos";
                sqlcmd.CommandType = CommandType.StoredProcedure;

                SqlParameter partextobuscar = new SqlParameter();
                partextobuscar.ParameterName = "@textobuscar";
                partextobuscar.SqlDbType = SqlDbType.VarChar;
                partextobuscar.Size = 50;
                partextobuscar.Value = Curso.Textobuscar;
                sqlcmd.Parameters.Add(partextobuscar);
                
                SqlDataAdapter sqldat = new SqlDataAdapter(sqlcmd);
                sqldat.Fill(dtresultado);
            }
            catch (Exception ex)
            {
                dtresultado = null;
            }
            return dtresultado;
        }
    }
}
