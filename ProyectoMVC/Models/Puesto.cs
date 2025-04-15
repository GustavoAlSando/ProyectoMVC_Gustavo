using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProyectoMVC.Models
{
    public class Puesto
    {
        //Ateributo IdPuesto -- Llave Primaria
        [Key]
        public int IdPuesto { get; set; }

        //Atributo -- Tipo
        [Required]
        [Display(Name = "Tipo de Puesto")]
        public TipoPuesto Tipo { get; set; }

        public ICollection<Funcionario> Funcionarios { get; set; }
    }//Fin de la class Puesto

    public enum TipoPuesto
    {
        Medico,
        Administrador,
        Secretario
    }//Fin de TipoPuesto
}//Fin del namespace
