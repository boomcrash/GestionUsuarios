namespace GestionUsuarios.controladores
{
    partial class EditarCargo
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cargo2 = new System.Windows.Forms.TextBox();
            this.tbcargo = new System.Windows.Forms.DataGridView();
            this.Cargos = new System.Windows.Forms.DataGridViewImageColumn();
            this.panel9 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.Csueldo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Cnombre = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btncargo = new System.Windows.Forms.Button();
            this.cargo.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbcargo)).BeginInit();
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
            this.cargo.TabIndex = 7;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.btncargo);
            this.panel1.Controls.Add(this.panel9);
            this.panel1.Controls.Add(this.panel8);
            this.panel1.Controls.Add(this.Csueldo);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.Cnombre);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.cargo2);
            this.panel1.Controls.Add(this.tbcargo);
            this.panel1.Location = new System.Drawing.Point(67, 98);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(662, 391);
            this.panel1.TabIndex = 17;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::GestionUsuarios.Properties.Resources.lupa;
            this.pictureBox1.Location = new System.Drawing.Point(395, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(28, 19);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 26;
            this.pictureBox1.TabStop = false;
            // 
            // cargo2
            // 
            this.cargo2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cargo2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            this.cargo2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.cargo2.ForeColor = System.Drawing.Color.White;
            this.cargo2.Location = new System.Drawing.Point(246, 3);
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
            this.tbcargo.Location = new System.Drawing.Point(215, 40);
            this.tbcargo.Name = "tbcargo";
            this.tbcargo.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(33)))), ((int)(((byte)(37)))));
            this.tbcargo.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbcargo.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.White;
            this.tbcargo.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.SeaGreen;
            this.tbcargo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tbcargo.Size = new System.Drawing.Size(244, 186);
            this.tbcargo.TabIndex = 24;
            this.tbcargo.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tbcargo_CellClick);
            // 
            // Cargos
            // 
            this.Cargos.HeaderText = "";
            this.Cargos.Image = global::GestionUsuarios.Properties.Resources.lapiz_y_papel;
            this.Cargos.Name = "Cargos";
            // 
            // panel9
            // 
            this.panel9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.panel9.BackColor = System.Drawing.Color.White;
            this.panel9.Location = new System.Drawing.Point(292, 304);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(146, 2);
            this.panel9.TabIndex = 32;
            // 
            // panel8
            // 
            this.panel8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.panel8.BackColor = System.Drawing.Color.White;
            this.panel8.Location = new System.Drawing.Point(292, 269);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(145, 2);
            this.panel8.TabIndex = 30;
            // 
            // Csueldo
            // 
            this.Csueldo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.Csueldo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            this.Csueldo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Csueldo.ForeColor = System.Drawing.Color.White;
            this.Csueldo.Location = new System.Drawing.Point(292, 287);
            this.Csueldo.Name = "Csueldo";
            this.Csueldo.Size = new System.Drawing.Size(145, 19);
            this.Csueldo.TabIndex = 31;
            this.Csueldo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Csueldo_KeyPress);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.SeaGreen;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(224, 251);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 20);
            this.label4.TabIndex = 27;
            this.label4.Text = "Cargo:";
            // 
            // Cnombre
            // 
            this.Cnombre.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.Cnombre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            this.Cnombre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Cnombre.ForeColor = System.Drawing.Color.White;
            this.Cnombre.Location = new System.Drawing.Point(292, 251);
            this.Cnombre.Name = "Cnombre";
            this.Cnombre.Size = new System.Drawing.Size(143, 19);
            this.Cnombre.TabIndex = 29;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.SeaGreen;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(195, 286);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 20);
            this.label5.TabIndex = 28;
            this.label5.Text = "Sueldo/hr:";
            // 
            // btncargo
            // 
            this.btncargo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btncargo.BackColor = System.Drawing.Color.SeaGreen;
            this.btncargo.FlatAppearance.BorderSize = 0;
            this.btncargo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btncargo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncargo.Location = new System.Drawing.Point(257, 335);
            this.btncargo.Name = "btncargo";
            this.btncargo.Size = new System.Drawing.Size(152, 26);
            this.btncargo.TabIndex = 33;
            this.btncargo.Text = "Editar Cargo";
            this.btncargo.UseVisualStyleBackColor = false;
            this.btncargo.Click += new System.EventHandler(this.btncargo_Click);
            // 
            // EditarCargo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.cargo);
            this.Name = "EditarCargo";
            this.Size = new System.Drawing.Size(800, 595);
            this.cargo.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbcargo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel cargo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox cargo2;
        private System.Windows.Forms.DataGridView tbcargo;
        private System.Windows.Forms.DataGridViewImageColumn Cargos;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.TextBox Csueldo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Cnombre;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btncargo;
    }
}
