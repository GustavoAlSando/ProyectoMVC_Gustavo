using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ProyectoMVC.Models
{
    public class HistorialClinico
    {
        //Ateributo IdHistorial -- Llave Primaria
        [Key]
        public int IdHistorial { get; set; }

        /*//Atributo PacienteId -- Llave Foranea
        [Required]
        [ForeignKey("Paciente")]
        public int PacienteId { get; set; }*/

        //Atributo TratamientoId -- Llave Foranea
        [Required]
        [ForeignKey("Tratamiento")]
        public int TratamientoId { get; set; }

        //Atributo DiagnosticoId -- Llave Foranea
        [Required]
        [ForeignKey("Diagnostico")]
        public int DiagnosticoId { get; set; }

        //Atributo CitaId -- Llave Foranea
        [Required]
        [ForeignKey("Cita")]
        public int CitaId { get; set; }

        // Propiedades de navegación
        public Paciente Paciente { get; set; }
        public Tratamiento Tratamiento { get; set; }
        public Diagnostico Diagnostico { get; set; }
        public Cita Cita { get; set; }

    }//Fin de la class HistorialClinico 
}//Fin del namespace
