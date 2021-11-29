using ProyectoClases.Helpers;
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
    public partial class Form24FilesNombres : Form
    {
        HelperFilesNombresOK helper;

        public Form24FilesNombres()
        {
            InitializeComponent();
        }

        private void DibujarNombres()
        {
            this.lstNombres.Items.Clear();
            foreach (String nombre in this.helper.Nombres)
            {
                this.lstNombres.Items.Add(nombre);
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            String name = this.txtNombre.Text;
            this.helper.Nombres.Add(name);
            this.DibujarNombres();
        }

        private void btnLeerFichero_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                String path = ofd.FileName;
                this.helper = new HelperFilesNombresOK(path);
                this.DibujarNombres();
            }
        }

        private void btnGuardarFichero_Click(object sender, EventArgs e)
        {
            this.helper.WriteFile();
            MessageBox.Show("Datos guardados");
        }
    }
}
