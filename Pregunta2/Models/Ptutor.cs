namespace Pregunta2.Models
{
    public class Tutor : Profesor
    {
        public int CantidadHorasAsesoria { get; set; }
        public bool Supervisor { get; set; }

        public override double CalculaSalario()
        {
            double adicional = CantidadHorasAsesoria * 25; 
            return base.CalculaSalario() + adicional; 
        }

        public double Incentivo()
        {
            return Supervisor ? 200 : 0;
        }

        public double Monto()
        {
            return  CalculaSalario() + Incentivo();
        }
    }
}
