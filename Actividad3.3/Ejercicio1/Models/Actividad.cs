
namespace Ejercicio1.Models;

public class Actividad
{
    public int Periodo { get; set; }
    public string Descripcion { get; set; } 

    List<Parcela> lotesAsignados = new List<Parcela>();

    public Actividad(int periodo, string descripcion)
    {
        Periodo = periodo;
        Descripcion = descripcion;
    }

}
