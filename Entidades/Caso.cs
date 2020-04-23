namespace EFGetStarted.Entidades
{    
    public class Caso
    {
        public int CasoId { get; set; }
        public Paciente paciente { get; set; }
        public Medico medico { get; set; }
        public string estado { get; set; }
    }
}