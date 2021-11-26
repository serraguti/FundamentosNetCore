
namespace Fundamentos
{
    partial class Form22EjemploClases
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
            this.txtMedia = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMinima = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMaxima = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnMostrarDatos = new System.Windows.Forms.Button();
            this.btnGenerarMeses = new System.Windows.Forms.Button();
            this.lstMeses = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtMedia
            // 
            this.txtMedia.ForeColor = System.Drawing.Color.Blue;
            this.txtMedia.Location = new System.Drawing.Point(430, 426);
            this.txtMedia.Name = "txtMedia";
            this.txtMedia.Size = new System.Drawing.Size(132, 43);
            this.txtMedia.TabIndex = 19;
            this.txtMedia.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(351, 386);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(225, 37);
            this.label4.TabIndex = 18;
            this.label4.Text = "Media MENSUAL:";
            // 
            // txtMinima
            // 
            this.txtMinima.ForeColor = System.Drawing.Color.Red;
            this.txtMinima.Location = new System.Drawing.Point(430, 336);
            this.txtMinima.Name = "txtMinima";
            this.txtMinima.Size = new System.Drawing.Size(132, 43);
            this.txtMinima.TabIndex = 17;
            this.txtMinima.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(360, 296);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(261, 37);
            this.label3.TabIndex = 16;
            this.label3.Text = "Temperatura minima";
            // 
            // txtMaxima
            // 
            this.txtMaxima.ForeColor = System.Drawing.Color.Blue;
            this.txtMaxima.Location = new System.Drawing.Point(430, 229);
            this.txtMaxima.Name = "txtMaxima";
            this.txtMaxima.Size = new System.Drawing.Size(132, 43);
            this.txtMaxima.TabIndex = 15;
            this.txtMaxima.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(351, 189);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(265, 37);
            this.label2.TabIndex = 14;
            this.label2.Text = "Temperatura máxima";
            // 
            // btnMostrarDatos
            // 
            this.btnMostrarDatos.Location = new System.Drawing.Point(396, 60);
            this.btnMostrarDatos.Name = "btnMostrarDatos";
            this.btnMostrarDatos.Size = new System.Drawing.Size(211, 53);
            this.btnMostrarDatos.TabIndex = 13;
            this.btnMostrarDatos.Text = "Mostrar datos";
            this.btnMostrarDatos.UseVisualStyleBackColor = true;
            // 
            // btnGenerarMeses
            // 
            this.btnGenerarMeses.Location = new System.Drawing.Point(396, -2);
            this.btnGenerarMeses.Name = "btnGenerarMeses";
            this.btnGenerarMeses.Size = new System.Drawing.Size(211, 56);
            this.btnGenerarMeses.TabIndex = 12;
            this.btnGenerarMeses.Text = "Generar meses";
            this.btnGenerarMeses.UseVisualStyleBackColor = true;
            this.btnGenerarMeses.Click += new System.EventHandler(this.btnGenerarMeses_Click);
            // 
            // lstMeses
            // 
            this.lstMeses.FormattingEnabled = true;
            this.lstMeses.ItemHeight = 37;
            this.lstMeses.Location = new System.Drawing.Point(62, 49);
            this.lstMeses.Name = "lstMeses";
            this.lstMeses.Size = new System.Drawing.Size(275, 448);
            this.lstMeses.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(62, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 37);
            this.label1.TabIndex = 10;
            this.label1.Text = "Meses";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(351, 139);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(171, 37);
            this.label5.TabIndex = 20;
            this.label5.Text = "Nombre Mes";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(528, 133);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(247, 43);
            this.textBox1.TabIndex = 21;
            // 
            // Form22EjemploClases
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(811, 509);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtMedia);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtMinima);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtMaxima);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnMostrarDatos);
            this.Controls.Add(this.btnGenerarMeses);
            this.Controls.Add(this.lstMeses);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.Name = "Form22EjemploClases";
            this.Text = "Form22EjemploClases";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtMedia;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtMinima;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMaxima;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnMostrarDatos;
        private System.Windows.Forms.Button btnGenerarMeses;
        private System.Windows.Forms.ListBox lstMeses;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox1;
    }
}