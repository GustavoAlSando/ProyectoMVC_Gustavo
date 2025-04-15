using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ProyectoMVC.Models
{
    public class Especialista
    {
        //Ateributo IdEspecialista -- Llave Primaria
        [Key]
        public int IdEspecialista { get; set; }

        //Atributo FuncionarioId -- Llave Foranea
        [Required]
        [ForeignKey("Funcionario")]
        public int FuncionarioId { get; set; }

        //Atributo EspecialidadId -- Llave Foranea
        [Required]
        [ForeignKey("Especialidad")]
        public int EspecialidadId { get; set; }

        //Propiedades de navegacion 
        public Funcionario Funcionario { get; set; }
        public  Especialidad Especialidad { get; set; }
        public ICollection<Cita> Citas { get; set; }
        public ICollection<Horario> Horarios { get; set; }

        //Creacion de listas para las citas y horarios de cada especialista 
        public Especialista()
        {
            Citas = new List<Cita>();
            Horarios = new List<Horario>();
        }//Fin de Especialista 

    }//Fin de la class Especialista
}//Fin del namespace
