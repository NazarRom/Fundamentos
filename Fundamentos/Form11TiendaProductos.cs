using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fundamentos
{
    public partial class Form11TiendaProductos : Form
    {
        public Form11TiendaProductos()
        {


            Stopwatch krono;
           


            InitializeComponent();
            this.lstTienda.SelectionMode = SelectionMode.MultiExtended;
        }
        void MetodoEnter()
        {
            string producto = this.txtProducto.Text;
            this.lstTienda.Items.Add(producto);
            this.txtProducto.Clear();
        }
        private void btnInsertar_Click(object sender, EventArgs e)
        {
            MetodoEnter();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            //no podemos eliminar elementos utilizando un bucle referencia
            //debemos recorrer todos los elementos seleccionados
            //nos interes el index de cada elemnto
            //numero de elementos seleccionados

            int productoSeleccionado = this.lstTienda.SelectedIndices.Count;
            //recogo los indices seleccionados 

            for( int i = productoSeleccionado -1; i >= 0; i--) //recorro todos los indices desde el final
                //porque si los recorro desde el principio y hay 3 productos entonces si borro el de final ya no hay 3 hay 2 por eso da error
            {
                int indice = this.lstTienda.SelectedIndices[i]; //se selecciona cada indice y se guarda
                this.lstTienda.Items.RemoveAt(indice); //borras solo/los indices seleccionados
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            int productoSeleccionado = this.lstTienda.SelectedIndices.Count;
            //recogo los indices seleccionados 

            for (int i = productoSeleccionado - 1; i >= 0; i--) //recorro todos los indices desde el final
                                                                //porque si los recorro desde el principio y hay 3 productos entonces si borro el de final ya no hay 3 hay 2 por eso da error
            {
                int indice = this.lstTienda.SelectedIndices[i]; //se selecciona cada indice y se guarda
                this.lstTienda.Items[indice] = txtProducto.Text; //borras solo/los indices seleccionados
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            this.lstTienda.Items.Clear();
        }

        private void btnSeleccion_Click(object sender, EventArgs e)
        {
         
            for (int i = this.lstTienda.SelectedIndices.Count - 1; i >= 0; i--) //recorro todos los i hay 3 hay 2 por eso da error
            {
                string producto = this.lstTienda.SelectedItems[i].ToString(); //se selecciona cada indice y se guarda
                int indice = this.lstTienda.SelectedIndices[i];
                this.lstAlmacen.Items.Add(producto);
                this.lstTienda.Items.RemoveAt(indice); //borras solo/los indices seleccionados


            }
        }

        private void btnTodos_Click(object sender, EventArgs e)
        {
            
            foreach (string producto in this.lstTienda.Items)
            {
                this.lstAlmacen.Items.Add(producto);
            }
            this.lstTienda.Items.Clear();
        }

        private void txtProducto_KeyPress(object sender, KeyPressEventArgs e)
        {
            
            if  (e.KeyChar == (char)Keys.Enter)
                 
            {
                this.MetodoEnter();
            }
        }
    }
}
