using Ejercicio1.Models;

namespace Ejercicio1;

public partial class FormPrincipal : Form
{
    Estancia estancia { get; set; }

    public FormPrincipal()
    {
        InitializeComponent();
    }

    private void btnCrearEstancia_Click(object sender, EventArgs e)
    {
        estancia = new Estancia("La Ana", "XE343", 100);
        estancia.Casco.Encargado = "Ana";
        Puesto puesto = estancia.VerPuesto(0);
        if (puesto != null)
            puesto.Encargado = "Gabriel";
    }

    private void btnAltaCampo_Click(object sender, EventArgs e)
    {
        string idCampo = tbIdentificadorCampo.Text;
        double supCampo = Convert.ToDouble(tbSuperficieCampo.Text);
        estancia.AgregarCampo(idCampo, supCampo);
    }

    private void btnMostrarCampos_Click(object sender, EventArgs e)
    {
        cmbCampos.Items.Clear();
        for (int idx = 0; idx < estancia.CantidadCampos; idx++)
        {
            Campo campo = estancia.VerCampo(idx);
            cmbCampos.Items.Add(campo);
        }
    }

    private void btnAltaParcela_Click(object sender, EventArgs e)
    {
        Campo campoSeleccionado = cmbCampos.SelectedItem as Campo;

        if (campoSeleccionado != null)
        {
            string idParcela = tbIdentificadorParcela.Text;
            double supCampo = Convert.ToDouble(tbSuperficieCampo.Text);
            bool exito = campoSeleccionado.CrearParcela(idParcela, supCampo);
            if (exito)
                MessageBox.Show("La parcela fue creada");
            else
                MessageBox.Show("Error. La parcela no fue creada");
        }
        else
        {
            MessageBox.Show("Seleccione un campo");
        }
    }

    private void btnAltaActividad_Click(object sender, EventArgs e)
    {
        int tipoActividadIndex = cmbTipoActividad.SelectedIndex;

        Actividad nueva = null;

        int periodo = Convert.ToInt32(tbPeriodoActividad.Text);
        string descripcion = tbDescripcionActividad.Text;

        switch (tipoActividadIndex)
        {
            case 0:
                {
                    nueva = new Agricola(periodo, descripcion);
                }
                break;
        }

        estancia.AltaActividad(nueva);
    }

    private void FormPrincipal_Load(object sender, EventArgs e)
    {
        cmbTipoActividad.Items.Clear();
        cmbTipoActividad.Items.Add("Agricola");
        cmbTipoActividad.Items.Add("Cria");
        cmbTipoActividad.Items.Add("Re Cria");
        cmbTipoActividad.Items.Add("Ivernada");
    }

    private void button1_Click(object sender, EventArgs e)
    {
      
    }
}
