using System;

namespace EFGetStarted.Entidades
{    
    public class Consulta
    {
        public int ConsultaId { get; set; }
        public Paciente paciente { get; set; }
        public Medico medico { get; set; }
        public DateTime fecha { get; set; }
        public string descripcionSintomas { get; set; }
        public string diagnostico { get; set; }

    }
}
        
        
        