
namespace Fundamentos
{
    partial class Form24FilesNombres
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
            this.btnNuevo = new System.Windows.Forms.Button();
            this.lstNombres = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnGuardarFichero = new System.Windows.Forms.Button();
            this.btnLeerFichero = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnNuevo
            // 
            this.btnNuevo.Location = new System.Drawing.Point(298, 35);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(100, 46);
            this.btnNuevo.TabIndex = 15;
            this.btnNuevo.Text = "+";
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // lstNombres
            // 
            this.lstNombres.FormattingEnabled = true;
            this.lstNombres.ItemHeight = 37;
            this.lstNombres.Location = new System.Drawing.Point(18, 137);
            this.lstNombres.Name = "lstNombres";
            this.lstNombres.Size = new System.Drawing.Size(263, 226);
            this.lstNombres.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 37);
            this.label3.TabIndex = 13;
            this.label3.Text = "Nombres";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(18, 38);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(263, 43);
            this.txtNombre.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, -2);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 37);
            this.label2.TabIndex = 11;
            this.label2.Text = "Nombre";
            // 
            // btnGuardarFichero
            // 
            this.btnGuardarFichero.Location = new System.Drawing.Point(444, 250);
            this.btnGuardarFichero.Name = "btnGuardarFichero";
            this.btnGuardarFichero.Size = new System.Drawing.Size(172, 91);
            this.btnGuardarFichero.TabIndex = 10;
            this.btnGuardarFichero.Text = "Guardar fichero";
            this.btnGuardarFichero.UseVisualStyleBackColor = true;
            this.btnGuardarFichero.Click += new System.EventHandler(this.btnGuardarFichero_Click);
            // 
            // btnLeerFichero
            // 
            this.btnLeerFichero.Location = new System.Drawing.Point(444, 137);
            this.btnLeerFichero.Name = "btnLeerFichero";
            this.btnLeerFichero.Size = new System.Drawing.Size(172, 82);
            this.btnLeerFichero.TabIndex = 9;
            this.btnLeerFichero.Text = "Leer Fichero";
            this.btnLeerFichero.UseVisualStyleBackColor = true;
            this.btnLeerFichero.Click += new System.EventHandler(this.btnLeerFichero_Click);
            // 
            // Form24FilesNombres
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(650, 387);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.lstNombres);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnGuardarFichero);
            this.Controls.Add(this.btnLeerFichero);
            this.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.Name = "Form24FilesNombres";
            this.Text = "Form24FilesNombres";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.ListBox lstNombres;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnGuardarFichero;
        private System.Windows.Forms.Button btnLeerFichero;
    }
}