
public class Administrativo : Empleado
{
    private string departamento;
    public string Departamento
    {
        get { return departamento; }
        set { departamento = value; }
    }
    public Administrativo(string nombre, string cargo, string departamento) : base(nombre, cargo)
    {
        this.departamento = departamento;
    }
    public override void Saludar()

    {
        Console.WriteLine($"Holla, soy {Nombre} soy administrador. trabajo en el area de: {departamento}");

    }
    public void Enseñar()
    {
        Console.WriteLine($"{Nombre} estas gestionando el {departamento}.");
    }
}