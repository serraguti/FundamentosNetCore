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
    public partial class Form19TablaMultiplicar : Form
    {
        List<TextBox> cajas;

        public Form19TablaMultiplicar()
        {
            InitializeComponent();
            this.cajas = new List<TextBox>();
            foreach (Control c in this.panel1.Controls)
            {
                if (c is TextBox)
                {
                    this.cajas.Add((TextBox)c);
                }
            }

            this.cajas.Reverse();
        }

        private void btnMostrarTabla_Click(object sender, EventArgs e)
        {
            int numero = int.Parse(this.txtNumero.Text);
            for (int i = 0; i < this.cajas.Count; i++)
            {
                int multi = numero * (i + 1);
                this.cajas[i].Text = multi.ToString();
            }
        }
    }
}
