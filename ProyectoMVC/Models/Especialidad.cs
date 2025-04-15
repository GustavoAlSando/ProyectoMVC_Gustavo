using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProyectoMVC.Models
{
    public class Especialidad
    {
        //Ateributo IdEspecialidad -- Llave Primaria
        [Key]
        public int IdEspecialidad { get; set; }

        //Atributo -- Tipo
        [Required(ErrorMessage = "Ingrese el tipo de especialidad")]
        [StringLength(100, ErrorMessage = "Máximo 100 caracteres")]
        [Display(Name = "Tipo de Especialidad")]
        public string Tipo { get; set; }

        //Atributo -- Descripcion
        [Required(ErrorMessage = "Ingrese la descripción")]
        [StringLength(200, ErrorMessage = "Máximo 200 caracteres")]
        [Display(Name = "Descripción Especialidad")]
        public string Descripcion { get; set; }

        //Propiedad de navegacion 
        public ICollection<Especialista> Especialistas { get; set; }
    }//Fin de la class Especialidad
}//Fin del namespace
