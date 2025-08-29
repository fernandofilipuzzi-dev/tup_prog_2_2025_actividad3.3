
namespace Ejercicio1.Models;

abstract public class Figura :IComparable
{
    abstract public string Describir();
    
    virtual public double CalcularVolumen()
    {
        return 0;
    }

    public override string ToString()
    {
        return Describir();
    }

    public int CompareTo(object otra)
    {
        Figura otraFigura=otra as Figura;
        if (otraFigura != null)
        {
            return CalcularVolumen().CompareTo(otraFigura.CalcularVolumen());
        }
        return -1;
    }
}
