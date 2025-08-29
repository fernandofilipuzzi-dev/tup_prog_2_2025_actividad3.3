namespace Ejercicio1.Models;

public class Campo:IComparable
{
    public string Identificado { get; set; }
    public double Superficie { get; set; }

    public Campo(string id, double sup)
    { 
        Identificado = id;
        Superficie = sup;
    }

    public int CompareTo(object otro)
    {
        Campo otroCampo = otro as Campo;
        if (otroCampo!=null)
        {
            return Identificado.CompareTo(otroCampo.Identificado);
        }
        return 1;
    }

    public override string ToString()
    {
        return $"{Identificado} ({Superficie:f2})";
    }
}
