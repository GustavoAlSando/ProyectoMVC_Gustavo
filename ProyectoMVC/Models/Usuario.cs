using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProyectoMVC.Models
{
    public class Usuario
    {
        //Atributo Id_usuario -- Llave Principal
        [Key]
        public int IdUsuario { get; set; }

        //Atributo -- NombreUsuario
        [Required]
        [Display(Name = "Nombre Usuario")]
        public string NombreUsuario { get; set; }

        //Atributo -- Contraseña
        [Required]
        [DataType(DataType.Password)]
        [StringLength(100, MinimumLength = 3, ErrorMessage = "La contraseña debe tener al menos 6 caracteres.")]
        public string Contraseña { get; set; }

        //Atributo -- Rol
        [Required]
        [Display(Name = "Rol de Usuario")]
        public RolUsuario Rol { get; set; }
    }//Fin de la class Usuario 

    //Enum de Roles de Usuario
    public enum RolUsuario
    {
        Medico,
        Administrador,
        Secretario,
        Paciente
    }//Fin de RolUsuario

}//Fin del namespace
