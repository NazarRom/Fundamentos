namespace Fundamentos
{
    public partial class Form17TemperaturasAnuales : Form
    {
        //creas las colecciones
        List<string> meses;
        List<int> temperaturas;
        public Form17TemperaturasAnuales()
        {
            InitializeComponent();
            //inicio la app  y ya tengo la lista de meses hecha
            this.meses = new List<string>()//lista de meses

            {
                "enero","febrero","marzo","abril","mayo","junio","julio","agosto","septiembre","octubre","noviembre","diciembre"
            };

        }

        private void btnMeses_Click(object sender, EventArgs e)
        {
            GenerarMeses()
;
        }
        void GenerarMeses()
        {   
            this.lstMeses.Items.Clear();//limpar todo lo que hay
            this.temperaturas = new List<int>();//creas una coleccion vacia
            Random random = new Random();//hacemos un random
            for (int i = 0; i < meses.Count; i++) //con la longitud de meses
            {
                this.temperaturas.Add(random.Next(-20, 50));//añades a las temperaturas el random entre el -20 y 50
                this.lstMeses.Items.Add(meses[i] + ":" + temperaturas[i]);//añadimos a la lista los elementos string en este caso son meses y temperaturas con la posicion de los bucles

                

            }

        }

        private void btnDatos_Click(object sender, EventArgs e)
        {
            int max = 0;//inicio el maximo
            int min = 0;//inicio el minimo
            //lo que hace el bucle es comparar cada numero con la variable max y va cogiendo uno por uno para ver cual es más grande
            //lo mismo se hace con el minimo
            for (int i = 0; i < meses.Count; i++)//bucle con la longitud de los meses
            {
                if (this.temperaturas[i] > max)
                {
                    max = this.temperaturas[i];
                }
                if (this.temperaturas[i] < min)
                {
                    min = this.temperaturas[i];
                }
            }
            this.txtTempMax.Text = max.ToString();//pinto la temp máx
            this.txtTempMin.Text = min.ToString();//pinto la temp min
        }
    }
}
