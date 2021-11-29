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

        private void btnEmpleado_Click(object sender, EventArgs e)
        {
            this.lstPropiedades.Items.Clear();
            Empleado empleado = new Empleado();
            empleado.Nombre = "Empleado";
            empleado.Apellidos = "Net Core";
            this.lstPropiedades.Items.Add("Empleado "
                + empleado.GetNombreCompleto());
            this.lstPropiedades.Items.Add("Salario Minimo: "
                + empleado.GetSalarioMinimo());
            this.lstPropiedades.Items.Add("Vacaciones: "
                + empleado.GetDiasVacaciones());
        }

        private void btnDirector_Click(object sender, EventArgs e)
        {
            this.lstPropiedades.Items.Clear();
            Director dire = new Director();
            dire.Nombre = "M.";
            dire.Apellidos = "Rajoy";
            this.lstPropiedades.Items.Add("Director " + dire.GetNombreCompleto());
            this.lstPropiedades.Items.Add("Salario Minimo: " 
                + dire.GetSalarioMinimo());
            this.lstPropiedades.Items.Add("Vacaciones: "
                + dire.GetDiasVacaciones());
        }
    }
}
