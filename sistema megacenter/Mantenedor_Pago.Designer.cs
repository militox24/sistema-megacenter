namespace sistema_megacenter
{
    partial class Mantenedor_Pago
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Mantenedor_Pago));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtclientepago = new System.Windows.Forms.TextBox();
            this.btbuscarclientepago = new System.Windows.Forms.Button();
            this.grillapagocliente = new System.Windows.Forms.DataGridView();
            this.btpagar = new System.Windows.Forms.Button();
            this.btvolvermenuprincipalpago = new System.Windows.Forms.Button();
            this.Column1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GrillaInicio = new System.Windows.Forms.DataGridView();
            this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grillapagocliente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GrillaInicio)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 25);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(48, 48);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(79, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Pagos Pendientes";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Rut Cliente:";
            // 
            // txtclientepago
            // 
            this.txtclientepago.Location = new System.Drawing.Point(122, 90);
            this.txtclientepago.Multiline = true;
            this.txtclientepago.Name = "txtclientepago";
            this.txtclientepago.ShortcutsEnabled = false;
            this.txtclientepago.Size = new System.Drawing.Size(220, 26);
            this.txtclientepago.TabIndex = 3;
            this.txtclientepago.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtclientepago_KeyPress);
            // 
            // btbuscarclientepago
            // 
            this.btbuscarclientepago.BackColor = System.Drawing.SystemColors.Desktop;
            this.btbuscarclientepago.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btbuscarclientepago.Image = ((System.Drawing.Image)(resources.GetObject("btbuscarclientepago.Image")));
            this.btbuscarclientepago.Location = new System.Drawing.Point(348, 84);
            this.btbuscarclientepago.Name = "btbuscarclientepago";
            this.btbuscarclientepago.Size = new System.Drawing.Size(34, 34);
            this.btbuscarclientepago.TabIndex = 4;
            this.btbuscarclientepago.UseVisualStyleBackColor = false;
            this.btbuscarclientepago.Click += new System.EventHandler(this.btbuscarclientepago_Click);
            // 
            // grillapagocliente
            // 
            this.grillapagocliente.AllowUserToAddRows = false;
            this.grillapagocliente.AllowUserToDeleteRows = false;
            this.grillapagocliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grillapagocliente.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column4,
            this.Column2,
            this.Column3,
            this.Column5});
            this.grillapagocliente.Location = new System.Drawing.Point(16, 138);
            this.grillapagocliente.Name = "grillapagocliente";
            this.grillapagocliente.Size = new System.Drawing.Size(539, 174);
            this.grillapagocliente.TabIndex = 5;
            this.grillapagocliente.Visible = false;
            // 
            // btpagar
            // 
            this.btpagar.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btpagar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btpagar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btpagar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btpagar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btpagar.Image = ((System.Drawing.Image)(resources.GetObject("btpagar.Image")));
            this.btpagar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btpagar.Location = new System.Drawing.Point(467, 359);
            this.btpagar.Name = "btpagar";
            this.btpagar.Size = new System.Drawing.Size(109, 36);
            this.btpagar.TabIndex = 66;
            this.btpagar.Text = "Pagar";
            this.btpagar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btpagar.UseVisualStyleBackColor = false;
            this.btpagar.Click += new System.EventHandler(this.btpagar_Click);
            // 
            // btvolvermenuprincipalpago
            // 
            this.btvolvermenuprincipalpago.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btvolvermenuprincipalpago.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btvolvermenuprincipalpago.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btvolvermenuprincipalpago.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btvolvermenuprincipalpago.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btvolvermenuprincipalpago.Image = ((System.Drawing.Image)(resources.GetObject("btvolvermenuprincipalpago.Image")));
            this.btvolvermenuprincipalpago.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btvolvermenuprincipalpago.Location = new System.Drawing.Point(64, 359);
            this.btvolvermenuprincipalpago.Name = "btvolvermenuprincipalpago";
            this.btvolvermenuprincipalpago.Size = new System.Drawing.Size(229, 36);
            this.btvolvermenuprincipalpago.TabIndex = 67;
            this.btvolvermenuprincipalpago.Text = "Volver menu principal";
            this.btvolvermenuprincipalpago.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btvolvermenuprincipalpago.UseVisualStyleBackColor = false;
            this.btvolvermenuprincipalpago.Click += new System.EventHandler(this.btvolvermenuprincipalpago_Click);
            // 
            // Column1
            // 
            this.Column1.FalseValue = "false";
            this.Column1.HeaderText = "Seleccione";
            this.Column1.MinimumWidth = 7;
            this.Column1.Name = "Column1";
            this.Column1.TrueValue = "true";
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "N_Venta";
            this.Column4.HeaderText = "N° Venta";
            this.Column4.Name = "Column4";
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "Fecha";
            this.Column2.HeaderText = "Fecha";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "Rut_Usuario";
            this.Column3.HeaderText = "Rut_Vendedor";
            this.Column3.Name = "Column3";
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "Total_Bruto";
            this.Column5.HeaderText = "Total a pagar";
            this.Column5.Name = "Column5";
            // 
            // GrillaInicio
            // 
            this.GrillaInicio.AllowUserToAddRows = false;
            this.GrillaInicio.AllowUserToDeleteRows = false;
            this.GrillaInicio.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GrillaInicio.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewCheckBoxColumn1,
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.GrillaInicio.Location = new System.Drawing.Point(16, 138);
            this.GrillaInicio.Name = "GrillaInicio";
            this.GrillaInicio.Size = new System.Drawing.Size(539, 174);
            this.GrillaInicio.TabIndex = 68;
            // 
            // dataGridViewCheckBoxColumn1
            // 
            this.dataGridViewCheckBoxColumn1.FalseValue = "false";
            this.dataGridViewCheckBoxColumn1.HeaderText = "Seleccione";
            this.dataGridViewCheckBoxColumn1.MinimumWidth = 7;
            this.dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
            this.dataGridViewCheckBoxColumn1.TrueValue = "true";
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "N_Venta";
            this.dataGridViewTextBoxColumn1.HeaderText = "N° Venta";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Fecha";
            this.dataGridViewTextBoxColumn2.HeaderText = "Fecha";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Rut_Usuario";
            this.dataGridViewTextBoxColumn3.HeaderText = "Rut_Vendedor";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Total_Bruto";
            this.dataGridViewTextBoxColumn4.HeaderText = "Total a pagar";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // Mantenedor_Pago
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(619, 407);
            this.Controls.Add(this.GrillaInicio);
            this.Controls.Add(this.btvolvermenuprincipalpago);
            this.Controls.Add(this.btpagar);
            this.Controls.Add(this.grillapagocliente);
            this.Controls.Add(this.btbuscarclientepago);
            this.Controls.Add(this.txtclientepago);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Mantenedor_Pago";
            this.Text = "Mantenedor_Pago";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grillapagocliente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GrillaInicio)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtclientepago;
        private System.Windows.Forms.Button btbuscarclientepago;
        private System.Windows.Forms.DataGridView grillapagocliente;
        private System.Windows.Forms.Button btpagar;
        private System.Windows.Forms.Button btvolvermenuprincipalpago;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridView GrillaInicio;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
    }
}