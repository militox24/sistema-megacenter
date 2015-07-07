namespace sistema_megacenter
{
    partial class Mantenedor_Venta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Mantenedor_Venta));
            this.txtfechaventa = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtcantidadventa = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btagregarventa = new System.Windows.Forms.Button();
            this.txtcodigoproductoventa = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btventa = new System.Windows.Forms.Button();
            this.txttotalventa = new System.Windows.Forms.TextBox();
            this.txtivaventa = new System.Windows.Forms.TextBox();
            this.txtnetoventa = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.grilladetalleventa = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.txtventa = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtrutadministrador = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtrutcliente = new System.Windows.Forms.TextBox();
            this.btvolvermenuvendedorventa = new System.Windows.Forms.Button();
            this.btmenuprincipalventa = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.cbtipoventa = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grilladetalleventa)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtfechaventa
            // 
            this.txtfechaventa.Enabled = false;
            this.txtfechaventa.Location = new System.Drawing.Point(309, 35);
            this.txtfechaventa.Name = "txtfechaventa";
            this.txtfechaventa.Size = new System.Drawing.Size(126, 20);
            this.txtfechaventa.TabIndex = 180;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Palatino Linotype", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(247, 32);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(51, 21);
            this.label9.TabIndex = 179;
            this.label9.Text = "Fecha";
            // 
            // txtcantidadventa
            // 
            this.txtcantidadventa.Location = new System.Drawing.Point(373, 28);
            this.txtcantidadventa.MaxLength = 4;
            this.txtcantidadventa.Name = "txtcantidadventa";
            this.txtcantidadventa.ShortcutsEnabled = false;
            this.txtcantidadventa.Size = new System.Drawing.Size(100, 26);
            this.txtcantidadventa.TabIndex = 178;
            this.txtcantidadventa.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtcantidadventa_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Palatino Linotype", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label8.Location = new System.Drawing.Point(280, 91);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(77, 21);
            this.label8.TabIndex = 177;
            this.label8.Text = "Cantidad";
            // 
            // btagregarventa
            // 
            this.btagregarventa.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btagregarventa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btagregarventa.Font = new System.Drawing.Font("Palatino Linotype", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.btagregarventa.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btagregarventa.Location = new System.Drawing.Point(510, 89);
            this.btagregarventa.Name = "btagregarventa";
            this.btagregarventa.Size = new System.Drawing.Size(163, 34);
            this.btagregarventa.TabIndex = 176;
            this.btagregarventa.Text = "Agregar";
            this.btagregarventa.UseVisualStyleBackColor = false;
            this.btagregarventa.Click += new System.EventHandler(this.btagregarventa_Click);
            // 
            // txtcodigoproductoventa
            // 
            this.txtcodigoproductoventa.Location = new System.Drawing.Point(134, 91);
            this.txtcodigoproductoventa.MaxLength = 13;
            this.txtcodigoproductoventa.Name = "txtcodigoproductoventa";
            this.txtcodigoproductoventa.ShortcutsEnabled = false;
            this.txtcodigoproductoventa.Size = new System.Drawing.Size(133, 26);
            this.txtcodigoproductoventa.TabIndex = 175;
            this.txtcodigoproductoventa.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtcodigoproductoventa_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Palatino Linotype", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label7.Location = new System.Drawing.Point(3, 96);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(131, 21);
            this.label7.TabIndex = 174;
            this.label7.Text = "Codigo Producto";
            // 
            // btventa
            // 
            this.btventa.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btventa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btventa.Font = new System.Drawing.Font("Palatino Linotype", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.btventa.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btventa.Location = new System.Drawing.Point(535, 655);
            this.btventa.Name = "btventa";
            this.btventa.Size = new System.Drawing.Size(163, 34);
            this.btventa.TabIndex = 172;
            this.btventa.Text = "Realizar venta";
            this.btventa.UseVisualStyleBackColor = false;
            this.btventa.Click += new System.EventHandler(this.btventa_Click);
            // 
            // txttotalventa
            // 
            this.txttotalventa.Enabled = false;
            this.txttotalventa.Location = new System.Drawing.Point(547, 603);
            this.txttotalventa.Name = "txttotalventa";
            this.txttotalventa.Size = new System.Drawing.Size(176, 20);
            this.txttotalventa.TabIndex = 171;
            // 
            // txtivaventa
            // 
            this.txtivaventa.Enabled = false;
            this.txtivaventa.Location = new System.Drawing.Point(545, 568);
            this.txtivaventa.Name = "txtivaventa";
            this.txtivaventa.Size = new System.Drawing.Size(176, 20);
            this.txtivaventa.TabIndex = 170;
            // 
            // txtnetoventa
            // 
            this.txtnetoventa.Enabled = false;
            this.txtnetoventa.Location = new System.Drawing.Point(545, 531);
            this.txtnetoventa.Name = "txtnetoventa";
            this.txtnetoventa.Size = new System.Drawing.Size(176, 20);
            this.txtnetoventa.TabIndex = 169;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Palatino Linotype", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(495, 565);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 21);
            this.label6.TabIndex = 168;
            this.label6.Text = "Iva";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Palatino Linotype", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(492, 600);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 21);
            this.label5.TabIndex = 167;
            this.label5.Text = "Total";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Palatino Linotype", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(495, 528);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 21);
            this.label4.TabIndex = 166;
            this.label4.Text = "Neto";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.grilladetalleventa);
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Gold;
            this.groupBox1.Location = new System.Drawing.Point(26, 307);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(721, 196);
            this.groupBox1.TabIndex = 165;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Detalle Venta";
            // 
            // grilladetalleventa
            // 
            this.grilladetalleventa.AllowUserToAddRows = false;
            this.grilladetalleventa.AllowUserToDeleteRows = false;
            this.grilladetalleventa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grilladetalleventa.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.grilladetalleventa.Location = new System.Drawing.Point(33, 25);
            this.grilladetalleventa.Name = "grilladetalleventa";
            this.grilladetalleventa.ReadOnly = true;
            this.grilladetalleventa.Size = new System.Drawing.Size(654, 154);
            this.grilladetalleventa.TabIndex = 0;
            this.grilladetalleventa.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grilladetalleventa_CellClick);
            this.grilladetalleventa.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.grilladetalleventa_RowsAdded);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Cantidad";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "nombre producto";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 130;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Valor unitario";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 130;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Subtotal";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 130;
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
            // txtventa
            // 
            this.txtventa.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtventa.Enabled = false;
            this.txtventa.Location = new System.Drawing.Point(114, 33);
            this.txtventa.Name = "txtventa";
            this.txtventa.Size = new System.Drawing.Size(100, 20);
            this.txtventa.TabIndex = 164;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Palatino Linotype", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(35, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 21);
            this.label3.TabIndex = 163;
            this.label3.Text = "N° Venta";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Palatino Linotype", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(280, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 21);
            this.label2.TabIndex = 162;
            this.label2.Text = "Rut cliente";
            // 
            // txtrutadministrador
            // 
            this.txtrutadministrador.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtrutadministrador.Enabled = false;
            this.txtrutadministrador.Location = new System.Drawing.Point(157, 29);
            this.txtrutadministrador.Name = "txtrutadministrador";
            this.txtrutadministrador.Size = new System.Drawing.Size(116, 26);
            this.txtrutadministrador.TabIndex = 161;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Palatino Linotype", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label14.Location = new System.Drawing.Point(6, 25);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(145, 21);
            this.label14.TabIndex = 160;
            this.label14.Text = "Rut Administrador";
            // 
            // txtrutcliente
            // 
            this.txtrutcliente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtrutcliente.Location = new System.Drawing.Point(373, 92);
            this.txtrutcliente.MaxLength = 10;
            this.txtrutcliente.Name = "txtrutcliente";
            this.txtrutcliente.ShortcutsEnabled = false;
            this.txtrutcliente.Size = new System.Drawing.Size(116, 26);
            this.txtrutcliente.TabIndex = 181;
            this.txtrutcliente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtrutcliente_KeyPress);
            // 
            // btvolvermenuvendedorventa
            // 
            this.btvolvermenuvendedorventa.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btvolvermenuvendedorventa.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btvolvermenuvendedorventa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btvolvermenuvendedorventa.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btvolvermenuvendedorventa.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btvolvermenuvendedorventa.Image = ((System.Drawing.Image)(resources.GetObject("btvolvermenuvendedorventa.Image")));
            this.btvolvermenuvendedorventa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btvolvermenuvendedorventa.Location = new System.Drawing.Point(69, 653);
            this.btvolvermenuvendedorventa.Name = "btvolvermenuvendedorventa";
            this.btvolvermenuvendedorventa.Size = new System.Drawing.Size(223, 36);
            this.btvolvermenuvendedorventa.TabIndex = 182;
            this.btvolvermenuvendedorventa.Text = "Volver Menu Principal";
            this.btvolvermenuvendedorventa.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btvolvermenuvendedorventa.UseVisualStyleBackColor = false;
            this.btvolvermenuvendedorventa.Visible = false;
            this.btvolvermenuvendedorventa.Click += new System.EventHandler(this.btvolvermenuvendedorventa_Click);
            // 
            // btmenuprincipalventa
            // 
            this.btmenuprincipalventa.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btmenuprincipalventa.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btmenuprincipalventa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btmenuprincipalventa.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btmenuprincipalventa.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btmenuprincipalventa.Image = ((System.Drawing.Image)(resources.GetObject("btmenuprincipalventa.Image")));
            this.btmenuprincipalventa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btmenuprincipalventa.Location = new System.Drawing.Point(75, 653);
            this.btmenuprincipalventa.Name = "btmenuprincipalventa";
            this.btmenuprincipalventa.Size = new System.Drawing.Size(223, 36);
            this.btmenuprincipalventa.TabIndex = 183;
            this.btmenuprincipalventa.Text = "Volver Menu Principal";
            this.btmenuprincipalventa.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btmenuprincipalventa.UseVisualStyleBackColor = false;
            this.btmenuprincipalventa.Visible = false;
            this.btmenuprincipalventa.Click += new System.EventHandler(this.btmenuprincipalventa_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Palatino Linotype", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label10.Location = new System.Drawing.Point(492, 29);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(92, 21);
            this.label10.TabIndex = 184;
            this.label10.Text = "Tipo_Venta";
            // 
            // cbtipoventa
            // 
            this.cbtipoventa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbtipoventa.FormattingEnabled = true;
            this.cbtipoventa.Items.AddRange(new object[] {
            "Seleccione",
            "Contado",
            "Credito"});
            this.cbtipoventa.Location = new System.Drawing.Point(585, 26);
            this.cbtipoventa.Name = "cbtipoventa";
            this.cbtipoventa.Size = new System.Drawing.Size(144, 28);
            this.cbtipoventa.TabIndex = 185;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.cbtipoventa);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.txtrutadministrador);
            this.groupBox2.Controls.Add(this.btagregarventa);
            this.groupBox2.Controls.Add(this.txtcodigoproductoventa);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.txtrutcliente);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.txtcantidadventa);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.Gold;
            this.groupBox2.Location = new System.Drawing.Point(19, 125);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(735, 155);
            this.groupBox2.TabIndex = 186;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Información Venta";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(515, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(239, 90);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 187;
            this.pictureBox1.TabStop = false;
            // 
            // Mantenedor_Venta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(786, 709);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btmenuprincipalventa);
            this.Controls.Add(this.btvolvermenuvendedorventa);
            this.Controls.Add(this.txtfechaventa);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btventa);
            this.Controls.Add(this.txttotalventa);
            this.Controls.Add(this.txtivaventa);
            this.Controls.Add(this.txtnetoventa);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtventa);
            this.Controls.Add(this.label3);
            this.Name = "Mantenedor_Venta";
            this.Text = "Mantenedor_Venta";
            this.Load += new System.EventHandler(this.Mantenedor_Venta_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grilladetalleventa)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtfechaventa;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtcantidadventa;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btagregarventa;
        private System.Windows.Forms.TextBox txtcodigoproductoventa;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btventa;
        private System.Windows.Forms.TextBox txttotalventa;
        private System.Windows.Forms.TextBox txtivaventa;
        private System.Windows.Forms.TextBox txtnetoventa;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView grilladetalleventa;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewButtonColumn Column5;
        private System.Windows.Forms.TextBox txtventa;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtrutadministrador;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtrutcliente;
        private System.Windows.Forms.Button btvolvermenuvendedorventa;
        private System.Windows.Forms.Button btmenuprincipalventa;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cbtipoventa;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}