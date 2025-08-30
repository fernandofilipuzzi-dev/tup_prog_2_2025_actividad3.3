using Ejercicio1.Models;
using Ejercicio1.Vistas;
using System.Configuration;
using System.Text;

namespace Ejercicio1;

public partial class FormPrincipal : Form
{
    Estancia estancia { get; set; }

    public FormPrincipal()
    {
        InitializeComponent();
    }

    private void FormPrincipal_Load(object sender, EventArgs e)
    {
        //inicia el sistema pide los datos del establecimiento
        AltaEstancia();
    }

 

    private void administrarCamposToolStripMenuItem_Click(object sender, EventArgs e)
    {
        FormCamposAdm fCamposAdm = new FormCamposAdm();

        //mostrar el listado de campos del establecimiento
        for (int idx = 0; idx < estancia.CantidadCampos; idx++)
        {
            Campo campo = estancia.VerCampo(idx);
            fCamposAdm.lsbCampos.Items.Add(campo);
        }

        //mostrando listado de campos
        fCamposAdm.ShowDialog();

        bool continua = fCamposAdm.DialogResult == DialogResult.TryAgain ||
                        fCamposAdm.DialogResult == DialogResult.TryAgain;
        
        while (continua)
        {
            //listar campos
            if (fCamposAdm.DialogResult == DialogResult.Retry)
            {
                //mostrar el listado de campos del establecimiento
                fCamposAdm.lsbCampos.Items.Clear();
                for (int idx = 0; idx < estancia.CantidadCampos; idx++)
                {
                    Campo campo = estancia.VerCampo(idx);
                    fCamposAdm.lsbCampos.Items.Add(campo);
                }             
            }

            //agregar un campo al establecimiento
            else if (fCamposAdm.DialogResult == DialogResult.TryAgain)
            {
                Campo nuevo=SolicitarDatosCampo();
                if (estancia.AgregarCampo(nuevo.Identificador, nuevo.SuperficieTotal)!=null)
                {
                    fCamposAdm.lsbCampos.Items.Add(nuevo);
                }
            }

            fCamposAdm.ShowDialog();

            continua = fCamposAdm.DialogResult == DialogResult.Retry ||
                       fCamposAdm.DialogResult == DialogResult.TryAgain;
        }
    }

    #region casos reutilizables


    /*es simplemente la pantalla para pedir datos*/
    protected Campo SolicitarDatosCampo() // acá campo es un abstracción de datos!!!
    {
        FormCampoDatos formCampoDatos = new FormCampoDatos();

        //solicito los valores al usuario
        if (formCampoDatos.ShowDialog() == DialogResult.OK)
        {            
            string identificadorCampo1 = formCampoDatos.tbIdentificadorCampo.Text;
            double superficieCampo1 = Convert.ToDouble(formCampoDatos.tbSuperficieCampo.Text);

            //el campo aquí es un modelo de datos, un objeto de transporte
            Campo campo = new Campo(identificadorCampo1, superficieCampo1);

            return campo;
        }

        return null;
    }

    protected void AltaEstancia()
    {
        FormEstanciaDatos formEstanciaDatos = new FormEstanciaDatos();
        Campo nuevoCampo = null;

        //tengo que evaluar como vuelvo del formulario
        //tomo la estrategia de salir desde el formulario principal
        //y en lo posible no abrir ventanas modales de formularios modales.

        //para esto necesito un bucle que evalue con result vuelvo desde el formulario principal

        formEstanciaDatos.ShowDialog();

        bool estaEditando = formEstanciaDatos.DialogResult == DialogResult.OK ||
            formEstanciaDatos.DialogResult == DialogResult.TryAgain;

        //sigo solicitando datos al usuario mientras esté en editando y no haya completado los datos de la estancia
        while (estaEditando && estancia==null)
        {         
            //verifico si quiere! cargar los datos del campo, si "si", me guardo los datos
            //si quiere!, tengo que pedir los datos
            if (formEstanciaDatos.DialogResult == DialogResult.TryAgain)
            {
                nuevoCampo = SolicitarDatosCampo();

                if (nuevoCampo != null)
                {
                    formEstanciaDatos.lbDescripcionGeneral.Text = nuevoCampo.ToString();
                }

                formEstanciaDatos.ShowDialog();
            }

            //evaluo el caso de que finalice el formulario
            else if (formEstanciaDatos.DialogResult == DialogResult.OK)
            {
                //verifico si editó los datos del campo.
                if (nuevoCampo == null)
                {
                    formEstanciaDatos.lbDescripcionGeneral.Text = "Debe completar los datos del campo principal de la estancia.";

                    formEstanciaDatos.ShowDialog();
                }
                else
                {
                    //confirmación del alta del campo
                    string nombreEstancia = formEstanciaDatos.tbNombre.Text;
                    estancia = new Estancia(nombreEstancia, nuevoCampo.Identificador, nuevoCampo.SuperficieTotal);
                }
            }

            estaEditando = formEstanciaDatos.DialogResult == DialogResult.OK ||
            formEstanciaDatos.DialogResult == DialogResult.TryAgain;
        }

        //verifico si cancelo la configuración de la estancia - 
        if (estancia == null)
            Close();
    }

    #endregion

}
