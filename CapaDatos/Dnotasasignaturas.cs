using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;


namespace CapaDatos
{
    public class Dnotasasignaturas
    {
        private int _Id_notasasignaturas;
        private int _id_asignatura;
        private int _id_estudiante;
        private int _nota_primer_mes;
        private int _nota_segundo_mes;
        private int _nota_tercer_mes;
        private int _nota_cuarto_mes;
        private int _periodo;
        private int _ano;

        private string _textobuscar;

        public int Id_notasasignaturas { get => _Id_notasasignaturas; set => _Id_notasasignaturas = value; }
        public int Id_asignatura { get => _id_asignatura; set => _id_asignatura = value; }
        public int Id_estudiante { get => _id_estudiante; set => _id_estudiante = value; }
        public string Textobuscar { get => _textobuscar; set => _textobuscar = value; }
        public int Nota_primer_mes { get => _nota_primer_mes; set => _nota_primer_mes = value; }
        public int Nota_segundo_mes { get => _nota_segundo_mes; set => _nota_segundo_mes = value; }
        public int Nota_tercer_mes { get => _nota_tercer_mes; set => _nota_tercer_mes = value; }
        public int Nota_cuarto_mes { get => _nota_cuarto_mes; set => _nota_cuarto_mes = value; }
        public int Periodo { get => _periodo; set => _periodo = value; }
        public int Ano { get => _ano; set => _ano = value; }

        //Constructor vacio
        public Dnotasasignaturas()
        {

        }

        //Constructor con parametros
        public Dnotasasignaturas(int Id_notasasignaturas, int id_asignatura, int id_estudiante, string textobuscar, int nota_primer_mes, int nota_segundo_mes, int nota_tercer_mes, int nota_cuarto_mes, int periodo, int ano)
        {
            this.Id_notasasignaturas = Id_notasasignaturas;
            this.Id_asignatura = id_asignatura;
            this.Id_estudiante = id_estudiante;
            this.Textobuscar = textobuscar;
            this.Nota_primer_mes = nota_primer_mes;
            this.Nota_segundo_mes = nota_segundo_mes;
            this.Nota_tercer_mes = nota_tercer_mes;
            this.Nota_cuarto_mes = nota_cuarto_mes;
            this.Periodo = periodo;
            this.Ano = ano;
        }

        //Metodo insertar
        public string Insertar(Dnotasasignaturas Notasasignaturas)
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
                sqlcmd.CommandText = "spinsertar_notasasignaturas";
                sqlcmd.CommandType = CommandType.StoredProcedure;

                SqlParameter parId_notasasignaturas = new SqlParameter();
                parId_notasasignaturas.ParameterName = "@id_notasasignaturas";
                parId_notasasignaturas.SqlDbType = SqlDbType.Int;
                parId_notasasignaturas.Direction = ParameterDirection.Output;
                sqlcmd.Parameters.Add(parId_notasasignaturas);

                SqlParameter parid_asignatura = new SqlParameter();
                parid_asignatura.ParameterName = "@id_asignatura";
                parid_asignatura.SqlDbType = SqlDbType.Int;
                //parid_asignatura.Size = 50;
                parid_asignatura.Value = Notasasignaturas.Id_asignatura;
                sqlcmd.Parameters.Add(parid_asignatura);

                SqlParameter parid_estudiante = new SqlParameter();
                parid_estudiante.ParameterName = "@id_estudiante";
                parid_estudiante.SqlDbType = SqlDbType.Int;
                //parid_asignatura.Size = 50;
                parid_asignatura.Value = Notasasignaturas.Id_estudiante;
                sqlcmd.Parameters.Add(parid_estudiante);

                SqlParameter parnota_primer_mes = new SqlParameter();
                parnota_primer_mes.ParameterName = "@nota_primer_mes";
                parnota_primer_mes.SqlDbType = SqlDbType.VarChar;
                parnota_primer_mes.Size = 50;
                parnota_primer_mes.Value = Notasasignaturas.Nota_primer_mes;
                sqlcmd.Parameters.Add(parnota_primer_mes);

                SqlParameter parnota_segundo_mes = new SqlParameter();
                parnota_segundo_mes.ParameterName = "@nota_segundo_mes";
                parnota_segundo_mes.SqlDbType = SqlDbType.VarChar;
                parnota_segundo_mes.Size = 50;
                parnota_segundo_mes.Value = Notasasignaturas.Nota_segundo_mes;
                sqlcmd.Parameters.Add(parnota_segundo_mes);

                SqlParameter parnota_tercer_mes = new SqlParameter();
                parnota_tercer_mes.ParameterName = "@nota_tercer_mes";
                parnota_tercer_mes.SqlDbType = SqlDbType.VarChar;
                parnota_tercer_mes.Size = 50;
                parnota_tercer_mes.Value = Notasasignaturas.Nota_tercer_mes;
                sqlcmd.Parameters.Add(parnota_tercer_mes);

                SqlParameter parnota_cuarto_mes = new SqlParameter();
                parnota_cuarto_mes.ParameterName = "@nota_cuarto_mes";
                parnota_cuarto_mes.SqlDbType = SqlDbType.VarChar;
                parnota_cuarto_mes.Size = 50;
                parnota_cuarto_mes.Value = Notasasignaturas.Nota_cuarto_mes;
                sqlcmd.Parameters.Add(parnota_cuarto_mes);

                SqlParameter par_periodo = new SqlParameter();
                par_periodo.ParameterName = "@periodo";
                par_periodo.SqlDbType = SqlDbType.Int;
                //parid_asignatura.Size = 50;
                par_periodo.Value = Notasasignaturas.Periodo;
                sqlcmd.Parameters.Add(par_periodo);

                SqlParameter par_ano = new SqlParameter();
                par_ano.ParameterName = "@ano";
                par_ano.SqlDbType = SqlDbType.Int;
                //parid_asignatura.Size = 50;
                par_ano.Value = Notasasignaturas.Ano;
                sqlcmd.Parameters.Add(par_ano);

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
        public string Editar(Dnotasasignaturas Notasasignaturas)
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
                sqlcmd.CommandText = "speditar_notasasignaturas";
                sqlcmd.CommandType = CommandType.StoredProcedure;

                SqlParameter parid_asignatura = new SqlParameter();
                parid_asignatura.ParameterName = "@id_asignatura";
                parid_asignatura.SqlDbType = SqlDbType.Int;
                //parid_asignatura.Size = 50;
                parid_asignatura.Value = Notasasignaturas.Id_asignatura;
                sqlcmd.Parameters.Add(parid_asignatura);

                SqlParameter parid_estudiante = new SqlParameter();
                parid_estudiante.ParameterName = "@id_estudiante";
                parid_estudiante.SqlDbType = SqlDbType.Int;
                //parid_asignatura.Size = 50;
                parid_asignatura.Value = Notasasignaturas.Id_estudiante;
                sqlcmd.Parameters.Add(parid_estudiante);

                SqlParameter parnota_primer_mes = new SqlParameter();
                parnota_primer_mes.ParameterName = "@nota_primer_mes";
                parnota_primer_mes.SqlDbType = SqlDbType.VarChar;
                parnota_primer_mes.Size = 50;
                parnota_primer_mes.Value = Notasasignaturas.Nota_primer_mes;
                sqlcmd.Parameters.Add(parnota_primer_mes);

                SqlParameter parnota_segundo_mes = new SqlParameter();
                parnota_segundo_mes.ParameterName = "@nota_segundo_mes";
                parnota_segundo_mes.SqlDbType = SqlDbType.VarChar;
                parnota_segundo_mes.Size = 50;
                parnota_segundo_mes.Value = Notasasignaturas.Nota_segundo_mes;
                sqlcmd.Parameters.Add(parnota_segundo_mes);

                SqlParameter parnota_tercer_mes = new SqlParameter();
                parnota_tercer_mes.ParameterName = "@nota_tercer_mes";
                parnota_tercer_mes.SqlDbType = SqlDbType.VarChar;
                parnota_tercer_mes.Size = 50;
                parnota_tercer_mes.Value = Notasasignaturas.Nota_tercer_mes;
                sqlcmd.Parameters.Add(parnota_tercer_mes);

                SqlParameter parnota_cuarto_mes = new SqlParameter();
                parnota_cuarto_mes.ParameterName = "@nota_cuarto_mes";
                parnota_cuarto_mes.SqlDbType = SqlDbType.VarChar;
                parnota_cuarto_mes.Size = 50;
                parnota_cuarto_mes.Value = Notasasignaturas.Nota_cuarto_mes;
                sqlcmd.Parameters.Add(parnota_cuarto_mes);

                SqlParameter par_periodo = new SqlParameter();
                par_periodo.ParameterName = "@periodo";
                par_periodo.SqlDbType = SqlDbType.Int;
                //parid_asignatura.Size = 50;
                par_periodo.Value = Notasasignaturas.Periodo;
                sqlcmd.Parameters.Add(par_periodo);

                SqlParameter par_ano = new SqlParameter();
                par_ano.ParameterName = "@ano";
                par_ano.SqlDbType = SqlDbType.Int;
                //parid_asignatura.Size = 50;
                par_ano.Value = Notasasignaturas.Ano;
                sqlcmd.Parameters.Add(par_ano);
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
        public string Eliminar(Dnotasasignaturas Notasasignaturas)
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
                sqlcmd.CommandText = "speliminar_notasasignaturas";
                sqlcmd.CommandType = CommandType.StoredProcedure;

                SqlParameter parId_notasasignaturas = new SqlParameter();
                parId_notasasignaturas.ParameterName = "@id_notasasignaturas";
                parId_notasasignaturas.SqlDbType = SqlDbType.Int;
                parId_notasasignaturas.Value = Notasasignaturas.Id_notasasignaturas;
                sqlcmd.Parameters.Add(parId_notasasignaturas);

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
            DataTable dtresultado = new DataTable("notasasignaturas");
            SqlConnection sqlcon = new SqlConnection();
            try
            {
                sqlcon.ConnectionString = Conexion.Cn;
                SqlCommand sqlcmd = new SqlCommand();
                sqlcmd.Connection = sqlcon;
                sqlcmd.CommandText = "spmostrar_notasasignaturas";
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
        public DataTable Buscarnombre(Dnotasasignaturas Notasasignaturas)
        {
            DataTable dtresultado = new DataTable("notasasignaturas");
            SqlConnection sqlcon = new SqlConnection();
            try
            {
                sqlcon.ConnectionString = Conexion.Cn;
                SqlCommand sqlcmd = new SqlCommand();
                sqlcmd.Connection = sqlcon;
                sqlcmd.CommandText = "spbuscar_notasasignaturas";
                sqlcmd.CommandType = CommandType.StoredProcedure;

                SqlParameter partextobuscar = new SqlParameter();
                partextobuscar.ParameterName = "@textobuscar";
                partextobuscar.SqlDbType = SqlDbType.Int;
                //partextobuscar.Size = 50;
                partextobuscar.Value = Notasasignaturas.Textobuscar;
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
