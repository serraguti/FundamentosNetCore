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
    public partial class Form06ClaseChar : Form
    {
        public Form06ClaseChar()
        {
            InitializeComponent();
        }

        private void btnAnalizarAscii_Click(object sender, EventArgs e)
        {
            for (int i = 0; i <= 255; i++)
            {
                char caracter = (char)i;
                if (char.IsLetter(caracter) == true)
                {
                    //this.txtLetras.Text = this.txtLetras.Text + caracter;
                    this.txtLetras.Text += caracter;
                }else if (char.IsNumber(caracter) == true)
                {
                    this.txtNumeros.Text += caracter;
                }else if (char.IsSymbol(caracter) == true)
                {
                    this.txtSimbolos.Text += caracter;
                }else if (char.IsPunctuation(caracter) == true)
                {
                    this.txtPuntuacion.Text += caracter;
                }
            }
            MessageBox.Show("Mensaje", "Titulo", MessageBoxButtons.YesNoCancel
                , MessageBoxIcon.Information);
            String texto = "hola coca cola"; //20
            texto.PadRight(25); //"hola coca cola     "
            texto.PadRight(25, '?'); //"hola coca cola?????"
            
            
            texto.Trim('@'); //hola coca col@

            texto.IndexOf("o"); //1
            texto.IndexOf("o", 2); //6
            texto.Substring(6); //oca cola
            texto.Substring(6, 3); //oca
        }
    }
}
