using ProyectoClases.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace ProyectoClases.Helpers
{
    public class HelperMascota
    {
        public List<Mascota> Mascotas { get; set; }

        public HelperMascota()
        {
            this.Mascotas = new List<Mascota>();
        }

        //tendremos metodos que serán las tripas de la clase
        //vamos a leer un file y contendrá un texto con las mascotas
        // garfield#Gato , REX#perro

        private void CrearMascotas( string data)
        {
            //limpiamos la coleccion para nuevas mascotas
            this.Mascotas.Clear();
            //separamos los objetos
            string[] datosmascotas = data.Split(',');
            foreach( string d in datosmascotas)
            {
                //garfield#gato
                //separamos cada propiedad
                string[] propiedaes = d.Split('#');
                //instanciamos objeto mascota
                Mascota mascota = new Mascota();
                mascota.Nombre = propiedaes[0];
                mascota.Raza = propiedaes[1];
                this.Mascotas.Add(mascota);
              
            }

        }
        //cuando leamos el fichero de mascotas, las crearemos 
        //necesitamos la ruta
         public async Task ReadFileMascotasAsync(string path)
        {
            //extraemos el contenido del fichero 
            string data = await HelperFiles.ReadFileAsync(path);
            this.CrearMascotas(data);
        }

        //al escribir vamos a dibujar todas las mascotas
        //con los separadores que hemos pensado
        private string GetMascotasString()
        {
            string data = "";
            //recorremos la coleccion  List<Mascota>
            //y le damos formnato string
            foreach( Mascota mascota in this.Mascotas)
            {
                string temp = mascota.Nombre + "#" + mascota.Raza;
                data += temp + ",";

            }
            data = data.Trim(',');
            return data;
        }

        public async Task SaveFileMascotasAsync(string path)
        {
            string data = this.GetMascotasString();
           await HelperFiles.WriteFileAsync(path, data);
        }

    }
}
