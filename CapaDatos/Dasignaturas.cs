using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;


namespace CapaDatos
{
    public class Dasignatura
    {
        private int _Id_asignatura;
        private string _nombre;
        private string _codigo;

        private string _textobuscar;

        public int Id_asignatura { get => _Id_asignatura; set => _Id_asignatura = value; }
        public string Nombre { get => _nombre; set => _nombre = value; }
        public string Codigo { get => _codigo; set => _codigo = value; }
        public string Textobuscar { get => _textobuscar; set => _textobuscar = value; }

        //Constructor vacio
        public Dasignatura()
        {

        }

        //Constructor con parametros
        public Dasignatura(int Id_asignatura, string nombre, string codigo, string textobuscar)
        {
            this.Id_asignatura = Id_asignatura;
            this.Nombre = nombre;
            this.Codigo = codigo;
            this.Textobuscar = textobuscar;
        }

        //Metodo insertar
        public string Insertar(Dasignatura Asignatura)
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
                sqlcmd.CommandText = "spinsertar_asignaturas";
                sqlcmd.CommandType = CommandType.StoredProcedure;

                SqlParameter parId_asignatura = new SqlParameter();
                parId_asignatura.ParameterName = "@id_asignatura";
                parId_asignatura.SqlDbType = SqlDbType.Int;
                parId_asignatura.Direction = ParameterDirection.Output;
                sqlcmd.Parameters.Add(parId_asignatura);

                SqlParameter parnombre = new SqlParameter();
                parnombre.ParameterName = "@nombre";
                parnombre.SqlDbType = SqlDbType.VarChar;
                parnombre.Size = 50;
                parnombre.Value = Asignatura.Nombre;
                sqlcmd.Parameters.Add(parnombre);

                SqlParameter parcodigo = new SqlParameter();
                parcodigo.ParameterName = "@codigo";
                parcodigo.SqlDbType = SqlDbType.VarChar;
                parcodigo.Size = 20;
                parcodigo.Value = Asignatura.Codigo;
                sqlcmd.Parameters.Add(parcodigo);

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
        public string Editar(Dasignatura Asignatura)
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
                sqlcmd.CommandText = "speditar_asignaturas";
                sqlcmd.CommandType = CommandType.StoredProcedure;

                SqlParameter parId_asignatura = new SqlParameter();
                parId_asignatura.ParameterName = "@id_asignatura";
                parId_asignatura.SqlDbType = SqlDbType.Int;
                parId_asignatura.Value = Asignatura.Id_asignatura;
                sqlcmd.Parameters.Add(parId_asignatura);

                SqlParameter parnombre = new SqlParameter();
                parnombre.ParameterName = "@nombre";
                parnombre.SqlDbType = SqlDbType.VarChar;
                parnombre.Size = 50;
                parnombre.Value = Asignatura.Nombre;
                sqlcmd.Parameters.Add(parnombre);

                SqlParameter parcodigo = new SqlParameter();
                parcodigo.ParameterName = "@codigo";
                parcodigo.SqlDbType = SqlDbType.VarChar;
                parcodigo.Size = 20;
                parcodigo.Value = Asignatura.Codigo;
                sqlcmd.Parameters.Add(parcodigo);

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
        public string Eliminar(Dasignatura Asignatura)
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
                sqlcmd.CommandText = "speliminar_asignaturas";
                sqlcmd.CommandType = CommandType.StoredProcedure;

                SqlParameter parId_asignatura = new SqlParameter();
                parId_asignatura.ParameterName = "@id_asignatura";
                parId_asignatura.SqlDbType = SqlDbType.Int;
                parId_asignatura.Value = Asignatura.Id_asignatura;
                sqlcmd.Parameters.Add(parId_asignatura);

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
            DataTable dtresultado = new DataTable("asignaturas");
            SqlConnection sqlcon = new SqlConnection();
            try
            {
                sqlcon.ConnectionString = Conexion.Cn;
                SqlCommand sqlcmd = new SqlCommand();
                sqlcmd.Connection = sqlcon;
                sqlcmd.CommandText = "spmostrar_asignaturas";
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
        public DataTable Buscarnombre(Dasignatura Asignatura)
        {
            DataTable dtresultado = new DataTable("asignaturas");
            SqlConnection sqlcon = new SqlConnection();
            try
            {
                sqlcon.ConnectionString = Conexion.Cn;
                SqlCommand sqlcmd = new SqlCommand();
                sqlcmd.Connection = sqlcon;
                sqlcmd.CommandText = "spbuscar_asignaturas";
                sqlcmd.CommandType = CommandType.StoredProcedure;

                SqlParameter partextobuscar = new SqlParameter();
                partextobuscar.ParameterName = "@textobuscar";
                partextobuscar.SqlDbType = SqlDbType.VarChar;
                partextobuscar.Size = 50;
                partextobuscar.Value = Asignatura.Textobuscar;
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
