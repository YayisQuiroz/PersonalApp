namespace PersonalApp
{
    partial class Modulo_Docente
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellidos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cedula = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnMdfDct = new System.Windows.Forms.Button();
            this.btnEDct = new System.Windows.Forms.Button();
            this.btnMDct = new System.Windows.Forms.Button();
            this.btnAggDct = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nombre,
            this.apellidos,
            this.cedula});
            this.dataGridView1.Location = new System.Drawing.Point(31, 121);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(691, 205);
            this.dataGridView1.TabIndex = 0;
            // 
            // nombre
            // 
            this.nombre.HeaderText = "nombre";
            this.nombre.Name = "nombre";
            // 
            // apellidos
            // 
            this.apellidos.HeaderText = "apellidos";
            this.apellidos.Name = "apellidos";
            // 
            // cedula
            // 
            this.cedula.HeaderText = "cedula";
            this.cedula.Name = "cedula";
            // 
            // btnMdfDct
            // 
            this.btnMdfDct.Location = new System.Drawing.Point(301, 51);
            this.btnMdfDct.Name = "btnMdfDct";
            this.btnMdfDct.Size = new System.Drawing.Size(78, 23);
            this.btnMdfDct.TabIndex = 8;
            this.btnMdfDct.Text = "modificar";
            this.btnMdfDct.UseVisualStyleBackColor = true;
            // 
            // btnEDct
            // 
            this.btnEDct.Location = new System.Drawing.Point(217, 51);
            this.btnEDct.Name = "btnEDct";
            this.btnEDct.Size = new System.Drawing.Size(78, 23);
            this.btnEDct.TabIndex = 7;
            this.btnEDct.Text = "eliminar";
            this.btnEDct.UseVisualStyleBackColor = true;
            // 
            // btnMDct
            // 
            this.btnMDct.Location = new System.Drawing.Point(133, 51);
            this.btnMDct.Name = "btnMDct";
            this.btnMDct.Size = new System.Drawing.Size(78, 23);
            this.btnMDct.TabIndex = 6;
            this.btnMDct.Text = "mostrar";
            this.btnMDct.UseVisualStyleBackColor = true;
            // 
            // btnAggDct
            // 
            this.btnAggDct.Location = new System.Drawing.Point(49, 51);
            this.btnAggDct.Name = "btnAggDct";
            this.btnAggDct.Size = new System.Drawing.Size(78, 23);
            this.btnAggDct.TabIndex = 5;
            this.btnAggDct.Text = "agregar";
            this.btnAggDct.UseVisualStyleBackColor = true;
            this.btnAggDct.Click += new System.EventHandler(this.btnAggDct_Click);
            // 
            // Modulo_Docente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnMdfDct);
            this.Controls.Add(this.btnEDct);
            this.Controls.Add(this.btnMDct);
            this.Controls.Add(this.btnAggDct);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Modulo_Docente";
            this.Text = "Modulo_Docente";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellidos;
        private System.Windows.Forms.DataGridViewTextBoxColumn cedula;
        private System.Windows.Forms.Button btnMdfDct;
        private System.Windows.Forms.Button btnEDct;
        private System.Windows.Forms.Button btnMDct;
        private System.Windows.Forms.Button btnAggDct;
    }
}