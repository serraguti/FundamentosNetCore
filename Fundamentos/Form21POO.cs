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
    public partial class Form21POO : Form
    {
        public Form21POO()
        {
            InitializeComponent();
        }

        private void btnInstanciarPersona_Click(object sender, EventArgs e)
        {
            Persona person = new Persona();
            person.Nombre = "Alumno Net";
            person.Apellidos = "Core";
            person.Edad = 26;
            //person.Domicilio = new Direccion();
            //person.Domicilio.Calle = "Calle Pez";
            person.Nacionalidad = Paises.Alemania;
            person.Genero = TipoGenero.Femenino;
            person.MetodoParametroOpcional(88);
            person.MetodoParametroOpcional(66, 55);
            //SI TUVIERAMOS MAS PARAMETROS OPCIONALES
            person.MetodoParametroOpcional(22, parametroopcional: 77);
            this.lstPropiedades.Items.Add("GetNombreCompleto(): "
                + person.GetNombreCompleto(true));
            this.lstPropiedades.Items.Add("Nombre: " + person.Nombre);
            this.lstPropiedades.Items.Add("Edad " + person.Edad);
            this.lstPropiedades.Items.Add("Nacionalidad: " + person.Nacionalidad);
            this.lstPropiedades.Items.Add("Genero: " + person.Genero);
        }
    }
}
