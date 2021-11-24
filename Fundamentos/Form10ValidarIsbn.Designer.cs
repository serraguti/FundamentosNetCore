
namespace Fundamentos
{
    partial class Form10ValidarIsbn
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
            this.txtIsbn = new System.Windows.Forms.TextBox();
            this.btnValidarISBN = new System.Windows.Forms.Button();
            this.lblResultado = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(183, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Número ISBN:";
            // 
            // txtIsbn
            // 
            this.txtIsbn.Location = new System.Drawing.Point(35, 67);
            this.txtIsbn.Name = "txtIsbn";
            this.txtIsbn.Size = new System.Drawing.Size(318, 43);
            this.txtIsbn.TabIndex = 1;
            // 
            // btnValidarISBN
            // 
            this.btnValidarISBN.Location = new System.Drawing.Point(35, 131);
            this.btnValidarISBN.Name = "btnValidarISBN";
            this.btnValidarISBN.Size = new System.Drawing.Size(318, 51);
            this.btnValidarISBN.TabIndex = 2;
            this.btnValidarISBN.Text = "Validar ISBN";
            this.btnValidarISBN.UseVisualStyleBackColor = true;
            this.btnValidarISBN.Click += new System.EventHandler(this.btnValidarISBN_Click);
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.ForeColor = System.Drawing.Color.Blue;
            this.lblResultado.Location = new System.Drawing.Point(35, 211);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(0, 37);
            this.lblResultado.TabIndex = 3;
            // 
            // Form10ValidarIsbn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(414, 294);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.btnValidarISBN);
            this.Controls.Add(this.txtIsbn);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.Name = "Form10ValidarIsbn";
            this.Text = "Form10ValidarIsbn";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtIsbn;
        private System.Windows.Forms.Button btnValidarISBN;
        private System.Windows.Forms.Label lblResultado;
    }
}