
namespace Ejercicio1.Models;

public class Ortoedro : Figura
{
    public double Ancho { get; set; }
    public double Alto { get; set; }
    public double Largo { get; set; }

    public Ortoedro(double ancho, double alto, double largo)
    {
        this.Ancho = ancho;
        Alto = alto;
        Largo = largo;
    }

    override public double CalcularVolumen()
    {
        return Ancho*Alto*Largo;
    }

    public override string Describir()
    {
        return $"Ortoedro: Ancho: {Ancho}";
    }

   
}
