using System;
using System.Collections;
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
    public partial class Form16ColeccionArrayList : Form
    {
        public Form16ColeccionArrayList()
        {
            InitializeComponent();
            ArrayList coleccion = new ArrayList();
            coleccion.Add(this.button1);
            coleccion.Add(this.button2);
            coleccion.Add(this.button3);
            //AÑADIMOS LA CAJA A LA COLECCION
            coleccion.Add(this.textBox1);
            //QUEREMOS CAMBIAR EL COLOR AL PRIMER ELEMENTO
            //DE LA COLECCION
            //((Button)coleccion[0]).BackColor = Color.Fuchsia;
            foreach (Control control in coleccion)
            {
                //LOGICAMENTE, PODEMOS PREGUNTAR POR TIPOS
                //DEFINIDOS EN LOS OBJETOS
                if (control is TextBox)
                {
                    control.BackColor = Color.Yellow;
                    //TextBox TIENE UN METODO LLAMADO Paste()
                    //QUE PEGA LO QUE TENGAMOS EN EL PORTAPAPELES
                    //quiero pegar el contenido en la caja
                    ((TextBox)control).Paste();
                }
                else
                {
                    control.BackColor = Color.Fuchsia;
                }
            }

        }
    }
}
