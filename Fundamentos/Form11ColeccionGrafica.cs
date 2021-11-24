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
    public partial class Form11ColeccionGrafica : Form
    {
        public Form11ColeccionGrafica()
        {
            InitializeComponent();
            this.lstElementos.Items.Add("A");
            this.lstElementos.Items.Add("B");
            this.lstElementos.Items.Add("C");
            this.lstElementos.Items.Add("D");
            this.lstElementos.Items.Add("E");
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            string elem = this.txtElemento.Text;
            this.lstElementos.Items.Add(elem);
        }

        private void lstElementos_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.lblPosicion.Text = "Indice: " 
                + this.lstElementos.SelectedIndex.ToString();
            this.lblSeleccionado.Text = "Item: "
                + this.lstElementos.SelectedItem;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            //PARA ELIMINAR TENEMOS DOS METODOS
            //.Remove(Object)
            //.RemoveAt(Index)
            // 0 ANA, 1 LUCIA, 2 ADRIAN, 3 MARIA, 4 ANA
            //.Remove("ANA")
            //.RemoveAt(4)
            int indice = this.lstElementos.SelectedIndex;
            this.lstElementos.Items.RemoveAt(0);
        }

        private void btnLimpiarLista_Click(object sender, EventArgs e)
        {
            this.lstElementos.Items.Clear();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            string elem = this.txtElemento.Text;
            int indice = this.lstElementos.SelectedIndex;
            this.lstElementos.Items[indice] = elem;
        }

        private void btnSubir_Click(object sender, EventArgs e)
        {
            int indice = this.lstElementos.SelectedIndex;
            string elem = this.lstElementos.SelectedItem.ToString();
            this.lstElementos.Items.RemoveAt(indice);
            this.lstElementos.Items.Insert(indice - 1, elem);
            this.lstElementos.SelectedIndex = indice - 1;
        }

        private void btnBajar_Click(object sender, EventArgs e)
        {
            int indice = this.lstElementos.SelectedIndex;
            string elem = this.lstElementos.SelectedItem.ToString();
            this.lstElementos.Items.RemoveAt(indice);
            this.lstElementos.Items.Insert(indice + 1, elem);
            this.lstElementos.SelectedIndex = indice + 1;
        }
    }
}
