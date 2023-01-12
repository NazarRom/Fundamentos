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
    public partial class Form10ColeccionRandom : Form
    {
        public Form10ColeccionRandom()
        {
            InitializeComponent();
            this.lstElementos.SelectionMode = SelectionMode.MultiExtended;
        }

        private void btnRandom_Click(object sender, EventArgs e)
        {
           Random random = new Random();
            for(int i = 0; i < 5; i++)
            {
                int valor = random.Next(1,10);
                this.lstElementos.Items.Add(valor);
            }
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            int suma = 0;
            int sumaPares = 0;
            int sumaImpares = 0;
            for (int i = 0; i < this.lstElementos.Items.Count; i++)
            {
                suma += int.Parse(this.lstElementos.Items[i].ToString());

                if (int.Parse(this.lstElementos.Items[i].ToString()) % 2 == 0)
                {
                    sumaPares += int.Parse(this.lstElementos.Items[i].ToString());
                    
                }
                else
                {
                    sumaImpares += int.Parse(this.lstElementos.Items[i].ToString());
                }
                
            }
            this.txtSuma.Text = suma.ToString();
            this.txtPares.Text = sumaPares.ToString();
            this.txtImpares.Text = sumaImpares.ToString();
        }

        private void btnSumarSelecionados_Click(object sender, EventArgs e)
        {
            int suma = 0;
            int sumaPares = 0;
            int sumaImpares = 0;
            for (int i = 0; i < this.lstElementos.SelectedItems.Count; i++)
            {
                suma += int.Parse(this.lstElementos.SelectedItems[i].ToString());

                if (int.Parse(this.lstElementos.SelectedItems[i].ToString()) % 2 == 0)
                {
                    sumaPares += int.Parse(this.lstElementos.SelectedItems[i].ToString());

                }
                else
                {
                    sumaImpares += int.Parse(this.lstElementos.SelectedItems[i].ToString());
                }

            }
            this.txtSuma.Text = suma.ToString();
            this.txtPares.Text = sumaPares.ToString();
            this.txtImpares.Text = sumaImpares.ToString();
        }
    }
}
