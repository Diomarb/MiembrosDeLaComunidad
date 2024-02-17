

public class ExAlumno : MiembroDeLaComunidad
{
    private string carrera;
    public string Carrera
    {
        get { return carrera; }
        set { carrera = value; }
    }
    public ExAlumno(string nombre, string carrera) : base(nombre)
    {
        this.Carrera = Carrera;
    }
    public override void Saludar()

    {
        Console.WriteLine($"Holla, soy {Nombre} soy un ExAlumno. Mi carrera es: {carrera}");

    }
    public void Trabajar()
    {
        Console.WriteLine($"{Nombre} estas trabajando como {carrera}.");
    }
}
