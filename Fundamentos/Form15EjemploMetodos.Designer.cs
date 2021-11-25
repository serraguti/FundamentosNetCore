
namespace Fundamentos
{
    partial class Form15EjemploMetodos
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.btnDobleValor = new System.Windows.Forms.Button();
            this.btnDobleReferencia = new System.Windows.Forms.Button();
            this.btnMetodoReferencia = new System.Windows.Forms.Button();
            this.lblResultado = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSoloNumeros = new System.Windows.Forms.TextBox();
            this.txtSoloLetras = new System.Windows.Forms.TextBox();
            this.lblMouse = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Número";
            // 
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(150, 27);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(100, 43);
            this.txtNumero.TabIndex = 1;
            // 
            // btnDobleValor
            // 
            this.btnDobleValor.Location = new System.Drawing.Point(39, 92);
            this.btnDobleValor.Name = "btnDobleValor";
            this.btnDobleValor.Size = new System.Drawing.Size(211, 62);
            this.btnDobleValor.TabIndex = 2;
            this.btnDobleValor.Text = "Doble Valor";
            this.btnDobleValor.UseVisualStyleBackColor = true;
            this.btnDobleValor.Click += new System.EventHandler(this.btnDobleValor_Click);
            // 
            // btnDobleReferencia
            // 
            this.btnDobleReferencia.Location = new System.Drawing.Point(39, 171);
            this.btnDobleReferencia.Name = "btnDobleReferencia";
            this.btnDobleReferencia.Size = new System.Drawing.Size(211, 93);
            this.btnDobleReferencia.TabIndex = 3;
            this.btnDobleReferencia.Text = "Doble Referencia";
            this.btnDobleReferencia.UseVisualStyleBackColor = true;
            this.btnDobleReferencia.Click += new System.EventHandler(this.btnDobleReferencia_Click);
            // 
            // btnMetodoReferencia
            // 
            this.btnMetodoReferencia.Location = new System.Drawing.Point(39, 270);
            this.btnMetodoReferencia.Name = "btnMetodoReferencia";
            this.btnMetodoReferencia.Size = new System.Drawing.Size(211, 97);
            this.btnMetodoReferencia.TabIndex = 4;
            this.btnMetodoReferencia.Text = "Método Clase Referencia";
            this.btnMetodoReferencia.UseVisualStyleBackColor = true;
            this.btnMetodoReferencia.Click += new System.EventHandler(this.btnMetodoReferencia_Click);
            this.btnMetodoReferencia.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnMetodoReferencia_MouseMove);
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.ForeColor = System.Drawing.Color.Blue;
            this.lblResultado.Location = new System.Drawing.Point(39, 388);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(164, 37);
            this.lblResultado.TabIndex = 5;
            this.lblResultado.Text = "lblResultado";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(307, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(180, 37);
            this.label2.TabIndex = 6;
            this.label2.Text = "Solo números";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(307, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(141, 37);
            this.label3.TabIndex = 7;
            this.label3.Text = "Solo letras";
            // 
            // txtSoloNumeros
            // 
            this.txtSoloNumeros.Location = new System.Drawing.Point(527, 27);
            this.txtSoloNumeros.Name = "txtSoloNumeros";
            this.txtSoloNumeros.Size = new System.Drawing.Size(265, 43);
            this.txtSoloNumeros.TabIndex = 8;
            this.txtSoloNumeros.TextChanged += new System.EventHandler(this.txtSoloNumeros_TextChanged);
            this.txtSoloNumeros.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSoloNumeros_KeyPress);
            // 
            // txtSoloLetras
            // 
            this.txtSoloLetras.Location = new System.Drawing.Point(527, 86);
            this.txtSoloLetras.Name = "txtSoloLetras";
            this.txtSoloLetras.Size = new System.Drawing.Size(265, 43);
            this.txtSoloLetras.TabIndex = 9;
            // 
            // lblMouse
            // 
            this.lblMouse.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.lblMouse.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblMouse.Location = new System.Drawing.Point(307, 171);
            this.lblMouse.Name = "lblMouse";
            this.lblMouse.Size = new System.Drawing.Size(485, 254);
            this.lblMouse.TabIndex = 10;
            this.lblMouse.Text = "lblMouse";
            this.lblMouse.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblMouse.MouseMove += new System.Windows.Forms.MouseEventHandler(this.lblMouse_MouseMove);
            // 
            // Form15EjemploMetodos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(842, 457);
            this.Controls.Add(this.lblMouse);
            this.Controls.Add(this.txtSoloLetras);
            this.Controls.Add(this.txtSoloNumeros);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.btnMetodoReferencia);
            this.Controls.Add(this.btnDobleReferencia);
            this.Controls.Add(this.btnDobleValor);
            this.Controls.Add(this.txtNumero);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.Name = "Form15EjemploMetodos";
            this.Text = "Form15EjemploMetodos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.Button btnDobleValor;
        private System.Windows.Forms.Button btnDobleReferencia;
        private System.Windows.Forms.Button btnMetodoReferencia;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSoloNumeros;
        private System.Windows.Forms.TextBox txtSoloLetras;
        private System.Windows.Forms.Label lblMouse;
    }
}