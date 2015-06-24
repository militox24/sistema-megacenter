namespace sistema_megacenter
{
    partial class Mantenedor_Categoria
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Mantenedor_Categoria));
            this.panel1 = new System.Windows.Forms.Panel();
            this.cargamodicategoria = new System.Windows.Forms.Button();
            this.Cargaelimcategoria = new System.Windows.Forms.Button();
            this.cargaagrecategoria = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.gbelimcategoria = new System.Windows.Forms.GroupBox();
            this.btelimcategoria = new System.Windows.Forms.Button();
            this.grillaelimcategoria = new System.Windows.Forms.DataGridView();
            this.Column2 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.btbuscarcategoriaelim = new System.Windows.Forms.Button();
            this.txtbuscarcategoria = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.gbmodificacategoria = new System.Windows.Forms.GroupBox();
            this.btcancelarcategoria = new System.Windows.Forms.Button();
            this.txtnuevonombre = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btbuscarcategoriamodifica = new System.Windows.Forms.Button();
            this.btmodificarcategoria = new System.Windows.Forms.Button();
            this.txtdescripcionmodifica = new System.Windows.Forms.TextBox();
            this.txtcategoriamodifica = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.gbagrecategoria = new System.Windows.Forms.GroupBox();
            this.btagregarcategoria = new System.Windows.Forms.Button();
            this.txtdescripacatgre = new System.Windows.Forms.TextBox();
            this.txtcateagre = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btvolvermenuprincipalcategoria = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.gbelimcategoria.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grillaelimcategoria)).BeginInit();
            this.gbmodificacategoria.SuspendLayout();
            this.gbagrecategoria.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.cargamodicategoria);
            this.panel1.Controls.Add(this.Cargaelimcategoria);
            this.panel1.Controls.Add(this.cargaagrecategoria);
            this.panel1.Location = new System.Drawing.Point(12, 22);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(150, 391);
            this.panel1.TabIndex = 0;
            // 
            // cargamodicategoria
            // 
            this.cargamodicategoria.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cargamodicategoria.BackgroundImage")));
            this.cargamodicategoria.ForeColor = System.Drawing.SystemColors.Control;
            this.cargamodicategoria.Location = new System.Drawing.Point(16, 265);
            this.cargamodicategoria.Name = "cargamodicategoria";
            this.cargamodicategoria.Size = new System.Drawing.Size(97, 93);
            this.cargamodicategoria.TabIndex = 6;
            this.cargamodicategoria.Text = "MODIFICAR";
            this.cargamodicategoria.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.cargamodicategoria.UseVisualStyleBackColor = true;
            this.cargamodicategoria.Click += new System.EventHandler(this.cargamodicategoria_Click);
            // 
            // Cargaelimcategoria
            // 
            this.Cargaelimcategoria.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Cargaelimcategoria.BackgroundImage")));
            this.Cargaelimcategoria.ForeColor = System.Drawing.SystemColors.Control;
            this.Cargaelimcategoria.Location = new System.Drawing.Point(16, 148);
            this.Cargaelimcategoria.Name = "Cargaelimcategoria";
            this.Cargaelimcategoria.Size = new System.Drawing.Size(97, 93);
            this.Cargaelimcategoria.TabIndex = 5;
            this.Cargaelimcategoria.Text = "ELIMINAR";
            this.Cargaelimcategoria.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Cargaelimcategoria.UseVisualStyleBackColor = true;
            this.Cargaelimcategoria.Click += new System.EventHandler(this.Cargaelimcategoria_Click_1);
            // 
            // cargaagrecategoria
            // 
            this.cargaagrecategoria.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cargaagrecategoria.BackgroundImage")));
            this.cargaagrecategoria.ForeColor = System.Drawing.SystemColors.Control;
            this.cargaagrecategoria.Location = new System.Drawing.Point(16, 18);
            this.cargaagrecategoria.Name = "cargaagrecategoria";
            this.cargaagrecategoria.Size = new System.Drawing.Size(97, 93);
            this.cargaagrecategoria.TabIndex = 4;
            this.cargaagrecategoria.Text = "AGREGAR";
            this.cargaagrecategoria.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.cargaagrecategoria.UseVisualStyleBackColor = true;
            this.cargaagrecategoria.Click += new System.EventHandler(this.cargaagrecategoria_Click);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.gbelimcategoria);
            this.panel2.Controls.Add(this.gbmodificacategoria);
            this.panel2.Controls.Add(this.gbagrecategoria);
            this.panel2.Location = new System.Drawing.Point(181, 22);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(602, 391);
            this.panel2.TabIndex = 1;
            // 
            // gbelimcategoria
            // 
            this.gbelimcategoria.Controls.Add(this.btelimcategoria);
            this.gbelimcategoria.Controls.Add(this.grillaelimcategoria);
            this.gbelimcategoria.Controls.Add(this.btbuscarcategoriaelim);
            this.gbelimcategoria.Controls.Add(this.txtbuscarcategoria);
            this.gbelimcategoria.Controls.Add(this.label3);
            this.gbelimcategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.gbelimcategoria.ForeColor = System.Drawing.Color.Gold;
            this.gbelimcategoria.Location = new System.Drawing.Point(15, 18);
            this.gbelimcategoria.Name = "gbelimcategoria";
            this.gbelimcategoria.Size = new System.Drawing.Size(497, 301);
            this.gbelimcategoria.TabIndex = 44;
            this.gbelimcategoria.TabStop = false;
            this.gbelimcategoria.Text = "Eliminar Categoria";
            this.gbelimcategoria.Visible = false;
            // 
            // btelimcategoria
            // 
            this.btelimcategoria.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btelimcategoria.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btelimcategoria.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btelimcategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btelimcategoria.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btelimcategoria.Image = ((System.Drawing.Image)(resources.GetObject("btelimcategoria.Image")));
            this.btelimcategoria.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btelimcategoria.Location = new System.Drawing.Point(305, 249);
            this.btelimcategoria.Name = "btelimcategoria";
            this.btelimcategoria.Size = new System.Drawing.Size(124, 30);
            this.btelimcategoria.TabIndex = 40;
            this.btelimcategoria.Text = "Eliminar";
            this.btelimcategoria.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btelimcategoria.UseVisualStyleBackColor = false;
            this.btelimcategoria.Click += new System.EventHandler(this.btelimcategoria_Click);
            // 
            // grillaelimcategoria
            // 
            this.grillaelimcategoria.AllowUserToAddRows = false;
            this.grillaelimcategoria.AllowUserToDeleteRows = false;
            this.grillaelimcategoria.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grillaelimcategoria.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column2});
            this.grillaelimcategoria.Location = new System.Drawing.Point(19, 76);
            this.grillaelimcategoria.Name = "grillaelimcategoria";
            this.grillaelimcategoria.Size = new System.Drawing.Size(460, 150);
            this.grillaelimcategoria.TabIndex = 39;
            
            // 
            // Column2
            // 
            this.Column2.FalseValue = "false";
            this.Column2.HeaderText = "Seleccione";
            this.Column2.Name = "Column2";
            this.Column2.TrueValue = "true";
            // 
            // btbuscarcategoriaelim
            // 
            this.btbuscarcategoriaelim.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btbuscarcategoriaelim.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btbuscarcategoriaelim.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btbuscarcategoriaelim.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btbuscarcategoriaelim.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btbuscarcategoriaelim.Image = ((System.Drawing.Image)(resources.GetObject("btbuscarcategoriaelim.Image")));
            this.btbuscarcategoriaelim.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btbuscarcategoriaelim.Location = new System.Drawing.Point(339, 36);
            this.btbuscarcategoriaelim.Name = "btbuscarcategoriaelim";
            this.btbuscarcategoriaelim.Size = new System.Drawing.Size(107, 28);
            this.btbuscarcategoriaelim.TabIndex = 38;
            this.btbuscarcategoriaelim.Text = "Buscar";
            this.btbuscarcategoriaelim.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btbuscarcategoriaelim.UseVisualStyleBackColor = false;
            this.btbuscarcategoriaelim.Click += new System.EventHandler(this.btbuscarcategoriaelim_Click);
            // 
            // txtbuscarcategoria
            // 
            this.txtbuscarcategoria.Location = new System.Drawing.Point(110, 36);
            this.txtbuscarcategoria.MaxLength = 50;
            this.txtbuscarcategoria.Name = "txtbuscarcategoria";
            this.txtbuscarcategoria.ShortcutsEnabled = false;
            this.txtbuscarcategoria.Size = new System.Drawing.Size(223, 26);
            this.txtbuscarcategoria.TabIndex = 37;
            this.txtbuscarcategoria.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtbuscarcategoria_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(15, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 20);
            this.label3.TabIndex = 36;
            this.label3.Text = "Categoria:";
            // 
            // gbmodificacategoria
            // 
            this.gbmodificacategoria.Controls.Add(this.btcancelarcategoria);
            this.gbmodificacategoria.Controls.Add(this.txtnuevonombre);
            this.gbmodificacategoria.Controls.Add(this.label6);
            this.gbmodificacategoria.Controls.Add(this.btbuscarcategoriamodifica);
            this.gbmodificacategoria.Controls.Add(this.btmodificarcategoria);
            this.gbmodificacategoria.Controls.Add(this.txtdescripcionmodifica);
            this.gbmodificacategoria.Controls.Add(this.txtcategoriamodifica);
            this.gbmodificacategoria.Controls.Add(this.label1);
            this.gbmodificacategoria.Controls.Add(this.label2);
            this.gbmodificacategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbmodificacategoria.ForeColor = System.Drawing.Color.Gold;
            this.gbmodificacategoria.Location = new System.Drawing.Point(15, 18);
            this.gbmodificacategoria.Name = "gbmodificacategoria";
            this.gbmodificacategoria.Size = new System.Drawing.Size(497, 325);
            this.gbmodificacategoria.TabIndex = 43;
            this.gbmodificacategoria.TabStop = false;
            this.gbmodificacategoria.Text = "Modificar Categoria";
            // 
            // btcancelarcategoria
            // 
            this.btcancelarcategoria.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btcancelarcategoria.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btcancelarcategoria.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btcancelarcategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btcancelarcategoria.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btcancelarcategoria.Image = ((System.Drawing.Image)(resources.GetObject("btcancelarcategoria.Image")));
            this.btcancelarcategoria.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btcancelarcategoria.Location = new System.Drawing.Point(56, 268);
            this.btcancelarcategoria.Name = "btcancelarcategoria";
            this.btcancelarcategoria.Size = new System.Drawing.Size(129, 36);
            this.btcancelarcategoria.TabIndex = 45;
            this.btcancelarcategoria.Text = "Cancelar";
            this.btcancelarcategoria.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btcancelarcategoria.UseVisualStyleBackColor = false;
            this.btcancelarcategoria.Visible = false;
            this.btcancelarcategoria.Click += new System.EventHandler(this.btcancelarcategoria_Click);
            // 
            // txtnuevonombre
            // 
            this.txtnuevonombre.Enabled = false;
            this.txtnuevonombre.Location = new System.Drawing.Point(157, 85);
            this.txtnuevonombre.MaxLength = 50;
            this.txtnuevonombre.Name = "txtnuevonombre";
            this.txtnuevonombre.ShortcutsEnabled = false;
            this.txtnuevonombre.Size = new System.Drawing.Size(215, 26);
            this.txtnuevonombre.TabIndex = 44;
            this.txtnuevonombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtnuevonombre_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(15, 85);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(136, 20);
            this.label6.TabIndex = 43;
            this.label6.Text = "Nuevo Nombre :";
            // 
            // btbuscarcategoriamodifica
            // 
            this.btbuscarcategoriamodifica.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btbuscarcategoriamodifica.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btbuscarcategoriamodifica.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btbuscarcategoriamodifica.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btbuscarcategoriamodifica.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btbuscarcategoriamodifica.Image = ((System.Drawing.Image)(resources.GetObject("btbuscarcategoriamodifica.Image")));
            this.btbuscarcategoriamodifica.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btbuscarcategoriamodifica.Location = new System.Drawing.Point(355, 45);
            this.btbuscarcategoriamodifica.Name = "btbuscarcategoriamodifica";
            this.btbuscarcategoriamodifica.Size = new System.Drawing.Size(107, 28);
            this.btbuscarcategoriamodifica.TabIndex = 42;
            this.btbuscarcategoriamodifica.Text = "Buscar";
            this.btbuscarcategoriamodifica.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btbuscarcategoriamodifica.UseVisualStyleBackColor = false;
            this.btbuscarcategoriamodifica.Click += new System.EventHandler(this.btbuscarcategoriamodifica_Click);
            // 
            // btmodificarcategoria
            // 
            this.btmodificarcategoria.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btmodificarcategoria.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btmodificarcategoria.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btmodificarcategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btmodificarcategoria.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btmodificarcategoria.Image = ((System.Drawing.Image)(resources.GetObject("btmodificarcategoria.Image")));
            this.btmodificarcategoria.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btmodificarcategoria.Location = new System.Drawing.Point(339, 268);
            this.btmodificarcategoria.Name = "btmodificarcategoria";
            this.btmodificarcategoria.Size = new System.Drawing.Size(129, 36);
            this.btmodificarcategoria.TabIndex = 41;
            this.btmodificarcategoria.Text = "Modificar";
            this.btmodificarcategoria.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btmodificarcategoria.UseVisualStyleBackColor = false;
            this.btmodificarcategoria.Visible = false;
            this.btmodificarcategoria.Click += new System.EventHandler(this.btmodificarcategoria_Click);
            // 
            // txtdescripcionmodifica
            // 
            this.txtdescripcionmodifica.Enabled = false;
            this.txtdescripcionmodifica.Location = new System.Drawing.Point(129, 144);
            this.txtdescripcionmodifica.MaxLength = 150;
            this.txtdescripcionmodifica.Multiline = true;
            this.txtdescripcionmodifica.Name = "txtdescripcionmodifica";
            this.txtdescripcionmodifica.ShortcutsEnabled = false;
            this.txtdescripcionmodifica.Size = new System.Drawing.Size(215, 118);
            this.txtdescripcionmodifica.TabIndex = 40;
            this.txtdescripcionmodifica.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtdescripcionmodifica_KeyPress);
            // 
            // txtcategoriamodifica
            // 
            this.txtcategoriamodifica.Location = new System.Drawing.Point(127, 47);
            this.txtcategoriamodifica.MaxLength = 50;
            this.txtcategoriamodifica.Name = "txtcategoriamodifica";
            this.txtcategoriamodifica.ShortcutsEnabled = false;
            this.txtcategoriamodifica.Size = new System.Drawing.Size(215, 26);
            this.txtcategoriamodifica.TabIndex = 39;
            this.txtcategoriamodifica.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtcategoriamodifica_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(6, 144);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 20);
            this.label1.TabIndex = 38;
            this.label1.Text = "Descripción:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(15, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 20);
            this.label2.TabIndex = 37;
            this.label2.Text = "Categoria:";
            // 
            // gbagrecategoria
            // 
            this.gbagrecategoria.Controls.Add(this.btagregarcategoria);
            this.gbagrecategoria.Controls.Add(this.txtdescripacatgre);
            this.gbagrecategoria.Controls.Add(this.txtcateagre);
            this.gbagrecategoria.Controls.Add(this.label5);
            this.gbagrecategoria.Controls.Add(this.label4);
            this.gbagrecategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbagrecategoria.ForeColor = System.Drawing.Color.Gold;
            this.gbagrecategoria.Location = new System.Drawing.Point(15, 18);
            this.gbagrecategoria.Name = "gbagrecategoria";
            this.gbagrecategoria.Size = new System.Drawing.Size(497, 279);
            this.gbagrecategoria.TabIndex = 42;
            this.gbagrecategoria.TabStop = false;
            this.gbagrecategoria.Text = "Agregar Categoria";
            // 
            // btagregarcategoria
            // 
            this.btagregarcategoria.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btagregarcategoria.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btagregarcategoria.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btagregarcategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btagregarcategoria.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btagregarcategoria.Image = ((System.Drawing.Image)(resources.GetObject("btagregarcategoria.Image")));
            this.btagregarcategoria.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btagregarcategoria.Location = new System.Drawing.Point(355, 224);
            this.btagregarcategoria.Name = "btagregarcategoria";
            this.btagregarcategoria.Size = new System.Drawing.Size(113, 36);
            this.btagregarcategoria.TabIndex = 41;
            this.btagregarcategoria.Text = "Agregar";
            this.btagregarcategoria.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btagregarcategoria.UseVisualStyleBackColor = false;
            this.btagregarcategoria.Click += new System.EventHandler(this.btagregarcategoria_Click);
            // 
            // txtdescripacatgre
            // 
            this.txtdescripacatgre.Location = new System.Drawing.Point(127, 105);
            this.txtdescripacatgre.MaxLength = 150;
            this.txtdescripacatgre.Multiline = true;
            this.txtdescripacatgre.Name = "txtdescripacatgre";
            this.txtdescripacatgre.ShortcutsEnabled = false;
            this.txtdescripacatgre.Size = new System.Drawing.Size(215, 118);
            this.txtdescripacatgre.TabIndex = 40;
            this.txtdescripacatgre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtdescripacatgre_KeyPress);
            // 
            // txtcateagre
            // 
            this.txtcateagre.Location = new System.Drawing.Point(127, 47);
            this.txtcateagre.MaxLength = 50;
            this.txtcateagre.Name = "txtcateagre";
            this.txtcateagre.ShortcutsEnabled = false;
            this.txtcateagre.Size = new System.Drawing.Size(215, 26);
            this.txtcateagre.TabIndex = 39;
            this.txtcateagre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtcateagre_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(15, 105);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 20);
            this.label5.TabIndex = 38;
            this.label5.Text = "Descripción:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(15, 47);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 20);
            this.label4.TabIndex = 37;
            this.label4.Text = "Categoria:";
            // 
            // btvolvermenuprincipalcategoria
            // 
            this.btvolvermenuprincipalcategoria.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btvolvermenuprincipalcategoria.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btvolvermenuprincipalcategoria.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btvolvermenuprincipalcategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btvolvermenuprincipalcategoria.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btvolvermenuprincipalcategoria.Image = ((System.Drawing.Image)(resources.GetObject("btvolvermenuprincipalcategoria.Image")));
            this.btvolvermenuprincipalcategoria.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btvolvermenuprincipalcategoria.Location = new System.Drawing.Point(355, 422);
            this.btvolvermenuprincipalcategoria.Name = "btvolvermenuprincipalcategoria";
            this.btvolvermenuprincipalcategoria.Size = new System.Drawing.Size(215, 36);
            this.btvolvermenuprincipalcategoria.TabIndex = 31;
            this.btvolvermenuprincipalcategoria.Text = "Volver Menú Principal";
            this.btvolvermenuprincipalcategoria.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btvolvermenuprincipalcategoria.UseVisualStyleBackColor = false;
            this.btvolvermenuprincipalcategoria.Visible = false;
            this.btvolvermenuprincipalcategoria.Click += new System.EventHandler(this.btvolvermenuprincipalcategoria_Click);
            // 
            // Mantenedor_Categoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(807, 470);
            this.Controls.Add(this.btvolvermenuprincipalcategoria);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Name = "Mantenedor_Categoria";
            this.Text = "Mantenedor_Categoria";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.gbelimcategoria.ResumeLayout(false);
            this.gbelimcategoria.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grillaelimcategoria)).EndInit();
            this.gbmodificacategoria.ResumeLayout(false);
            this.gbmodificacategoria.PerformLayout();
            this.gbagrecategoria.ResumeLayout(false);
            this.gbagrecategoria.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button cargamodicategoria;
        private System.Windows.Forms.Button Cargaelimcategoria;
        private System.Windows.Forms.Button cargaagrecategoria;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox gbelimcategoria;
        private System.Windows.Forms.Button btelimcategoria;
        private System.Windows.Forms.DataGridView grillaelimcategoria;
        private System.Windows.Forms.Button btbuscarcategoriaelim;
        private System.Windows.Forms.TextBox txtbuscarcategoria;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox gbmodificacategoria;
        private System.Windows.Forms.Button btmodificarcategoria;
        private System.Windows.Forms.TextBox txtdescripcionmodifica;
        private System.Windows.Forms.TextBox txtcategoriamodifica;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox gbagrecategoria;
        private System.Windows.Forms.Button btagregarcategoria;
        private System.Windows.Forms.TextBox txtdescripacatgre;
        private System.Windows.Forms.TextBox txtcateagre;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btbuscarcategoriamodifica;
        private System.Windows.Forms.TextBox txtnuevonombre;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btcancelarcategoria;
        private System.Windows.Forms.Button btvolvermenuprincipalcategoria;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Column2;
    }
}