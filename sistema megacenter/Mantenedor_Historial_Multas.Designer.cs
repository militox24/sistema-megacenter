﻿namespace sistema_megacenter
{
    partial class Mantenedor_Historial_Multas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Mantenedor_Historial_Multas));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.GrillaHistorial = new System.Windows.Forms.DataGridView();
            this.btvolvermenuprincipal3 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GrillaHistorial)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(27, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(214, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nombre_Vendedor:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(247, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Vendedor";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.GrillaHistorial);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Gold;
            this.groupBox1.Location = new System.Drawing.Point(12, 67);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(517, 309);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Mis Multas";
            // 
            // GrillaHistorial
            // 
            this.GrillaHistorial.AllowUserToAddRows = false;
            this.GrillaHistorial.AllowUserToDeleteRows = false;
            this.GrillaHistorial.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GrillaHistorial.Location = new System.Drawing.Point(6, 35);
            this.GrillaHistorial.Name = "GrillaHistorial";
            this.GrillaHistorial.Size = new System.Drawing.Size(494, 251);
            this.GrillaHistorial.TabIndex = 0;
            // 
            // btvolvermenuprincipal3
            // 
            this.btvolvermenuprincipal3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btvolvermenuprincipal3.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btvolvermenuprincipal3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btvolvermenuprincipal3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btvolvermenuprincipal3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btvolvermenuprincipal3.Image = ((System.Drawing.Image)(resources.GetObject("btvolvermenuprincipal3.Image")));
            this.btvolvermenuprincipal3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btvolvermenuprincipal3.Location = new System.Drawing.Point(241, 398);
            this.btvolvermenuprincipal3.Name = "btvolvermenuprincipal3";
            this.btvolvermenuprincipal3.Size = new System.Drawing.Size(223, 36);
            this.btvolvermenuprincipal3.TabIndex = 90;
            this.btvolvermenuprincipal3.Text = "Volver Menu Principal";
            this.btvolvermenuprincipal3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btvolvermenuprincipal3.UseVisualStyleBackColor = false;
            this.btvolvermenuprincipal3.Click += new System.EventHandler(this.btvolvermenuprincipal3_Click);
            // 
            // Mantenedor_Historial_Multas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(727, 446);
            this.Controls.Add(this.btvolvermenuprincipal3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Mantenedor_Historial_Multas";
            this.Text = "Mantenedor_Historial_Multas";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GrillaHistorial)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView GrillaHistorial;
        private System.Windows.Forms.Button btvolvermenuprincipal3;
    }
}