using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;


namespace CapaDatos
{
    public class Dadministrador
    {
        private int _Id_administrador;
        private int _id_usuario;

        private string _textobuscar;

        public int Id_administrador { get => _Id_administrador; set => _Id_administrador = value; }
        public int Id_usuario { get => _id_usuario; set => _id_usuario = value; }
        public string Textobuscar { get => _textobuscar; set => _textobuscar = value; }

        //Constructor vacio
        public Dadministrador()
        {

        }

        //Constructor con parametros
        public Dadministrador(int Id_administrador, int id_usuario, string textobuscar)
        {
            this.Id_administrador = Id_administrador;
            this.Id_usuario = id_usuario;
            this.Textobuscar = textobuscar;
        }

        //Metodo insertar
        public string Insertar(Dadministrador Administrador)
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
                sqlcmd.CommandText = "spinsertar_administrador";
                sqlcmd.CommandType = CommandType.StoredProcedure;

                SqlParameter parId_administrador = new SqlParameter();
                parId_administrador.ParameterName = "@id_administrador";
                parId_administrador.SqlDbType = SqlDbType.Int;
                parId_administrador.Direction = ParameterDirection.Output;
                sqlcmd.Parameters.Add(parId_administrador);

                SqlParameter parid_usuario = new SqlParameter();
                parid_usuario.ParameterName = "@id_usuario";
                parid_usuario.SqlDbType = SqlDbType.Int;
                //parid_usuario.Size = 50;
                parid_usuario.Value = Administrador.Id_usuario;
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
        public string Editar(Dadministrador Administrador)
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
                sqlcmd.CommandText = "speditar_administrador";
                sqlcmd.CommandType = CommandType.StoredProcedure;

                SqlParameter parId_administrador = new SqlParameter();
                parId_administrador.ParameterName = "@id_administrador";
                parId_administrador.SqlDbType = SqlDbType.Int;
                parId_administrador.Value = Administrador.Id_administrador;
                sqlcmd.Parameters.Add(parId_administrador);

                SqlParameter parid_usuario = new SqlParameter();
                parid_usuario.ParameterName = "@id_usuario";
                parid_usuario.SqlDbType = SqlDbType.Int;
                //parid_usuario.Size = 50;
                parid_usuario.Value = Administrador.Id_usuario;
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
        public string Eliminar(Dadministrador Administrador)
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
                sqlcmd.CommandText = "speliminar_administrador";
                sqlcmd.CommandType = CommandType.StoredProcedure;

                SqlParameter parId_administrador = new SqlParameter();
                parId_administrador.ParameterName = "@id_administrador";
                parId_administrador.SqlDbType = SqlDbType.Int;
                parId_administrador.Value = Administrador.Id_administrador;
                sqlcmd.Parameters.Add(parId_administrador);

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
            DataTable dtresultado = new DataTable("administrador");
            SqlConnection sqlcon = new SqlConnection();
            try
            {
                sqlcon.ConnectionString = Conexion.Cn;
                SqlCommand sqlcmd = new SqlCommand();
                sqlcmd.Connection = sqlcon;
                sqlcmd.CommandText = "spmostrar_administrador";
                sqlcmd.CommandType = CommandType.StoredProcedure;

                SqlDataAdapter sqldat = new SqlDataAdapter(sqlcmd);
                sqldat.Fill(dtresultado);
            }
            catch (Exception ex)
            {
                dtresultado = null;
            }
            finally
            {
                if (sqlcon.State == ConnectionState.Open)
                {
                    sqlcon.Close();
                }
            }
            return dtresultado;

        }

        //Metodo buscarnombre
        public DataTable Buscarnombre(Dadministrador Administrador)
        {
            DataTable dtresultado = new DataTable("administrador");
            SqlConnection sqlcon = new SqlConnection();
            try
            {
                sqlcon.ConnectionString = Conexion.Cn;
                SqlCommand sqlcmd = new SqlCommand();
                sqlcmd.Connection = sqlcon;
                sqlcmd.CommandText = "spbuscar_administrador";
                sqlcmd.CommandType = CommandType.StoredProcedure;

                SqlParameter partextobuscar = new SqlParameter();
                partextobuscar.ParameterName = "@textobuscar";
                partextobuscar.SqlDbType = SqlDbType.Int;
                //partextobuscar.Size = 50;
                partextobuscar.Value = Administrador.Textobuscar;
                sqlcmd.Parameters.Add(partextobuscar);
                
                SqlDataAdapter sqldat = new SqlDataAdapter(sqlcmd);
                sqldat.Fill(dtresultado);
            }
            catch (Exception ex)
            {
                dtresultado = null;
            }
            finally
            {
                if (sqlcon.State == ConnectionState.Open)
                {
                    sqlcon.Close();
                }
            }
            return dtresultado;
        }
    }
}
