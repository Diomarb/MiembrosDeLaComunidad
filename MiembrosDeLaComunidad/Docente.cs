

public class Docente : Empleado
{
    private string materia;
    public string Asignatura
    {
        get { return materia; }
        set { materia = value; }
    }
    public Docente(string nombre, string cargo, string materia) : base(nombre, cargo)
    {
        this.materia = materia;
    }
    public override void Saludar()

    {
        Console.WriteLine($"Holla, soy {Nombre} soy docente. enseño la materia: {materia}");

    }
    public void Enseñar()
    {
        Console.WriteLine($"{Nombre} estas eseñando la {materia}.");
    }
}