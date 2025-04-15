using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProyectoMVC.Models
{
    public class Diagnostico
    {
        //Ateributo IdDiagnostico -- Llave Primaria
        [Key]
        public int IdDiagnostico { get; set; }

        //Atributo -- DescripcionDi
        [Required]
        [StringLength(500, ErrorMessage = "La descripción no puede exceder los 500 caracteres.")]
        [Display(Name = "Descripción Diagnóstico")]
        public string DescripcionDi { get; set; }

        //Propiedad de navegacioin 
        public Cita Cita { get; set; }

    }//Fin de la class Diagnostico
}//Fin del namespace
