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
    public partial class Form08SumarNumerosString : Form
    {
        public Form08SumarNumerosString()
        {
            InitializeComponent();
        }

        private void btnSumarNumeros_Click(object sender, EventArgs e)
        {
            bool isNumber = true;
            String textoNumeros = this.txtNumeros.Text;
            for (int i = 0; i < textoNumeros.Length; i++)
            {
                if (char.IsDigit(textoNumeros[i]) == false)
                {
                    isNumber = false;
                    break;
                }
            }
            if (isNumber == false)
            {
                MessageBox.Show("Debe escribir números en la caja", "Warning");
                this.txtNumeros.SelectAll();
                this.txtNumeros.Focus();
            }
            else
            {
                int suma = 0;
                for (int i = 0; i < textoNumeros.Length; i++)
                {
                    char caracter = textoNumeros[i];
                    //La clase Convert sirve para conversiones
                    //especiales Convert.ToInt32(caracter)
                    int numero = int.Parse(caracter.ToString());
                    suma += numero;
                }
                this.lblResultado.Text = "La suma es " + suma.ToString();
            }
        }
    }
}
