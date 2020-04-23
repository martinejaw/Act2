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


                var paciente1 = new Paciente { 
                                                nombre = "Martin",
                                                apellido = "Yaoming"};
                var paciente2 = new Paciente { dni = 41000002 ,
                                                nombre = "Juan",
                                                apellido = "Bo"};
                var paciente3 = new Paciente { dni = 41000003 ,
                                                nombre = "Jazmin",
                                                apellido = "Flores"};


                var medico1 = new Medico { matricula = 1, nombre = "Ezequiel", apellido = "Del Peru"};
                var medico2 = new Medico { matricula = 2, nombre = "Hernan", apellido = "Troncoso"};

                var caso1 = new Caso { estado = "En prueba", medico = medico1, paciente = paciente1};
                var caso2 = new Caso { estado = "Sospechoso", medico = medico1, paciente = paciente2};
                var caso3 = new Caso { estado = "En prueba", medico = medico2, paciente = paciente3};

                //medicoNuevo.casos.Add(casoNuevo);

                //casoNuevo.medico = medicoNuevo;
                
                /*Console.WriteLine("Insertando un caso");
                db.Add(casoNuevo);
                db.Add(pacienteNuevo);
                db.Add(medicoNuevo);
                db.SaveChanges();*/

                db.Add(caso1);
                db.Add(caso2);
                db.Add(caso3);
                db.Add(paciente1);
                db.Add(paciente2);
                db.Add(paciente3);
                db.Add(medico1);
                db.Add(medico2);
                db.SaveChanges();


                Console.WriteLine("Leyendo un caso");
                var casos = db.Casos
                    .OrderBy(c => c.CasoId)
                    .ToList();
                
                foreach (Caso caso in casos){
                    Console.WriteLine("Numero de caso: ");
                    Console.WriteLine(caso.CasoId);
                    Console.WriteLine("Paciente del caso: ");
                    Console.WriteLine(caso.pacientedni);
                    Console.WriteLine("Medico encargado: ");
                    Console.WriteLine(caso.medicomatricula);
                }
                

            }
        }
    }
}