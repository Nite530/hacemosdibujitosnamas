//se crea a imagen y semejanza la clase pistola desde la clase armas
public class armas {
    protected int velocidad;

    public void disparar() {
        Console.WriteLine("Disparando...");
        velocidad++;
    }
}

public class pistola : armas {
    public void recargar() {
        Console.WriteLine("Recargando...");
        velocidad--;
    }
}