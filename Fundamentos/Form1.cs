namespace Fundamentos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnPulsar_Click(object sender, EventArgs e)
        {   
            //aqui escribiremos nuestras acciones
            this.txtNombre.Width = 50;
            this.btnPulsar.Text = "Botón pulsado!!!";
            //tenemos propiedades que son de tipo objeto
            this.txtNombre.Location = new Point(70, 100);
            //tenemos propiedades de tipo enumeradas
            //una enumeracion son una serie de valores 
            //que se representan de forma grafica y ayudan al
            //programador
            this.txtNombre.TextAlign = HorizontalAlignment.Center;
            this.BackColor = Color.Tomato;
            this.btnPulsar.BackColor = Color.LightGreen;

            //conversion automática
            short numero = 99;
            int mayor = numero;

            //casting entre objetos
            int numeroMayor = 99;
            short numeroMenor = 888;
            //necesitamos almacenar 
            //el numero menor en dato del mayor
            numeroMenor = (short) numeroMayor;

            //convertir string a primitivo
            string textoNumero = "1444";
            int numeroEntero = int.Parse(textoNumero);
            double doble = double.Parse(textoNumero);

            //convertir objetos a string
            int valor = 88888;
            string texto = valor.ToString();
            string boton = this.btnPulsar.ToString();


        }
    }
}