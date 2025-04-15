using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ProyectoMVC.Models
{
    public class Funcionario
    {
        //Ateributo IdFuncionario -- Llave Primaria
        [Key]
        public int IdFuncionario { get; set; }

        //Atributo -- Nombre
        [Required(ErrorMessage = "Ingrese el nombre del funcionario")]
        [StringLength(100, ErrorMessage = "Máximo 100 caracteres")]
        [Display(Name = "Nombre Funcionario")]
        public string Nombre { get; set; }

        //Atributo -- Cedula 
        [Required(ErrorMessage = "Ingrese la cédula del funcionario")]
        [StringLength(20, ErrorMessage = "Máximo 20 caracteres")]
        [Display(Name = "Cédula Funcionario")]
        public string Cedula { get; set; }

        //Atributo -- Telefono 
        [Required(ErrorMessage = "Ingrese un número de teléfono")]
        [Phone(ErrorMessage = "Ingresar un número de teléfono válido")]
        [Display(Name = "Teléfono Funcionario")]
        public string Telefono { get; set; }

        //Atributo -- Residencia
        [Required(ErrorMessage = "Ingrese la residencia del funcionario")]
        [StringLength(100, ErrorMessage = "Máximo 100 caracteres")]
        [Display(Name = "Residencia Funcionario")]
        public string Residencia { get; set; }

        //Atributo -- Correo
        [Required(ErrorMessage = "Ingrese una dirección de correo electrónico")]
        [EmailAddress(ErrorMessage = "Ingresar un correo electrónico válido")]
        [Display(Name = "Correo Funcionario")]
        public string Correo { get; set; }

        //Atributo PuestoId -- Llave Foranea
        [Required]
        [ForeignKey("Puesto")]
        public int PuestoId { get; set; }

        //Propiedades de navegacion 
        public Puesto Puesto { get; set; }
        public ICollection<Horario> Horarios { get; set; }


    }//Fin de la class Funcionario 
}//Fin del namespace