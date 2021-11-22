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
    public partial class Form03CambiarForm : Form
    {
        public Form03CambiarForm()
        {
            InitializeComponent();
        }

        private void btnPosicion_Click(object sender, EventArgs e)
        {
            int posX = int.Parse(this.txtPosicionX.Text);
            int posY = int.Parse(this.txtPosicionY.Text);
            this.btnPosicion.Location = new Point(posX, posY);
        }

        private void btnCambiarColor_Click(object sender, EventArgs e)
        {
            int rojo, verde, azul;
            rojo = int.Parse(this.txtRojo.Text);
            verde = int.Parse(this.txtVerde.Text);
            azul = int.Parse(this.txtAzul.Text);
            this.BackColor = Color.FromArgb(rojo, verde, azul);
        }

        private void btnEvaluarNumero_Click(object sender, EventArgs e)
        {
            int numero = int.Parse(this.txtNumero.Text);
            if (numero > 0)
            {
                this.lblResultado.Text = "POSITIVO";
                this.lblResultado.ForeColor = Color.Green;
            }else if (numero == 0)
            {
                this.lblResultado.Text = "CERO";
                this.lblResultado.ForeColor = Color.Blue;
            }
            else
            {
                this.lblResultado.Text = "NEGATIVO";
                this.lblResultado.ForeColor = Color.Red;
            }
        }
    }
}
