
namespace Fundamentos
{
    partial class Form13ColeccionNumeros
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
            this.btnMostrarDatos = new System.Windows.Forms.Button();
            this.btnGenerar = new System.Windows.Forms.Button();
            this.txtSuma = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lstNumeros = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPares = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtImpares = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnMostrarDatos
            // 
            this.btnMostrarDatos.Location = new System.Drawing.Point(339, 101);
            this.btnMostrarDatos.Name = "btnMostrarDatos";
            this.btnMostrarDatos.Size = new System.Drawing.Size(275, 63);
            this.btnMostrarDatos.TabIndex = 15;
            this.btnMostrarDatos.Text = "Mostrar datos";
            this.btnMostrarDatos.UseVisualStyleBackColor = true;
            this.btnMostrarDatos.Click += new System.EventHandler(this.btnMostrarDatos_Click);
            // 
            // btnGenerar
            // 
            this.btnGenerar.Location = new System.Drawing.Point(339, 12);
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.Size = new System.Drawing.Size(275, 60);
            this.btnGenerar.TabIndex = 14;
            this.btnGenerar.Text = "Generar";
            this.btnGenerar.UseVisualStyleBackColor = true;
            this.btnGenerar.Click += new System.EventHandler(this.btnGenerar_Click);
            // 
            // txtSuma
            // 
            this.txtSuma.Location = new System.Drawing.Point(487, 179);
            this.txtSuma.Name = "txtSuma";
            this.txtSuma.Size = new System.Drawing.Size(73, 43);
            this.txtSuma.TabIndex = 13;
            this.txtSuma.Text = "13";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(382, 185);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 37);
            this.label2.TabIndex = 12;
            this.label2.Text = "Suma";
            // 
            // lstNumeros
            // 
            this.lstNumeros.FormattingEnabled = true;
            this.lstNumeros.ItemHeight = 37;
            this.lstNumeros.Items.AddRange(new object[] {
            "5",
            "2",
            "3",
            "1",
            "2"});
            this.lstNumeros.Location = new System.Drawing.Point(37, 53);
            this.lstNumeros.Name = "lstNumeros";
            this.lstNumeros.Size = new System.Drawing.Size(238, 263);
            this.lstNumeros.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 37);
            this.label1.TabIndex = 10;
            this.label1.Text = "Números";
            // 
            // txtPares
            // 
            this.txtPares.Location = new System.Drawing.Point(487, 242);
            this.txtPares.Name = "txtPares";
            this.txtPares.Size = new System.Drawing.Size(73, 43);
            this.txtPares.TabIndex = 17;
            this.txtPares.Text = "4";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(382, 248);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 37);
            this.label3.TabIndex = 16;
            this.label3.Text = "Pares";
            // 
            // txtImpares
            // 
            this.txtImpares.Location = new System.Drawing.Point(487, 311);
            this.txtImpares.Name = "txtImpares";
            this.txtImpares.Size = new System.Drawing.Size(73, 43);
            this.txtImpares.TabIndex = 19;
            this.txtImpares.Text = "9";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(382, 317);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 37);
            this.label4.TabIndex = 18;
            this.label4.Text = "Impares";
            // 
            // Form13ColeccionNumeros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(680, 408);
            this.Controls.Add(this.txtImpares);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtPares);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnMostrarDatos);
            this.Controls.Add(this.btnGenerar);
            this.Controls.Add(this.txtSuma);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lstNumeros);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.Name = "Form13ColeccionNumeros";
            this.Text = "Form13ColeccionNumeros";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnMostrarDatos;
        private System.Windows.Forms.Button btnGenerar;
        private System.Windows.Forms.TextBox txtSuma;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lstNumeros;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPares;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtImpares;
        private System.Windows.Forms.Label label4;
    }
}