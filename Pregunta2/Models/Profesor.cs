namespace Pregunta2.Models
{
    public class Profesor
    {
        public string DNI { get; set; } 
        public string Nombre { get; set; }
        public string Apellidos { get; set; }
        public string Email { get; set; }
        public string Telefono { get; set; }
        public double SueldoBasico { get; set; }

        public Profesor()
        {
            SueldoBasico = 1025;
        }
        public double ObtenerSueldoBasico()
        {
            return SueldoBasico;
        }

        public virtual double CalculaSalario()
        {
            return ObtenerSueldoBasico();
        }
    }
}
