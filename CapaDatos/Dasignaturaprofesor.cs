using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;


namespace CapaDatos
{
    public class Dasignaturaprofesor
    {
        private int _Id_asignaturaprofesor;
        private int _id_asignatura;
        private int _id_profesor;

        private string _textobuscar;

        public int Id_asignaturaprofesor { get => _Id_asignaturaprofesor; set => _Id_asignaturaprofesor = value; }
        public int Id_asignatura { get => _id_asignatura; set => _id_asignatura = value; }
        public int Id_profesor { get => _id_profesor; set => _id_profesor = value; }
        public string Textobuscar { get => _textobuscar; set => _textobuscar = value; }

        //Constructor vacio
        public Dasignaturaprofesor()
        {

        }

        //Constructor con parametros
        public Dasignaturaprofesor(int Id_asignaturaprofesor, int id_asignatura, int id_profesor, string textobuscar)
        {
            this.Id_asignaturaprofesor = Id_asignaturaprofesor;
            this.Id_asignatura = id_asignatura;
            this.Id_profesor = id_profesor;
            this.Textobuscar = textobuscar;
        }

        //Metodo insertar
        public string Insertar(Dasignaturaprofesor Asignaturaprofesor)
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
                sqlcmd.CommandText = "spinsertar_asignaturaprofesor";
                sqlcmd.CommandType = CommandType.StoredProcedure;

                SqlParameter parId_asignaturaprofesor = new SqlParameter();
                parId_asignaturaprofesor.ParameterName = "@id_asignaturaprofesor";
                parId_asignaturaprofesor.SqlDbType = SqlDbType.Int;
                parId_asignaturaprofesor.Direction = ParameterDirection.Output;
                sqlcmd.Parameters.Add(parId_asignaturaprofesor);

                SqlParameter parid_asignatura = new SqlParameter();
                parid_asignatura.ParameterName = "@id_asignatura";
                parid_asignatura.SqlDbType = SqlDbType.Int;
                //parid_asignatura.Size = 50;
                parid_asignatura.Value = Asignaturaprofesor.Id_asignatura;
                sqlcmd.Parameters.Add(parid_asignatura);

                SqlParameter parid_profesor = new SqlParameter();
                parid_profesor.ParameterName = "@id_profesor";
                parid_profesor.SqlDbType = SqlDbType.Int;
                //parid_asignatura.Size = 50;
                parid_profesor.Value = Asignaturaprofesor.Id_profesor;
                sqlcmd.Parameters.Add(parid_profesor);

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
        public string Editar(Dasignaturaprofesor Asignaturaprofesor)
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
                sqlcmd.CommandText = "speditar_asignaturaprofesor";
                sqlcmd.CommandType = CommandType.StoredProcedure;

                SqlParameter parId_asignaturaprofesor = new SqlParameter();
                parId_asignaturaprofesor.ParameterName = "@id_asignaturaprofesor";
                parId_asignaturaprofesor.SqlDbType = SqlDbType.Int;
                parId_asignaturaprofesor.Value = Asignaturaprofesor.Id_asignaturaprofesor;
                sqlcmd.Parameters.Add(parId_asignaturaprofesor);

                SqlParameter parid_asignatura = new SqlParameter();
                parid_asignatura.ParameterName = "@id_asignatura";
                parid_asignatura.SqlDbType = SqlDbType.Int;
                //parid_asignatura.Size = 50;
                parid_asignatura.Value = Asignaturaprofesor.Id_asignatura;
                sqlcmd.Parameters.Add(parid_asignatura);

                SqlParameter parid_profesor = new SqlParameter();
                parid_profesor.ParameterName = "@id_profesor";
                parid_profesor.SqlDbType = SqlDbType.Int;
                //parid_asignatura.Size = 50;
                parid_profesor.Value = Asignaturaprofesor.Id_profesor;
                sqlcmd.Parameters.Add(parid_profesor);

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
        public string Eliminar(Dasignaturaprofesor Asignaturaprofesor)
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
                sqlcmd.CommandText = "speliminar_asignaturaprofesor";
                sqlcmd.CommandType = CommandType.StoredProcedure;

                SqlParameter parId_asignaturaprofesor = new SqlParameter();
                parId_asignaturaprofesor.ParameterName = "@id_asignaturaprofesor";
                parId_asignaturaprofesor.SqlDbType = SqlDbType.Int;
                parId_asignaturaprofesor.Value = Asignaturaprofesor.Id_asignaturaprofesor;
                sqlcmd.Parameters.Add(parId_asignaturaprofesor);

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
            DataTable dtresultado = new DataTable("asignaturaprofesor");
            SqlConnection sqlcon = new SqlConnection();
            try
            {
                sqlcon.ConnectionString = Conexion.Cn;
                SqlCommand sqlcmd = new SqlCommand();
                sqlcmd.Connection = sqlcon;
                sqlcmd.CommandText = "spmostrar_asignaturaprofesor";
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
        public DataTable Buscarnombre(Dasignaturaprofesor Asignaturaprofesor)
        {
            DataTable dtresultado = new DataTable("asignaturaprofesor");
            SqlConnection sqlcon = new SqlConnection();
            try
            {
                sqlcon.ConnectionString = Conexion.Cn;
                SqlCommand sqlcmd = new SqlCommand();
                sqlcmd.Connection = sqlcon;
                sqlcmd.CommandText = "spbuscar_asignaturaprofesor";
                sqlcmd.CommandType = CommandType.StoredProcedure;

                SqlParameter partextobuscar = new SqlParameter();
                partextobuscar.ParameterName = "@textobuscar";
                partextobuscar.SqlDbType = SqlDbType.Int;
                //partextobuscar.Size = 50;
                partextobuscar.Value = Asignaturaprofesor.Textobuscar;
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
