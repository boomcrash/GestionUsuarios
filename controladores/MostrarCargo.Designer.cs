namespace GestionUsuarios.controladores
{
    partial class MostrarCargo
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

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.cargo = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cargo2 = new System.Windows.Forms.TextBox();
            this.tbcargo = new System.Windows.Forms.DataGridView();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.Cargos = new System.Windows.Forms.DataGridViewImageColumn();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cargo.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbcargo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // cargo
            // 
            this.cargo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(33)))), ((int)(((byte)(37)))));
            this.cargo.Controls.Add(this.panel1);
            this.cargo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cargo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cargo.Location = new System.Drawing.Point(0, 0);
            this.cargo.Name = "cargo";
            this.cargo.Size = new System.Drawing.Size(800, 595);
            this.cargo.TabIndex = 6;
            this.cargo.Paint += new System.Windows.Forms.PaintEventHandler(this.cargo_Paint);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.cargo2);
            this.panel1.Controls.Add(this.tbcargo);
            this.panel1.Location = new System.Drawing.Point(67, 98);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(662, 391);
            this.panel1.TabIndex = 17;
            // 
            // cargo2
            // 
            this.cargo2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cargo2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            this.cargo2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.cargo2.ForeColor = System.Drawing.Color.White;
            this.cargo2.Location = new System.Drawing.Point(245, 81);
            this.cargo2.Name = "cargo2";
            this.cargo2.Size = new System.Drawing.Size(152, 19);
            this.cargo2.TabIndex = 25;
            this.cargo2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.cargo2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cargo2_KeyPress);
            // 
            // tbcargo
            // 
            this.tbcargo.AllowUserToAddRows = false;
            this.tbcargo.AllowUserToDeleteRows = false;
            this.tbcargo.AllowUserToResizeRows = false;
            this.tbcargo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tbcargo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Cargos});
            this.tbcargo.Location = new System.Drawing.Point(213, 130);
            this.tbcargo.Name = "tbcargo";
            this.tbcargo.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(33)))), ((int)(((byte)(37)))));
            this.tbcargo.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbcargo.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.White;
            this.tbcargo.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.SeaGreen;
            this.tbcargo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tbcargo.Size = new System.Drawing.Size(244, 186);
            this.tbcargo.TabIndex = 24;
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.HeaderText = "";
            this.dataGridViewImageColumn1.Image = global::GestionUsuarios.Properties.Resources.lapiz_y_papel;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            // 
            // Cargos
            // 
            this.Cargos.HeaderText = "";
            this.Cargos.Image = global::GestionUsuarios.Properties.Resources.lapiz_y_papel;
            this.Cargos.Name = "Cargos";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::GestionUsuarios.Properties.Resources.lupa;
            this.pictureBox1.Location = new System.Drawing.Point(394, 81);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(28, 19);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 26;
            this.pictureBox1.TabStop = false;
            // 
            // MostrarCargo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.cargo);
            this.Name = "MostrarCargo";
            this.Size = new System.Drawing.Size(800, 595);
            this.cargo.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbcargo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel cargo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView tbcargo;
        private System.Windows.Forms.TextBox cargo2;
        private System.Windows.Forms.DataGridViewImageColumn Cargos;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
    }
}
