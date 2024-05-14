namespace Consulta
{
    using Paciente;
    public class Consulta
    {
        private DateTime fecha;
        private Paciente paciente;

        public Consulta(DateTime fecha, Paciente paciente)
        {
            this.fecha = fecha;
            this.paciente = paciente;
        }

        public DateTime Fecha
        {
            get
            {
                return this.fecha;
            }
        }

        public Paciente Paciente
        {
            get
            {
                return this.paciente;
            }
        }
       
        public override string ToString()
        {
            return $"El día {this.fecha.ToString("dd/MM/yyyy")} se ha atendido al paciente {this.paciente.NombreCompleto}";
        }
    }
}
