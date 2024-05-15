namespace PersonalMedico
{
    using Persona;
    using Consulta;
    using Paciente;
    using System.Text;

    public class PersonalMedico : Persona
    {
        private List<Consulta> consultas;
        private bool esRecidente;

        public PersonalMedico(string nombre, string apellido, DateTime nacimiento, bool esRecidente) : base(nombre, apellido, nacimiento)
        {
            this.esRecidente = esRecidente;
            this.consultas = new List<Consulta>();
        }

        public string ObtenerFichaExtra
        {
            get
            {
                return this.FichaExtra();
            }
        }

        public static Consulta operator +(PersonalMedico doctor, Paciente paciente)
        {
            Consulta nuevaConsulta = new Consulta(DateTime.Now, paciente);
            doctor.consultas.Add(nuevaConsulta);
            return nuevaConsulta;
        }

        protected override string FichaExtra()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"¿Finalizó la residencia {(this.esRecidente ? "SI" : "NO")}?");
            foreach (var consulta in consultas)
            {
                sb.AppendLine(consulta.ToString());
            }
            return sb.ToString();
        }

    }
}
