using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ProyectoMVC.Models
{
    public class Pago
    {
        //Atributo IdPago -- Llave principal
        [Key]
        public int IdPago { get; set; }

        //Atributo PacienteId -- Llave Foránea
        [Required]
        [ForeignKey("Paciente")]
        public int PacienteId { get; set; }

        //Atributo -- FechaPago
        [Required]
        [DataType(DataType.Date)]
        [Display(Name = "Fecha de Pago")]
        public DateTime FechaPago { get; set; }

        //Atributo -- Monto
        [Required]
        [Column(TypeName = "decimal(10,2)")]
        [Display(Name = "Monto")]
        public decimal Monto { get; set; }

        //Atributo -- Metodo
        [Required(ErrorMessage = "Seleccione el metodo de pago")]
        [EnumDataType(typeof(Metodo))]
        [Display(Name = "Metodo Pago")]
        public Metodo Metodo { get; set; }

        //Propiedad de navegación
        public Paciente Paciente { get; set; }
    }

    public enum Metodo
    {
        Efectivo,
        Tarjeta,
        SINPE
    }//Fin de Metodo
}//Fin del namespace
