using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoClases
{
    public class Director: Empleado
    {
        public Director()
        {
            this.SalarioMinimo += 200;
        }

        //override
        public override int GetDiasVacaciones()
        {
            Debug.WriteLine("GetDiasVacaciones() DIRECTOR");
            int dias = base.GetDiasVacaciones();
            return dias + 8;
        }
    }
}
