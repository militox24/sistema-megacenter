namespace sistema_megacenter
{
    partial class Mantenedor_Devolucion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Mantenedor_Devolucion));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.gbagregardevolucion = new System.Windows.Forms.GroupBox();
            this.btdevolver = new System.Windows.Forms.Button();
            this.txtmotivodevolucion = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtunidadesdevueltas = new System.Windows.Forms.TextBox();
            this.grilladevolucion = new System.Windows.Forms.DataGridView();
            this.btbuscarventa = new System.Windows.Forms.Button();
            this.txtnumeroventadevolucion = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btcargaagregadevolucion = new System.Windows.Forms.Button();
            this.btcargaconsulatrdevolucion = new System.Windows.Forms.Button();
            this.gbconsultardevolucion = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.gbagregardevolucion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grilladevolucion)).BeginInit();
            this.gbconsultardevolucion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.gbagregardevolucion);
            this.panel1.Controls.Add(this.gbconsultardevolucion);
            this.panel1.Location = new System.Drawing.Point(217, 22);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(677, 506);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.btcargaconsulatrdevolucion);
            this.panel2.Controls.Add(this.btcargaagregadevolucion);
            this.panel2.Location = new System.Drawing.Point(12, 22);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(154, 422);
            this.panel2.TabIndex = 0;
            // 
            // gbagregardevolucion
            // 
            this.gbagregardevolucion.Controls.Add(this.btdevolver);
            this.gbagregardevolucion.Controls.Add(this.txtmotivodevolucion);
            this.gbagregardevolucion.Controls.Add(this.label3);
            this.gbagregardevolucion.Controls.Add(this.label2);
            this.gbagregardevolucion.Controls.Add(this.txtunidadesdevueltas);
            this.gbagregardevolucion.Controls.Add(this.grilladevolucion);
            this.gbagregardevolucion.Controls.Add(this.btbuscarventa);
            this.gbagregardevolucion.Controls.Add(this.txtnumeroventadevolucion);
            this.gbagregardevolucion.Controls.Add(this.label1);
            this.gbagregardevolucion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbagregardevolucion.ForeColor = System.Drawing.Color.Gold;
            this.gbagregardevolucion.Location = new System.Drawing.Point(15, 3);
            this.gbagregardevolucion.Name = "gbagregardevolucion";
            this.gbagregardevolucion.Size = new System.Drawing.Size(637, 480);
            this.gbagregardevolucion.TabIndex = 0;
            this.gbagregardevolucion.TabStop = false;
            this.gbagregardevolucion.Text = "Agregar Devolución";
            // 
            // btdevolver
            // 
            this.btdevolver.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btdevolver.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btdevolver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btdevolver.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btdevolver.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btdevolver.Image = ((System.Drawing.Image)(resources.GetObject("btdevolver.Image")));
            this.btdevolver.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btdevolver.Location = new System.Drawing.Point(462, 426);
            this.btdevolver.Name = "btdevolver";
            this.btdevolver.Size = new System.Drawing.Size(139, 28);
            this.btdevolver.TabIndex = 44;
            this.btdevolver.Text = "Devolver";
            this.btdevolver.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btdevolver.UseVisualStyleBackColor = false;
            // 
            // txtmotivodevolucion
            // 
            this.txtmotivodevolucion.Location = new System.Drawing.Point(101, 307);
            this.txtmotivodevolucion.Multiline = true;
            this.txtmotivodevolucion.Name = "txtmotivodevolucion";
            this.txtmotivodevolucion.Size = new System.Drawing.Size(337, 132);
            this.txtmotivodevolucion.TabIndex = 43;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Location = new System.Drawing.Point(9, 307);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 20);
            this.label3.TabIndex = 42;
            this.label3.Text = "Motivo:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(6, 261);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(156, 20);
            this.label2.TabIndex = 41;
            this.label2.Text = "Unidades Devueltas:";
            // 
            // txtunidadesdevueltas
            // 
            this.txtunidadesdevueltas.Location = new System.Drawing.Point(168, 258);
            this.txtunidadesdevueltas.Multiline = true;
            this.txtunidadesdevueltas.Name = "txtunidadesdevueltas";
            this.txtunidadesdevueltas.Size = new System.Drawing.Size(204, 29);
            this.txtunidadesdevueltas.TabIndex = 40;
            // 
            // grilladevolucion
            // 
            this.grilladevolucion.AllowUserToAddRows = false;
            this.grilladevolucion.AllowUserToDeleteRows = false;
            this.grilladevolucion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grilladevolucion.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.grilladevolucion.Location = new System.Drawing.Point(13, 91);
            this.grilladevolucion.Name = "grilladevolucion";
            this.grilladevolucion.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grilladevolucion.Size = new System.Drawing.Size(607, 150);
            this.grilladevolucion.TabIndex = 39;
            this.grilladevolucion.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grilladevolucion_CellContentClick);
            // 
            // btbuscarventa
            // 
            this.btbuscarventa.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btbuscarventa.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btbuscarventa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btbuscarventa.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btbuscarventa.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btbuscarventa.Image = ((System.Drawing.Image)(resources.GetObject("btbuscarventa.Image")));
            this.btbuscarventa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btbuscarventa.Location = new System.Drawing.Point(315, 45);
            this.btbuscarventa.Name = "btbuscarventa";
            this.btbuscarventa.Size = new System.Drawing.Size(99, 28);
            this.btbuscarventa.TabIndex = 38;
            this.btbuscarventa.Text = "Buscar";
            this.btbuscarventa.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btbuscarventa.UseVisualStyleBackColor = false;
            this.btbuscarventa.Click += new System.EventHandler(this.btbuscarventa_Click_1);
            // 
            // txtnumeroventadevolucion
            // 
            this.txtnumeroventadevolucion.Location = new System.Drawing.Point(85, 47);
            this.txtnumeroventadevolucion.Name = "txtnumeroventadevolucion";
            this.txtnumeroventadevolucion.Size = new System.Drawing.Size(204, 26);
            this.txtnumeroventadevolucion.TabIndex = 37;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(9, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 20);
            this.label1.TabIndex = 36;
            this.label1.Text = "N° Boleta:";
            // 
            // btcargaagregadevolucion
            // 
            this.btcargaagregadevolucion.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btcargaagregadevolucion.BackgroundImage")));
            this.btcargaagregadevolucion.ForeColor = System.Drawing.SystemColors.Control;
            this.btcargaagregadevolucion.Location = new System.Drawing.Point(18, 61);
            this.btcargaagregadevolucion.Name = "btcargaagregadevolucion";
            this.btcargaagregadevolucion.Size = new System.Drawing.Size(97, 93);
            this.btcargaagregadevolucion.TabIndex = 4;
            this.btcargaagregadevolucion.Text = "Agregar";
            this.btcargaagregadevolucion.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btcargaagregadevolucion.UseVisualStyleBackColor = true;
            this.btcargaagregadevolucion.Click += new System.EventHandler(this.btcargaagregadevolucion_Click);
            // 
            // btcargaconsulatrdevolucion
            // 
            this.btcargaconsulatrdevolucion.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btcargaconsulatrdevolucion.BackgroundImage")));
            this.btcargaconsulatrdevolucion.ForeColor = System.Drawing.SystemColors.Control;
            this.btcargaconsulatrdevolucion.Location = new System.Drawing.Point(18, 237);
            this.btcargaconsulatrdevolucion.Name = "btcargaconsulatrdevolucion";
            this.btcargaconsulatrdevolucion.Size = new System.Drawing.Size(97, 93);
            this.btcargaconsulatrdevolucion.TabIndex = 45;
            this.btcargaconsulatrdevolucion.Text = "Consultar";
            this.btcargaconsulatrdevolucion.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btcargaconsulatrdevolucion.UseVisualStyleBackColor = true;
            this.btcargaconsulatrdevolucion.Click += new System.EventHandler(this.btcargaconsulatrdevolucion_Click);
            // 
            // gbconsultardevolucion
            // 
            this.gbconsultardevolucion.Controls.Add(this.dataGridView1);
            this.gbconsultardevolucion.Controls.Add(this.button1);
            this.gbconsultardevolucion.Controls.Add(this.textBox1);
            this.gbconsultardevolucion.Controls.Add(this.label4);
            this.gbconsultardevolucion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbconsultardevolucion.ForeColor = System.Drawing.Color.Gold;
            this.gbconsultardevolucion.Location = new System.Drawing.Point(15, 12);
            this.gbconsultardevolucion.Name = "gbconsultardevolucion";
            this.gbconsultardevolucion.Size = new System.Drawing.Size(637, 348);
            this.gbconsultardevolucion.TabIndex = 45;
            this.gbconsultardevolucion.TabStop = false;
            this.gbconsultardevolucion.Text = "Consultar Devolución";
            this.gbconsultardevolucion.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(9, 40);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "N° Boleta:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(85, 38);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(216, 26);
            this.textBox1.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(315, 37);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(99, 28);
            this.button1.TabIndex = 39;
            this.button1.Text = "Buscar";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(13, 93);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(607, 150);
            this.dataGridView1.TabIndex = 40;
            // 
            // Column1
            // 
            this.Column1.FalseValue = "falso";
            this.Column1.HeaderText = "Seleccione";
            this.Column1.Name = "Column1";
            this.Column1.TrueValue = "verdadero";
            this.Column1.Width = 93;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "Cantidad";
            this.Column2.HeaderText = "Cantidad";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Column2.Width = 150;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "Producto";
            this.Column3.HeaderText = "Producto";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 161;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "Precio";
            this.Column4.HeaderText = "Precio";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 80;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "Subtotal";
            this.Column5.HeaderText = "Subtotal";
            this.Column5.Name = "Column5";
            this.Column5.Width = 79;
            // 
            // Mantenedor_Devolucion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(906, 585);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Mantenedor_Devolucion";
            this.Text = "Mantenedor_Devolucion";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.gbagregardevolucion.ResumeLayout(false);
            this.gbagregardevolucion.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grilladevolucion)).EndInit();
            this.gbconsultardevolucion.ResumeLayout(false);
            this.gbconsultardevolucion.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox gbagregardevolucion;
        private System.Windows.Forms.Button btdevolver;
        private System.Windows.Forms.TextBox txtmotivodevolucion;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtunidadesdevueltas;
        private System.Windows.Forms.DataGridView grilladevolucion;
        private System.Windows.Forms.Button btbuscarventa;
        private System.Windows.Forms.TextBox txtnumeroventadevolucion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox gbconsultardevolucion;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btcargaconsulatrdevolucion;
        private System.Windows.Forms.Button btcargaagregadevolucion;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;

    }
}