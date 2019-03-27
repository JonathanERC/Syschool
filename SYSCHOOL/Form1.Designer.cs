namespace SYSCHOOL
{
    partial class Form1
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
            this.txt0user = new System.Windows.Forms.TextBox();
            this.txt0pass = new System.Windows.Forms.TextBox();
            this.btn0ingresar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt0user
            // 
            this.txt0user.Location = new System.Drawing.Point(123, 72);
            this.txt0user.Name = "txt0user";
            this.txt0user.Size = new System.Drawing.Size(100, 20);
            this.txt0user.TabIndex = 0;
            // 
            // txt0pass
            // 
            this.txt0pass.Location = new System.Drawing.Point(123, 117);
            this.txt0pass.Name = "txt0pass";
            this.txt0pass.Size = new System.Drawing.Size(100, 20);
            this.txt0pass.TabIndex = 1;
            // 
            // btn0ingresar
            // 
            this.btn0ingresar.Location = new System.Drawing.Point(134, 171);
            this.btn0ingresar.Name = "btn0ingresar";
            this.btn0ingresar.Size = new System.Drawing.Size(75, 23);
            this.btn0ingresar.TabIndex = 2;
            this.btn0ingresar.Text = "button1";
            this.btn0ingresar.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.btn0ingresar);
            this.Controls.Add(this.txt0pass);
            this.Controls.Add(this.txt0user);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt0user;
        private System.Windows.Forms.TextBox txt0pass;
        private System.Windows.Forms.Button btn0ingresar;
    }
}

