namespace sistema_megacenter
{
    partial class Recupera_Contraseña_2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Recupera_Contraseña_2));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BtAceptar = new System.Windows.Forms.Button();
            this.Rbcorreoelectronico = new System.Windows.Forms.RadioButton();
            this.Rbpreguntasecreta = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.BtAceptar);
            this.groupBox1.Controls.Add(this.Rbcorreoelectronico);
            this.groupBox1.Controls.Add(this.Rbpreguntasecreta);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.groupBox1.ForeColor = System.Drawing.Color.Gold;
            this.groupBox1.Location = new System.Drawing.Point(52, 40);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(549, 264);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Seleccione Opción de recuperación";
            // 
            // BtAceptar
            // 
            this.BtAceptar.BackColor = System.Drawing.SystemColors.ControlText;
            this.BtAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtAceptar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.BtAceptar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtAceptar.Image = ((System.Drawing.Image)(resources.GetObject("BtAceptar.Image")));
            this.BtAceptar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtAceptar.Location = new System.Drawing.Point(260, 170);
            this.BtAceptar.Name = "BtAceptar";
            this.BtAceptar.Size = new System.Drawing.Size(166, 36);
            this.BtAceptar.TabIndex = 4;
            this.BtAceptar.Text = "Aceptar";
            this.BtAceptar.UseVisualStyleBackColor = false;
            this.BtAceptar.Click += new System.EventHandler(this.BtAceptar_Click);
            // 
            // Rbcorreoelectronico
            // 
            this.Rbcorreoelectronico.AutoSize = true;
            this.Rbcorreoelectronico.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Rbcorreoelectronico.ForeColor = System.Drawing.Color.Black;
            this.Rbcorreoelectronico.Location = new System.Drawing.Point(28, 117);
            this.Rbcorreoelectronico.Name = "Rbcorreoelectronico";
            this.Rbcorreoelectronico.Size = new System.Drawing.Size(222, 22);
            this.Rbcorreoelectronico.TabIndex = 1;
            this.Rbcorreoelectronico.TabStop = true;
            this.Rbcorreoelectronico.Text = "Enviar Correo Electrónico";
            this.Rbcorreoelectronico.UseVisualStyleBackColor = true;
            // 
            // Rbpreguntasecreta
            // 
            this.Rbpreguntasecreta.AutoSize = true;
            this.Rbpreguntasecreta.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Rbpreguntasecreta.ForeColor = System.Drawing.Color.Black;
            this.Rbpreguntasecreta.Location = new System.Drawing.Point(28, 63);
            this.Rbpreguntasecreta.Name = "Rbpreguntasecreta";
            this.Rbpreguntasecreta.Size = new System.Drawing.Size(243, 22);
            this.Rbpreguntasecreta.TabIndex = 0;
            this.Rbpreguntasecreta.TabStop = true;
            this.Rbpreguntasecreta.Text = "Responder Pregunta Secreta";
            this.Rbpreguntasecreta.UseVisualStyleBackColor = true;
            // 
            // Recupera_Contraseña_2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(664, 331);
            this.Controls.Add(this.groupBox1);
            this.Name = "Recupera_Contraseña_2";
            this.Text = "Recupera_Contraseña_2";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton Rbcorreoelectronico;
        private System.Windows.Forms.RadioButton Rbpreguntasecreta;
        private System.Windows.Forms.Button BtAceptar;
    }
}