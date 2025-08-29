
using Ejercicio1.Models;
using System.Collections;

namespace Ejercicio1;

public partial class Form1 : Form
{
    ArrayList figuras = new ArrayList();
    //List<Figura> figuras = new List<Figura>();

    public Form1()
    {
        InitializeComponent();
    }

    private void button1_Click(object sender, EventArgs e)
    {

        //Un ortoedro es Una Figura
        //Pero una Figura no necesariamente es un Ortoedro

        Figura nueva = null;

        if (radioButton1.Checked == true)
        {
            nueva = new Ortoedro(1, 1, 1);
        }
        else if (radioButton2.Checked == true)
        {
            nueva = new Cilindro(1, 1);
        }

        if (nueva != null)//verifico si selecciono un tipo de figura 
        {
            figuras.Add(nueva);
        }
        else
        {
            MessageBox.Show("debe seleccionar un tipo de figura.");
        }
    }

    private void button2_Click(object sender, EventArgs e)
    {
        listBox1.Items.Clear();
        foreach (Figura f in figuras)
        {
            listBox1.Items.Add(f);
        }
    }

    private void button3_Click(object sender, EventArgs e)
    {
        Figura seleccionada = listBox1.SelectedItem as Figura;
        label1.Text = "";
        if (seleccionada != null)
        {
            if (seleccionada is Ortoedro)
            {
                Ortoedro aux = (Ortoedro)seleccionada;
                label1.Text = $"An:{aux.Ancho:f2} X Al:{aux.Alto:f2}";
            }
            else if (seleccionada is Cilindro)
            {
                Cilindro aux = (Cilindro)seleccionada;
                label1.Text = $"An:{aux.Radio:f2}";
            }
            label1.Text += seleccionada.Describir();
        }
        else
        {
            label1.Text = "no ha seleccionado un objeto";
        }

    }

    private void button4_Click(object sender, EventArgs e)
    {
        figuras.Sort();
    }
}
