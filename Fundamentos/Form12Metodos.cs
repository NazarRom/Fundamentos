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
    public partial class Form12Metodos : Form
    {
        public Form12Metodos()
        {
            InitializeComponent();
        }

        private void btnValor_Click(object sender, EventArgs e)
        {
            int num = int.Parse(this.txtNumero.Text);
            this.GetDoble(num);
            //dibujamos el resultado
            this.lblResultado.Text = num.ToString();
        }
        void GetDoble(int numero)
        {
            //cambiamos el valor del parametro wrapper recibido
            numero = numero * 2;
        }
        private void btnReferencia_Click(object sender, EventArgs e)
        {
            int num = int.Parse(this.txtNumero.Text);
            //this.GetDobleReferencia(ref num);
            //this.lblResultado.Text = num.ToString();
            int resultado = this.GetDobleNumero(num);
            this.lblResultado.Text = resultado.ToString();
        }

        int GetDobleNumero(int numero)
        {
            int doble = numero * 2;
            return doble;
        }
        void GetDobleReferencia(ref int numero)
        {
            //cambiamos el valor de la variable recibida
            numero = numero * 2;
        }
        private void btnObjetoReferencia_Click(object sender, EventArgs e)
        {
            this.CambiarColor(this.btnReferencia);
            this.CambiarColor(this.btnValor);
        }
        void CambiarColor(Button boton)
        {
            //cambiamos algo del objeto
            boton.BackColor = Color.Yellow;
        }

        private void lblMouse_MouseMove(object sender, MouseEventArgs e)
        {
            this.lblMouse.Text = "X: " + e.X + ", Y:" + e.Y;
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {   //la tecla pulsada
            //e.keyChar
            //desactiva las acciones anteriores
            //e.Handled = true;
            //debemos incar que si es la tecla de borrar
            //también este habilitado el evento
            //existe una enumeracion que nos devuelve
            //el codigo de cada letra
            char teclaBorrar = (char) Keys.Back;
            if (char.IsDigit(e.KeyChar) == false
                 && e.KeyChar != teclaBorrar)
            {
                e.Handled = true;
            }
            }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            char teclaBorrar = (char)Keys.Back;
            if (char.IsLetter(e.KeyChar) == false
                 && e.KeyChar != teclaBorrar)
            {
                e.Handled = true;
            }
        }
    }
    }

