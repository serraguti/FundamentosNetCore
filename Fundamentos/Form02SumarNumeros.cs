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
    public partial class Form02SumarNumeros : Form
    {
        public Form02SumarNumeros()
        {
            InitializeComponent();
        }

        private void btnSumarNumeros_Click(object sender, EventArgs e)
        {
            int num1, num2;
            num1 = int.Parse(this.txtNumero1.Text);
            num2 = int.Parse(this.txtNumero2.Text);
            int suma = num1 + num2;
            this.lblResultado.Text = "La suma es: " + suma;
        }
    }
}
