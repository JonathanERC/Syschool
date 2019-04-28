using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using CapaNegocio;



namespace CapaPresentacion
{
    public partial class frmUsuario : Form
    {
        private bool Isnuevo = false;
        private bool Iseditar = false;

        public frmUsuario()
        {
            InitializeComponent();
            this.ttMensaje.SetToolTip(this.txtPrimerNombre, "Ingrese el nombre del Usuario");
        }

        //Mostrar Mensaje de Confirmacion
        private void MensajeOk(string mensaje)
        {
            MessageBox.Show(mensaje, "SYSCHOOL", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        //Mostrar Mensaje de Error
        private void MensajeError(string mensaje)
        {

            MessageBox.Show(mensaje, "SYSCHOOL", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        //Limpiar Controles
        private void Limpiar()
        {
            this.txtCodigo.Text = string.Empty;
            this.txtRol.Text = string.Empty;
            this.txtUsuario.Text = string.Empty;
            this.txtContrasena.Text = string.Empty;
            this.txtPrimerNombre.Text = string.Empty;
            this.txtPrimerApellido.Text = string.Empty;
            this.txtGenero.Text = string.Empty;
            this.txtNacionalidad.Text = string.Empty;
            this.txtEmail.Text = string.Empty;
            this.txtCedula.Text = string.Empty;
            this.txtFechadeNacimiento.Text = string.Empty;
            this.txtSegundoNombre.Text = string.Empty;
            this.txtSegundoApellido.Text = string.Empty;
        }

        //habilitar controles del formulario
        private void Habilitar(bool valor)
        {
            this.txtCodigo.ReadOnly = !valor;
            this.txtRol.ReadOnly = !valor;
            this.txtUsuario.ReadOnly = !valor;
            this.txtContrasena.ReadOnly = !valor;
            this.txtPrimerNombre.ReadOnly = !valor;
            this.txtCedula.ReadOnly = !valor;
            this.txtPrimerApellido.ReadOnly = !valor;
            this.txtEmail.ReadOnly = !valor;
            this.txtGenero.ReadOnly = !valor;
            this.txtSegundoNombre.ReadOnly = !valor;
            this.txtSegundoApellido.ReadOnly = !valor;
        }


        //habilitar botones
        private void Botones()
        {
            if (this.Isnuevo || this.Iseditar)
            {
                this.Habilitar(true);
                this.btnNuevo.Enabled = false;
                this.btnGuardar.Enabled = true;
                this.btnEditar.Enabled = false;
                this.btnCancelar.Enabled = true;
            }
            else
            {
                this.Habilitar(false);
                this.btnNuevo.Enabled = true;
                this.btnGuardar.Enabled = false;
                this.btnEditar.Enabled = true;
                this.btnCancelar.Enabled = false;
            }
        }

        //Ocultar para ocultar columnas
        private void OcultarColumnas()
        {
            this.dataListado.Columns[0].Visible = false;
            this.dataListado.Columns[1].Visible = false;

        }
        //Metodo Mostrar
        private void Mostrar()
        {
            this.dataListado.DataSource = Nusuarios.Mostrar();
            this.OcultarColumnas();
            lblTotal.Text = "Total de Usuarios: " + Convert.ToString(dataListado.RowCount);

        }
        //Buscar por el nombre
        private void BuscarNOmbre()
        {
            this.dataListado.DataSource = Nusuarios.Buscarnombre(this.textBuscar.Text);
            this.OcultarColumnas();
            lblTotal.Text = "Total de Usuarios: " + Convert.ToString(dataListado.RowCount);

        }



        private void FrmUsuario_Load(object sender, EventArgs e)
        {
            this.Top = 0;
            this.Left = 0;
            this.Mostrar();
            this.Habilitar(false);
            this.Botones();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void lblTotal_Click(object sender, EventArgs e)
        {

        }

        private void chkEliminar_CheckedChanged(object sender, EventArgs e)
        {
            if (chkEliminar.Checked)
            {
                this.dataListado.Columns[0].Visible = true;
            }
            else
            {
                this.dataListado.Columns[0].Visible = false;
            }
        }

        private void dataListado_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataListado.Columns["Eliminar"].Index)
            {
                DataGridViewCheckBoxCell chkEliminar = (DataGridViewCheckBoxCell)dataListado.Rows[e.RowIndex].Cells["Eliminar"];
                chkEliminar.Value = !Convert.ToBoolean(chkEliminar.Value);
            }
        }

        private void lblFechadenacimiento_Click(object sender, EventArgs e)
        {

        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            this.Isnuevo = true;
            this.Iseditar = false;
            this.Botones();
            this.Limpiar();
            this.Habilitar(true);
            this.txtRol.Focus();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            this.BuscarNOmbre();

        }

        private void textBuscar_TextChanged(object sender, EventArgs e)
        {
            this.BuscarNOmbre();

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                string rpta = "";
                if (this.txtRol.Text == string.Empty || this.txtUsuario.Text == string.Empty || this.txtContrasena.Text == string.Empty || this.txtPrimerNombre.Text == string.Empty || this.txtPrimerApellido.Text == string.Empty || this.txtGenero.Text == string.Empty || this.txtNacionalidad.Text == string.Empty || this.txtFechadeNacimiento.Text == string.Empty)
                {
                    MensajeError("Verifique que los datos marcados esten completos.");
                    errorecono.SetError(txtRol, "Complete el Campo");
                    errorecono.SetError(txtUsuario, "Complete el Campo");
                    errorecono.SetError(txtContrasena, "Complete el Campo");
                    errorecono.SetError(txtPrimerNombre, "Complete el Campo");
                    errorecono.SetError(txtPrimerApellido, "Complete el Campo");
                    errorecono.SetError(txtGenero, "Complete el Campo");
                    errorecono.SetError(txtNacionalidad, "Complete el Campo");
                    errorecono.SetError(txtFechadeNacimiento, "Complete el Campo");
                }
                else
                {
                    if (this.Isnuevo)
                    {
                        rpta = Nusuarios.Insertar((Convert.ToInt32(this.txtRol.Text)), (this.txtUsuario.Text.Trim()), (this.txtContrasena.Text.Trim()), (this.txtPrimerNombre.Text.Trim()), (this.txtSegundoNombre.Text.Trim()), (this.txtPrimerApellido.Text.Trim()), (this.txtSegundoApellido.Text.Trim()), (this.txtGenero.Text.Trim()), (this.txtNacionalidad.Text.Trim()), (this.txtEmail.Text.Trim()), (Convert.ToInt32(this.txtCedula.Text)), (Convert.ToDateTime(this.txtFechadeNacimiento.Text)));
                    }
                    else
                    {
                        rpta = Nusuarios.Editar((Convert.ToInt32(this.txtCodigo.Text)), (Convert.ToInt32(this.txtRol.Text)), (this.txtUsuario.Text.Trim()), (this.txtContrasena.Text.Trim()), (this.txtPrimerNombre.Text.Trim()), (this.txtSegundoNombre.Text.Trim()), (this.txtPrimerApellido.Text.Trim()), (this.txtSegundoApellido.Text.Trim()), (this.txtGenero.Text.Trim()), (this.txtNacionalidad.Text.Trim()), (this.txtEmail.Text.Trim()), (Convert.ToInt32(this.txtCedula.Text)), (Convert.ToDateTime(this.txtFechadeNacimiento.Text)));
                    }

                    if (rpta.Equals("Ok"))
                    {
                        if (this.Isnuevo)
                        {
                            this.MensajeOk("Se ha insertado un Usuario.");
                        }
                        else
                        {
                            this.MensajeOk("Se ha actualizado un Usuario.");
                        }
                    }
                    else
                    {
                        this.MensajeError(rpta);
                    }
                    this.Isnuevo = false;
                    this.Iseditar = false;
                    this.Botones();
                    this.Limpiar();
                    this.Mostrar();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult Opcion;
                Opcion = MessageBox.Show("¿Desea eliminar el Curso seleccionado?", "SYSCHOOL", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (Opcion == DialogResult.OK)
                {
                    String codigo;
                    string rpta = "";

                    foreach (DataGridViewRow row in dataListado.Rows)
                    {
                        if (Convert.ToBoolean(row.Cells[0].Value))
                        {
                            codigo = Convert.ToString(row.Cells[1].Value);
                            rpta = Nusuarios.Eliminar(Convert.ToInt32(codigo));

                            if (rpta.Equals("Ok"))
                            {
                                this.MensajeOk("Se ha eliminado el curso");
                            }
                            else
                            {
                                this.MensajeError(rpta);
                            }
                        }
                    }
                    this.Mostrar();
                    this.chkEliminar.Checked = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void dataListado_DoubleClick(object sender, EventArgs e)
        {
            this.txtCodigo.Text = Convert.ToString(this.dataListado.CurrentRow.Cells["id_usuarios"].Value);
            this.txtRol.Text = Convert.ToString(this.dataListado.CurrentRow.Cells["id_rol"].Value);
            this.txtUsuario.Text = Convert.ToString(this.dataListado.CurrentRow.Cells["usuario"].Value);
            this.txtContrasena.Text = Convert.ToString(this.dataListado.CurrentRow.Cells["contraseña"].Value);
            this.txtPrimerNombre.Text = Convert.ToString(this.dataListado.CurrentRow.Cells["primer_nombre"].Value);
            this.txtSegundoNombre.Text = Convert.ToString(this.dataListado.CurrentRow.Cells["segundo_nombre"].Value);
            this.txtCedula.Text = Convert.ToString(this.dataListado.CurrentRow.Cells["cedula"].Value);
            this.txtEmail.Text = Convert.ToString(this.dataListado.CurrentRow.Cells["email"].Value);
            this.txtPrimerApellido.Text = Convert.ToString(this.dataListado.CurrentRow.Cells["primer_apellido"].Value);
            this.txtSegundoApellido.Text = Convert.ToString(this.dataListado.CurrentRow.Cells["segundo_apellido"].Value);
            this.txtGenero.Text = Convert.ToString(this.dataListado.CurrentRow.Cells["genero"].Value);
            this.txtNacionalidad.Text = Convert.ToString(this.dataListado.CurrentRow.Cells["nacionalidad"].Value);
            this.txtFechadeNacimiento.Text = Convert.ToString(this.dataListado.CurrentRow.Cells["fecha_de_nacimiento"].Value);

            this.tabControl1.SelectedIndex = 1;
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (!this.txtCodigo.Text.Equals(""))
            {
                this.Iseditar = true;
                this.Botones();
                this.Habilitar(true);
            }
            else
            {
                this.MensajeError("Por favor seleccionar el Usuario a Modificar");
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Isnuevo = false;
            this.Iseditar = false;
            this.Botones();
            this.Limpiar();
            this.Habilitar(false);
        }
    }
    }

