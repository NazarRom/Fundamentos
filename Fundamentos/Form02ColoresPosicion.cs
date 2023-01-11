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
    public partial class Form02ColoresPosicion : Form
    {
        public Form02ColoresPosicion()
        {
            InitializeComponent();
        }

        private void btnCambiar_Click(object sender, EventArgs e)
        {
            int positionX = int.Parse(txtPositionX.Text);
            int positionY = int.Parse(txtPositionY.Text);
            
            this.btnCambiar.Location = new Point(positionX, positionY);
        }

        private void btnCambiarColor_Click(object sender, EventArgs e)
        {
            int red = int.Parse(this.txtRed.Text);
            int green = int.Parse(this.txtGreen.Text);
            int blue = int.Parse(this.txtBlue.Text);
            //los colores son entre 0 y 255
            if(red < 0 || red > 255)
            {
                MessageBox.Show("eL color debe ser entre 0 y 255");

            }else if (green < 0 || green > 255)
            {
                MessageBox.Show("El color debe ser entre 0 y 255");
            }else if (blue < 0 || blue > 255)
            {
                MessageBox.Show("el color debe ser entre 0 y 255");
            }
            else
            {
                this.BackColor = Color.FromArgb(red, green, blue);
            }
            
        }
    }
}
