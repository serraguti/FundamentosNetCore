
namespace Fundamentos
{
    partial class Form23TrabajarFicheros
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
            this.txtContenido = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnLeerFichero = new System.Windows.Forms.Button();
            this.btnGuardarFichero = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lstNombres = new System.Windows.Forms.ListBox();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtContenido
            // 
            this.txtContenido.Location = new System.Drawing.Point(29, 54);
            this.txtContenido.Name = "txtContenido";
            this.txtContenido.Size = new System.Drawing.Size(362, 319);
            this.txtContenido.TabIndex = 0;
            this.txtContenido.Text = "";
            this.txtContenido.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 37);
            this.label1.TabIndex = 1;
            this.label1.Text = "Contenido";
            this.label1.Visible = false;
            // 
            // btnLeerFichero
            // 
            this.btnLeerFichero.Location = new System.Drawing.Point(438, 153);
            this.btnLeerFichero.Name = "btnLeerFichero";
            this.btnLeerFichero.Size = new System.Drawing.Size(172, 82);
            this.btnLeerFichero.TabIndex = 2;
            this.btnLeerFichero.Text = "Leer Fichero";
            this.btnLeerFichero.UseVisualStyleBackColor = true;
            this.btnLeerFichero.Click += new System.EventHandler(this.btnLeerFichero_Click);
            // 
            // btnGuardarFichero
            // 
            this.btnGuardarFichero.Location = new System.Drawing.Point(438, 266);
            this.btnGuardarFichero.Name = "btnGuardarFichero";
            this.btnGuardarFichero.Size = new System.Drawing.Size(172, 91);
            this.btnGuardarFichero.TabIndex = 3;
            this.btnGuardarFichero.Text = "Guardar fichero";
            this.btnGuardarFichero.UseVisualStyleBackColor = true;
            this.btnGuardarFichero.Click += new System.EventHandler(this.btnGuardarFichero_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 37);
            this.label2.TabIndex = 4;
            this.label2.Text = "Nombre";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(12, 54);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(263, 43);
            this.txtNombre.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(106, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 37);
            this.label3.TabIndex = 6;
            this.label3.Text = "Nombres";
            // 
            // lstNombres
            // 
            this.lstNombres.FormattingEnabled = true;
            this.lstNombres.ItemHeight = 37;
            this.lstNombres.Location = new System.Drawing.Point(106, 165);
            this.lstNombres.Name = "lstNombres";
            this.lstNombres.Size = new System.Drawing.Size(263, 226);
            this.lstNombres.TabIndex = 7;
            // 
            // btnNuevo
            // 
            this.btnNuevo.Location = new System.Drawing.Point(292, 51);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(100, 46);
            this.btnNuevo.TabIndex = 8;
            this.btnNuevo.Text = "+";
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // Form23TrabajarFicheros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(655, 424);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.lstNombres);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnGuardarFichero);
            this.Controls.Add(this.btnLeerFichero);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtContenido);
            this.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.Name = "Form23TrabajarFicheros";
            this.Text = "Form23TrabajarFicheros";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox txtContenido;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnLeerFichero;
        private System.Windows.Forms.Button btnGuardarFichero;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox lstNombres;
        private System.Windows.Forms.Button btnNuevo;
    }
}