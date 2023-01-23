using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProyectoClases.Helpers;

namespace Fundamentos
{
    public partial class Form21Files : Form
    {
       

        public Form21Files()
        {
            InitializeComponent();
           
        }

        private async void btnReadFile_Click(object sender, EventArgs e)
        {
            //objeto para abrir files
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                string path = ofd.FileName;
                string contenido = await HelperFiles.ReadFileAsync(path);
                this.txtContenido.Text = contenido;
                this.SetStringNombres(contenido);
               
            }
        }

        private async void btnWriteFile_Click(object sender, EventArgs e)
        {

            SaveFileDialog save = new SaveFileDialog();
            if( save.ShowDialog() == DialogResult.OK)
            {
                string path = save.FileName;
                string contenido = this.GetStringNombres();
                await HelperFiles.WriteFileAsync(path, contenido);
                MessageBox.Show("Datos Guardados");
            }
        }
        //metodo para recuperar todos los nombresde la lista en formato separado por comas
        public string GetStringNombres()
        {
            string datos = "";
            foreach (string nombre in this.lstNombres.Items)
            {
                datos += nombre + ",";
                
            }
            datos = datos.Trim(',');
            return datos;
        }

        //metodo para escribir los nombres que tengamos en un string en el listBox
        public void SetStringNombres(string data)
        {
            //antonia , lucia , andrea
            string[] nombres = data.Split(',');
            this.lstNombres.Items.Clear();
            foreach (string name in nombres)
            {
                this.lstNombres.Items.Add(name);
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string nombre = this.txtNombre.Text;
            this.lstNombres.Items.Add(nombre);
            this.txtNombre.SelectAll();
            this.txtNombre.Focus();
        }

    }
}
