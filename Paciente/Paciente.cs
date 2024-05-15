namespace Paciente
{
    using System;
    using System.Text;
    using Persona;

    public class Paciente : Persona
    {
        public string diagnostico;

        public Paciente(string nombre, string apellido, DateTime nacimiento, string barrioRecidencia) : base(nombre, apellido, nacimiento, barrioRecidencia)
        {
            this.diagnostico = "";
        }

        public string Diagnostico
        {
            get { return this.diagnostico; }

            set { this.diagnostico = value; }
        }

        protected override string FichaExtra()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Reside en: {this.barrioRecidencia}");
            sb.AppendLine(this.diagnostico);
            return sb.ToString();
        }

    }
}