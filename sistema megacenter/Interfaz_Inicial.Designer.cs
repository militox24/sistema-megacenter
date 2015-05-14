namespace sistema_megacenter
{
    partial class Interfaz_Inicial
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Interfaz_Inicial));
            this.btacessadministrador = new System.Windows.Forms.Button();
            this.Btacessvendedor = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btacessadministrador
            // 
            this.btacessadministrador.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btacessadministrador.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btacessadministrador.BackgroundImage")));
            this.btacessadministrador.Location = new System.Drawing.Point(187, 65);
            this.btacessadministrador.Name = "btacessadministrador";
            this.btacessadministrador.Size = new System.Drawing.Size(617, 144);
            this.btacessadministrador.TabIndex = 0;
            this.btacessadministrador.UseVisualStyleBackColor = false;
            this.btacessadministrador.Click += new System.EventHandler(this.btacessadministrador_Click);
            // 
            // Btacessvendedor
            // 
            this.Btacessvendedor.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.Btacessvendedor.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Btacessvendedor.BackgroundImage")));
            this.Btacessvendedor.Location = new System.Drawing.Point(187, 273);
            this.Btacessvendedor.Name = "Btacessvendedor";
            this.Btacessvendedor.Size = new System.Drawing.Size(617, 144);
            this.Btacessvendedor.TabIndex = 1;
            this.Btacessvendedor.UseVisualStyleBackColor = false;
            this.Btacessvendedor.Click += new System.EventHandler(this.Btacessvendedor_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(965, 532);
            this.Controls.Add(this.Btacessvendedor);
            this.Controls.Add(this.btacessadministrador);
            this.Name = "Form1";
            this.Text = "Interfaz_inicial";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btacessadministrador;
        private System.Windows.Forms.Button Btacessvendedor;
    }
}

