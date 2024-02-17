
public class administrador : Docente
{
    private string area;
    public string Area
    {
        get { return area; }
        set { area = value; }
    }
    public administrador(string nombre, string cargo, string area) : base(nombre, cargo,area)
    {
        this.area = area;
    }
    public override void Saludar()

    {
        Console.WriteLine($"Holla, soy {Nombre} soy docente estoy en el area: {area}");

    }
    public void Gestionar()
    {
        Console.WriteLine($"{Nombre} estas esenñando en el {area}.");
    }
}
