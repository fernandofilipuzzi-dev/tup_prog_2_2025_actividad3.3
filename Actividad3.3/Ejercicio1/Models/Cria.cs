
using System.Security.Policy;

namespace Ejercicio1.Models;

public class Cria:Estancia
{
    Actividad suGranja;
    
    static Random azar = new Random();

    public Cria(Actividad granja)
    {
        this.suGranja = granja;
    }

    public bool TieneHambre()
    {
        return azar.Next(0, 1)==1;
    }

    public Campo EligeAve()
    {
        Campo elegida = null;

        if (suGranja != null)
        {
            List<Campo> presas = suGranja.VerAvesVivas();
            
            if (presas != null && presas.Count > 0)
            {
                int idx = azar.Next(0, presas.Count);
                elegida = presas[idx];
            }

            if (elegida != null)
                acciones.Add("El zorro ha elegido una presa.");
            else
                acciones.Add("El zorro no ha encontrado presas.");

        }
        return elegida;
    }

    public void Come(Campo ave)
    {
        if (ave != null && ave.TieneHambre())
        {
            ave.EstaViva = false; 
            acciones.Add($"El zorro ha comido a {ave.GetType().Name}.");
        }
        else
        {
            acciones.Add("El zorro no ha podido comer, la presa no está disponible o no tiene hambre.");
        }
    }

    public override List<string> CorreRutinas()
    {
        Campo ave= EligeAve();
        if (ave != null)
        {
            Come(ave);
        }
        return acciones;
    }
}
