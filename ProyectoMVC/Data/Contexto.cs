using Microsoft.EntityFrameworkCore;
using ProyectoMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProyectoMVC.Data
{
    public class Contexto : DbContext
    {
        //Constructor 
        public Contexto(DbContextOptions<Contexto> options) : base(options){
        }//Fin del constructor 

        //Propiedades
        public DbSet<Paciente> Paciente { get; set; }
        public DbSet<Puesto> Puesto { get; set; }
        public DbSet<Funcionario> Funcionario { get; set; }
        public DbSet<Especialidad> Especialidad { get; set; }
        public DbSet<Especialista> Especialista { get; set; }
        public DbSet<Horario> Horario { get; set; }
        public DbSet<Cita> Cita { get; set; }
        public DbSet<Diagnostico> Diagnostico { get; set; }
        public DbSet<Tratamiento> Tratamiento { get; set; }
        public DbSet<Pago> Pago { get; set; }
        public DbSet<HistorialClinico> HistorialClinico { get; set; }
        public DbSet<Usuario> Usuario { get; set; }
        public DbSet<Bitacora> Bitacora { get; set; }


    }//Fin de la class COntexto 
}//Fin del namespace
