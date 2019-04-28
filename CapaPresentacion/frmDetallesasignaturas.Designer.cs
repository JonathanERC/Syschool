namespace CapaPresentacion
{
    partial class frmDetallesasignaturas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.datalistado = new System.Windows.Forms.DataGridView();
            this.Eliminar = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.lbltotal = new System.Windows.Forms.Label();
            this.chkeliminar = new System.Windows.Forms.CheckBox();
            this.btneliminar = new System.Windows.Forms.Button();
            this.btnbuscar = new System.Windows.Forms.Button();
            this.txtbuscar = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btncancelar = new System.Windows.Forms.Button();
            this.btneditar = new System.Windows.Forms.Button();
            this.btnguardar = new System.Windows.Forms.Button();
            this.btnnuevo = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tp_hora_fin = new System.Windows.Forms.DateTimePicker();
            this.tp_hora_inicio = new System.Windows.Forms.DateTimePicker();
            this.txtid_curso = new System.Windows.Forms.TextBox();
            this.txtid_asignatura = new System.Windows.Forms.TextBox();
            this.txtid_detallesasignaturas = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.erroricono = new System.Windows.Forms.ErrorProvider(this.components);
            this.ttmensaje = new System.Windows.Forms.ToolTip(this.components);
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datalistado)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.erroricono)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(4, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(277, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Detalles de la Asignatura";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(1, 1);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(506, 305);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.datalistado);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.lbltotal);
            this.tabPage1.Controls.Add(this.chkeliminar);
            this.tabPage1.Controls.Add(this.btneliminar);
            this.tabPage1.Controls.Add(this.btnbuscar);
            this.tabPage1.Controls.Add(this.txtbuscar);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage1.Size = new System.Drawing.Size(498, 279);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Listado";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // datalistado
            // 
            this.datalistado.AllowUserToAddRows = false;
            this.datalistado.AllowUserToDeleteRows = false;
            this.datalistado.AllowUserToOrderColumns = true;
            this.datalistado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datalistado.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Eliminar});
            this.datalistado.Location = new System.Drawing.Point(4, 125);
            this.datalistado.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.datalistado.MultiSelect = false;
            this.datalistado.Name = "datalistado";
            this.datalistado.ReadOnly = true;
            this.datalistado.RowTemplate.Height = 24;
            this.datalistado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.datalistado.Size = new System.Drawing.Size(491, 152);
            this.datalistado.TabIndex = 5;
            this.datalistado.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.datalistado_CellContentClick);
            this.datalistado.DoubleClick += new System.EventHandler(this.datalistado_DoubleClick);
            // 
            // Eliminar
            // 
            this.Eliminar.HeaderText = "Eliminar";
            this.Eliminar.Name = "Eliminar";
            this.Eliminar.ReadOnly = true;
            // 
            // lbltotal
            // 
            this.lbltotal.AutoSize = true;
            this.lbltotal.Location = new System.Drawing.Point(353, 99);
            this.lbltotal.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbltotal.Name = "lbltotal";
            this.lbltotal.Size = new System.Drawing.Size(91, 13);
            this.lbltotal.TabIndex = 4;
            this.lbltotal.Text = "Total de registros:";
            // 
            // chkeliminar
            // 
            this.chkeliminar.AutoSize = true;
            this.chkeliminar.Location = new System.Drawing.Point(9, 95);
            this.chkeliminar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.chkeliminar.Name = "chkeliminar";
            this.chkeliminar.Size = new System.Drawing.Size(62, 17);
            this.chkeliminar.TabIndex = 3;
            this.chkeliminar.Text = "Eliminar";
            this.chkeliminar.UseVisualStyleBackColor = true;
            this.chkeliminar.CheckedChanged += new System.EventHandler(this.chkeliminar_CheckedChanged);
            // 
            // btneliminar
            // 
            this.btneliminar.Location = new System.Drawing.Point(75, 90);
            this.btneliminar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btneliminar.Name = "btneliminar";
            this.btneliminar.Size = new System.Drawing.Size(63, 22);
            this.btneliminar.TabIndex = 2;
            this.btneliminar.Text = "Eliminar";
            this.btneliminar.UseVisualStyleBackColor = true;
            this.btneliminar.Click += new System.EventHandler(this.btneliminar_Click);
            // 
            // btnbuscar
            // 
            this.btnbuscar.Location = new System.Drawing.Point(257, 57);
            this.btnbuscar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnbuscar.Name = "btnbuscar";
            this.btnbuscar.Size = new System.Drawing.Size(120, 22);
            this.btnbuscar.TabIndex = 2;
            this.btnbuscar.Text = "Buscar";
            this.btnbuscar.UseVisualStyleBackColor = true;
            this.btnbuscar.Click += new System.EventHandler(this.btnbuscar_Click);
            // 
            // txtbuscar
            // 
            this.txtbuscar.Location = new System.Drawing.Point(133, 57);
            this.txtbuscar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtbuscar.Name = "txtbuscar";
            this.txtbuscar.Size = new System.Drawing.Size(120, 20);
            this.txtbuscar.TabIndex = 1;
            this.txtbuscar.TextChanged += new System.EventHandler(this.txtbuscar_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 63);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Código de la Asignatura:";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox2);
            this.tabPage2.Controls.Add(this.groupBox1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage2.Size = new System.Drawing.Size(498, 279);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Mantenimiento";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btncancelar);
            this.groupBox2.Controls.Add(this.btneditar);
            this.groupBox2.Controls.Add(this.btnguardar);
            this.groupBox2.Controls.Add(this.btnnuevo);
            this.groupBox2.Location = new System.Drawing.Point(4, 179);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(494, 100);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Controles";
            // 
            // btncancelar
            // 
            this.btncancelar.Location = new System.Drawing.Point(325, 27);
            this.btncancelar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.Size = new System.Drawing.Size(63, 56);
            this.btncancelar.TabIndex = 0;
            this.btncancelar.Text = "Cancelar";
            this.btncancelar.UseVisualStyleBackColor = true;
            this.btncancelar.Click += new System.EventHandler(this.btncancelar_Click);
            // 
            // btneditar
            // 
            this.btneditar.Location = new System.Drawing.Point(172, 27);
            this.btneditar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btneditar.Name = "btneditar";
            this.btneditar.Size = new System.Drawing.Size(63, 56);
            this.btneditar.TabIndex = 0;
            this.btneditar.Text = "Editar";
            this.btneditar.UseVisualStyleBackColor = true;
            this.btneditar.Click += new System.EventHandler(this.btneditar_Click);
            // 
            // btnguardar
            // 
            this.btnguardar.Location = new System.Drawing.Point(248, 27);
            this.btnguardar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnguardar.Name = "btnguardar";
            this.btnguardar.Size = new System.Drawing.Size(63, 56);
            this.btnguardar.TabIndex = 0;
            this.btnguardar.Text = "Guardar";
            this.btnguardar.UseVisualStyleBackColor = true;
            this.btnguardar.Click += new System.EventHandler(this.btnguardar_Click);
            // 
            // btnnuevo
            // 
            this.btnnuevo.Location = new System.Drawing.Point(96, 27);
            this.btnnuevo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnnuevo.Name = "btnnuevo";
            this.btnnuevo.Size = new System.Drawing.Size(63, 56);
            this.btnnuevo.TabIndex = 0;
            this.btnnuevo.Text = "Nuevo";
            this.btnnuevo.UseVisualStyleBackColor = true;
            this.btnnuevo.Click += new System.EventHandler(this.btnnuevo_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tp_hora_fin);
            this.groupBox1.Controls.Add(this.tp_hora_inicio);
            this.groupBox1.Controls.Add(this.txtid_curso);
            this.groupBox1.Controls.Add(this.txtid_asignatura);
            this.groupBox1.Controls.Add(this.txtid_detallesasignaturas);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(2, 6);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(496, 167);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Detalles de la Asignatura";
            // 
            // tp_hora_fin
            // 
            this.tp_hora_fin.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.tp_hora_fin.Location = new System.Drawing.Point(326, 109);
            this.tp_hora_fin.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tp_hora_fin.Name = "tp_hora_fin";
            this.tp_hora_fin.ShowUpDown = true;
            this.tp_hora_fin.Size = new System.Drawing.Size(92, 20);
            this.tp_hora_fin.TabIndex = 4;
            this.tp_hora_fin.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // tp_hora_inicio
            // 
            this.tp_hora_inicio.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.tp_hora_inicio.Location = new System.Drawing.Point(326, 76);
            this.tp_hora_inicio.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tp_hora_inicio.Name = "tp_hora_inicio";
            this.tp_hora_inicio.ShowUpDown = true;
            this.tp_hora_inicio.Size = new System.Drawing.Size(92, 20);
            this.tp_hora_inicio.TabIndex = 4;
            this.tp_hora_inicio.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // txtid_curso
            // 
            this.txtid_curso.Location = new System.Drawing.Point(143, 110);
            this.txtid_curso.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtid_curso.Name = "txtid_curso";
            this.txtid_curso.Size = new System.Drawing.Size(94, 20);
            this.txtid_curso.TabIndex = 2;
            // 
            // txtid_asignatura
            // 
            this.txtid_asignatura.Location = new System.Drawing.Point(143, 77);
            this.txtid_asignatura.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtid_asignatura.Name = "txtid_asignatura";
            this.txtid_asignatura.Size = new System.Drawing.Size(94, 20);
            this.txtid_asignatura.TabIndex = 2;
            // 
            // txtid_detallesasignaturas
            // 
            this.txtid_detallesasignaturas.Location = new System.Drawing.Point(143, 47);
            this.txtid_detallesasignaturas.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtid_detallesasignaturas.Name = "txtid_detallesasignaturas";
            this.txtid_detallesasignaturas.Size = new System.Drawing.Size(76, 20);
            this.txtid_detallesasignaturas.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(248, 114);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "Hora de Fin:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(43, 113);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Código Curso:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(43, 80);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Código Asignatura:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(248, 80);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Hora de Inicio:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(43, 50);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Código:";
            // 
            // erroricono
            // 
            this.erroricono.ContainerControl = this;
            // 
            // ttmensaje
            // 
            this.ttmensaje.IsBalloon = true;
            // 
            // frmDetallesasignaturas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(506, 305);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.Name = "frmDetallesasignaturas";
            this.ShowIcon = false;
            this.Text = "SYSCHOOL - Detalles de la Asignatura";
            this.Load += new System.EventHandler(this.frmDetallesasignaturas_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datalistado)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.erroricono)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btneliminar;
        private System.Windows.Forms.Button btnbuscar;
        private System.Windows.Forms.TextBox txtbuscar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox chkeliminar;
        private System.Windows.Forms.DataGridView datalistado;
        private System.Windows.Forms.Label lbltotal;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Eliminar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtid_asignatura;
        private System.Windows.Forms.TextBox txtid_detallesasignaturas;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btncancelar;
        private System.Windows.Forms.Button btneditar;
        private System.Windows.Forms.Button btnguardar;
        private System.Windows.Forms.Button btnnuevo;
        private System.Windows.Forms.ErrorProvider erroricono;
        private System.Windows.Forms.ToolTip ttmensaje;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtid_curso;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker tp_hora_inicio;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker tp_hora_fin;
    }
}