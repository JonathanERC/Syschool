using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;


namespace CapaDatos
{
    public class Dprofesores
    {
        private int _Id_profesor;
        private int _id_usuario;

        private string _textobuscar;

        public int Id_profesor { get => _Id_profesor; set => _Id_profesor = value; }
        public int Id_usuario { get => _id_usuario; set => _id_usuario = value; }
        public string Textobuscar { get => _textobuscar; set => _textobuscar = value; }

        //Constructor vacio
        public Dprofesores()
        {

        }

        //Constructor con parametros
        public Dprofesores(int Id_profesor, int id_usuario, string textobuscar)
        {
            this.Id_profesor = Id_profesor;
            this.Id_usuario = id_usuario;
            this.Textobuscar = textobuscar;
        }

        //Metodo insertar
        public string Insertar(Dprofesores Profesor)
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
                sqlcmd.CommandText = "spinsertar_profesores";
                sqlcmd.CommandType = CommandType.StoredProcedure;

                SqlParameter parId_profesor = new SqlParameter();
                parId_profesor.ParameterName = "@id_profesor";
                parId_profesor.SqlDbType = SqlDbType.Int;
                parId_profesor.Direction = ParameterDirection.Output;
                sqlcmd.Parameters.Add(parId_profesor);

                SqlParameter parid_usuario = new SqlParameter();
                parid_usuario.ParameterName = "@id_usuario";
                parid_usuario.SqlDbType = SqlDbType.Int;
                //parid_usuario.Size = 50;
                parid_usuario.Value = Profesor.Id_usuario;
                sqlcmd.Parameters.Add(parid_usuario);

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
        public string Editar(Dprofesores Profesor)
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
                sqlcmd.CommandText = "speditar_profesores";
                sqlcmd.CommandType = CommandType.StoredProcedure;

                SqlParameter parId_profesor = new SqlParameter();
                parId_profesor.ParameterName = "@id_profesor";
                parId_profesor.SqlDbType = SqlDbType.Int;
                parId_profesor.Value = Profesor.Id_profesor;
                sqlcmd.Parameters.Add(parId_profesor);

                SqlParameter parid_usuario = new SqlParameter();
                parid_usuario.ParameterName = "@id_usuario";
                parid_usuario.SqlDbType = SqlDbType.Int;
                //parid_usuario.Size = 50;
                parid_usuario.Value = Profesor.Id_usuario;
                sqlcmd.Parameters.Add(parid_usuario);

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
        public string Eliminar(Dprofesores Profesor)
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
                sqlcmd.CommandText = "speliminar_profesores";
                sqlcmd.CommandType = CommandType.StoredProcedure;

                SqlParameter parId_profesor = new SqlParameter();
                parId_profesor.ParameterName = "@id_profesor";
                parId_profesor.SqlDbType = SqlDbType.Int;
                parId_profesor.Value = Profesor.Id_profesor;
                sqlcmd.Parameters.Add(parId_profesor);

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
            DataTable dtresultado = new DataTable("profesores");
            SqlConnection sqlcon = new SqlConnection();
            try
            {
                sqlcon.ConnectionString = Conexion.Cn;
                SqlCommand sqlcmd = new SqlCommand();
                sqlcmd.Connection = sqlcon;
                sqlcmd.CommandText = "spmostrar_profesores";
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
        public DataTable Buscarnombre(Dprofesores Profesor)
        {
            DataTable dtresultado = new DataTable("profesores");
            SqlConnection sqlcon = new SqlConnection();
            try
            {
                sqlcon.ConnectionString = Conexion.Cn;
                SqlCommand sqlcmd = new SqlCommand();
                sqlcmd.Connection = sqlcon;
                sqlcmd.CommandText = "spbuscar_profesores";
                sqlcmd.CommandType = CommandType.StoredProcedure;

                SqlParameter partextobuscar = new SqlParameter();
                partextobuscar.ParameterName = "@textobuscar";
                partextobuscar.SqlDbType = SqlDbType.Int;
                //partextobuscar.Size = 50;
                partextobuscar.Value = Profesor.Textobuscar;
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
