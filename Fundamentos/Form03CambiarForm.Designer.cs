
namespace Fundamentos
{
    partial class Form03CambiarForm
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
            this.label2 = new System.Windows.Forms.Label();
            this.txtPosicionX = new System.Windows.Forms.TextBox();
            this.txtPosicionY = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtRojo = new System.Windows.Forms.TextBox();
            this.txtVerde = new System.Windows.Forms.TextBox();
            this.txtAzul = new System.Windows.Forms.TextBox();
            this.btnPosicion = new System.Windows.Forms.Button();
            this.btnCambiarColor = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.btnEvaluarNumero = new System.Windows.Forms.Button();
            this.lblResultado = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Posición X:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 37);
            this.label2.TabIndex = 1;
            this.label2.Text = "Posición Y:";
            // 
            // txtPosicionX
            // 
            this.txtPosicionX.Location = new System.Drawing.Point(177, 30);
            this.txtPosicionX.Name = "txtPosicionX";
            this.txtPosicionX.Size = new System.Drawing.Size(100, 43);
            this.txtPosicionX.TabIndex = 2;
            // 
            // txtPosicionY
            // 
            this.txtPosicionY.Location = new System.Drawing.Point(177, 99);
            this.txtPosicionY.Name = "txtPosicionY";
            this.txtPosicionY.Size = new System.Drawing.Size(100, 43);
            this.txtPosicionY.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(360, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 37);
            this.label3.TabIndex = 4;
            this.label3.Text = "Rojo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(360, 99);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 37);
            this.label4.TabIndex = 5;
            this.label4.Text = "Verde";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(360, 157);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 37);
            this.label5.TabIndex = 6;
            this.label5.Text = "Azul";
            // 
            // txtRojo
            // 
            this.txtRojo.Location = new System.Drawing.Point(488, 30);
            this.txtRojo.Name = "txtRojo";
            this.txtRojo.Size = new System.Drawing.Size(100, 43);
            this.txtRojo.TabIndex = 7;
            // 
            // txtVerde
            // 
            this.txtVerde.Location = new System.Drawing.Point(488, 99);
            this.txtVerde.Name = "txtVerde";
            this.txtVerde.Size = new System.Drawing.Size(100, 43);
            this.txtVerde.TabIndex = 8;
            // 
            // txtAzul
            // 
            this.txtAzul.Location = new System.Drawing.Point(488, 157);
            this.txtAzul.Name = "txtAzul";
            this.txtAzul.Size = new System.Drawing.Size(100, 43);
            this.txtAzul.TabIndex = 9;
            // 
            // btnPosicion
            // 
            this.btnPosicion.Location = new System.Drawing.Point(52, 243);
            this.btnPosicion.Name = "btnPosicion";
            this.btnPosicion.Size = new System.Drawing.Size(140, 58);
            this.btnPosicion.TabIndex = 10;
            this.btnPosicion.Text = "Posición";
            this.btnPosicion.UseVisualStyleBackColor = true;
            this.btnPosicion.Click += new System.EventHandler(this.btnPosicion_Click);
            // 
            // btnCambiarColor
            // 
            this.btnCambiarColor.Location = new System.Drawing.Point(380, 242);
            this.btnCambiarColor.Name = "btnCambiarColor";
            this.btnCambiarColor.Size = new System.Drawing.Size(208, 59);
            this.btnCambiarColor.TabIndex = 11;
            this.btnCambiarColor.Text = "Cambiar color";
            this.btnCambiarColor.UseVisualStyleBackColor = true;
            this.btnCambiarColor.Click += new System.EventHandler(this.btnCambiarColor_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(32, 330);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(120, 37);
            this.label6.TabIndex = 12;
            this.label6.Text = "Número:";
            // 
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(158, 324);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(100, 43);
            this.txtNumero.TabIndex = 13;
            // 
            // btnEvaluarNumero
            // 
            this.btnEvaluarNumero.Location = new System.Drawing.Point(328, 324);
            this.btnEvaluarNumero.Name = "btnEvaluarNumero";
            this.btnEvaluarNumero.Size = new System.Drawing.Size(273, 43);
            this.btnEvaluarNumero.TabIndex = 14;
            this.btnEvaluarNumero.Text = "Evaluar Número";
            this.btnEvaluarNumero.UseVisualStyleBackColor = true;
            this.btnEvaluarNumero.Click += new System.EventHandler(this.btnEvaluarNumero_Click);
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Location = new System.Drawing.Point(42, 396);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(164, 37);
            this.lblResultado.TabIndex = 15;
            this.lblResultado.Text = "lblResultado";
            // 
            // Form03CambiarForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(704, 446);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.btnEvaluarNumero);
            this.Controls.Add(this.txtNumero);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnCambiarColor);
            this.Controls.Add(this.btnPosicion);
            this.Controls.Add(this.txtAzul);
            this.Controls.Add(this.txtVerde);
            this.Controls.Add(this.txtRojo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtPosicionY);
            this.Controls.Add(this.txtPosicionX);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.Name = "Form03CambiarForm";
            this.Text = "Form03CambiarForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPosicionX;
        private System.Windows.Forms.TextBox txtPosicionY;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtRojo;
        private System.Windows.Forms.TextBox txtVerde;
        private System.Windows.Forms.TextBox txtAzul;
        private System.Windows.Forms.Button btnPosicion;
        private System.Windows.Forms.Button btnCambiarColor;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.Button btnEvaluarNumero;
        private System.Windows.Forms.Label lblResultado;
    }
}