public class humano {
    private string nombre;
    private int edad;
    public humano(string nombre, int edad) {
        this.nombre = nombre;
        this.edad = edad;
    }
    public void trabajar() {
        Console.WriteLine(nombre + " esta laburando hasta el fin de sus dias.");
    }
}