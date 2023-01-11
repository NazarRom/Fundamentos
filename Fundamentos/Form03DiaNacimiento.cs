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
    public partial class Form03DiaNacimiento : Form
    {
        public Form03DiaNacimiento()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            string[] diasemana = new string[] { "Sábado", "Domingo", "Lunes", "Martes", "Miercoles", "Jueves","Viernes" };
            int dia = int.Parse(txtDia.Text);
            int mes = int.Parse(txtMes.Text);
            int anio = int.Parse(txtAnio.Text);

            if (mes == 1)
            {
                mes = 13;
                anio = anio - 1;
            }
            else if (mes == 2)
            {
                mes = 14;
                anio = anio - 1;
            }
           

                int primer_paso = ((mes + 1) * 3) / 5;
                int segundo_paso = anio / 4;
                int tercer_paso = anio / 100;
                int cuarto_paso = anio / 400;
                int quinto_paso = dia + (mes * 2) + anio + primer_paso + segundo_paso - tercer_paso + cuarto_paso + 2;
                int sexto_paso = quinto_paso / 7;
                int septimo_paso = quinto_paso - (sexto_paso * 7);

            this.lblResultado.Text = diasemana[septimo_paso].ToString();
            
        }
    }
}
