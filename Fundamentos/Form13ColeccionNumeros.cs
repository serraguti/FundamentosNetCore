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
    public partial class Form13ColeccionNumeros : Form
    {
        public Form13ColeccionNumeros()
        {
            InitializeComponent();
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            this.lstNumeros.Items.Clear();
            Random random = new Random();
            for (int i = 1; i <= 10; i++)
            {
                int aleat = random.Next(1, 200);
                this.lstNumeros.Items.Add(aleat);
            }
        }

        private void btnMostrarDatos_Click(object sender, EventArgs e)
        {
            int suma = 0, sumapares = 0, sumaimpares = 0;
            foreach (object obj in this.lstNumeros.Items)
            {
                int num = (int)obj;
            }
            //TAMBIEN PODEMOS RECORRER OBJECT CON FOREACH
            //CON EL TIPO DEFINIDO, SIEMPRE QUE TODOS SEAN DEL MISMO
            //TIPO
            foreach (int num in this.lstNumeros.Items)
            {
                suma += num;
                if (num % 2 == 0)
                {
                    sumapares += num;
                }
                else
                {
                    sumaimpares += num;
                }
            }
            this.txtImpares.Text = sumaimpares.ToString();
            this.txtPares.Text = sumapares.ToString();
            this.txtSuma.Text = suma.ToString();
        }
    }
}
