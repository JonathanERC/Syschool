using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
            lblHora.Text = DateTime.Now.ToString();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblHora.Text = DateTime.Now.ToString();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            DataTable Datos = CapaNegocio.Nusuarios.Login(this.txtusuario.Text, this.txtcontraseña.Text);
            //Evaluar si existe el usuario
            if (Datos.Rows.Count == 0)
            {
                MessageBox.Show("No Tiene Acceso al Sistema", "SYSCHOOL", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                frmPrincipal frm = new frmPrincipal();
                frm.Id_usuario = Datos.Rows[0][0].ToString();
                frm.Id_rol = Datos.Rows[0][1].ToString();
                frm.Primer_nombre = Datos.Rows[0][2].ToString();
                frm.Primer_apellido = Datos.Rows[0][3].ToString();

                frm.Show();
                this.Hide();
            }
        }
    }
}
