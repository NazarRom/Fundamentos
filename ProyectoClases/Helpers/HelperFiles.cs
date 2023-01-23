using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;// accedo a los datos

namespace ProyectoClases.Helpers
{
    public class HelperFiles
    {
        //necesitamos metodo para leer ficheros
        //este metodo devuleve el string del file
        //en las clases los metodos asyncronos 
        //utilizan la clase task para su declaración
        //si es un void, simplemente la palabra task
        //si es un returnm, se utiliza Task<Tipo>
        public static async Task<string> ReadFileAsync(string path)
        {
            FileInfo file = new FileInfo(path);
            //Para leer vamos a utilizar using 
            //para asegurarnos que dentro del código el objeto estará accesible
            string contenido = "";
            using (TextReader reader = file.OpenText())
            {
                //Deentor de este código debemos utilizar reader y después quedará destruido
                //la lectura devbemos hacerla de forma asincrona
                contenido = await reader.ReadToEndAsync();
                reader.Close();

            }
            return contenido;
        }
        //Metodo para escribir en un file
        //este metodo es de accion (void)
        // no devuelve nada
        public static async Task WriteFileAsync(string path, string data)
        {
            FileInfo file = new FileInfo(path);
            using (TextWriter writer = file.CreateText())
            {

                await writer.WriteAsync(data);
                //siempre que trabajemos con file al escribir 
                //debemos terminar con el metodo flush
                //despues de escribir
                await writer.FlushAsync();
                writer.Close();
            }
        }
    }
}
