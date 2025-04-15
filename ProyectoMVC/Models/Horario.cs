using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ProyectoMVC.Models
{
    public class Horario
    {
        //Ateributo IdHorario -- Llave Primaria
        [Key]
        public int IdHorario { get; set; }

        //Atributo -- Dia
        [Required]
        [DataType(DataType.Date)]
        [Display(Name = "Día Disponible")]
        public DateTime Dia { get; set; }

        //Atributo -- HoraEntrada
        [Required]
        [DataType(DataType.Time)]
        [Display(Name = "Hora de Entrada")]
        public TimeSpan HoraEntrada { get; set; }

        //Atributo -- HoraSalida
        [Required]
        [DataType(DataType.Time)]
        [Display(Name = "Hora de Salida")]
        public TimeSpan HoraSalida { get; set; }

        //Atributo EspecialistaId -- Llave Foranea
        [Required]
        [ForeignKey("Especialista")]
        public int EspecialistaId { get; set; }

        //Propiedad de navegacion 
        public Especialista Especialista { get; set; }
    }//Fin de la class Horario
}//Fin del namespace
