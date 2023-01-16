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
    public partial class Form15SumarBotones : Form
    {
        //declaramos la colecicon a nivel de clase
        List<Button> botones;
        //necesitamos ina variable para almacenar el valor actual de la suma a nivel de clase
        int suma;
        public Form15SumarBotones()
        {
            InitializeComponent();
            this.botones = new List<Button>();
            this.suma = 0;
            //recorremos toda la coleccion control y accedemos a cada uno de los botones
            foreach(Control control in this.panelBotones.Controls)
            {
                if(control is Button)
                {
                    this.botones.Add((Button)control);
                }
            }
            //recorremos nuestros controles y asignamos a un numero random
            //en cada uno
            Random random = new Random();
            foreach(Button boton in this.botones)
            {
                int num = random.Next(1, 200);
                boton.Text = num.ToString();
                boton.Click += SumarNumeros;
            }
        }

        private void SumarNumeros(object? sender, EventArgs e)
        {
            //recuperamos el numero del control pulsado
            Button boton = (Button)sender;
            int numero = int.Parse(boton.Text);
            this.suma += numero;
            this.txtSuma.Text = this.suma.ToString();
            boton.BackColor = Color.LightBlue;
        }

        private void btnReiniciar_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            this.suma = 0;
            this.txtSuma.Text = "0";
            foreach (Button boton in this.botones)
            {
                int num = random.Next(1, 200);
                boton.Text = num.ToString();
                boton.BackColor = Color.FromKnownColor(KnownColor.ButtonFace);
            }
        }

        private void Form15SumarBotones_Load(object sender, EventArgs e)
        {

        }
    }
}
