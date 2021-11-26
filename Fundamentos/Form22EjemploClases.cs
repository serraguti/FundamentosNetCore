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
        public Form22EjemploClases()
        {
            InitializeComponent();
        }

        private void btnGenerarMeses_Click(object sender, EventArgs e)
        {
            DateTime fecha = DateTime.Parse("01/01/2021");
            for (int i = 1; i <= 12; i++)
            {
                String nombreMes = fecha.ToString("MMMM");
                this.lstMeses.Items.Add(nombreMes.ToUpper());
                fecha = fecha.AddMonths(1);
            }
        }
    }
}
