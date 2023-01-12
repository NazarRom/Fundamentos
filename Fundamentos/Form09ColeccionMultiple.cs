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
    public partial class Form09ColeccionMultiple : Form
    {
        public Form09ColeccionMultiple()
        {
            InitializeComponent();
            this.lstElementos.SelectionMode = SelectionMode.MultiExtended;
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            string elem = this.txtNewElement.Text;
            this.lstElementos.Items.Add(elem);
            this.txtNewElement.Focus();
            this.txtNewElement.Clear();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            //no podemos eliminar elementos utilizando un bucle referencia
            //debemos recorrer todos los elementos seleccionados
            //nos interes el index de cada elemnto
            //numero de elementos seleccionados
            int numSeleccionados = this.lstElementos.SelectedIndices.Count;
            //recorremos todos los indices seleccionados
            for (int i = numSeleccionados-1;i>=0; i--)
            {
                //recuperamos el indice selecionado
                int indice = this.lstElementos.SelectedIndices[i];
                //eliminamos el elemento por su inidce
                this.lstElementos.Items.RemoveAt(indice);
            }
        }

        private void btnSeleccionados_Click(object sender, EventArgs e)
        {
            //como solamente vamos a dibujar, podemos utilizar 
            //bucles de referencia
            string indices = "";
            foreach(int indice in this.lstElementos.SelectedIndices)
            {
                indices += indice + ",";
                
            }
            this.lblIndice.Text = indices.Trim(',');
            string items = "";
            foreach(string elem in this.lstElementos.SelectedItems)
            {
                items += elem + ",";
            }
            this.lblItem.Text = items.Trim(',');
        }

        private void btnDeleteAll_Click(object sender, EventArgs e)
        {

        }
    }
}
