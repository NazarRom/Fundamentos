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
    public partial class Form16TablaMultiplicar : Form
    {
        //declaramos la colecicon a nivel de clase
        List<TextBox> textos;
        //necesitamos ina variable para almacenar el valor actual
        int multi;
        public Form16TablaMultiplicar()
        {
            InitializeComponent();
            this.textos = new List<TextBox>();

            //recorremos toda la coleccion control y accedemos a cada uno de los textos
            foreach ( Control control in this.gbResultado.Controls)
            {
                if (control is TextBox)
                {
                    this.textos.Add((TextBox)control);
                }
            }
            //para mostrar los indices invertidos
            this.textos.Reverse();
            //un bucle para recorrer los indices y ver que posicion hay
            for (int i = 0; i < textos.Count; i++)
            {
                this.textos[i].Text = i.ToString();
            }


        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            int numero = int.Parse(this.txtNumero.Text);
            for (int i = 0; i < this.textos.Count; i++)
            {
                int operacion = numero * i;
                this.textos[i].Text = operacion.ToString();
            }
        }
    }
}
