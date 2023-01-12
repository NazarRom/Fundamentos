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
    public partial class Form06Email : Form
    {
        public Form06Email()
        {
            InitializeComponent();
        }

        private void btnValidar_Click(object sender, EventArgs e)
        {
            string mail = this.txtMail.Text;

            if(mail.Contains("@")== false)
            {
                this.lblResultado.Text = "Tiene que tener @";
            }
            else if (mail.StartsWith("@") || mail.EndsWith('@')){
                this.lblResultado.Text = "No debe de comenzar o terminar con @";
            }
            else if (mail.IndexOf("@") != mail.LastIndexOf("@"))
            {
                this.lblResultado.Text = "no debe de haber más de 2 @";

            }
            else if (mail.Contains(".") == false)
            {
                this.lblResultado.Text = "No hay punto después de @";
            }
            else if(mail.IndexOf(".") < mail.IndexOf("@"))
            {
                this.lblResultado.Text = "tiene que haber un . después de @";
            }
            else
            {
                int ultimoPunto = mail.LastIndexOf('.');
                string dominio = mail.Substring(ultimoPunto + 1);
                if (dominio.Length >=2  && dominio.Length <= 4)
                {
                    this.lblResultado.Text = "Mail correcto";
                }
                else
                {
                    this.lblResultado.Text = "Dominio debe ser de 2 a 4 caracteres";
                }
            }
        }
    }
}
