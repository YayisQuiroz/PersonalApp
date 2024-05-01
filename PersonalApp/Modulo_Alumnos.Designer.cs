namespace PersonalApp
{
    partial class Modulo_Alumnos
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
            this.btnAggAlmn = new System.Windows.Forms.Button();
            this.btnMstAlmn = new System.Windows.Forms.Button();
            this.btnElmAlmn = new System.Windows.Forms.Button();
            this.btnMdfAlmn = new System.Windows.Forms.Button();
            this.lstAlumno = new System.Windows.Forms.ListView();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnAggAlmn
            // 
            this.btnAggAlmn.Location = new System.Drawing.Point(680, 85);
            this.btnAggAlmn.Name = "btnAggAlmn";
            this.btnAggAlmn.Size = new System.Drawing.Size(75, 23);
            this.btnAggAlmn.TabIndex = 0;
            this.btnAggAlmn.Text = "agregar";
            this.btnAggAlmn.UseVisualStyleBackColor = true;
            this.btnAggAlmn.Click += new System.EventHandler(this.btnAggAlmn_Click_1);
            // 
            // btnMstAlmn
            // 
            this.btnMstAlmn.Location = new System.Drawing.Point(518, 85);
            this.btnMstAlmn.Name = "btnMstAlmn";
            this.btnMstAlmn.Size = new System.Drawing.Size(75, 23);
            this.btnMstAlmn.TabIndex = 1;
            this.btnMstAlmn.Text = "mostrar";
            this.btnMstAlmn.UseVisualStyleBackColor = true;
            // 
            // btnElmAlmn
            // 
            this.btnElmAlmn.Location = new System.Drawing.Point(680, 271);
            this.btnElmAlmn.Name = "btnElmAlmn";
            this.btnElmAlmn.Size = new System.Drawing.Size(75, 23);
            this.btnElmAlmn.TabIndex = 2;
            this.btnElmAlmn.Text = "Eliminar";
            this.btnElmAlmn.UseVisualStyleBackColor = true;
            // 
            // btnMdfAlmn
            // 
            this.btnMdfAlmn.Location = new System.Drawing.Point(599, 85);
            this.btnMdfAlmn.Name = "btnMdfAlmn";
            this.btnMdfAlmn.Size = new System.Drawing.Size(75, 23);
            this.btnMdfAlmn.TabIndex = 3;
            this.btnMdfAlmn.Text = "Modificar";
            this.btnMdfAlmn.UseVisualStyleBackColor = true;
            this.btnMdfAlmn.Click += new System.EventHandler(this.btnMdfAlmn_Click);
            // 
            // lstAlumno
            // 
            this.lstAlumno.FullRowSelect = true;
            this.lstAlumno.HideSelection = false;
            this.lstAlumno.Location = new System.Drawing.Point(12, 114);
            this.lstAlumno.Name = "lstAlumno";
            this.lstAlumno.Size = new System.Drawing.Size(743, 151);
            this.lstAlumno.TabIndex = 4;
            this.lstAlumno.UseCompatibleStateImageBehavior = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(262, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "modulo alumno";
            // 
            // Modulo_Alumnos
            // 
            this.ClientSize = new System.Drawing.Size(779, 298);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstAlumno);
            this.Controls.Add(this.btnMdfAlmn);
            this.Controls.Add(this.btnElmAlmn);
            this.Controls.Add(this.btnMstAlmn);
            this.Controls.Add(this.btnAggAlmn);
            this.Name = "Modulo_Alumnos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion


        private System.Windows.Forms.Button btnAggAlmn;
        private System.Windows.Forms.Button btnMstAlmn;
        private System.Windows.Forms.Button btnElmAlmn;
        private System.Windows.Forms.Button btnMdfAlmn;
        private System.Windows.Forms.ListView lstAlumno;
        private System.Windows.Forms.Label label1;
    }
}