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
            this.btncargo = new System.Windows.Forms.Button();
            this.cargo.SuspendLayout();
            this.panel1.SuspendLayout();
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
            this.panel1.Controls.Add(this.cargo2);
            this.panel1.Controls.Add(this.tbcargo);
            this.panel1.Controls.Add(this.btncargo);
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
            this.cargo2.Location = new System.Drawing.Point(268, 32);
            this.cargo2.Name = "cargo2";
            this.cargo2.Size = new System.Drawing.Size(143, 19);
            this.cargo2.TabIndex = 25;
            // 
            // tbcargo
            // 
            this.tbcargo.AllowUserToAddRows = false;
            this.tbcargo.AllowUserToDeleteRows = false;
            this.tbcargo.AllowUserToResizeRows = false;
            this.tbcargo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tbcargo.Location = new System.Drawing.Point(188, 75);
            this.tbcargo.Name = "tbcargo";
            this.tbcargo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tbcargo.Size = new System.Drawing.Size(306, 186);
            this.tbcargo.TabIndex = 24;
            // 
            // btncargo
            // 
            this.btncargo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btncargo.BackColor = System.Drawing.Color.SeaGreen;
            this.btncargo.FlatAppearance.BorderSize = 0;
            this.btncargo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btncargo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncargo.Location = new System.Drawing.Point(268, 303);
            this.btncargo.Name = "btncargo";
            this.btncargo.Size = new System.Drawing.Size(143, 26);
            this.btncargo.TabIndex = 23;
            this.btncargo.Text = "Mostrar Cargos";
            this.btncargo.UseVisualStyleBackColor = false;
            this.btncargo.Click += new System.EventHandler(this.btncargo_Click);
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
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel cargo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btncargo;
        private System.Windows.Forms.DataGridView tbcargo;
        private System.Windows.Forms.TextBox cargo2;
    }
}
