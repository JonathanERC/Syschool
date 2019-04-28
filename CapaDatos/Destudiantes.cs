using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;


namespace CapaDatos
{
    public class Destudiantes
    {
        private int _Id_estudiante;
        private int _numero_estudiante;
        private int _id_curso;
        private int _id_usuario;

        private string _textobuscar;

        public int Id_estudiante { get => _Id_estudiante; set => _Id_estudiante = value; }
        public int Numero_estudiante { get => _numero_estudiante; set => _numero_estudiante = value; }
        public int Id_curso { get => _id_curso; set => _id_curso = value; }
        public int Id_usuario { get => _id_usuario; set => _id_usuario = value; }

        public string Textobuscar { get => _textobuscar; set => _textobuscar = value; }

        //Constructor vacio
        public Destudiantes()
        {

        }

        //Constructor con parametros
        public Destudiantes(int Id_estudiante, int numero_estudiante, int id_curso, int id_usuario, string textobuscar)
        {
            this.Id_estudiante = Id_estudiante;
            this.Numero_estudiante = numero_estudiante;
            this.Id_curso = id_curso;
            this.Id_usuario = id_usuario;
            this.Textobuscar = textobuscar;
        }

        //Metodo insertar
        public string Insertar(Destudiantes Estudiante)
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
                sqlcmd.CommandText = "spinsertar_estudiantes";
                sqlcmd.CommandType = CommandType.StoredProcedure;

                SqlParameter parId_estudiante = new SqlParameter();
                parId_estudiante.ParameterName = "@id_estudiante";
                parId_estudiante.SqlDbType = SqlDbType.Int;
                parId_estudiante.Direction = ParameterDirection.Output;
                sqlcmd.Parameters.Add(parId_estudiante);

                SqlParameter parnumero_estudiante = new SqlParameter();
                parnumero_estudiante.ParameterName = "@numero_estudiante";
                parnumero_estudiante.SqlDbType = SqlDbType.Int;
                //parnumero_estudiante.Size = 50;
                parnumero_estudiante.Value = Estudiante.Numero_estudiante;
                sqlcmd.Parameters.Add(parnumero_estudiante);

                SqlParameter parid_curso = new SqlParameter();
                parid_curso.ParameterName = "@numero_estudiante";
                parid_curso.SqlDbType = SqlDbType.Int;
                //parnumero_estudiante.Size = 50;
                parid_curso.Value = Estudiante.Id_curso;
                sqlcmd.Parameters.Add(parid_curso);

                SqlParameter parid_ususario = new SqlParameter();
                parid_ususario.ParameterName = "@numero_estudiante";
                parid_ususario.SqlDbType = SqlDbType.Int;
                //parnumero_estudiante.Size = 50;
                parid_ususario.Value = Estudiante.Id_usuario;
                sqlcmd.Parameters.Add(parid_ususario);

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
        public string Editar(Destudiantes Estudiante)
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
                sqlcmd.CommandText = "speditar_estudiantes";
                sqlcmd.CommandType = CommandType.StoredProcedure;

                SqlParameter parnumero_estudiante = new SqlParameter();
                parnumero_estudiante.ParameterName = "@numero_estudiante";
                parnumero_estudiante.SqlDbType = SqlDbType.Int;
                //parnumero_estudiante.Size = 50;
                parnumero_estudiante.Value = Estudiante.Numero_estudiante;
                sqlcmd.Parameters.Add(parnumero_estudiante);

                SqlParameter parid_curso = new SqlParameter();
                parid_curso.ParameterName = "@numero_estudiante";
                parid_curso.SqlDbType = SqlDbType.Int;
                //parnumero_estudiante.Size = 50;
                parid_curso.Value = Estudiante.Id_curso;
                sqlcmd.Parameters.Add(parid_curso);

                SqlParameter parid_ususario = new SqlParameter();
                parid_ususario.ParameterName = "@numero_estudiante";
                parid_ususario.SqlDbType = SqlDbType.Int;
                //parnumero_estudiante.Size = 50;
                parid_ususario.Value = Estudiante.Id_usuario;
                sqlcmd.Parameters.Add(parid_ususario);

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
        public string Eliminar(Destudiantes Estudiante)
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
                sqlcmd.CommandText = "speliminar_estudiantes";
                sqlcmd.CommandType = CommandType.StoredProcedure;

                SqlParameter parnumero_estudiante = new SqlParameter();
                parnumero_estudiante.ParameterName = "@numero_estudiante";
                parnumero_estudiante.SqlDbType = SqlDbType.Int;
                //parnumero_estudiante.Size = 50;
                parnumero_estudiante.Value = Estudiante.Numero_estudiante;
                sqlcmd.Parameters.Add(parnumero_estudiante);

                SqlParameter parid_curso = new SqlParameter();
                parid_curso.ParameterName = "@numero_estudiante";
                parid_curso.SqlDbType = SqlDbType.Int;
                //parnumero_estudiante.Size = 50;
                parid_curso.Value = Estudiante.Id_curso;
                sqlcmd.Parameters.Add(parid_curso);

                SqlParameter parid_ususario = new SqlParameter();
                parid_ususario.ParameterName = "@numero_estudiante";
                parid_ususario.SqlDbType = SqlDbType.Int;
                //parnumero_estudiante.Size = 50;
                parid_ususario.Value = Estudiante.Id_usuario;
                sqlcmd.Parameters.Add(parid_ususario);

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
            DataTable dtresultado = new DataTable("estudiantes");
            SqlConnection sqlcon = new SqlConnection();
            try
            {
                sqlcon.ConnectionString = Conexion.Cn;
                SqlCommand sqlcmd = new SqlCommand();
                sqlcmd.Connection = sqlcon;
                sqlcmd.CommandText = "spmostrar_estudiantes";
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

        //Metodo buscarnumero
        public DataTable Buscarnombre(Destudiantes Estudiante)
        {
            DataTable dtresultado = new DataTable("estudiantes");
            SqlConnection sqlcon = new SqlConnection();
            try
            {
                sqlcon.ConnectionString = Conexion.Cn;
                SqlCommand sqlcmd = new SqlCommand();
                sqlcmd.Connection = sqlcon;
                sqlcmd.CommandText = "spbuscar_estudiantes";
                sqlcmd.CommandType = CommandType.StoredProcedure;

                SqlParameter partextobuscar = new SqlParameter();
                partextobuscar.ParameterName = "@textobuscar";
                partextobuscar.SqlDbType = SqlDbType.VarChar;
                partextobuscar.Size = 50;
                partextobuscar.Value = Estudiante.Textobuscar;
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
