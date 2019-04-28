using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;


namespace CapaDatos
{
    public class Dusuarios
    {
        private int _Id_usuarios;
        private int _id_rol;
        private string _usuario;
        private string _contraseña;
        private string _primer_nombre;
        private string _segundo_nombre;
        private string _primer_apellido;
        private string _segundo_apellido;
        private string _genero;
        private string _nacionalidad;
        private int _cedula;
        private string _email;
        private DateTime _fecha_de_nacimiento;

        private string _textobuscar;

        public int Id_usuarios { get => _Id_usuarios; set => _Id_usuarios = value; }
        public int Id_rol { get => _id_rol; set => _id_rol = value; }
        public string Usuario { get => _usuario; set => _usuario = value; }
        public string Textobuscar { get => _textobuscar; set => _textobuscar = value; }
        public string Primer_nombre { get => _primer_nombre; set => _primer_nombre = value; }
        public string Segundo_nombre { get => _segundo_nombre; set => _segundo_nombre = value; }
        public string Primer_apellido { get => _primer_apellido; set => _primer_apellido = value; }
        public string Segundo_apellido { get => _segundo_apellido; set => _segundo_apellido = value; }
        public int Cedula { get => _cedula; set => _cedula = value; }
        public string Email { get => _email; set => _email = value; }
        public string Contraseña { get => _contraseña; set => _contraseña = value; }
        public string Genero { get => _genero; set => _genero = value; }
        public string Nacionalidad { get => _nacionalidad; set => _nacionalidad = value; }
        public DateTime Fecha_de_nacimiento { get => _fecha_de_nacimiento; set => _fecha_de_nacimiento = value; }

        //Constructor vacio
        public Dusuarios()
        {

        }

        //Constructor con parametros
        public Dusuarios(int Id_usuarios, int id_rol, string usuario, string textobuscar, string primer_nombre, string segundo_nombre, string primer_apellido, string segundo_apellido, int cedula, string email, string contraseña, string genero, string nacionalidad, DateTime fecha_de_nacimiento)
        {
            this.Id_usuarios = Id_usuarios;
            this.Id_rol = id_rol;
            this.Usuario = usuario;
            this.Textobuscar = textobuscar;
            this.Primer_nombre = primer_nombre;
            this.Segundo_nombre = segundo_nombre;
            this.Primer_apellido = primer_apellido;
            this.Segundo_apellido = segundo_apellido;
            this.Cedula = cedula;
            this.Email = email;
            this.Contraseña = contraseña;
            this.Genero = genero;
            this.Nacionalidad = nacionalidad;
            this.Fecha_de_nacimiento = fecha_de_nacimiento;
        }

        //Metodo insertar
        public string Insertar(Dusuarios Usuarios)
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
                sqlcmd.CommandText = "spinsertar_usuarios";
                sqlcmd.CommandType = CommandType.StoredProcedure;

                SqlParameter parId_usuarios = new SqlParameter();
                parId_usuarios.ParameterName = "@id_usuarios";
                parId_usuarios.SqlDbType = SqlDbType.Int;
                parId_usuarios.Direction = ParameterDirection.Output;
                sqlcmd.Parameters.Add(parId_usuarios);

                SqlParameter parid_rol = new SqlParameter();
                parid_rol.ParameterName = "@id_rol";
                parid_rol.SqlDbType = SqlDbType.Int;
                //parid_rol.Size = 50;
                parid_rol.Value = Usuarios.Id_rol;
                sqlcmd.Parameters.Add(parid_rol);

                SqlParameter parusuario = new SqlParameter();
                parusuario.ParameterName = "@usuario";
                parusuario.SqlDbType = SqlDbType.VarChar;
                parusuario.Size = 50;
                parusuario.Value = Usuarios.Usuario;
                sqlcmd.Parameters.Add(parusuario);

                SqlParameter parcontraseña = new SqlParameter();
                parcontraseña.ParameterName = "@contraseña";
                parcontraseña.SqlDbType = SqlDbType.VarChar;
                parcontraseña.Size = 50;
                parcontraseña.Value = Usuarios.Contraseña;
                sqlcmd.Parameters.Add(parcontraseña);

                SqlParameter parprimer_nombre = new SqlParameter();
                parprimer_nombre.ParameterName = "@primer_nombre";
                parprimer_nombre.SqlDbType = SqlDbType.VarChar;
                parprimer_nombre.Size = 50;
                parprimer_nombre.Value = Usuarios.Primer_nombre;
                sqlcmd.Parameters.Add(parprimer_nombre);

                SqlParameter parsegundo_nombre = new SqlParameter();
                parsegundo_nombre.ParameterName = "@segundo_nombre";
                parsegundo_nombre.SqlDbType = SqlDbType.VarChar;
                parsegundo_nombre.Size = 50;
                parsegundo_nombre.Value = Usuarios.Segundo_nombre;
                sqlcmd.Parameters.Add(parsegundo_nombre);

                SqlParameter parprimer_apellido = new SqlParameter();
                parprimer_apellido.ParameterName = "@primer_apellido";
                parprimer_apellido.SqlDbType = SqlDbType.VarChar;
                parprimer_apellido.Size = 50;
                parprimer_apellido.Value = Usuarios.Primer_apellido;
                sqlcmd.Parameters.Add(parprimer_apellido);

                SqlParameter parsegundo_apellido = new SqlParameter();
                parsegundo_apellido.ParameterName = "@segundo_apellido";
                parsegundo_apellido.SqlDbType = SqlDbType.VarChar;
                parsegundo_apellido.Size = 50;
                parsegundo_apellido.Value = Usuarios.Segundo_apellido;
                sqlcmd.Parameters.Add(parsegundo_apellido);

                SqlParameter pargenero = new SqlParameter();
                pargenero.ParameterName = "@genero";
                pargenero.SqlDbType = SqlDbType.VarChar;
                pargenero.Size = 50;
                pargenero.Value = Usuarios.Genero;
                sqlcmd.Parameters.Add(pargenero);

                SqlParameter parnacionalidad = new SqlParameter();
                parnacionalidad.ParameterName = "@nacionalidad";
                parnacionalidad.SqlDbType = SqlDbType.VarChar;
                parnacionalidad.Size = 50;
                parnacionalidad.Value = Usuarios.Nacionalidad;
                sqlcmd.Parameters.Add(parnacionalidad);

                SqlParameter parcedula = new SqlParameter();
                parcedula.ParameterName = "@cedula";
                parcedula.SqlDbType = SqlDbType.Int;
                //parid_rol.Size = 50;
                parcedula.Value = Usuarios.Cedula;
                sqlcmd.Parameters.Add(parcedula);

                SqlParameter paremail = new SqlParameter();
                paremail.ParameterName = "@email";
                paremail.SqlDbType = SqlDbType.VarChar;
                paremail.Size = 50;
                paremail.Value = Usuarios.Email;
                sqlcmd.Parameters.Add(paremail);

                SqlParameter parfecha_de_nacimiento = new SqlParameter();
                parfecha_de_nacimiento.ParameterName = "@fecha_de_nacimiento";
                parfecha_de_nacimiento.SqlDbType = SqlDbType.VarChar;
                parfecha_de_nacimiento.Size = 50;
                parfecha_de_nacimiento.Value = Usuarios.Fecha_de_nacimiento;
                sqlcmd.Parameters.Add(parfecha_de_nacimiento);

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
        public string Editar(Dusuarios Usuarios)
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
                sqlcmd.CommandText = "spinsertar_usuarios";
                sqlcmd.CommandType = CommandType.StoredProcedure;

                SqlParameter parId_usuarios = new SqlParameter();
                parId_usuarios.ParameterName = "@id_usuarios";
                parId_usuarios.SqlDbType = SqlDbType.Int;
                parId_usuarios.Direction = ParameterDirection.Output;
                sqlcmd.Parameters.Add(parId_usuarios);

                SqlParameter parid_rol = new SqlParameter();
                parid_rol.ParameterName = "@id_rol";
                parid_rol.SqlDbType = SqlDbType.Int;
                //parid_rol.Size = 50;
                parid_rol.Value = Usuarios.Id_rol;
                sqlcmd.Parameters.Add(parid_rol);

                SqlParameter parusuario = new SqlParameter();
                parusuario.ParameterName = "@usuario";
                parusuario.SqlDbType = SqlDbType.VarChar;
                parid_rol.Size = 50;
                parid_rol.Value = Usuarios.Usuario;
                sqlcmd.Parameters.Add(parusuario);

                SqlParameter parcontraseña = new SqlParameter();
                parcontraseña.ParameterName = "@contraseña";
                parcontraseña.SqlDbType = SqlDbType.VarChar;
                parcontraseña.Size = 50;
                parcontraseña.Value = Usuarios.Contraseña;
                sqlcmd.Parameters.Add(parcontraseña);

                SqlParameter parprimer_nombre = new SqlParameter();
                parprimer_nombre.ParameterName = "@primer_nombre";
                parprimer_nombre.SqlDbType = SqlDbType.VarChar;
                parprimer_nombre.Size = 50;
                parprimer_nombre.Value = Usuarios.Primer_nombre;
                sqlcmd.Parameters.Add(parprimer_nombre);

                SqlParameter parsegundo_nombre = new SqlParameter();
                parsegundo_nombre.ParameterName = "@segundo_nombre";
                parsegundo_nombre.SqlDbType = SqlDbType.VarChar;
                parsegundo_nombre.Size = 50;
                parsegundo_nombre.Value = Usuarios.Segundo_nombre;
                sqlcmd.Parameters.Add(parsegundo_nombre);

                SqlParameter parprimer_apellido = new SqlParameter();
                parprimer_apellido.ParameterName = "@primer_apellido";
                parprimer_apellido.SqlDbType = SqlDbType.VarChar;
                parprimer_apellido.Size = 50;
                parprimer_apellido.Value = Usuarios.Primer_apellido;
                sqlcmd.Parameters.Add(parprimer_apellido);

                SqlParameter parsegundo_apellido = new SqlParameter();
                parsegundo_apellido.ParameterName = "@segundo_apellido";
                parsegundo_apellido.SqlDbType = SqlDbType.VarChar;
                parsegundo_apellido.Size = 50;
                parsegundo_apellido.Value = Usuarios.Segundo_apellido;
                sqlcmd.Parameters.Add(parsegundo_apellido);

                SqlParameter pargenero = new SqlParameter();
                pargenero.ParameterName = "@genero";
                pargenero.SqlDbType = SqlDbType.VarChar;
                pargenero.Size = 50;
                pargenero.Value = Usuarios.Genero;
                sqlcmd.Parameters.Add(pargenero);

                SqlParameter parnacionalidad = new SqlParameter();
                parnacionalidad.ParameterName = "@nacionalidad";
                parnacionalidad.SqlDbType = SqlDbType.VarChar;
                parnacionalidad.Size = 50;
                parnacionalidad.Value = Usuarios.Nacionalidad;
                sqlcmd.Parameters.Add(parnacionalidad);

                SqlParameter parcedula = new SqlParameter();
                parcedula.ParameterName = "@cedula";
                parcedula.SqlDbType = SqlDbType.Int;
                //parid_rol.Size = 50;
                parcedula.Value = Usuarios.Cedula;
                sqlcmd.Parameters.Add(parcedula);

                SqlParameter paremail = new SqlParameter();
                paremail.ParameterName = "@email";
                paremail.SqlDbType = SqlDbType.VarChar;
                paremail.Size = 50;
                paremail.Value = Usuarios.Email;
                sqlcmd.Parameters.Add(paremail);

                SqlParameter parfecha_de_nacimiento = new SqlParameter();
                parfecha_de_nacimiento.ParameterName = "@fecha_de_nacimiento";
                parfecha_de_nacimiento.SqlDbType = SqlDbType.VarChar;
                parfecha_de_nacimiento.Size = 50;
                parfecha_de_nacimiento.Value = Usuarios.Fecha_de_nacimiento;
                sqlcmd.Parameters.Add(parfecha_de_nacimiento);

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
        public string Eliminar(Dusuarios Usuarios)
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
                sqlcmd.CommandText = "speliminar_usuarios";
                sqlcmd.CommandType = CommandType.StoredProcedure;

                SqlParameter parId_usuarios = new SqlParameter();
                parId_usuarios.ParameterName = "@id_usuarios";
                parId_usuarios.SqlDbType = SqlDbType.Int;
                parId_usuarios.Value = Usuarios.Id_usuarios;
                sqlcmd.Parameters.Add(parId_usuarios);

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
            DataTable dtresultado = new DataTable("usuarios");
            SqlConnection sqlcon = new SqlConnection();
            try
            {
                sqlcon.ConnectionString = Conexion.Cn;
                SqlCommand sqlcmd = new SqlCommand();
                sqlcmd.Connection = sqlcon;
                sqlcmd.CommandText = "spmostrar_usuarios";
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
        public DataTable Buscarnombre(Dusuarios Usuarios)
        {
            DataTable dtresultado = new DataTable("usuarios");
            SqlConnection sqlcon = new SqlConnection();
            try
            {
                sqlcon.ConnectionString = Conexion.Cn;
                SqlCommand sqlcmd = new SqlCommand();
                sqlcmd.Connection = sqlcon;
                sqlcmd.CommandText = "spbuscar_usuarios";
                sqlcmd.CommandType = CommandType.StoredProcedure;

                SqlParameter partextobuscar = new SqlParameter();
                partextobuscar.ParameterName = "@textobuscar";
                partextobuscar.SqlDbType = SqlDbType.VarChar;
                partextobuscar.Size = 50;
                partextobuscar.Value = Usuarios.Textobuscar;
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

        //Metodo login
        public DataTable Login(Dusuarios Usuarios)
        {
            DataTable dtresultado = new DataTable("usuarios");
            SqlConnection sqlcon = new SqlConnection();
            try
            {
                sqlcon.ConnectionString = Conexion.Cn;
                SqlCommand sqlcmd = new SqlCommand();
                sqlcmd.Connection = sqlcon;
                sqlcmd.CommandText = "splogin";
                sqlcmd.CommandType = CommandType.StoredProcedure;

                SqlParameter parusuario = new SqlParameter();
                parusuario.ParameterName = "@usuario";
                parusuario.SqlDbType = SqlDbType.VarChar;
                parusuario.Size = 50;
                parusuario.Value = Usuarios.Usuario;
                sqlcmd.Parameters.Add(parusuario);

                SqlParameter parpassword = new SqlParameter();
                parpassword.ParameterName = "@password";
                parpassword.SqlDbType = SqlDbType.VarChar;
                parpassword.Size = 50;
                parpassword.Value = Usuarios.Contraseña;
                sqlcmd.Parameters.Add(parpassword);

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
