namespace sistema_megacenter
{
    partial class Mantenedor_correo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Mantenedor_correo));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btcargaenviarcorreo = new System.Windows.Forms.Button();
            this.cargaenviarcorreo = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.gbmismensajes = new System.Windows.Forms.GroupBox();
            this.grillacorreos = new System.Windows.Forms.DataGridView();
            this.gbredactarcorreo = new System.Windows.Forms.GroupBox();
            this.btbuscarcorreo = new System.Windows.Forms.Button();
            this.btenviarcorreo = new System.Windows.Forms.Button();
            this.btbuscararchivocorreo = new System.Windows.Forms.Button();
            this.txtarchivocorreo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtmensajecorreo = new System.Windows.Forms.TextBox();
            this.txtasuntocorreo = new System.Windows.Forms.TextBox();
            this.txtdestinatariocorreo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.gbdetallemensaje = new System.Windows.Forms.GroupBox();
            this.btvolvermismensajes = new System.Windows.Forms.Button();
            this.btverarchivo = new System.Windows.Forms.Button();
            this.txtmensajeverdetalle = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtarchivoverdetalle = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtasuntoverdetalle = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtemisorverdetalle = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewLinkColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewLinkColumn();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.gbmismensajes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grillacorreos)).BeginInit();
            this.gbredactarcorreo.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.gbdetallemensaje.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.btcargaenviarcorreo);
            this.panel1.Controls.Add(this.cargaenviarcorreo);
            this.panel1.Location = new System.Drawing.Point(11, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(150, 399);
            this.panel1.TabIndex = 29;
            // 
            // btcargaenviarcorreo
            // 
            this.btcargaenviarcorreo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btcargaenviarcorreo.BackgroundImage")));
            this.btcargaenviarcorreo.ForeColor = System.Drawing.SystemColors.Control;
            this.btcargaenviarcorreo.Location = new System.Drawing.Point(17, 208);
            this.btcargaenviarcorreo.Name = "btcargaenviarcorreo";
            this.btcargaenviarcorreo.Size = new System.Drawing.Size(97, 99);
            this.btcargaenviarcorreo.TabIndex = 3;
            this.btcargaenviarcorreo.Text = "MIS CORREOS";
            this.btcargaenviarcorreo.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btcargaenviarcorreo.UseVisualStyleBackColor = true;
            this.btcargaenviarcorreo.Click += new System.EventHandler(this.btcargaenviarcorreo_Click);
            // 
            // cargaenviarcorreo
            // 
            this.cargaenviarcorreo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cargaenviarcorreo.BackgroundImage")));
            this.cargaenviarcorreo.ForeColor = System.Drawing.SystemColors.Control;
            this.cargaenviarcorreo.Location = new System.Drawing.Point(17, 29);
            this.cargaenviarcorreo.Name = "cargaenviarcorreo";
            this.cargaenviarcorreo.Size = new System.Drawing.Size(97, 103);
            this.cargaenviarcorreo.TabIndex = 2;
            this.cargaenviarcorreo.Text = "ENVIAR CORREO";
            this.cargaenviarcorreo.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.cargaenviarcorreo.UseVisualStyleBackColor = true;
            this.cargaenviarcorreo.Click += new System.EventHandler(this.cargaenviarcorreo_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.gbmismensajes);
            this.panel2.Controls.Add(this.gbredactarcorreo);
            this.panel2.Controls.Add(this.gbdetallemensaje);
            this.panel2.Location = new System.Drawing.Point(186, 10);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(655, 445);
            this.panel2.TabIndex = 30;
            // 
            // gbmismensajes
            // 
            this.gbmismensajes.Controls.Add(this.grillacorreos);
            this.gbmismensajes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbmismensajes.ForeColor = System.Drawing.Color.Gold;
            this.gbmismensajes.Location = new System.Drawing.Point(17, 39);
            this.gbmismensajes.Name = "gbmismensajes";
            this.gbmismensajes.Size = new System.Drawing.Size(615, 388);
            this.gbmismensajes.TabIndex = 28;
            this.gbmismensajes.TabStop = false;
            this.gbmismensajes.Text = "Mis mensajes";
            this.gbmismensajes.Visible = false;
            // 
            // grillacorreos
            // 
            this.grillacorreos.AllowUserToAddRows = false;
            this.grillacorreos.AllowUserToDeleteRows = false;
            this.grillacorreos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grillacorreos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column1,
            this.Column6});
            this.grillacorreos.Location = new System.Drawing.Point(23, 58);
            this.grillacorreos.Name = "grillacorreos";
            this.grillacorreos.Size = new System.Drawing.Size(574, 176);
            this.grillacorreos.TabIndex = 42;
            this.grillacorreos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grillacorreos_CellClick_1);
            // 
            // gbredactarcorreo
            // 
            this.gbredactarcorreo.Controls.Add(this.btbuscarcorreo);
            this.gbredactarcorreo.Controls.Add(this.btenviarcorreo);
            this.gbredactarcorreo.Controls.Add(this.btbuscararchivocorreo);
            this.gbredactarcorreo.Controls.Add(this.txtarchivocorreo);
            this.gbredactarcorreo.Controls.Add(this.label2);
            this.gbredactarcorreo.Controls.Add(this.groupBox2);
            this.gbredactarcorreo.Controls.Add(this.txtasuntocorreo);
            this.gbredactarcorreo.Controls.Add(this.txtdestinatariocorreo);
            this.gbredactarcorreo.Controls.Add(this.label1);
            this.gbredactarcorreo.Controls.Add(this.label20);
            this.gbredactarcorreo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbredactarcorreo.ForeColor = System.Drawing.Color.Gold;
            this.gbredactarcorreo.Location = new System.Drawing.Point(19, 46);
            this.gbredactarcorreo.Name = "gbredactarcorreo";
            this.gbredactarcorreo.Size = new System.Drawing.Size(613, 392);
            this.gbredactarcorreo.TabIndex = 0;
            this.gbredactarcorreo.TabStop = false;
            this.gbredactarcorreo.Text = "Redactar_Correo";
            // 
            // btbuscarcorreo
            // 
            this.btbuscarcorreo.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btbuscarcorreo.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btbuscarcorreo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btbuscarcorreo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btbuscarcorreo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btbuscarcorreo.Image = ((System.Drawing.Image)(resources.GetObject("btbuscarcorreo.Image")));
            this.btbuscarcorreo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btbuscarcorreo.Location = new System.Drawing.Point(381, 31);
            this.btbuscarcorreo.Name = "btbuscarcorreo";
            this.btbuscarcorreo.Size = new System.Drawing.Size(99, 28);
            this.btbuscarcorreo.TabIndex = 27;
            this.btbuscarcorreo.Text = "Buscar";
            this.btbuscarcorreo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btbuscarcorreo.UseVisualStyleBackColor = false;
            this.btbuscarcorreo.Click += new System.EventHandler(this.btbuscarcorreo_Click);
            // 
            // btenviarcorreo
            // 
            this.btenviarcorreo.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btenviarcorreo.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btenviarcorreo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btenviarcorreo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btenviarcorreo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btenviarcorreo.Image = ((System.Drawing.Image)(resources.GetObject("btenviarcorreo.Image")));
            this.btenviarcorreo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btenviarcorreo.Location = new System.Drawing.Point(356, 328);
            this.btenviarcorreo.Name = "btenviarcorreo";
            this.btenviarcorreo.Size = new System.Drawing.Size(107, 28);
            this.btenviarcorreo.TabIndex = 26;
            this.btenviarcorreo.Text = "Enviar";
            this.btenviarcorreo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btenviarcorreo.UseVisualStyleBackColor = false;
            this.btenviarcorreo.Click += new System.EventHandler(this.btenviarcorreo_Click);
            // 
            // btbuscararchivocorreo
            // 
            this.btbuscararchivocorreo.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btbuscararchivocorreo.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btbuscararchivocorreo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btbuscararchivocorreo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btbuscararchivocorreo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btbuscararchivocorreo.Image = ((System.Drawing.Image)(resources.GetObject("btbuscararchivocorreo.Image")));
            this.btbuscararchivocorreo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btbuscararchivocorreo.Location = new System.Drawing.Point(381, 104);
            this.btbuscararchivocorreo.Name = "btbuscararchivocorreo";
            this.btbuscararchivocorreo.Size = new System.Drawing.Size(120, 28);
            this.btbuscararchivocorreo.TabIndex = 25;
            this.btbuscararchivocorreo.Text = "Examinar";
            this.btbuscararchivocorreo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btbuscararchivocorreo.UseVisualStyleBackColor = false;
            this.btbuscararchivocorreo.Click += new System.EventHandler(this.btbuscararchivocorreo_Click);
            // 
            // txtarchivocorreo
            // 
            this.txtarchivocorreo.Location = new System.Drawing.Point(124, 104);
            this.txtarchivocorreo.Name = "txtarchivocorreo";
            this.txtarchivocorreo.Size = new System.Drawing.Size(251, 26);
            this.txtarchivocorreo.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(6, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 20);
            this.label2.TabIndex = 10;
            this.label2.Text = "Archivo:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtmensajecorreo);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(22, 136);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(533, 184);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Mensaje:";
            // 
            // txtmensajecorreo
            // 
            this.txtmensajecorreo.Location = new System.Drawing.Point(6, 34);
            this.txtmensajecorreo.Multiline = true;
            this.txtmensajecorreo.Name = "txtmensajecorreo";
            this.txtmensajecorreo.Size = new System.Drawing.Size(452, 144);
            this.txtmensajecorreo.TabIndex = 0;
            // 
            // txtasuntocorreo
            // 
            this.txtasuntocorreo.Location = new System.Drawing.Point(124, 64);
            this.txtasuntocorreo.Name = "txtasuntocorreo";
            this.txtasuntocorreo.Size = new System.Drawing.Size(251, 26);
            this.txtasuntocorreo.TabIndex = 8;
            // 
            // txtdestinatariocorreo
            // 
            this.txtdestinatariocorreo.Location = new System.Drawing.Point(124, 32);
            this.txtdestinatariocorreo.Name = "txtdestinatariocorreo";
            this.txtdestinatariocorreo.Size = new System.Drawing.Size(251, 26);
            this.txtdestinatariocorreo.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(6, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Asunto:";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.ForeColor = System.Drawing.Color.Black;
            this.label20.Location = new System.Drawing.Point(6, 32);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(112, 20);
            this.label20.TabIndex = 5;
            this.label20.Text = "Destinatario:";
            // 
            // gbdetallemensaje
            // 
            this.gbdetallemensaje.Controls.Add(this.btvolvermismensajes);
            this.gbdetallemensaje.Controls.Add(this.btverarchivo);
            this.gbdetallemensaje.Controls.Add(this.txtmensajeverdetalle);
            this.gbdetallemensaje.Controls.Add(this.label6);
            this.gbdetallemensaje.Controls.Add(this.txtarchivoverdetalle);
            this.gbdetallemensaje.Controls.Add(this.label5);
            this.gbdetallemensaje.Controls.Add(this.txtasuntoverdetalle);
            this.gbdetallemensaje.Controls.Add(this.label4);
            this.gbdetallemensaje.Controls.Add(this.txtemisorverdetalle);
            this.gbdetallemensaje.Controls.Add(this.label3);
            this.gbdetallemensaje.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbdetallemensaje.ForeColor = System.Drawing.Color.Gold;
            this.gbdetallemensaje.Location = new System.Drawing.Point(19, 32);
            this.gbdetallemensaje.Name = "gbdetallemensaje";
            this.gbdetallemensaje.Size = new System.Drawing.Size(633, 395);
            this.gbdetallemensaje.TabIndex = 30;
            this.gbdetallemensaje.TabStop = false;
            this.gbdetallemensaje.Text = "Ver Detalle Mensaje";
            this.gbdetallemensaje.Visible = false;
            // 
            // btvolvermismensajes
            // 
            this.btvolvermismensajes.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btvolvermismensajes.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btvolvermismensajes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btvolvermismensajes.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btvolvermismensajes.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btvolvermismensajes.Image = ((System.Drawing.Image)(resources.GetObject("btvolvermismensajes.Image")));
            this.btvolvermismensajes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btvolvermismensajes.Location = new System.Drawing.Point(415, 315);
            this.btvolvermismensajes.Name = "btvolvermismensajes";
            this.btvolvermismensajes.Size = new System.Drawing.Size(119, 28);
            this.btvolvermismensajes.TabIndex = 30;
            this.btvolvermismensajes.Text = "Volver ";
            this.btvolvermismensajes.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btvolvermismensajes.UseVisualStyleBackColor = false;
            this.btvolvermismensajes.Click += new System.EventHandler(this.btvolvermismensajes_Click);
            // 
            // btverarchivo
            // 
            this.btverarchivo.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btverarchivo.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btverarchivo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btverarchivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btverarchivo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btverarchivo.Image = ((System.Drawing.Image)(resources.GetObject("btverarchivo.Image")));
            this.btverarchivo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btverarchivo.Location = new System.Drawing.Point(404, 141);
            this.btverarchivo.Name = "btverarchivo";
            this.btverarchivo.Size = new System.Drawing.Size(141, 28);
            this.btverarchivo.TabIndex = 29;
            this.btverarchivo.Text = "Ver Archivo";
            this.btverarchivo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btverarchivo.UseVisualStyleBackColor = false;
            this.btverarchivo.Click += new System.EventHandler(this.btverarchivo_Click);
            // 
            // txtmensajeverdetalle
            // 
            this.txtmensajeverdetalle.Location = new System.Drawing.Point(99, 195);
            this.txtmensajeverdetalle.Multiline = true;
            this.txtmensajeverdetalle.Name = "txtmensajeverdetalle";
            this.txtmensajeverdetalle.ReadOnly = true;
            this.txtmensajeverdetalle.Size = new System.Drawing.Size(298, 146);
            this.txtmensajeverdetalle.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(20, 195);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 20);
            this.label6.TabIndex = 6;
            this.label6.Text = "Mensaje:";
            // 
            // txtarchivoverdetalle
            // 
            this.txtarchivoverdetalle.Enabled = false;
            this.txtarchivoverdetalle.Location = new System.Drawing.Point(85, 145);
            this.txtarchivoverdetalle.Name = "txtarchivoverdetalle";
            this.txtarchivoverdetalle.Size = new System.Drawing.Size(312, 26);
            this.txtarchivoverdetalle.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(20, 145);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Archivo:";
            // 
            // txtasuntoverdetalle
            // 
            this.txtasuntoverdetalle.Enabled = false;
            this.txtasuntoverdetalle.Location = new System.Drawing.Point(85, 94);
            this.txtasuntoverdetalle.Name = "txtasuntoverdetalle";
            this.txtasuntoverdetalle.Size = new System.Drawing.Size(312, 26);
            this.txtasuntoverdetalle.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(17, 97);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 20);
            this.label4.TabIndex = 2;
            this.label4.Text = "Asunto:";
            // 
            // txtemisorverdetalle
            // 
            this.txtemisorverdetalle.Enabled = false;
            this.txtemisorverdetalle.Location = new System.Drawing.Point(85, 48);
            this.txtemisorverdetalle.Name = "txtemisorverdetalle";
            this.txtemisorverdetalle.Size = new System.Drawing.Size(312, 26);
            this.txtemisorverdetalle.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(17, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Emisor:";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel3.Location = new System.Drawing.Point(186, 13);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(567, 399);
            this.panel3.TabIndex = 31;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "Emisor";
            this.Column2.HeaderText = "Emisor";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "Asunto";
            this.Column3.HeaderText = "Asunto";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "Ruta_Archivo";
            this.Column4.HeaderText = "Archivo";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Column5
            // 
            this.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column5.DataPropertyName = "Mensaje";
            this.Column5.HeaderText = "Mensaje";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 94;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Eliminar";
            this.Column1.Name = "Column1";
            this.Column1.Text = "Eliminar";
            this.Column1.UseColumnTextForLinkValue = true;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Ver Mensaje";
            this.Column6.Name = "Column6";
            this.Column6.Text = "ver detalle";
            this.Column6.UseColumnTextForLinkValue = true;
            // 
            // Mantenedor_correo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(870, 488);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Name = "Mantenedor_correo";
            this.Text = "Mantenedor_correo";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.gbmismensajes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grillacorreos)).EndInit();
            this.gbredactarcorreo.ResumeLayout(false);
            this.gbredactarcorreo.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.gbdetallemensaje.ResumeLayout(false);
            this.gbdetallemensaje.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btcargaenviarcorreo;
        private System.Windows.Forms.Button cargaenviarcorreo;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox gbredactarcorreo;
        private System.Windows.Forms.Button btbuscarcorreo;
        private System.Windows.Forms.Button btenviarcorreo;
        private System.Windows.Forms.Button btbuscararchivocorreo;
        private System.Windows.Forms.TextBox txtarchivocorreo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtmensajecorreo;
        private System.Windows.Forms.TextBox txtasuntocorreo;
        private System.Windows.Forms.TextBox txtdestinatariocorreo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.GroupBox gbmismensajes;
        private System.Windows.Forms.GroupBox gbdetallemensaje;
        private System.Windows.Forms.TextBox txtmensajeverdetalle;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtarchivoverdetalle;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtasuntoverdetalle;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtemisorverdetalle;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btvolvermismensajes;
        private System.Windows.Forms.Button btverarchivo;
        private System.Windows.Forms.DataGridView grillacorreos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewLinkColumn Column1;
        private System.Windows.Forms.DataGridViewLinkColumn Column6;
    }
}