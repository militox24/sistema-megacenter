namespace sistema_megacenter
{
    partial class Mantenedor_Cambio_Clave
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Mantenedor_Cambio_Clave));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtnuevaclave = new System.Windows.Forms.TextBox();
            this.txtrepetirclave = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.BtModificarclave = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(35, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nueva Clave:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(35, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Repetir Clave:";
            // 
            // txtnuevaclave
            // 
            this.txtnuevaclave.Location = new System.Drawing.Point(154, 48);
            this.txtnuevaclave.Name = "txtnuevaclave";
            this.txtnuevaclave.PasswordChar = '*';
            this.txtnuevaclave.Size = new System.Drawing.Size(203, 20);
            this.txtnuevaclave.TabIndex = 4;
            this.txtnuevaclave.TextChanged += new System.EventHandler(this.txtnuevaclave_TextChanged);
            // 
            // txtrepetirclave
            // 
            this.txtrepetirclave.Location = new System.Drawing.Point(163, 102);
            this.txtrepetirclave.Name = "txtrepetirclave";
            this.txtrepetirclave.PasswordChar = '*';
            this.txtrepetirclave.Size = new System.Drawing.Size(194, 20);
            this.txtrepetirclave.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(380, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Pregunta:";
            this.label3.Visible = false;
            // 
            // BtModificarclave
            // 
            this.BtModificarclave.BackColor = System.Drawing.SystemColors.ControlText;
            this.BtModificarclave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtModificarclave.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.BtModificarclave.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtModificarclave.Image = ((System.Drawing.Image)(resources.GetObject("BtModificarclave.Image")));
            this.BtModificarclave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtModificarclave.Location = new System.Drawing.Point(191, 156);
            this.BtModificarclave.Name = "BtModificarclave";
            this.BtModificarclave.Size = new System.Drawing.Size(166, 36);
            this.BtModificarclave.TabIndex = 7;
            this.BtModificarclave.Text = "Modificar";
            this.BtModificarclave.UseVisualStyleBackColor = false;
            this.BtModificarclave.Click += new System.EventHandler(this.BtModificarclave_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(371, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(122, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "Nivel seguridad:";
            // 
            // Mantenedor_Cambio_Clave
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(514, 262);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.BtModificarclave);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtrepetirclave);
            this.Controls.Add(this.txtnuevaclave);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Mantenedor_Cambio_Clave";
            this.Text = "Mantenedor_Cambio_Clave";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtnuevaclave;
        private System.Windows.Forms.TextBox txtrepetirclave;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BtModificarclave;
        private System.Windows.Forms.Label label4;
    }
}