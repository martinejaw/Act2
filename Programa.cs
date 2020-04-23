using System;
using System.Linq;
using EFGetStarted.Entidades;

namespace EFGetStarted
{
    class Programa
    {
        static void Main()
        {
            using (var db = new ContextoHospital())
            {
                var casoNuevo = new Caso { paciente = "41000000" ,
                                    medico = "222",
                                    estado = "En prueba"};

                var pacienteNuevo = new Paciente { dni = 41000000 ,
                                                nombre = "Martin",
                                                apellido = "Joselo",
                                                caso = casoNuevo};
                
                Console.WriteLine("Insertando un caso");
                db.Add(casoNuevo);
                db.SaveChanges();

                Console.WriteLine("Insertando un paciente");
                db.Add(pacienteNuevo);
                db.SaveChanges();

                Console.WriteLine("Leyendo un caso");
                var caso = db.Casos
                    .OrderBy(c => c.CasoId)
                    .First();
                Console.WriteLine(caso.paciente);

                Console.WriteLine("Leyendo un paciente");
                var paciente = db.Pacientes
                    .OrderBy(p => p.dni)
                    .First();
                Console.WriteLine(paciente.nombre);
                Console.WriteLine(paciente.caso.CasoId);
            }
        }
    }
}