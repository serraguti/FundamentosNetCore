
namespace Fundamentos
{
    partial class Form05ClaseDateTime
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
            this.txtFechaActual = new System.Windows.Forms.TextBox();
            this.chkFormato = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnIncrementar = new System.Windows.Forms.Button();
            this.txtIncremento = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.rdbAnyo = new System.Windows.Forms.RadioButton();
            this.rdbMes = new System.Windows.Forms.RadioButton();
            this.rdbDia = new System.Windows.Forms.RadioButton();
            this.txtNuevaFecha = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Fecha Actual";
            // 
            // txtFechaActual
            // 
            this.txtFechaActual.Location = new System.Drawing.Point(30, 54);
            this.txtFechaActual.Name = "txtFechaActual";
            this.txtFechaActual.Size = new System.Drawing.Size(543, 43);
            this.txtFechaActual.TabIndex = 1;
            // 
            // chkFormato
            // 
            this.chkFormato.AutoSize = true;
            this.chkFormato.Location = new System.Drawing.Point(29, 116);
            this.chkFormato.Name = "chkFormato";
            this.chkFormato.Size = new System.Drawing.Size(313, 41);
            this.chkFormato.TabIndex = 2;
            this.chkFormato.Text = "Cambiar Formato fecha";
            this.chkFormato.UseVisualStyleBackColor = true;
            this.chkFormato.CheckedChanged += new System.EventHandler(this.chkFormato_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnIncrementar);
            this.groupBox1.Controls.Add(this.txtIncremento);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.rdbAnyo);
            this.groupBox1.Controls.Add(this.rdbMes);
            this.groupBox1.Controls.Add(this.rdbDia);
            this.groupBox1.Location = new System.Drawing.Point(30, 174);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(519, 212);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Incrementar Fecha";
            // 
            // btnIncrementar
            // 
            this.btnIncrementar.Location = new System.Drawing.Point(305, 138);
            this.btnIncrementar.Name = "btnIncrementar";
            this.btnIncrementar.Size = new System.Drawing.Size(187, 57);
            this.btnIncrementar.TabIndex = 5;
            this.btnIncrementar.Text = "Incrementar";
            this.btnIncrementar.UseVisualStyleBackColor = true;
            this.btnIncrementar.Click += new System.EventHandler(this.btnIncrementar_Click);
            // 
            // txtIncremento
            // 
            this.txtIncremento.Location = new System.Drawing.Point(314, 79);
            this.txtIncremento.Name = "txtIncremento";
            this.txtIncremento.Size = new System.Drawing.Size(157, 43);
            this.txtIncremento.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(305, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(157, 37);
            this.label2.TabIndex = 3;
            this.label2.Text = "Incremento:";
            // 
            // rdbAnyo
            // 
            this.rdbAnyo.AutoSize = true;
            this.rdbAnyo.Location = new System.Drawing.Point(29, 168);
            this.rdbAnyo.Name = "rdbAnyo";
            this.rdbAnyo.Size = new System.Drawing.Size(94, 41);
            this.rdbAnyo.TabIndex = 2;
            this.rdbAnyo.TabStop = true;
            this.rdbAnyo.Text = "Años";
            this.rdbAnyo.UseVisualStyleBackColor = true;
            // 
            // rdbMes
            // 
            this.rdbMes.AutoSize = true;
            this.rdbMes.Location = new System.Drawing.Point(29, 111);
            this.rdbMes.Name = "rdbMes";
            this.rdbMes.Size = new System.Drawing.Size(109, 41);
            this.rdbMes.TabIndex = 1;
            this.rdbMes.TabStop = true;
            this.rdbMes.Text = "Meses";
            this.rdbMes.UseVisualStyleBackColor = true;
            // 
            // rdbDia
            // 
            this.rdbDia.AutoSize = true;
            this.rdbDia.Location = new System.Drawing.Point(29, 54);
            this.rdbDia.Name = "rdbDia";
            this.rdbDia.Size = new System.Drawing.Size(86, 41);
            this.rdbDia.TabIndex = 0;
            this.rdbDia.TabStop = true;
            this.rdbDia.Text = "Dias";
            this.rdbDia.UseVisualStyleBackColor = true;
            // 
            // txtNuevaFecha
            // 
            this.txtNuevaFecha.Location = new System.Drawing.Point(29, 442);
            this.txtNuevaFecha.Name = "txtNuevaFecha";
            this.txtNuevaFecha.Size = new System.Drawing.Size(543, 43);
            this.txtNuevaFecha.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 397);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(168, 37);
            this.label3.TabIndex = 4;
            this.label3.Text = "Nueva Fecha";
            // 
            // Form05ClaseDateTime
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(585, 529);
            this.Controls.Add(this.txtNuevaFecha);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.chkFormato);
            this.Controls.Add(this.txtFechaActual);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.Name = "Form05ClaseDateTime";
            this.Text = "Form05ClaseDateTime";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtFechaActual;
        private System.Windows.Forms.CheckBox chkFormato;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnIncrementar;
        private System.Windows.Forms.TextBox txtIncremento;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton rdbAnyo;
        private System.Windows.Forms.RadioButton rdbMes;
        private System.Windows.Forms.RadioButton rdbDia;
        private System.Windows.Forms.TextBox txtNuevaFecha;
        private System.Windows.Forms.Label label3;
    }
}