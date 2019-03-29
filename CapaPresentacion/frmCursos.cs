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
    public partial class frmCursos : Form
    {
        private bool Isnuevo = false;
        private bool Iseditar = false;

        public frmCursos()
        {
            InitializeComponent();
            this.ttmensaje.SetToolTip(this.txtnombre_curso, "Ingrese el Nombre del Curso");
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
            this.txtnombre_curso.Text = string.Empty;
            this.txtid_cursos.Text = string.Empty;
        }

        //Habilitar controles
        private void Habilitar(bool valor)
        {
            this.txtid_cursos.ReadOnly = !valor;
            this.txtnombre_curso.ReadOnly = !valor;
        }

        //habilitar botones
        private void Botones()
        {
            if(this.Isnuevo || this.Iseditar)
            {
                this.Habilitar(true);
                this.btnnuevo.Enabled = false;
                this.btnguardar.Enabled = true;
                this.btneditar.Enabled = false;
                this.btncancelar.Enabled = true;
            }
            else
            {
                this.Habilitar(false);
                this.btnnuevo.Enabled = true;
                this.btnguardar.Enabled = false;
                this.btneditar.Enabled = true;
                this.btncancelar.Enabled = false;
            }
        }

        //Ocultar columnas
        private void Ocultarcolumnas()
        {
            this.datalistado.Columns[0].Visible = false;
            this.datalistado.Columns[1].Visible = false;
        }

        //Mostrar mostrar
        private void Mostrar()
        {
            this.datalistado.DataSource = Ncursos.Mostrar();
            this.Ocultarcolumnas();
            lbltotal.Text = "Total de Cursos: " + Convert.ToString(datalistado.RowCount);
        }

        //Buscar nombre
        private void Buscarnombre()
        {
            this.datalistado.DataSource = Ncursos.Buscarnombre(this.txtbuscar.Text);
            this.Ocultarcolumnas();
            lbltotal.Text = "Total de Cursos: " + Convert.ToString(datalistado.RowCount);
        }

        private void frmCursos_Load(object sender, EventArgs e)
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

        private void datalistado_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex==datalistado.Columns["Eliminar"].Index)
            {
                DataGridViewCheckBoxCell chkeliminar = (DataGridViewCheckBoxCell)datalistado.Rows[e.RowIndex].Cells["Eliminar"];
                chkeliminar.Value = !Convert.ToBoolean(chkeliminar.Value);
            }
        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            this.Buscarnombre();
        }

        private void txtbuscar_TextChanged(object sender, EventArgs e)
        {
            this.Buscarnombre();
        }

        private void btnnuevo_Click(object sender, EventArgs e)
        {
            this.Isnuevo = true;
            this.Iseditar = false;
            this.Botones();
            this.Limpiar();
            this.Habilitar(true);
            this.txtnombre_curso.Focus();
        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            try
            {
                string rpta = "";
                if (this.txtnombre_curso.Text == string.Empty)
                {
                    Mensajeerror("Verifique que los datos marcados esten completos.");
                    erroricono.SetError(txtnombre_curso, "Ingrese el Nombre del Curso");
                }
                else
                {
                    if (this.Isnuevo)
                    {
                        rpta = Ncursos.Insertar(this.txtnombre_curso.Text.Trim());
                    }
                    else
                    {
                        rpta = Ncursos.Editar(Convert.ToInt32(this.txtid_cursos.Text), this.txtnombre_curso.Text.Trim().ToUpper());
                    }

                    if (rpta.Equals("Ok"))
                    {
                        if (this.Isnuevo)
                        {
                            this.Mensajeok("Se ha insertado un Curso.");
                        }
                        else
                        {
                            this.Mensajeok("Se ha actualizado un Curso.");
                        }
                    }
                    else
                    {
                        this.Mensajeerror(rpta);
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

        private void datalistado_DoubleClick(object sender, EventArgs e)
        {
            this.txtid_cursos.Text = Convert.ToString(this.datalistado.CurrentRow.Cells["id_curso"].Value);
            this.txtnombre_curso.Text = Convert.ToString(this.datalistado.CurrentRow.Cells["nombre_curso"].Value);

            this.tabControl1.SelectedIndex = 1;
        }

        private void btneditar_Click(object sender, EventArgs e)
        {
            if (!this.txtid_cursos.Text.Equals(""))
            {
                this.Iseditar = true;
                this.Botones();
                this.Habilitar(true);
            }
            else
            {
                this.Mensajeerror("Por favor seleccionar el Curso a Modificar");
            }
        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            this.Isnuevo = false;
            this.Iseditar = false;
            this.Botones();
            this.Limpiar();
            this.Habilitar(false);
        }

        private void chkeliminar_CheckedChanged(object sender, EventArgs e)
        {
            if (chkeliminar.Checked)
            {
                this.datalistado.Columns[0].Visible = true;
            }
            else
            {
                this.datalistado.Columns[0].Visible = false;
            }
        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult Opcion;
                Opcion = MessageBox.Show("¿Desea eliminar el Curso seleccionado?", "SYSCHOOL", MessageBoxButtons.OKCancel,MessageBoxIcon.Question);
                if (Opcion == DialogResult.OK)
                {
                    String codigo;
                    string rpta = "";

                    foreach (DataGridViewRow row in datalistado.Rows)
                    {
                        if (Convert.ToBoolean(row.Cells[0].Value))
                        {
                            codigo = Convert.ToString(row.Cells[1].Value);
                            rpta = Ncursos.Eliminar(Convert.ToInt32(codigo));

                            if (rpta.Equals("Ok"))
                            {
                                this.Mensajeok("Se ha eliminado el curso");
                            }
                            else
                            {
                                this.Mensajeerror(rpta);
                            }
                        }
                    }
                    this.Mostrar();
                    this.chkeliminar.Checked = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }
    }
}
