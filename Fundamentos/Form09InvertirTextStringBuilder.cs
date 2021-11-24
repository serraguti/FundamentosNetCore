using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fundamentos
{
    public partial class Form09InvertirTextStringBuilder : Form
    {
        public Form09InvertirTextStringBuilder()
        {
            InitializeComponent();
        }

        private void btnInvertirString_Click(object sender, EventArgs e)
        {
            String texto = this.txtTexto.Text;
            Stopwatch krono = new Stopwatch();
            krono.Start();
            int longitud = texto.Length;
            for (int i = 0; i < longitud; i++)
            {
                //RECUPERAMOS LA ULTIMA LETRA
                char letra = texto[longitud - 1];
                //ELIMINAMOS LA ULTIMA LETRA
                texto = texto.Remove(longitud - 1, 1);
                //INSERTAMOS LA LETRA EN CADA POSICION DEL BUCLE
                texto = texto.Insert(i, letra.ToString());
            }
            this.txtTexto.Text = texto;
            krono.Stop();
            this.lblTiempo.Text = "Segundos: "
            + krono.Elapsed.Seconds
            + "\nMilisegundos: "
            + krono.Elapsed.TotalMilliseconds;
        }

        private void btnInvertirStringBuilder_Click(object sender, EventArgs e)
        {
            StringBuilder texto = new StringBuilder();
            Stopwatch krono = new Stopwatch();
            texto.Append(this.txtTexto.Text);
            krono.Start();
            int longitud = texto.Length;
            for (int i = 0; i < longitud; i++)
            {
                char letra = texto[longitud - 1];
                texto = texto.Remove(longitud - 1, 1);
                texto = texto.Insert(i, letra);
            }
            this.txtTexto.Text = texto.ToString();
            krono.Stop();
            this.lblTiempo.Text = "Segundos: "
                + krono.Elapsed.Seconds
                + "\nMilisegundos: "
                + krono.Elapsed.TotalMilliseconds;
        }
    }
}
