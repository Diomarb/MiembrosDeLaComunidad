
public class Maestro : Docente
{
    private string especialidad;
    public string Especialidad
    {
        get { return especialidad; }
        set { especialidad = value; }
    }
    public Maestro(string nombre, string asignatura, string especialidad) : base(nombre, asignatura, especialidad)
    {
        this.especialidad = especialidad;
    }
    public override void Saludar()

    {
        Console.WriteLine($"Hola, soy {Nombre} soy maestro mi especialidad es: {especialidad}");

    }
    public void Gestionar()
    {
        Console.WriteLine($"{Nombre} estas en el campo de especialidad {especialidad}.");
    }
}