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
    public partial class Form20TemperaturasAnuales : Form
    {
        List<int> temperaturas;

        public Form20TemperaturasAnuales()
        {
            InitializeComponent();
            this.temperaturas = new List<int>();
        }

        private void btnGenerarMeses_Click(object sender, EventArgs e)
        {
            this.lstMeses.Items.Clear();
            this.temperaturas.Clear();
            Random random = new Random();
            DateTime fecha = DateTime.Parse("01/01/2021");
            for (int i = 1; i <= 12; i++)
            {
                int temp = random.Next(-15, 45);
                this.temperaturas.Add(temp);
                String nombreMes = fecha.ToString("MMMM");
                this.lstMeses.Items.Add(nombreMes.ToUpper() + ": " + temp);
                fecha = fecha.AddMonths(1);
            }
        }

        private void btnMostrarDatos_Click(object sender, EventArgs e)
        {
            int maxima, media, minima, suma = 0;
            minima = this.temperaturas[0];
            maxima = this.temperaturas[0];
            foreach (int temp in this.temperaturas)
            {
                suma += temp;
                maxima = Math.Max(temp, maxima);
                minima = Math.Min(temp, minima);
            }
            media = suma / this.temperaturas.Count;
            this.txtMaxima.Text = maxima.ToString();
            this.txtMinima.Text = minima.ToString();
            this.txtMedia.Text = media.ToString();
        }
    }
}
