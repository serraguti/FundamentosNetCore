using ProyectoClases;
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
    public partial class Form22EjemploClases : Form
    {
        List<Mes> meses; 

        public Form22EjemploClases()
        {
            InitializeComponent();
            this.meses = new List<Mes>();
        }

        private void btnGenerarMeses_Click(object sender, EventArgs e)
        {
            this.meses.Clear();
            this.lstMeses.Items.Clear();
            DateTime fecha = DateTime.Parse("01/01/2021");
            Random random = new Random();
            for (int i = 1; i <= 12; i++)
            {
                Mes mes = new Mes();
                mes.TemperaturaMaxima = random.Next(15, 45);
                mes.TemperaturaMinima = random.Next(-20, 14);
                String nombremes = fecha.ToString("MMMM");
                mes.Nombre = nombremes;
                fecha = fecha.AddMonths(1);
                this.lstMeses.Items.Add(nombremes);
                this.meses.Add(mes);
            }
        }

        private void lstMeses_SelectedIndexChanged(object sender, EventArgs e)
        {
            int indice = this.lstMeses.SelectedIndex;
            if (indice != -1)
            {
                Mes mes = this.meses[indice];
                this.txtNombreMes.Text = mes.Nombre;
                this.txtMaxima.Text = mes.TemperaturaMaxima.ToString();
                this.txtMinima.Text = mes.TemperaturaMinima.ToString();
                this.txtMedia.Text = mes.GetMediaMensual().ToString();
            }
        }
    }
}
