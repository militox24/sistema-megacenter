namespace sistema_megacenter
{
    partial class Mantenedor_Pregunta_Secreta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Mantenedor_Pregunta_Secreta));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtrespuestarecupera = new System.Windows.Forms.TextBox();
            this.BtAceptar = new System.Windows.Forms.Button();
            this.txtpreguntasecretarecupera = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(41, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Pregunta:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(41, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Respuesta:";
            // 
            // txtrespuestarecupera
            // 
            this.txtrespuestarecupera.Location = new System.Drawing.Point(148, 117);
            this.txtrespuestarecupera.Name = "txtrespuestarecupera";
            this.txtrespuestarecupera.Size = new System.Drawing.Size(229, 20);
            this.txtrespuestarecupera.TabIndex = 4;
            // 
            // BtAceptar
            // 
            this.BtAceptar.BackColor = System.Drawing.SystemColors.ControlText;
            this.BtAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtAceptar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.BtAceptar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtAceptar.Image = ((System.Drawing.Image)(resources.GetObject("BtAceptar.Image")));
            this.BtAceptar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtAceptar.Location = new System.Drawing.Point(170, 189);
            this.BtAceptar.Name = "BtAceptar";
            this.BtAceptar.Size = new System.Drawing.Size(166, 36);
            this.BtAceptar.TabIndex = 5;
            this.BtAceptar.Text = "Aceptar";
            this.BtAceptar.UseVisualStyleBackColor = false;
            this.BtAceptar.Click += new System.EventHandler(this.BtAceptar_Click);
            // 
            // txtpreguntasecretarecupera
            // 
            this.txtpreguntasecretarecupera.Enabled = false;
            this.txtpreguntasecretarecupera.Location = new System.Drawing.Point(148, 64);
            this.txtpreguntasecretarecupera.Name = "txtpreguntasecretarecupera";
            this.txtpreguntasecretarecupera.Size = new System.Drawing.Size(229, 20);
            this.txtpreguntasecretarecupera.TabIndex = 6;
            // 
            // Mantenedor_Pregunta_Secreta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(535, 354);
            this.Controls.Add(this.txtpreguntasecretarecupera);
            this.Controls.Add(this.BtAceptar);
            this.Controls.Add(this.txtrespuestarecupera);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Mantenedor_Pregunta_Secreta";
            this.Text = "Mantenedor_Pregunta_Secreta";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtrespuestarecupera;
        private System.Windows.Forms.Button BtAceptar;
        private System.Windows.Forms.TextBox txtpreguntasecretarecupera;
    }
}