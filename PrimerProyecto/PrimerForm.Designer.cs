﻿namespace PrimerProyecto
{
    partial class PrimerForm
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
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
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblHolaMundo = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.btAceptar = new System.Windows.Forms.Button();
            this.btSuma = new System.Windows.Forms.Button();
            this.btSuma2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblHolaMundo
            // 
            this.lblHolaMundo.AutoSize = true;
            this.lblHolaMundo.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHolaMundo.Location = new System.Drawing.Point(7, 50);
            this.lblHolaMundo.Name = "lblHolaMundo";
            this.lblHolaMundo.Size = new System.Drawing.Size(169, 31);
            this.lblHolaMundo.TabIndex = 0;
            this.lblHolaMundo.Text = "Hola Mundo";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(13, 13);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 20);
            this.txtNombre.TabIndex = 1;
            // 
            // btAceptar
            // 
            this.btAceptar.Location = new System.Drawing.Point(134, 13);
            this.btAceptar.Name = "btAceptar";
            this.btAceptar.Size = new System.Drawing.Size(75, 23);
            this.btAceptar.TabIndex = 2;
            this.btAceptar.Text = "Aceptar";
            this.btAceptar.UseVisualStyleBackColor = true;
            this.btAceptar.Click += new System.EventHandler(this.btAceptar_Click);
            // 
            // btSuma
            // 
            this.btSuma.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btSuma.Location = new System.Drawing.Point(216, 14);
            this.btSuma.Name = "btSuma";
            this.btSuma.Size = new System.Drawing.Size(75, 23);
            this.btSuma.TabIndex = 3;
            this.btSuma.Text = "Suma";
            this.btSuma.UseVisualStyleBackColor = true;
            this.btSuma.Click += new System.EventHandler(this.btSuma_Click);
            // 
            // btSuma2
            // 
            this.btSuma2.Location = new System.Drawing.Point(298, 13);
            this.btSuma2.Name = "btSuma2";
            this.btSuma2.Size = new System.Drawing.Size(75, 23);
            this.btSuma2.TabIndex = 4;
            this.btSuma2.Text = "Suma 2";
            this.btSuma2.UseVisualStyleBackColor = true;
            this.btSuma2.Click += new System.EventHandler(this.btSuma2_Click);
            // 
            // PrimerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(421, 102);
            this.Controls.Add(this.btSuma2);
            this.Controls.Add(this.btSuma);
            this.Controls.Add(this.btAceptar);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblHolaMundo);
            this.Name = "PrimerForm";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHolaMundo;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Button btAceptar;
        private System.Windows.Forms.Button btSuma;
        private System.Windows.Forms.Button btSuma2;
    }
}

