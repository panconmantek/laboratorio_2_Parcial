namespace Persona
{
    using System.Text;
    public abstract class Persona
    {
        protected string apellido;
        protected string barrioRecidencia;
        protected DateTime nacimiento;
        protected string nombre;

        public Persona(string nombre, string apellido, DateTime nacimiento)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.nacimiento = nacimiento;
        }

        public Persona(string nombre, string apellido, DateTime nacimiento, string barrioRecidencia) : this(nombre, apellido, nacimiento)
        {
            this.barrioRecidencia = barrioRecidencia;
        }

        public int Edad
        {
            get
            {
                return DateTime.Today.AddTicks(-this.nacimiento.Ticks).Year - 1;
            }
        }

        public string NombreCompleto
        {
            get
            {
                return $"{this.apellido}, {this.nombre}";
            }
        }

        public override string ToString()
        {
            return this.NombreCompleto;
        }

        internal abstract string FichaExtra();
        public static string FichaPersonal(Persona p)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"{p.ToString()}");
            sb.AppendLine($"EDAD: {p.Edad}");
            sb.AppendLine($"{p.FichaExtra()}");
            return sb.ToString();
        }

    }
}
