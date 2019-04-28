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
    public partial class FrmNotasAsignaturas : Form
    {
        private bool IsNuevo = false;
        private bool IsEditar = false;

        public FrmNotasAsignaturas()
        {
            InitializeComponent();
             this.ttMensaje.SetToolTip(this.txtBuscar, "Ingrese el Nombre el ID del Estudiante");
        }
        
        //Mensaje de confirmacion
        private void Mensajeok(string mensaje)
        {
            MessageBox.Show(mensaje, "SYSCHOOL", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        //Mensaje de error
        private void Mensajeerror(string mensaje)
        {
            MessageBox.Show(mensaje, "SYSCHOOL", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        //Limpiar controles
        private void Limpiar()
        {
            this.txtCodigoNotasAsignaturas.Text = string.Empty;
            this.txtCodigodeAsignatura.Text = string.Empty;
            this.txtBuscar.Text = string.Empty;
            this.txtIddelEstudiante.Text = string.Empty;
            this.txtNotaPrimerMes.Text = string.Empty;
            this.txtNotaSegundoMes.Text = string.Empty;
            this.txtNotaTercerMes.Text = string.Empty;
            this.txtNotaCuartoMes.Text = string.Empty;
            this.txtPeriodo.Text = string.Empty;
            this.txtAno.Text = string.Empty;
        }

        //Habilitar controles
        private void Habilitar(bool valor)
        {
            this.txtCodigoNotasAsignaturas.ReadOnly = !valor;
            this.txtCodigodeAsignatura.ReadOnly = !valor;
            this.txtBuscar.ReadOnly = !valor;
            this.txtIddelEstudiante.ReadOnly = !valor;
            this.txtNotaPrimerMes.ReadOnly = !valor;
            this.txtNotaSegundoMes.ReadOnly = !valor;
            this.txtNotaTercerMes.ReadOnly = !valor;
            this.txtNotaCuartoMes.ReadOnly = !valor;
            this.txtPeriodo.ReadOnly = !valor;
            this.txtAno.ReadOnly = !valor;
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
            this.dataListado.DataSource = Nnotasasignaturas.Mostrar();
            this.Ocultarcolumnas();
            lblTotal.Text = " Notas de Estudiantes: " + Convert.ToString(dataListado.RowCount);
        }

        //Buscar nombre
        private void Buscarnombre()
        {
            this.dataListado.DataSource = Nnotasasignaturas.Buscarnombre(this.txtBuscar.Text);
            this.Ocultarcolumnas();
            lblTotal.Text = " Notas de Estudiantes: " + Convert.ToString(dataListado.RowCount);
        }
        private void label2_Click(object sender, EventArgs e)
        {
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void FrmNotasAsignaturas_Load(object sender, EventArgs e)
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
        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            this.Buscarnombre();
        }

        private void btnBuscarEstudiante_Click(object sender, EventArgs e)
        {
            this.Buscarnombre();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            this.IsNuevo = true;
            this.IsEditar = false;
            this.Botones();
            this.Limpiar();
            this.Habilitar(true);
            this.txtCodigoNotasAsignaturas.Focus();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                string rpta = "";
                if (this.txtCodigoNotasAsignaturas.Text == string.Empty)
                {
                    Mensajeerror("Verifique que los datos marcados esten completos.");
                    errorIcono.SetError(txtCodigoNotasAsignaturas, "Ingrese la Calificación");
                }
                else
                {
                    if (this.IsNuevo)
                    {
                        rpta = Nnotasasignaturas.Insertar(Convert.ToInt32(this.txtIddelEstudiante.Text), Convert.ToInt32(this.txtCodigodeAsignatura.Text), Convert.ToInt32(this.txtNotaPrimerMes.Text), Convert.ToInt32(this.txtNotaSegundoMes.Text),
                            Convert.ToInt32(this.txtNotaTercerMes.Text), Convert.ToInt32(this.txtNotaCuartoMes.Text), Convert.ToInt32(this.txtPeriodo.Text), Convert.ToInt32(this.txtAno.Text));
                    }
                    else
                    {
                        rpta = Nnotasasignaturas.Editar(Convert.ToInt32(this.txtCodigoNotasAsignaturas.Text), Convert.ToInt32(this.txtIddelEstudiante.Text), Convert.ToInt32(this.txtCodigodeAsignatura.Text),
                            Convert.ToInt32(this.txtNotaPrimerMes.Text), Convert.ToInt32(this.txtNotaSegundoMes.Text), Convert.ToInt32(this.txtNotaTercerMes.Text),
                            Convert.ToInt32(this.txtNotaCuartoMes.Text), Convert.ToInt32(this.txtPeriodo.Text), Convert.ToInt32(this.txtAno.Text));
                    }

                    if (rpta.Equals("Ok"))
                    {
                        if (this.IsNuevo)
                        {
                            this.Mensajeok("Se ha insertado una Calificación.");
                        }
                        else
                        {
                            this.Mensajeok("Se ha actualizado una Calificación.");
                        }
                    }
                    else
                    {
                        this.Mensajeerror(rpta);
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
        private void datalistado_DoubleClick(object sender, EventArgs e)
        {
            this.txtCodigoNotasAsignaturas.Text = Convert.ToString(this.dataListado.CurrentRow.Cells["CodigoNotasAsignaturas"].Value);
            this.txtIddelEstudiante.Text = Convert.ToString(this.dataListado.CurrentRow.Cells["IddelEstudiante"].Value);

            this.tabControl1.SelectedIndex = 1;
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (!this.txtIddelEstudiante.Text.Equals(""))
            {
                this.IsEditar = true;
                this.Botones();
                this.Habilitar(true);
            }
            else
            {
                this.Mensajeerror("Por favor seleccionar la Calificación a Modificar");
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

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
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
                            rpta = Ncursos.Eliminar(Convert.ToInt32(codigo));

                            if (rpta.Equals("Ok"))
                            {
                                this.Mensajeok("Se ha eliminado la Calificación");
                            }
                            else
                            {
                                this.Mensajeerror(rpta);
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

    }
}
