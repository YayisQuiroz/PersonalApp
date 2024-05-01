namespace PersonalApp
{
    partial class inicio
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.btnAlumnos = new System.Windows.Forms.Button();
            this.btnDocentes = new System.Windows.Forms.Button();
            this.btnSecretarios = new System.Windows.Forms.Button();
            this.btnChofer = new System.Windows.Forms.Button();
            this.btnJardineros = new System.Windows.Forms.Button();
            this.btnPAdministrativo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(99, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Modulo General";
            // 
            // btnAlumnos
            // 
            this.btnAlumnos.Location = new System.Drawing.Point(102, 68);
            this.btnAlumnos.Name = "btnAlumnos";
            this.btnAlumnos.Size = new System.Drawing.Size(85, 25);
            this.btnAlumnos.TabIndex = 5;
            this.btnAlumnos.Text = "Alumnos";
            this.btnAlumnos.UseVisualStyleBackColor = true;
            this.btnAlumnos.Click += new System.EventHandler(this.btnAlumnos_Click);
            // 
            // btnDocentes
            // 
            this.btnDocentes.Location = new System.Drawing.Point(102, 99);
            this.btnDocentes.Name = "btnDocentes";
            this.btnDocentes.Size = new System.Drawing.Size(85, 25);
            this.btnDocentes.TabIndex = 6;
            this.btnDocentes.Text = "Docentes";
            this.btnDocentes.UseVisualStyleBackColor = true;
            this.btnDocentes.Click += new System.EventHandler(this.btnDocentes_Click);
            // 
            // btnSecretarios
            // 
            this.btnSecretarios.Location = new System.Drawing.Point(102, 130);
            this.btnSecretarios.Name = "btnSecretarios";
            this.btnSecretarios.Size = new System.Drawing.Size(85, 25);
            this.btnSecretarios.TabIndex = 7;
            this.btnSecretarios.Text = "Secretarios";
            this.btnSecretarios.UseVisualStyleBackColor = true;
            this.btnSecretarios.Click += new System.EventHandler(this.btnSecretarios_Click);
            // 
            // btnChofer
            // 
            this.btnChofer.Location = new System.Drawing.Point(102, 238);
            this.btnChofer.Name = "btnChofer";
            this.btnChofer.Size = new System.Drawing.Size(85, 25);
            this.btnChofer.TabIndex = 10;
            this.btnChofer.Text = "Chofer";
            this.btnChofer.UseVisualStyleBackColor = true;
            this.btnChofer.Click += new System.EventHandler(this.btnChofer_Click);
            // 
            // btnJardineros
            // 
            this.btnJardineros.Location = new System.Drawing.Point(102, 207);
            this.btnJardineros.Name = "btnJardineros";
            this.btnJardineros.Size = new System.Drawing.Size(85, 25);
            this.btnJardineros.TabIndex = 9;
            this.btnJardineros.Text = "Jardineros";
            this.btnJardineros.UseVisualStyleBackColor = true;
            this.btnJardineros.Click += new System.EventHandler(this.btnJardineros_Click);
            // 
            // btnPAdministrativo
            // 
            this.btnPAdministrativo.Location = new System.Drawing.Point(102, 161);
            this.btnPAdministrativo.Name = "btnPAdministrativo";
            this.btnPAdministrativo.Size = new System.Drawing.Size(85, 40);
            this.btnPAdministrativo.TabIndex = 8;
            this.btnPAdministrativo.Text = "personal administrativo";
            this.btnPAdministrativo.UseVisualStyleBackColor = true;
            this.btnPAdministrativo.Click += new System.EventHandler(this.btnPAdministrativo_Click);
            // 
            // inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(345, 325);
            this.Controls.Add(this.btnChofer);
            this.Controls.Add(this.btnJardineros);
            this.Controls.Add(this.btnPAdministrativo);
            this.Controls.Add(this.btnSecretarios);
            this.Controls.Add(this.btnDocentes);
            this.Controls.Add(this.btnAlumnos);
            this.Controls.Add(this.label1);
            this.Name = "inicio";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAlumnos;
        private System.Windows.Forms.Button btnDocentes;
        private System.Windows.Forms.Button btnSecretarios;
        private System.Windows.Forms.Button btnChofer;
        private System.Windows.Forms.Button btnJardineros;
        private System.Windows.Forms.Button btnPAdministrativo;
    }
}

