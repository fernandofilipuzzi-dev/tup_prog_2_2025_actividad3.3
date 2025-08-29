
using System.Collections;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Ejercicio1.Models;

public class Estancia
{
    public string Nombre { get; set; }

    public Casco Casco { get; set; }

    ArrayList puestos = new ArrayList();
      
    public Estancia(string nombre, string idCampo, double sup)
    { 
        this.Nombre=nombre;
        this.Casco = new Casco();
        this.Casco.Administrador = "Sin asignar";

        Puesto puesto = new Puesto();
        puestos.Add(puesto);
        puesto.Responsable = "Sin asignar";

        Campo campo = new Campo(idCampo, sup);
        campos.Add(campo);

    }

    #region administrar los campos

    ArrayList campos = new ArrayList();
    public Campo AgregarCampos(string identificador, double superficie)
    {
        Campo nuevo = new Campo(identificador, superficie);
        campos.Add(nuevo);
        return nuevo;
    }

    public Campo this[int idx]
    {
        get {
            return campos[idx] as Campo;
        }
    }

    public Campo VerCampo(int idx)
    {
        if (campos!=null && idx >= 0 && idx < campos.Count)
        {
            return campos[idx] as Campo;
        }
        return null;
    }

    public int VerCantidadCampos()
    {
        if (campos != null)
        {
            return campos.Count;
        }
        return 0;
    }

    #endregion 
}
