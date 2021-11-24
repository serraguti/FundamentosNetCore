
namespace Fundamentos
{
    partial class Form14TiendaProductos
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
            this.btnBajar = new System.Windows.Forms.Button();
            this.btnSubir = new System.Windows.Forms.Button();
            this.btnLimpiarLista = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnInsertar = new System.Windows.Forms.Button();
            this.txtProducto = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lstTienda = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnTodos = new System.Windows.Forms.Button();
            this.btnSeleccionados = new System.Windows.Forms.Button();
            this.lstAlmacen = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnBajar
            // 
            this.btnBajar.Location = new System.Drawing.Point(601, 360);
            this.btnBajar.Name = "btnBajar";
            this.btnBajar.Size = new System.Drawing.Size(148, 47);
            this.btnBajar.TabIndex = 23;
            this.btnBajar.Text = "Bajar";
            this.btnBajar.UseVisualStyleBackColor = true;
            this.btnBajar.Click += new System.EventHandler(this.btnBajar_Click);
            // 
            // btnSubir
            // 
            this.btnSubir.Location = new System.Drawing.Point(601, 307);
            this.btnSubir.Name = "btnSubir";
            this.btnSubir.Size = new System.Drawing.Size(148, 47);
            this.btnSubir.TabIndex = 22;
            this.btnSubir.Text = "Subir";
            this.btnSubir.UseVisualStyleBackColor = true;
            this.btnSubir.Click += new System.EventHandler(this.btnSubir_Click);
            // 
            // btnLimpiarLista
            // 
            this.btnLimpiarLista.BackColor = System.Drawing.Color.Red;
            this.btnLimpiarLista.ForeColor = System.Drawing.Color.White;
            this.btnLimpiarLista.Location = new System.Drawing.Point(29, 326);
            this.btnLimpiarLista.Name = "btnLimpiarLista";
            this.btnLimpiarLista.Size = new System.Drawing.Size(275, 54);
            this.btnLimpiarLista.TabIndex = 19;
            this.btnLimpiarLista.Text = "Limpiar lista";
            this.btnLimpiarLista.UseVisualStyleBackColor = false;
            this.btnLimpiarLista.Click += new System.EventHandler(this.btnLimpiarLista_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.Red;
            this.btnEliminar.ForeColor = System.Drawing.Color.White;
            this.btnEliminar.Location = new System.Drawing.Point(29, 188);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(275, 54);
            this.btnEliminar.TabIndex = 18;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(29, 257);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(275, 53);
            this.btnModificar.TabIndex = 17;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnInsertar
            // 
            this.btnInsertar.Location = new System.Drawing.Point(29, 122);
            this.btnInsertar.Name = "btnInsertar";
            this.btnInsertar.Size = new System.Drawing.Size(275, 60);
            this.btnInsertar.TabIndex = 16;
            this.btnInsertar.Text = "Insertar";
            this.btnInsertar.UseVisualStyleBackColor = true;
            this.btnInsertar.Click += new System.EventHandler(this.btnInsertar_Click);
            // 
            // txtProducto
            // 
            this.txtProducto.Location = new System.Drawing.Point(29, 59);
            this.txtProducto.Name = "txtProducto";
            this.txtProducto.Size = new System.Drawing.Size(275, 43);
            this.txtProducto.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 37);
            this.label2.TabIndex = 14;
            this.label2.Text = "Producto";
            // 
            // lstTienda
            // 
            this.lstTienda.FormattingEnabled = true;
            this.lstTienda.ItemHeight = 37;
            this.lstTienda.Location = new System.Drawing.Point(328, 59);
            this.lstTienda.Name = "lstTienda";
            this.lstTienda.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lstTienda.Size = new System.Drawing.Size(238, 411);
            this.lstTienda.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(328, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 37);
            this.label1.TabIndex = 12;
            this.label1.Text = "Tienda";
            // 
            // btnTodos
            // 
            this.btnTodos.Location = new System.Drawing.Point(572, 188);
            this.btnTodos.Name = "btnTodos";
            this.btnTodos.Size = new System.Drawing.Size(195, 47);
            this.btnTodos.TabIndex = 25;
            this.btnTodos.Text = "Todos";
            this.btnTodos.UseVisualStyleBackColor = true;
            this.btnTodos.Click += new System.EventHandler(this.btnTodos_Click);
            // 
            // btnSeleccionados
            // 
            this.btnSeleccionados.Location = new System.Drawing.Point(572, 122);
            this.btnSeleccionados.Name = "btnSeleccionados";
            this.btnSeleccionados.Size = new System.Drawing.Size(195, 47);
            this.btnSeleccionados.TabIndex = 24;
            this.btnSeleccionados.Text = "Seleccionados";
            this.btnSeleccionados.UseVisualStyleBackColor = true;
            this.btnSeleccionados.Click += new System.EventHandler(this.btnSeleccionados_Click);
            // 
            // lstAlmacen
            // 
            this.lstAlmacen.FormattingEnabled = true;
            this.lstAlmacen.ItemHeight = 37;
            this.lstAlmacen.Location = new System.Drawing.Point(794, 59);
            this.lstAlmacen.Name = "lstAlmacen";
            this.lstAlmacen.Size = new System.Drawing.Size(238, 411);
            this.lstAlmacen.TabIndex = 27;
            this.lstAlmacen.SelectedIndexChanged += new System.EventHandler(this.lstAlmacen_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(794, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 37);
            this.label3.TabIndex = 26;
            this.label3.Text = "Almacén";
            // 
            // Form14TiendaProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1059, 518);
            this.Controls.Add(this.lstAlmacen);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnTodos);
            this.Controls.Add(this.btnSeleccionados);
            this.Controls.Add(this.btnBajar);
            this.Controls.Add(this.btnSubir);
            this.Controls.Add(this.btnLimpiarLista);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnInsertar);
            this.Controls.Add(this.txtProducto);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lstTienda);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.Name = "Form14TiendaProductos";
            this.Text = "Form14TiendaProductos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBajar;
        private System.Windows.Forms.Button btnSubir;
        private System.Windows.Forms.Button btnLimpiarLista;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnInsertar;
        private System.Windows.Forms.TextBox txtProducto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lstTienda;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnTodos;
        private System.Windows.Forms.Button btnSeleccionados;
        private System.Windows.Forms.ListBox lstAlmacen;
        private System.Windows.Forms.Label label3;
    }
}