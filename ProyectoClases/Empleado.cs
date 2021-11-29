using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoClases
{
    public class Empleado: Persona
    {
        public virtual int GetDiasVacaciones()
        {
            Debug.WriteLine("GetVacaciones() EMPLEADO");
            return 22;
        }

        protected int SalarioMinimo { get; set; }

        public int GetSalarioMinimo()
        {
            return this.SalarioMinimo;
        }

        public Empleado():base("otro", "constructor")
        {
            Debug.WriteLine("Constructor EMPLEADO vacio");
            this.SalarioMinimo = 1800;
        }

        public Empleado(String nombre, String apellidos)
        {
            Debug.WriteLine("Constructor EMPLEADO con parámetros");
            this.SalarioMinimo = 800;
            this.Nombre = nombre;
            this.Apellidos = apellidos;
        }
    }
}
