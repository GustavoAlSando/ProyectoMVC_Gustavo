using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ProyectoMVC.Models
{
    public class Bitacora
    {
        //Atributo IdBitacora -- Llave principal
        [Key]
        public int IdBitacora { get; set; }

        //Atributo UsuarioId -- Llave Foránea
        [Required]
        [ForeignKey("Usuario")]
        public int UsuarioId { get; set; }

        //Atributo -- Fecha
        [Required]
        [DataType(DataType.DateTime)] 
        [Display(Name = "Fecha")]
        public DateTime Fecha { get; set; }

        //Atributo -- Movimiento
        [Required]
        [StringLength(500, ErrorMessage = "El movimiento no debe exceder los 500 caracteres.")]
        [Display(Name = "Movimiento")]
        public string Movimiento { get; set; }

        //Propiedad de navegación con Usuario
        public Usuario Usuario { get; set; }

    }//Fin de la class Bitacora
}//Fin del namespace
