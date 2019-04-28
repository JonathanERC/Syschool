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
    public partial class frmPrincipal : Form
    {
        private int childFormNumber = 0;
        public string Id_usuario = "";
        public string Id_rol = "";
        public string Primer_nombre = "";
        public string Primer_apellido = "";


        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "Window " + childFormNumber++;
            childForm.Show();
        }

        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void ToolBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStrip.Visible = toolBarToolStripMenuItem.Checked;
        }

        private void StatusBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            statusStrip.Visible = statusBarToolStripMenuItem.Checked;
        }

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void rolesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void asignaturasToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmLogin frm = new frmLogin();

            frm.Show();
            this.Close();
        }

        private void administradorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAdministrador frm = new frmAdministrador();
            frm.MdiParent = this;
            frm.Show();
        }

        private void profesorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmProfesores frm = new frmProfesores();
            frm.MdiParent = this;
            frm.Show();
        }

        private void estudianteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmEstudiantes frm = new frmEstudiantes();
            frm.MdiParent = this;
            frm.Show();
        }

        private void asignaturasToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmAsignaturas frm = new frmAsignaturas();
            frm.MdiParent = this;
            frm.Show();
        }

        private void detallesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDetallesasignaturas frm = new frmDetallesasignaturas();
            frm.MdiParent = this;
            frm.Show();
        }

        private void notasToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void asignatuasProfesorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAsignaturaprofesor frm = new frmAsignaturaprofesor();
            frm.MdiParent = this;
            frm.Show();
        }

        private void rolesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmRol frm = new frmRol();
            frm.MdiParent = this;
            frm.Show();
        }

        private void usuariosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmUsuario frm = new frmUsuario();
            frm.MdiParent = this;
            frm.Show();
        }

        private void cursosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmCursos frm = new frmCursos();
            frm.MdiParent = this;
            frm.Show();
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            GestionUsuario();
        }

        private void GestionUsuario()
        {
            //Control de accesos
            if (Id_rol=="1") //Administrador
            {
                this.mnuacademico.Enabled = true;
                this.mnuperfiles.Enabled = true;
                this.mnusistema.Enabled = true;
                this.mnuherramientas.Enabled = true;
                this.mnuventanas.Enabled = true;
                this.mnuver.Enabled = true;
            }
            else if (Id_rol == "2") //Profesor
            {
                this.mnuacademico.Enabled = true;
                this.mnuperfiles.Enabled = false;
                this.mnusistema.Enabled = false;
                this.mnuherramientas.Enabled = true;
                this.mnuventanas.Enabled = true;
                this.mnuver.Enabled = true;
            }
            else if (Id_rol == "3") //Estudiante
            {
                this.mnuacademico.Enabled = false;
                this.mnuperfiles.Enabled = false;
                this.mnusistema.Enabled = false;
                this.mnuherramientas.Enabled = true;
                this.mnuventanas.Enabled = true;
                this.mnuver.Enabled = true;
            }
            else
            {
                this.mnuacademico.Enabled = false;
                this.mnuperfiles.Enabled = false;
                this.mnusistema.Enabled = false;
                this.mnuherramientas.Enabled = false;
                this.mnuventanas.Enabled = false;
                this.mnuver.Enabled = false;
            }
        }
    }
}
