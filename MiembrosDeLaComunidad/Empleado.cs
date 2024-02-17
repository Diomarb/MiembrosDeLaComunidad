


    public class Empleado : MiembroDeLaComunidad
    {
        private string cargo;
        public string Cargo
        {
            get { return cargo; }
            set { cargo = value; }
        }
    public Empleado(string nombre, string cargo) : base (nombre)
        {
            this.cargo = cargo;
        }
        public override void Saludar()

        { Console.WriteLine ($"Holla, soy {Nombre} soy empleado. Mi cargo es: {cargo}");

        }
        public void Trabajar()
        {
            Console.WriteLine($"{Nombre} estas trabajando como {cargo}.");
        }
    }

