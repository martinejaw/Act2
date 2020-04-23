using System.ComponentModel.DataAnnotations;

namespace EFGetStarted.Entidades
{    
    public class Medico
    {
        [Key]
        public int matricula { get; set; }
        public string nombre { get; set; }
        public string apellido { get; set; }
    }
}