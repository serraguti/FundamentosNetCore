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
    public partial class Form17ColeccionList : Form
    {
        int contador;
        List<Button> botones;

        public Form17ColeccionList()
        {
            InitializeComponent();
            this.contador = 0;
            this.botones = new List<Button>();
            //ESTO RECORRE TODOS LOS CONTROLES DEL Form
            foreach (Control control in this.Controls)
            {
                if (control is Button)
                {
                    this.botones.Add((Button)control);
                }
            }
            //botones.Add(this.button1);
            //botones.Add(this.button2);
            //botones.Add(this.button3);



            foreach (Button btn in botones)
            {
                btn.BackColor = Color.LightCyan;
                btn.Click += IncrementarContador;
            }
        }

        private void IncrementarContador(object sender, EventArgs e)
        {
            this.contador += 1;
            String name = ((Button)sender).Name;
            this.textBox1.Text = name + ": " + this.contador;
        }
    }
}
