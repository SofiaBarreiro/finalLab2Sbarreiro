namespace FinalUTN2020
{
    partial class frmFinal
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
            this.btnMecanicaGral = new System.Windows.Forms.Button();
            this.btnMecanicaEspecifica = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnMecanicaGral
            // 
            this.btnMecanicaGral.Location = new System.Drawing.Point(23, 35);
            this.btnMecanicaGral.Name = "btnMecanicaGral";
            this.btnMecanicaGral.Size = new System.Drawing.Size(203, 168);
            this.btnMecanicaGral.TabIndex = 0;
            this.btnMecanicaGral.Text = "Mecanica General";
            this.btnMecanicaGral.UseVisualStyleBackColor = true;
            this.btnMecanicaGral.Click += new System.EventHandler(this.btnMecanicaGral_Click);
            // 
            // btnMecanicaEspecifica
            // 
            this.btnMecanicaEspecifica.Location = new System.Drawing.Point(324, 35);
            this.btnMecanicaEspecifica.Name = "btnMecanicaEspecifica";
            this.btnMecanicaEspecifica.Size = new System.Drawing.Size(203, 168);
            this.btnMecanicaEspecifica.TabIndex = 1;
            this.btnMecanicaEspecifica.Text = "Mecanica Especifica";
            this.btnMecanicaEspecifica.UseVisualStyleBackColor = true;
            this.btnMecanicaEspecifica.Click += new System.EventHandler(this.btnMecanicaEspecifica_Click);
            // 
            // frmFinal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(603, 254);
            this.Controls.Add(this.btnMecanicaEspecifica);
            this.Controls.Add(this.btnMecanicaGral);
            this.Name = "frmFinal";
            this.Text = "Final UTN 2020";
            this.Load += new System.EventHandler(this.frmFinal_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnMecanicaGral;
        private System.Windows.Forms.Button btnMecanicaEspecifica;
    }
}

