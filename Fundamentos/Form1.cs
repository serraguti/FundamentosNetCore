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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnPulsar_Click(object sender, EventArgs e)
        {
            //AQUI ESCRIBIMOS NUESTRO CODIGO LOGICO
            //TIPOS DE PROPIEDADES MAS COMUNES
            //PROPIEDAD DE TIPO PRIMITIVO, (int, String)
            this.txtName.Width = 250;
            this.txtName.Text = "600";

            this.btnPrueba.Text = "Pulsado...";
            //TENEMOS PROPIEDADES DE TIPO OBJETO
            //EN DICHAS PROPIEDADES, DEBEMOS INSTANCIAR UN OBJETO
            //Y ADAPTARNOS A LO QUE NOS PIDE
            this.btnPrueba.Location = new Point(20, 50);
            //EXISTEN ALGUNAS CLASES (RARA EXCEPCION)
            //QUE NO SE CREAN, SE UTILIZAN.
            //DICHAS CLASES ESTAN CERRADAS, ES DECIR, NO EXISTE
            //MAS FORMAS DE CREAR SU VALOR Y NOS LO OFRECEN 
            //DIRECTAMENTE
            this.btnPrueba.BackColor = Color.Yellow;
            //PROPIEDADES ENUMERADAS
            //UNA PROPIEDAD ENUMERADA ME OFRECE EL VALOR DIRECTAMENTE
            //DE FORMA TEXTUAL, INTERNAMENTE TIENE UN NUMERO int
            this.txtName.TextAlign= HorizontalAlignment.Center;
        }

        private void btnPrueba_Click(object sender, EventArgs e)
        {
            int numeroMayor = 999;
            short numeroMenor = 888;
            //CASTING PRIMITIVOS
            numeroMenor = (short)numeroMayor;

            String texto = "14";
            int numero = int.Parse(texto);
            double doble = double.Parse(texto);


            int dato = 25;
            String valor = dato.ToString();
            valor = this.btnPrueba.ToString();



        }
    }
}
