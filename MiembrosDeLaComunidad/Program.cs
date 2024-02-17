public class MiembroDeLaComunidad
{
    private string nombre;
    public string Nombre
    {
        get { return nombre; }
        set { nombre = value; }


    }
    public MiembroDeLaComunidad(string nombre)
    {

        this.nombre = nombre;
    }
    public virtual void Saludar()
    {
        Console.WriteLine($"Hola, soy {Nombre} Soy un miembro de la cominuda.");

    }


}
class program
{
    static void Main(string[] args)
    { MiembroDeLaComunidad[] comunida = new MiembroDeLaComunidad[2];
        {
            new Empleado("Billie", "Gerente");
            new Estudiante("Eilish", 22);
            new ExAlumno("Carla", "Abogada");
            new Docente("Maria", "Profesora", "Lengua");
            new administrador("Arlen", "Administrador", "Finanzas");
            new Administrativo("Jk", "Secretario", "Recursos Humanoz");
            new Maestro("Diumar", "Sociales", "Maestria");
        };
        foreach (var miembro in comunida) { miembro.Saludar(); if (miembro is Empleado empleado)
            {
                empleado.Trabajar();

            }
            else if (miembro is Estudiante estudiante) 
            {
                estudiante.Saludar();
            }
            else if ( miembro is ExAlumno exAlumno) 
            {
            exAlumno.Saludar();
            }
            
                
            }
            
                
            }

        }

