namespace sistema_megacenter
{
    partial class Mantenedor_Compra
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Mantenedor_Compra));
            this.label14 = new System.Windows.Forms.Label();
            this.txtrutadmin = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtcompra = new System.Windows.Forms.TextBox();
            this.grilladetallecompra = new System.Windows.Forms.DataGridView();
            this.Column5 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtneto = new System.Windows.Forms.TextBox();
            this.txtiva = new System.Windows.Forms.TextBox();
            this.txttotal = new System.Windows.Forms.TextBox();
            this.btcompra = new System.Windows.Forms.Button();
            this.cbproveedor = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtcodigo = new System.Windows.Forms.TextBox();
            this.btagregar = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.txtcantidad = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtfecha = new System.Windows.Forms.TextBox();
            this.btvolvermenuprincipalcompra = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.grilladetallecompra)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Palatino Linotype", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label14.Location = new System.Drawing.Point(28, 23);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(145, 21);
            this.label14.TabIndex = 139;
            this.label14.Text = "Rut Administrador";
            // 
            // txtrutadmin
            // 
            this.txtrutadmin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtrutadmin.Enabled = false;
            this.txtrutadmin.Location = new System.Drawing.Point(208, 18);
            this.txtrutadmin.Name = "txtrutadmin";
            this.txtrutadmin.Size = new System.Drawing.Size(116, 26);
            this.txtrutadmin.TabIndex = 140;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Palatino Linotype", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(362, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 21);
            this.label2.TabIndex = 141;
            this.label2.Text = "Rut Proveedor";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Palatino Linotype", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(15, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 21);
            this.label3.TabIndex = 142;
            this.label3.Text = "N° Compra";
            // 
            // txtcompra
            // 
            this.txtcompra.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtcompra.Enabled = false;
            this.txtcompra.Location = new System.Drawing.Point(112, 34);
            this.txtcompra.Name = "txtcompra";
            this.txtcompra.Size = new System.Drawing.Size(100, 20);
            this.txtcompra.TabIndex = 143;
            // 
            // grilladetallecompra
            // 
            this.grilladetallecompra.AllowUserToAddRows = false;
            this.grilladetallecompra.AllowUserToDeleteRows = false;
            this.grilladetallecompra.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grilladetallecompra.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.grilladetallecompra.Location = new System.Drawing.Point(33, 25);
            this.grilladetallecompra.Name = "grilladetallecompra";
            this.grilladetallecompra.ReadOnly = true;
            this.grilladetallecompra.Size = new System.Drawing.Size(654, 154);
            this.grilladetallecompra.TabIndex = 0;
            this.grilladetallecompra.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grilladetallecompra_CellClick);
            this.grilladetallecompra.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.grilladetallecompra_RowsAdded);
            // 
            // Column5
            // 
            this.Column5.HeaderText = "ELiminar";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column5.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Column5.Width = 130;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Subtotal";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 130;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Valor unitario";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 130;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "nombre producto";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 130;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Cantidad";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.grilladetallecompra);
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(38, 258);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(721, 196);
            this.groupBox1.TabIndex = 144;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Detalle compra";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Palatino Linotype", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(442, 477);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 21);
            this.label4.TabIndex = 145;
            this.label4.Text = "Neto";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Palatino Linotype", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(437, 561);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 21);
            this.label5.TabIndex = 146;
            this.label5.Text = "Total";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Palatino Linotype", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(442, 533);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 21);
            this.label6.TabIndex = 147;
            this.label6.Text = "Iva";
            // 
            // txtneto
            // 
            this.txtneto.Enabled = false;
            this.txtneto.Location = new System.Drawing.Point(502, 480);
            this.txtneto.Name = "txtneto";
            this.txtneto.Size = new System.Drawing.Size(176, 20);
            this.txtneto.TabIndex = 148;
            // 
            // txtiva
            // 
            this.txtiva.Enabled = false;
            this.txtiva.Location = new System.Drawing.Point(502, 536);
            this.txtiva.Name = "txtiva";
            this.txtiva.Size = new System.Drawing.Size(176, 20);
            this.txtiva.TabIndex = 149;
            // 
            // txttotal
            // 
            this.txttotal.Enabled = false;
            this.txttotal.Location = new System.Drawing.Point(502, 562);
            this.txttotal.Name = "txttotal";
            this.txttotal.Size = new System.Drawing.Size(176, 20);
            this.txttotal.TabIndex = 150;
            // 
            // btcompra
            // 
            this.btcompra.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btcompra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btcompra.Font = new System.Drawing.Font("Palatino Linotype", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.btcompra.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btcompra.Location = new System.Drawing.Point(502, 599);
            this.btcompra.Name = "btcompra";
            this.btcompra.Size = new System.Drawing.Size(163, 34);
            this.btcompra.TabIndex = 151;
            this.btcompra.Text = "Realizar Compra";
            this.btcompra.UseVisualStyleBackColor = false;
            this.btcompra.Click += new System.EventHandler(this.btcompra_Click);
            // 
            // cbproveedor
            // 
            this.cbproveedor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbproveedor.FormattingEnabled = true;
            this.cbproveedor.Location = new System.Drawing.Point(492, 18);
            this.cbproveedor.Name = "cbproveedor";
            this.cbproveedor.Size = new System.Drawing.Size(146, 28);
            this.cbproveedor.TabIndex = 152;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Palatino Linotype", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label7.Location = new System.Drawing.Point(20, 64);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(131, 21);
            this.label7.TabIndex = 153;
            this.label7.Text = "Codigo Producto";
            // 
            // txtcodigo
            // 
            this.txtcodigo.Location = new System.Drawing.Point(154, 67);
            this.txtcodigo.Name = "txtcodigo";
            this.txtcodigo.Size = new System.Drawing.Size(133, 26);
            this.txtcodigo.TabIndex = 154;
            // 
            // btagregar
            // 
            this.btagregar.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btagregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btagregar.Font = new System.Drawing.Font("Palatino Linotype", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.btagregar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btagregar.Location = new System.Drawing.Point(517, 60);
            this.btagregar.Name = "btagregar";
            this.btagregar.Size = new System.Drawing.Size(163, 34);
            this.btagregar.TabIndex = 155;
            this.btagregar.Text = "Agregar";
            this.btagregar.UseVisualStyleBackColor = false;
            this.btagregar.Click += new System.EventHandler(this.btagregar_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Palatino Linotype", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label8.Location = new System.Drawing.Point(293, 67);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(77, 21);
            this.label8.TabIndex = 156;
            this.label8.Text = "Cantidad";
            // 
            // txtcantidad
            // 
            this.txtcantidad.Location = new System.Drawing.Point(376, 67);
            this.txtcantidad.Name = "txtcantidad";
            this.txtcantidad.Size = new System.Drawing.Size(100, 26);
            this.txtcantidad.TabIndex = 157;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Palatino Linotype", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(228, 33);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(51, 21);
            this.label9.TabIndex = 158;
            this.label9.Text = "Fecha";
            // 
            // txtfecha
            // 
            this.txtfecha.Enabled = false;
            this.txtfecha.Location = new System.Drawing.Point(295, 36);
            this.txtfecha.Name = "txtfecha";
            this.txtfecha.Size = new System.Drawing.Size(126, 20);
            this.txtfecha.TabIndex = 159;
            // 
            // btvolvermenuprincipalcompra
            // 
            this.btvolvermenuprincipalcompra.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btvolvermenuprincipalcompra.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btvolvermenuprincipalcompra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btvolvermenuprincipalcompra.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btvolvermenuprincipalcompra.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btvolvermenuprincipalcompra.Image = ((System.Drawing.Image)(resources.GetObject("btvolvermenuprincipalcompra.Image")));
            this.btvolvermenuprincipalcompra.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btvolvermenuprincipalcompra.Location = new System.Drawing.Point(327, 682);
            this.btvolvermenuprincipalcompra.Name = "btvolvermenuprincipalcompra";
            this.btvolvermenuprincipalcompra.Size = new System.Drawing.Size(223, 36);
            this.btvolvermenuprincipalcompra.TabIndex = 160;
            this.btvolvermenuprincipalcompra.Text = "Volver Menu Principal";
            this.btvolvermenuprincipalcompra.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btvolvermenuprincipalcompra.UseVisualStyleBackColor = false;
            this.btvolvermenuprincipalcompra.Click += new System.EventHandler(this.btvolvermenuprincipalcompra_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.pictureBox1);
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txtcompra);
            this.groupBox2.Controls.Add(this.btcompra);
            this.groupBox2.Controls.Add(this.txttotal);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txtiva);
            this.groupBox2.Controls.Add(this.txtfecha);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.txtneto);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.groupBox1);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(852, 664);
            this.groupBox2.TabIndex = 161;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Sistema compra";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Controls.Add(this.txtrutadmin);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.cbproveedor);
            this.groupBox3.Controls.Add(this.btagregar);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.txtcodigo);
            this.groupBox3.Controls.Add(this.txtcantidad);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.Color.Gold;
            this.groupBox3.Location = new System.Drawing.Point(39, 97);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(743, 131);
            this.groupBox3.TabIndex = 160;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Informacion venta";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(591, 19);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(219, 69);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 161;
            this.pictureBox1.TabStop = false;
            // 
            // Mantenedor_Compra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(895, 730);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btvolvermenuprincipalcompra);
            this.Name = "Mantenedor_Compra";
            this.Text = "Mantenedor_Compra";
            this.Load += new System.EventHandler(this.Mantenedor_Compra_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grilladetallecompra)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtrutadmin;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtcompra;
        private System.Windows.Forms.DataGridView grilladetallecompra;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewButtonColumn Column5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtneto;
        private System.Windows.Forms.TextBox txtiva;
        private System.Windows.Forms.TextBox txttotal;
        private System.Windows.Forms.Button btcompra;
        private System.Windows.Forms.ComboBox cbproveedor;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtcodigo;
        private System.Windows.Forms.Button btagregar;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtcantidad;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtfecha;
        private System.Windows.Forms.Button btvolvermenuprincipalcompra;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox3;

    }
}