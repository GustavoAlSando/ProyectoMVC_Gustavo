using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProyectoMVC.Models
{
    public class Tratamiento
    {
        //Ateributo IdTratamiento -- Llave Primaria
        [Key]
        public int IdTratamiento { get; set; }

        //Atributo -- TipoTr
        [Required]
        [StringLength(100, ErrorMessage = "El tipo de tratamiento no puede exceder los 100 caracteres.")]
        [Display(Name = "Tipo de Tratamiento")]
        public string TipoTr { get; set; }

        //Atributo -- Frecuencia
        [Required]
        [Display(Name = "Frecuencia Tratamiento")]
        public string Frecuencia { get; set; }

        //Atributo -- DescripcionTr
        [Required]
        [StringLength(500, ErrorMessage = "La descripción no puede exceder los 500 caracteres.")]
        [Display(Name = "Descripción Tratamiento")]
        public string DescripcionTr { get; set; }

    }//Fin de la class Tratamiento
}//Fin del namespace
