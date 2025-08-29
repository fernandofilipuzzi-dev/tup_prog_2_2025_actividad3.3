using Ejercicio1.Models;

namespace Ejercicio1
{
    public partial class Form1 : Form
    {
        Estancia estancia;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            estancia = new Estancia("La ana", "AB12", 3000.0);
            estancia.Casco.Administrador = "Jorge";

            estancia[0].Superficie

        }

        private void button2_Click(object sender, EventArgs e)
        {
            estancia.AgregarCampos("AC12", 234);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {


            comboBox1.Items.Clear();
            for (int n = 0; n < estancia.VerCantidadCampos(); n++)
            {
                Campo campo = estancia.VerCampo(n);
                comboBox1.Items.Add(campo);
            }
        }
    }
}
