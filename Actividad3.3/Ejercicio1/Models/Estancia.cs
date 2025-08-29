
using System.Collections;

namespace Ejercicio1.Models;

public class Estancia
{
    #region atributos y propiedades
    public string Nombre { get; set; }

   

    List<Actividad> actividades = new List<Actividad>();

    public Casco Casco { get; set; }

    Puesto[] puestos = new Puesto[100];
    public int CantidadPuestos { get; private set; } = 0;
    #endregion

    #region constructor
    //(1)
    public Estancia(string nombre, string idCampo1, double supCampo1)
    {
        Nombre = nombre;
        campos.Add(new Campo(idCampo1, supCampo1));
        Casco = new Casco();
        Casco.Encargado = "No designado";
        AgregarPuesto("No designado");
    }
    #endregion

    #region manejo de actividades y campos
    public bool AltaActividad(Actividad nueva)
    { 
       actividades.Add(nueva);
        return true;
    }
    #endregion

    #region manejo de campos

    ArrayList campos = new ArrayList();

    public Campo AgregarCampo(string identificador, double superficie)
    {
        Campo campo = new Campo(identificador, superficie);
        campos.Add(campo);  
        return campo;
    }

    public int CantidadCampos
    {
        get
        {
            return campos.Count;
        }
    }

    public Campo VerCampo(int idx)
    {
        if (idx >= 0 && idx < campos.Count)
        {
            return campos[idx] as Campo;
        }
        return null;
    }
    #endregion

    #region manejo de los puestos
    public void AgregarPuesto(string encargado)
    {
        Puesto puesto = new Puesto();
        puesto.Encargado = encargado;
        puestos[CantidadPuestos] = puesto;
        CantidadPuestos++; 
    }

    public Puesto VerPuesto(int idx)
    { 
        if(idx>=0 && idx<CantidadPuestos)
            return puestos[idx];
        return null;
    }
    #endregion 
}
