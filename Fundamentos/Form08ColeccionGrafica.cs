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
    public partial class Form08ColeccionGrafica : Form
    {
        public Form08ColeccionGrafica()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            string elem = this.txtNewElement.Text;
            this.lstElementos.Items.Add(elem);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            //necesitamos recuperar el objeto seleccionado
            //del control listBox
            //string seleccionado = this.lstElementos.SelectedItem.ToString();
            //this.lstElementos.Items.Remove(seleccionado);

            int indice = this.lstElementos.SelectedIndex;
            this.lstElementos.Items.RemoveAt(indice);
        }

        private void btnDeleteAll_Click(object sender, EventArgs e)
        {
            this.lstElementos.Items.Clear();
        }

        private void lstElementos_SelectedIndexChanged(object sender, EventArgs e)
        {   if (this.lstElementos.SelectedIndex != -1)
            {
                this.lblIndice.Text = this.lstElementos.SelectedIndex.ToString();
                this.lblItem.Text = this.lstElementos.SelectedItem.ToString();
            }
            
        }
    }
}
