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
    public partial class frmProfesores : Form
    {
        private bool IsNuevo = false;

        private bool IsEditar = false;

        public frmProfesores()
        {
            InitializeComponent();
            this.ttMensaje.SetToolTip(this.txtidusuario, "Ingrese el Nombre del Profesor");
        }

        //Mostrar Mensaje de Confirmación

        private void MensajeOk(string mensaje)
        {
            MessageBox.Show(mensaje, "SYSCHOOL", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        //Mostrar Mensaje de Error  

        private void MensajeError(string mensaje)
        {
            MessageBox.Show(mensaje, "SYSCHOOL", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        //Limpiar controles
        private void Limpiar()
        {
            this.txtCodigo.Text = string.Empty;
            this.txtidusuario.Text = string.Empty;
        }

        //Habilitar controles
        private void Habilitar(bool valor)
        {
            this.txtCodigo.ReadOnly = !valor;
            this.txtidusuario.ReadOnly = !valor;
        }

        //habilitar botones
        private void Botones()
        {
            if (this.IsNuevo || this.IsEditar)
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

        //Ocultar columnas
        private void Ocultarcolumnas()
        {
            this.dataListado.Columns[0].Visible = false;
            this.dataListado.Columns[1].Visible = false;
        }

        //Mostrar mostrar
        private void Mostrar()
        {
            this.dataListado.DataSource = Nprofesores.Mostrar();
            this.Ocultarcolumnas();
            lblTotal.Text = "Total de Profesores: " + Convert.ToString(dataListado.RowCount);
        }

        //Buscar nombre
        private void BuscarNombre()
        {
            this.dataListado.DataSource = Nprofesores.Buscarnombre(this.txtBuscar.Text);
            this.Ocultarcolumnas();
            lblTotal.Text = "Total de Profesores: " + Convert.ToString(dataListado.RowCount);
        }

        private void frmProfesores_Load(object sender, EventArgs e)
        {
            this.Top = 0;
            this.Left = 0;

            this.Mostrar();
            this.Habilitar(false);
            this.Botones();
        }

        private void datalistado_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataListado.Columns["Eliminar"].Index)
            {
                DataGridViewCheckBoxCell chkeliminar = (DataGridViewCheckBoxCell)dataListado.Rows[e.RowIndex].Cells["Eliminar"];
                chkeliminar.Value = !Convert.ToBoolean(chkeliminar.Value);
            }

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

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult Opcion;
                Opcion = MessageBox.Show("¿Desea eliminar el Profesor seleccionado?", "SYSCHOOL", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (Opcion == DialogResult.OK)
                {
                    String codigo;
                    string rpta = "";

                    foreach (DataGridViewRow row in dataListado.Rows)
                    {
                        if (Convert.ToBoolean(row.Cells[0].Value))
                        {
                            codigo = Convert.ToString(row.Cells[1].Value);
                            rpta = Nprofesores.Eliminar(Convert.ToInt32(codigo));

                            if (rpta.Equals("OK"))
                            {
                                this.MensajeOk("Se ha eliminado el Profesor");
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

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            this.BuscarNombre();
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            this.BuscarNombre();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            this.IsNuevo = true;
            this.IsEditar = false;
            this.Botones();
            this.Limpiar();
            this.Habilitar(true);
            this.txtidusuario.Focus();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            this.IsEditar = true;
            this.Botones();
            this.Habilitar(true);
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                string rpta = "";
                if (this.txtidusuario.Text == string.Empty)
                {
                    MensajeError("Verifique que los datos marcados esten completos.");
                    errorIcono.SetError(txtidusuario, "Ingrese el Nombre del Profesor");
                }
                else
                {
                    if (this.IsNuevo)
                    {
                        rpta = Nprofesores.Insertar(Convert.ToInt32(this.txtidusuario.Text));
                    }
                    else
                    {
                        rpta = Nprofesores.Editar(Convert.ToInt32(this.txtCodigo.Text), Convert.ToInt32(this.txtidusuario.Text));
                    }

                    if (rpta.Equals("OK"))
                    {
                        if (this.IsNuevo)
                        {
                            this.MensajeOk("Se ha insertado un Profesor.");
                        }
                        else
                        {
                            this.MensajeOk("Se ha actualizado un Profesor.");
                        }
                    }
                    else
                    {
                        this.MensajeError(rpta);
                    }
                    this.IsNuevo = false;
                    this.IsEditar = false;
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

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.IsNuevo = false;
            this.IsEditar = false;
            this.Botones();
            this.Limpiar();
            this.Habilitar(false);
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }

}

