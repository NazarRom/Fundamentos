using ProyectoClases;
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
    public partial class Form20TemperaturasAnualesClases : Form
    { 
        List<Year> years;
        Year anyoSeleccionado;

        public Form20TemperaturasAnualesClases()
        {
            InitializeComponent();
            this.years = new List<Year>();
        }

        private void btnMeses_Click(object sender, EventArgs e)
        {
            int numAnyo = 2018;
            for( int i = 1; i <=5; i++)
            {
                Year anual = new Year(numAnyo);
                this.years.Add(anual);
                this.comboAnios.Items.Add("Año " + numAnyo);
                numAnyo += 1;
            }
        }

        private void lstMeses_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.lstMeses.SelectedIndex != -1)
            {
                int indiceMesSeleccionado = this.lstMeses.SelectedIndex;
                Mes mes = this.anyoSeleccionado.Meses[indiceMesSeleccionado];
                this.txtTempMax.Text = mes.TempMaxima.ToString();
                this.txtTempMin.Text = mes.TempMinima.ToString();
                this.txtTempAnual.Text = mes.GetTemperaturaMedia().ToString();
            }

        }


        private void comboAnios_SelectedIndexChanged(object sender, EventArgs e)
        {
            int indice = this.comboAnios.SelectedIndex;
            this.anyoSeleccionado = this.years[indice];
            this.txtMaxAnual.Text = this.anyoSeleccionado.GetMaximaAnual().ToString();
            this.txtMinAnual.Text = this.anyoSeleccionado.GetMinimaAnual().ToString();
            this.txtMedAnual.Text = this.anyoSeleccionado.GetMediaAnual().ToString();
            this.lstMeses.Items.Clear();
            foreach (Mes mes in this.anyoSeleccionado.Meses)
            {
                this.lstMeses.Items.Add(mes.NombreMes);
            }
        }
    }
}
