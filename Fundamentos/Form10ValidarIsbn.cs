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
    public partial class Form10ValidarIsbn : Form
    {
        public Form10ValidarIsbn()
        {
            InitializeComponent();
            int[] numeros = new int[4] { 14, 999, 222, 333 };
            int suma = 0;
            foreach (int num in numeros)
            {
                suma += num;
            }
            this.lblResultado.Text = suma.ToString();

            foreach (Form f in this.OwnedForms)
            {
                f.Text = "Que eres???";
            }

            foreach (Control c in this.Controls)
            {
                c.BackColor = Color.Yellow;
            }
        }

        private void btnValidarISBN_Click(object sender, EventArgs e)
        {
            string isbn = this.txtIsbn.Text;
            if (isbn.Length != 10)
            {
                this.lblResultado.Text = "El ISBN debe tener 10 caracteres";
            }
            else
            {
                int suma = 0;
                for (int i = 0; i < isbn.Length; i++)
                {
                    char caracter = isbn[i];
                    int numero = int.Parse(caracter.ToString());
                    int multi = numero * (i + 1);
                    suma += multi;
                }
                if (suma % 11 == 0)
                {
                    this.lblResultado.Text = "Correcto";
                }
                else
                {
                    this.lblResultado.Text = "Número INCORRECTO!!!";
                }
            }
        }
    }
}
