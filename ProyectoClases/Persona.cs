using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoClases
{
    public enum TipoGenero { Femenino, Masculino }    
    public enum Paises { España, Italia, Alemania, Colombia, Francia }

    public class Persona
    {
        #region PROPIEDADES DE LA CLASE

        public Direccion Domicilio { get; set; }

        public String Nombre { get; set; }
        public String Apellidos { get; set; }

        //LAS PROPIEDADES SON DE ALGUN TIPO...
        public TipoGenero Genero { get; set; }

        public Paises Nacionalidad { get; set; }

        //Las propiedades trabajan con campos
        //privados que manejan la propiedad
        //La propiedad es publica, pero yo con el campo
        //privado decido que hacer (es mio)
        private int _Edad;
        public int Edad
        {
            get {
                return this._Edad;
            }
            set {
                if (value < 0)
                {
                    throw new Exception("El valor de la edad no puede ser negativo");
                }
                else
                {
                    this._Edad = value;
                }
            }
        }

        #endregion

        #region METODOS DE LA CLASE

        //METODOS CON PARAMETROS OPCIONALES
        public void MetodoParametroOpcional(int numero 
            , int parametroopcional = 77)
        {
            
        }

        //SOBRECARGA DE METODOS
        public String GetNombreCompleto()
        {
            return this.Nombre + " " + this.Apellidos;
        }

        public String GetNombreCompleto(bool orden)
        {
            //PODEMOS LLAMAR ENTRE FORMAS SIN PROBLEMAS
            //NO DEJAN DE SER OTRO METODO DE LA CLASE
            if (orden == true)
            {
                return this.Apellidos + " " + this.Nombre;
            }
            else
            {
                return this.GetNombreCompleto();
            }
        }

        public void GetNombreCompleto(int numero) { }
        public void GetNombreCompleto(String dato) { }
        public void GetNombreCompleto(int numero1, int numero2) { }
        public void GetNombreCompleto(String dato, int numero) { }


        #endregion
    }
}
