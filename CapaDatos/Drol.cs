using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;


namespace CapaDatos
{
    public class Drol
    {
        private int _Id_rol;
        private string _descripcion;

        private string _textobuscar;

        public int Id_rol { get => _Id_rol; set => _Id_rol = value; }
        public string Descripcion { get => _descripcion; set => _descripcion = value; }
        public string Textobuscar { get => _textobuscar; set => _textobuscar = value; }

        //Constructor vacio
        public Drol()
        {

        }

        //Constructor con parametros
        public Drol(int Id_rol, string descripcion, string textobuscar)
        {
            this.Id_rol = Id_rol;
            this.Descripcion = descripcion;
            this.Textobuscar = textobuscar;
        }

        //Metodo insertar
        public string Insertar(Drol Rol)
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
                sqlcmd.CommandText = "spinsertar_rol";
                sqlcmd.CommandType = CommandType.StoredProcedure;

                SqlParameter parId_rol = new SqlParameter();
                parId_rol.ParameterName = "@id_rol";
                parId_rol.SqlDbType = SqlDbType.Int;
                parId_rol.Direction = ParameterDirection.Output;
                sqlcmd.Parameters.Add(parId_rol);

                SqlParameter pardescripcion = new SqlParameter();
                pardescripcion.ParameterName = "@descripcion";
                pardescripcion.SqlDbType = SqlDbType.VarChar;
                pardescripcion.Size = 50;
                pardescripcion.Value = Rol.Descripcion;
                sqlcmd.Parameters.Add(pardescripcion);

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
        public string Editar(Drol Rol)
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
                sqlcmd.CommandText = "speditar_rol";
                sqlcmd.CommandType = CommandType.StoredProcedure;

                SqlParameter parId_rol = new SqlParameter();
                parId_rol.ParameterName = "@id_rol";
                parId_rol.SqlDbType = SqlDbType.Int;
                parId_rol.Value = Rol.Id_rol;
                sqlcmd.Parameters.Add(parId_rol);

                SqlParameter pardescripcion = new SqlParameter();
                pardescripcion.ParameterName = "@descripcion";
                pardescripcion.SqlDbType = SqlDbType.VarChar;
                pardescripcion.Size = 50;
                pardescripcion.Value = Rol.Descripcion;
                sqlcmd.Parameters.Add(pardescripcion);

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
        public string Eliminar(Drol Rol)
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
                sqlcmd.CommandText = "speliminar_rol";
                sqlcmd.CommandType = CommandType.StoredProcedure;

                SqlParameter parId_rol = new SqlParameter();
                parId_rol.ParameterName = "@id_rol";
                parId_rol.SqlDbType = SqlDbType.Int;
                parId_rol.Value = Rol.Id_rol;
                sqlcmd.Parameters.Add(parId_rol);

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
            DataTable dtresultado = new DataTable("rol");
            SqlConnection sqlcon = new SqlConnection();
            try
            {
                sqlcon.ConnectionString = Conexion.Cn;
                SqlCommand sqlcmd = new SqlCommand();
                sqlcmd.Connection = sqlcon;
                sqlcmd.CommandText = "spmostrar_rol";
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
        public DataTable Buscarnombre(Drol Rol)
        {
            DataTable dtresultado = new DataTable("rol");
            SqlConnection sqlcon = new SqlConnection();
            try
            {
                sqlcon.ConnectionString = Conexion.Cn;
                SqlCommand sqlcmd = new SqlCommand();
                sqlcmd.Connection = sqlcon;
                sqlcmd.CommandText = "spbuscar_rol";
                sqlcmd.CommandType = CommandType.StoredProcedure;

                SqlParameter partextobuscar = new SqlParameter();
                partextobuscar.ParameterName = "@textobuscar";
                partextobuscar.SqlDbType = SqlDbType.VarChar;
                partextobuscar.Size = 50;
                partextobuscar.Value = Rol.Textobuscar;
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
