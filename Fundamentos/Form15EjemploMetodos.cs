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
    public partial class Form15EjemploMetodos : Form
    {
        public Form15EjemploMetodos()
        {
            InitializeComponent();
        }

        void DobleNumero(int numero)
        {
            //MODIFICAMOS LA VARIABLE DEL METODO
            numero = numero * 2;
        }

        void CambiarColorBoton(Button boton)
        {
            boton.BackColor = Color.Yellow;
        }

        //PODEMOS HACER QUE UNA VARIABLE WRAPPER SEA REFERENCIADA
        //MEDIANTE LA PALABRA ref
        void DobleNumeroReferencia(ref int numero)
        {
            numero = numero * 2;
        }

        int GetDoble(int numero)
        {
            return numero * 2;
        }

        void MetodoEvento(object sender, EventArgs e)
        {
            //ACCIONES EN UN CUANDO
        }


        private void btnDobleValor_Click(object sender, EventArgs e)
        {
            int num = int.Parse(this.txtNumero.Text);
            int doble = this.GetDoble(num);
            //this.DobleNumero(num);
            this.lblResultado.Text = "Doble: " + doble;
        }

        private void btnMetodoReferencia_Click(object sender, EventArgs e)
        {
            this.CambiarColorBoton(this.btnDobleReferencia);
            this.CambiarColorBoton(this.btnMetodoReferencia);
        }

        private void btnDobleReferencia_Click(object sender, EventArgs e)
        {
            int num = int.Parse(this.txtNumero.Text);
            //EN LA LLAMADA, TAMBIEN DEBEMOS PONER ref
            this.DobleNumeroReferencia(ref num);
            this.lblResultado.Text = "Doble: " + num;
        }

        private void btnMetodoReferencia_MouseMove(object sender, MouseEventArgs e)
        {
        }

        private void lblMouse_MouseMove(object sender, MouseEventArgs e)
        {
            this.lblMouse.Text = "X: " + e.X
                + ", Y: " + e.Y;
        }

        private void txtSoloNumeros_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSoloNumeros_KeyPress(object sender, KeyPressEventArgs e)
        {
            //DEBEMOS CONVERTIR LA TECLA DE BORRAR EN UN CHAR
            char barra = '/';
            char teclaborrar = (char)8;
            char teclaBack = (char)Keys.Back;
            if (char.IsDigit(e.KeyChar) == false && 
                e.KeyChar != teclaBack)
            {
                e.Handled = true;
            }
        }
    }
}
