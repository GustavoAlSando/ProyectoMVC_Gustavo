using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ProyectoMVC.Models
{
    public class Cita
    {
        //Ateributo IdCita -- Llave Primaria
        [Key]
        public int IdCita { get; set; }

        //Atributo PacienteId -- Llave Foranea
        [Required]
        [ForeignKey("Paciente")]
        public int PacienteId { get; set; }

        //Atributo EspecialistaId -- Llave Foranea
        [Required]
        [ForeignKey("Especialista")]
        public int EspecialistaId { get; set; }

        //Atributo -- DiaCita
        [Required]
        [DataType(DataType.Date)]
        [Display(Name = "Día de la Cita")]
        public DateTime DiaCita { get; set; }

        //Atributo -- HoraCita
        [Required]
        [DataType(DataType.Time)]
        [Display(Name = "Hora de la Cita")]
        public TimeSpan HoraCita { get; set; }

        //Propiedades de navegacion 
        public Paciente Paciente { get; set; }
        public Especialista Especialista { get; set; }

    }//Fin de la class Cita
}//Fin del namespace
