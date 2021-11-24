
namespace Fundamentos
{
    partial class Form12SeleccionMultipleColeccion
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
            this.lblSeleccionados = new System.Windows.Forms.Label();
            this.lblPosiciones = new System.Windows.Forms.Label();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnInsertar = new System.Windows.Forms.Button();
            this.txtElemento = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lstElementos = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSeleccionados = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblSeleccionados
            // 
            this.lblSeleccionados.AutoSize = true;
            this.lblSeleccionados.Location = new System.Drawing.Point(56, 376);
            this.lblSeleccionados.Name = "lblSeleccionados";
            this.lblSeleccionados.Size = new System.Drawing.Size(215, 37);
            this.lblSeleccionados.TabIndex = 19;
            this.lblSeleccionados.Text = "lblSeleccionados";
            // 
            // lblPosiciones
            // 
            this.lblPosiciones.AutoSize = true;
            this.lblPosiciones.Location = new System.Drawing.Point(56, 320);
            this.lblPosiciones.Name = "lblPosiciones";
            this.lblPosiciones.Size = new System.Drawing.Size(170, 37);
            this.lblPosiciones.TabIndex = 18;
            this.lblPosiciones.Text = "lblPosiciones";
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.Black;
            this.btnEliminar.ForeColor = System.Drawing.Color.White;
            this.btnEliminar.Location = new System.Drawing.Point(368, 191);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(275, 54);
            this.btnEliminar.TabIndex = 16;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnInsertar
            // 
            this.btnInsertar.Location = new System.Drawing.Point(368, 113);
            this.btnInsertar.Name = "btnInsertar";
            this.btnInsertar.Size = new System.Drawing.Size(275, 60);
            this.btnInsertar.TabIndex = 14;
            this.btnInsertar.Text = "Insertar";
            this.btnInsertar.UseVisualStyleBackColor = true;
            this.btnInsertar.Click += new System.EventHandler(this.btnInsertar_Click);
            // 
            // txtElemento
            // 
            this.txtElemento.Location = new System.Drawing.Point(368, 50);
            this.txtElemento.Name = "txtElemento";
            this.txtElemento.Size = new System.Drawing.Size(275, 43);
            this.txtElemento.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(358, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 37);
            this.label2.TabIndex = 12;
            this.label2.Text = "Elemento";
            // 
            // lstElementos
            // 
            this.lstElementos.FormattingEnabled = true;
            this.lstElementos.ItemHeight = 37;
            this.lstElementos.Location = new System.Drawing.Point(56, 50);
            this.lstElementos.Name = "lstElementos";
            this.lstElementos.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lstElementos.Size = new System.Drawing.Size(238, 263);
            this.lstElementos.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(56, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(256, 37);
            this.label1.TabIndex = 10;
            this.label1.Text = "Elementos múltiples";
            // 
            // btnSeleccionados
            // 
            this.btnSeleccionados.Location = new System.Drawing.Point(368, 261);
            this.btnSeleccionados.Name = "btnSeleccionados";
            this.btnSeleccionados.Size = new System.Drawing.Size(275, 65);
            this.btnSeleccionados.TabIndex = 20;
            this.btnSeleccionados.Text = "Seleccionados";
            this.btnSeleccionados.UseVisualStyleBackColor = true;
            this.btnSeleccionados.Click += new System.EventHandler(this.btnSeleccionados_Click);
            // 
            // Form12SeleccionMultipleColeccion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(728, 434);
            this.Controls.Add(this.btnSeleccionados);
            this.Controls.Add(this.lblSeleccionados);
            this.Controls.Add(this.lblPosiciones);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnInsertar);
            this.Controls.Add(this.txtElemento);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lstElementos);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.Name = "Form12SeleccionMultipleColeccion";
            this.Text = "Form12SeleccionMultipleColeccion";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSeleccionados;
        private System.Windows.Forms.Label lblPosiciones;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnInsertar;
        private System.Windows.Forms.TextBox txtElemento;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lstElementos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSeleccionados;
    }
}