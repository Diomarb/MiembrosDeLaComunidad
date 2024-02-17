

public class Estudiante : MiembroDeLaComunidad
{
    private int grado;
    public int Grado
    {
        get { return grado; }
        set { grado = value; }
    }
    public Estudiante(string nombre, int crago) : base(nombre)
    {
        this.Grado = Grado;
    }
    public override void Saludar()

    {
        Console.WriteLine($"Holla, soy {Nombre} soy estudiante. Mi grado es: {grado}");

    }
    public void Trabajar()
    {
        Console.WriteLine($"{Nombre} estas trabajando como {grado}.");
    }
}
