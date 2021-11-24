using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fundamentos
{
    public partial class Form14TiendaProductos : Form
    {
        public Form14TiendaProductos()
        {
            InitializeComponent();
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            string elem = this.txtProducto.Text.ToUpper();
            if (this.lstTienda.Items.Contains(elem))
            {
                int posicion = this.lstTienda.Items.IndexOf(elem);
                this.lstTienda.SelectedIndex = -1;
                this.lstTienda.SelectedIndex = posicion;
            }
            else
            {
                this.lstTienda.Items.Add(elem);
            }
            this.txtProducto.SelectAll();
            this.txtProducto.Focus();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int numeroElementos = this.lstTienda.SelectedIndices.Count - 1;
            for (int i = numeroElementos; i >=0; i--)
            {
                int indice = this.lstTienda.SelectedIndices[i];
                this.lstTienda.Items.RemoveAt(indice);
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            string elem = this.txtProducto.Text.ToUpper();
            for (int i = 0; i < this.lstTienda.SelectedItems.Count; i++)
            {
                int indice = this.lstTienda.SelectedIndices[i];
                this.lstTienda.Items[indice] = elem;
            }
        }

        private void btnLimpiarLista_Click(object sender, EventArgs e)
        {
            this.lstTienda.Items.Clear();
        }

        private void btnSeleccionados_Click(object sender, EventArgs e)
        {
            foreach (string producto in this.lstTienda.SelectedItems)
            {
                this.lstAlmacen.Items.Add(producto);
            }
            int numeroElementos = this.lstTienda.SelectedIndices.Count - 1;
            for (int i = numeroElementos; i >= 0; i--)
            {
                int indice = this.lstTienda.SelectedIndices[i];
                this.lstTienda.Items.RemoveAt(indice);
            }
        }

        private void btnTodos_Click(object sender, EventArgs e)
        {
            this.lstAlmacen.Items.AddRange(this.lstTienda.Items);
            this.lstTienda.Items.Clear();
        }

        private void btnSubir_Click(object sender, EventArgs e)
        {
            int indice = this.lstAlmacen.SelectedIndex;
            string elem = this.lstAlmacen.SelectedItem.ToString();
            this.lstAlmacen.Items.RemoveAt(indice);
            this.lstAlmacen.Items.Insert(indice - 1, elem);
            this.lstAlmacen.SelectedIndex = indice - 1;
        }

        private void btnBajar_Click(object sender, EventArgs e)
        {
            int indice = this.lstAlmacen.SelectedIndex;
            string elem = this.lstAlmacen.SelectedItem.ToString();
            this.lstAlmacen.Items.RemoveAt(indice);
            this.lstAlmacen.Items.Insert(indice + 1, elem);
            this.lstAlmacen.SelectedIndex = indice + 1;
        }

        private void lstAlmacen_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.lstAlmacen.SelectedIndex == 0)
            {
                this.btnSubir.Enabled = false;
            }
            else
            {
                this.btnSubir.Enabled = true;
            }
            if (this.lstAlmacen.SelectedIndex == 
                this.lstAlmacen.Items.Count - 1)
            {
                this.btnBajar.Enabled = false;
            }
            else
            {
                this.btnBajar.Enabled = true;
            }
        }
    }
}
