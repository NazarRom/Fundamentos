using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using ProyectoClases.Models;
using System.IO;

namespace Fundamentos
{
    public partial class Form23ObjetoXMLMascota : Form
    {
        //el objeto para serializar en xml
        XmlSerializer serializer;
        public Form23ObjetoXMLMascota()
        {
            InitializeComponent();
            //en el momento de iniciar el objeto
            //será necesario indicar la clase que utilizara
            //en la serializacion
            this.serializer = new XmlSerializer(typeof(Mascota));//devuelve el tipo
        }

        private void btnLeerDato_Click(object sender, EventArgs e)
        {
            //leer es igual solo que se utiliza un objeto llamado
            //stremReader
            Mascota mascota = null;
            using(StreamReader reader = new StreamReader("mascota.xml"))
            {
                //necesitamos recuperar el objeto mascota
                //mediante el serializador tiene un metodo 
                //lamado Deserialize que recupera el objeto 
                //serializado
                mascota = (Mascota)this.serializer.Deserialize(reader);
                reader.Close();
            }
            this.txtNombre.Text = mascota.Nombre;
            this.txtRaza.Text = mascota.Raza;
            this.txtEdad.Text = mascota.Years.ToString();

        }

        private async void btnGuardarDato_Click(object sender, EventArgs e)
        {
            Mascota mascota = new Mascota();
            mascota.Nombre = this.txtNombre.Text;
            mascota.Raza = this.txtRaza.Text;
            mascota.Years = int.Parse(this.txtEdad.Text);
            //para serealizar se utiliza el objeto de system.io
            //llamado StreamWriter
            //no importa la extension del archivo, seimpre lo almacena con formato XML
            using (StreamWriter writer = new StreamWriter("mascota.xml"))
            {
                //el serializador xml tiene un metodo llamado
                //serialize() que utiliza el fichero para guardar el objeto
                this.serializer.Serialize(writer, mascota);
                //como hablamos de ficheros y escritura debemos utilizar Flush()
                await writer.FlushAsync();
                writer.Close();
            }

            this.txtEdad.Text = "";
            this.txtNombre.Text = "";
            this.txtRaza.Text = "";
        }
    }
}
