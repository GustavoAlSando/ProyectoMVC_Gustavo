using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProyectoMVC.Models
{
    public class Paciente
    {
        //Atributo IdPaciente -- Llave Primaria 
        [Key]
        public int IdPaciente { get; set; }

        //Atributo -- Nombre
        [Required(ErrorMessage = "Ingrese el nombre del paciente")]
        [StringLength(100, ErrorMessage = "Máximo 100 caracteres")]
        [Display(Name = "Nombre Paciente")]
        public string Nombre { get; set; }

        //Atributo -- Cedula
        [Required(ErrorMessage = "Ingrese la cédula del paciente")]
        [StringLength(20, ErrorMessage = "Máximo 20 caracteres")]
        [Display(Name = "Cédula Paciente")]
        public string Cedula { get; set; }

        //Atributo -- Telefono
        [Required(ErrorMessage = "Ingrese un número de teléfono")]
        [Phone(ErrorMessage = "Ingresar un número de teléfono válido")]
        [Display(Name = "Teléfono Paciente")]
        public string Telefono { get; set; }

        //Atributo -- Genero
        [Required(ErrorMessage = "Seleccione un género")]
        [Display(Name = "Género Paciente")]
        public string Genero { get; set; }

        //Atributo -- Edad
        [Required(ErrorMessage = "Ingrese la edad del paciente")]
        [Range(0, 90, ErrorMessage = "Ingrese una edad válida entre 0 y 90 años")]
        [Display(Name = "Edad Paciente")]
        public int Edad { get; set; }

        //Atributo -- Residencia
        [Required(ErrorMessage = "Ingrese la residencia del paciente")]
        [StringLength(100, ErrorMessage = "Máximo 100 caracteres")]
        [Display(Name = "Residencia Paciente")]
        public string Residencia { get; set; }

        //Atributo -- Correo
        [Required(ErrorMessage = "Ingrese una dirección de correo electrónico")]
        [EmailAddress(ErrorMessage = "Ingresar un correo electrónico válido")]
        [Display(Name = "Correo Paciente")]
        public string Correo { get; set; }

        //Propiedad de navegacion con Citas
        public ICollection<Cita> Citas { get; set; }

    }//Fin de la class Paciente
}//Fin del namespace
