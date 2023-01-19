using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoClases
{
    #region Enum
    public enum TipoGenero {Masculino=99, Femenino=109}//para la enumeracion 
    public enum Paises { España, Italia, Francia, Brasil}
    #endregion
    public class Persona
    {
        //public es que se puede usar donde quieras
        //internal solo dentro del proyecto
        //private solo dentro de la clase
        // public string PropiedadAutoImplementada { get; set; } para que en otro pado aparezca con llave y bonito
      
        public Persona()
        {
            this.DomicilioVacaciones = new Direccion("AA", "Miami");
        }


        #region Campos de propiedad
        private int _Edad;
        private TipoGenero _Genero;
        #endregion

        #region Propiedades
        public Direccion Domicilio { get; set; }
        public Direccion DomicilioVacaciones { get; set; }
        public Paises Nacionalidad { get; set; }
        public string Nombre { get; set; }
        public string Apellidos { get; set; }
       

        public TipoGenero Genero
        {
            get { return this._Genero; }
            set
            {
                if (value != TipoGenero.Masculino &&
                    value != TipoGenero.Femenino)
                {
                    throw new Exception("Valor no disponible en enumeración");
                }
                else
                {
                    this._Genero = value;
                }
            }
        }


        public int Edad
        {
            get {
                return this._Edad;
                    }

            set {
                //aqui deseamos comprobar el dato que viene dentro de value
                //value es el valor que me da alguien por fuera cuando utiliza Edad (sin el guion) "public int Edad"
                if (value < 0)
                {
                    throw new Exception("La edad no puede ser negativa");
                }
                else
                {
                    this._Edad = value;
                }
            }
        }
        #endregion

        #region Metodos 
        public string GetNombreCompleto()
        {
            return this.Nombre + " " + this.Apellidos;
        }
        //queremos devolver el nombre inverso
        public string GetNombreCompleto(bool orden)
        {   if (orden == true)
            {
                return this.Apellidos + " " + this.Nombre;
            }
            else
            {
                return this.GetNombreCompleto();
            }
        }
        public void GetNombreCompleto(int num1) { }
        public void GetNombreCompleto(int num1, int num2) { }
        public void GetNombreCompleto(string dato) { }

        public void GetNombreCompleto(int num1, int num2, int num3) { }


        //si un valor lo igualas a algo se vueleve opcional
        public void MetodoParametrosOpcionales(int numero1, int numero = 199, int numero2 = 5) { }
        #endregion
    }
}
