namespace PersonalApp
{
    partial class aggalumno
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
            this.btnagregaralmno = new System.Windows.Forms.Button();
            this.lb1Nombre = new System.Windows.Forms.TextBox();
            this.txtmatricula = new System.Windows.Forms.TextBox();
            this.txtcargaacademica = new System.Windows.Forms.TextBox();
            this.txtcarrera = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnagregaralmno
            // 
            this.btnagregaralmno.Location = new System.Drawing.Point(288, 63);
            this.btnagregaralmno.Name = "btnagregaralmno";
            this.btnagregaralmno.Size = new System.Drawing.Size(137, 62);
            this.btnagregaralmno.TabIndex = 0;
            this.btnagregaralmno.Text = "agregar alumno";
            this.btnagregaralmno.UseVisualStyleBackColor = true;
            this.btnagregaralmno.Click += new System.EventHandler(this.btnagregaralmno_Click);
            // 
            // lb1Nombre
            // 
            this.lb1Nombre.Location = new System.Drawing.Point(103, 53);
            this.lb1Nombre.Name = "lb1Nombre";
            this.lb1Nombre.Size = new System.Drawing.Size(100, 20);
            this.lb1Nombre.TabIndex = 1;
            // 
            // txtmatricula
            // 
            this.txtmatricula.Location = new System.Drawing.Point(103, 79);
            this.txtmatricula.Name = "txtmatricula";
            this.txtmatricula.Size = new System.Drawing.Size(100, 20);
            this.txtmatricula.TabIndex = 2;
            // 
            // txtcargaacademica
            // 
            this.txtcargaacademica.Location = new System.Drawing.Point(103, 131);
            this.txtcargaacademica.Name = "txtcargaacademica";
            this.txtcargaacademica.Size = new System.Drawing.Size(100, 20);
            this.txtcargaacademica.TabIndex = 4;
            // 
            // txtcarrera
            // 
            this.txtcarrera.Location = new System.Drawing.Point(103, 105);
            this.txtcarrera.Name = "txtcarrera";
            this.txtcarrera.Size = new System.Drawing.Size(100, 20);
            this.txtcarrera.TabIndex = 3;
            // 
            // aggalumno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(508, 237);
            this.Controls.Add(this.txtcargaacademica);
            this.Controls.Add(this.txtcarrera);
            this.Controls.Add(this.txtmatricula);
            this.Controls.Add(this.lb1Nombre);
            this.Controls.Add(this.btnagregaralmno);
            this.Name = "aggalumno";
            this.Text = "aggalumno";
            this.Load += new System.EventHandler(this.aggalumno_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnagregaralmno;
        private System.Windows.Forms.TextBox lb1Nombre;
        private System.Windows.Forms.TextBox txtmatricula;
        private System.Windows.Forms.TextBox txtcargaacademica;
        private System.Windows.Forms.TextBox txtcarrera;
    }
}