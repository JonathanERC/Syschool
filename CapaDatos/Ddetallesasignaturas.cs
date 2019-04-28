using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;


namespace CapaDatos
{
    public class Ddetallesasignaturas
    {
        private int _Id_detalleasignatura;
        private int _id_asignatura;
        private int _id_curso;
        private DateTime _hora_inicio;
        private DateTime _hora_fin;

        private string _textobuscar;

        public int Id_detalleasignatura { get => _Id_detalleasignatura; set => _Id_detalleasignatura = value; }
        public int Id_asignatura { get => _id_asignatura; set => _id_asignatura = value; }
        public int Id_curso { get => _id_curso; set => _id_curso = value; }
        public string Textobuscar { get => _textobuscar; set => _textobuscar = value; }
        public DateTime Hora_inicio { get => _hora_inicio; set => _hora_inicio = value; }
        public DateTime Hora_fin { get => _hora_fin; set => _hora_fin = value; }

        //Constructor vacio
        public Ddetallesasignaturas()
        {

        }

        //Constructor con parametros
        public Ddetallesasignaturas(int Id_detalleasignatura, int id_asignatura, int id_curso, string textobuscar, DateTime hora_inicio, DateTime hora_fin)
        {
            this.Id_detalleasignatura = Id_detalleasignatura;
            this.Id_asignatura = id_asignatura;
            this.Id_curso = id_curso;
            this.Textobuscar = textobuscar;
            this.Hora_inicio = hora_inicio;
            this.Hora_fin = hora_fin;
        }

        //Metodo insertar
        public string Insertar(Ddetallesasignaturas Detalleasignatura)
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
                sqlcmd.CommandText = "spinsertar_detallesasignaturas";
                sqlcmd.CommandType = CommandType.StoredProcedure;

                SqlParameter parId_detalleasignatura = new SqlParameter();
                parId_detalleasignatura.ParameterName = "@id_detalleasignatura";
                parId_detalleasignatura.SqlDbType = SqlDbType.Int;
                parId_detalleasignatura.Direction = ParameterDirection.Output;
                sqlcmd.Parameters.Add(parId_detalleasignatura);

                SqlParameter parid_asignatura = new SqlParameter();
                parid_asignatura.ParameterName = "@id_asignatura";
                parid_asignatura.SqlDbType = SqlDbType.Int;
                //parid_asignatura.Size = 50;
                parid_asignatura.Value = Detalleasignatura.Id_asignatura;
                sqlcmd.Parameters.Add(parid_asignatura);

                SqlParameter parid_curso = new SqlParameter();
                parid_curso.ParameterName = "@id_curso";
                parid_curso.SqlDbType = SqlDbType.Int;
                //parid_asignatura.Size = 50;
                parid_curso.Value = Detalleasignatura.Id_curso;
                sqlcmd.Parameters.Add(parid_curso);

                SqlParameter parhora_inicio = new SqlParameter();
                parhora_inicio.ParameterName = "@hora_inicio";
                parhora_inicio.SqlDbType = SqlDbType.VarChar;
                parhora_inicio.Size = 50;
                parhora_inicio.Value = Detalleasignatura.Hora_inicio;
                sqlcmd.Parameters.Add(parhora_inicio);

                SqlParameter parhora_fin = new SqlParameter();
                parhora_fin.ParameterName = "@hora_fin";
                parhora_fin.SqlDbType = SqlDbType.VarChar;
                parhora_fin.Size = 50;
                parhora_fin.Value = Detalleasignatura.Hora_fin;
                sqlcmd.Parameters.Add(parhora_fin);

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
        public string Editar(Ddetallesasignaturas Detalleasignatura)
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
                sqlcmd.CommandText = "speditar_detallesasignaturas";
                sqlcmd.CommandType = CommandType.StoredProcedure;

                SqlParameter parId_detalleasignatura = new SqlParameter();
                parId_detalleasignatura.ParameterName = "@id_detalleasignatura";
                parId_detalleasignatura.SqlDbType = SqlDbType.Int;
                parId_detalleasignatura.Value = Detalleasignatura.Id_detalleasignatura;
                sqlcmd.Parameters.Add(parId_detalleasignatura);

                SqlParameter parid_asignatura = new SqlParameter();
                parid_asignatura.ParameterName = "@id_asignatura";
                parid_asignatura.SqlDbType = SqlDbType.Int;
                //parid_asignatura.Size = 50;
                parid_asignatura.Value = Detalleasignatura.Id_asignatura;
                sqlcmd.Parameters.Add(parid_asignatura);

                SqlParameter parid_curso = new SqlParameter();
                parid_curso.ParameterName = "@id_curso";
                parid_curso.SqlDbType = SqlDbType.Int;
                //parid_asignatura.Size = 50;
                parid_curso.Value = Detalleasignatura.Id_curso;
                sqlcmd.Parameters.Add(parid_curso);

                SqlParameter parhora_inicio = new SqlParameter();
                parhora_inicio.ParameterName = "@hora_inicio";
                parhora_inicio.SqlDbType = SqlDbType.VarChar;
                parhora_inicio.Size = 50;
                parhora_inicio.Value = Detalleasignatura.Hora_inicio;
                sqlcmd.Parameters.Add(parhora_inicio);

                SqlParameter parhora_fin = new SqlParameter();
                parhora_fin.ParameterName = "@hora_fin";
                parhora_fin.SqlDbType = SqlDbType.VarChar;
                parhora_fin.Size = 50;
                parhora_fin.Value = Detalleasignatura.Hora_fin;
                sqlcmd.Parameters.Add(parhora_fin);

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
        public string Eliminar(Ddetallesasignaturas Detalleasignatura)
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
                sqlcmd.CommandText = "speliminar_detallesasignaturas";
                sqlcmd.CommandType = CommandType.StoredProcedure;

                SqlParameter parId_detalleasignatura = new SqlParameter();
                parId_detalleasignatura.ParameterName = "@id_detalleasignatura";
                parId_detalleasignatura.SqlDbType = SqlDbType.Int;
                parId_detalleasignatura.Value = Detalleasignatura.Id_detalleasignatura;
                sqlcmd.Parameters.Add(parId_detalleasignatura);

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
            DataTable dtresultado = new DataTable("detallesasignaturas");
            SqlConnection sqlcon = new SqlConnection();
            try
            {
                sqlcon.ConnectionString = Conexion.Cn;
                SqlCommand sqlcmd = new SqlCommand();
                sqlcmd.Connection = sqlcon;
                sqlcmd.CommandText = "spmostrar_detallesasignaturas";
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
        public DataTable Buscarnombre(Ddetallesasignaturas Detalleasignatura)
        {
            DataTable dtresultado = new DataTable("detallesasignaturas");
            SqlConnection sqlcon = new SqlConnection();
            try
            {
                sqlcon.ConnectionString = Conexion.Cn;
                SqlCommand sqlcmd = new SqlCommand();
                sqlcmd.Connection = sqlcon;
                sqlcmd.CommandText = "spbuscar_detalleasignatura";
                sqlcmd.CommandType = CommandType.StoredProcedure;

                SqlParameter partextobuscar = new SqlParameter();
                partextobuscar.ParameterName = "@textobuscar";
                partextobuscar.SqlDbType = SqlDbType.Int;
                //partextobuscar.Size = 50;
                partextobuscar.Value = Detalleasignatura.Textobuscar;
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
