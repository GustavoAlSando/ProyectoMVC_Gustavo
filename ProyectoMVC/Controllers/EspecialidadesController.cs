using Microsoft.AspNetCore.Mvc;
using ProyectoMVC.Data;
using ProyectoMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProyectoMVC.Controllers
{
    public class EspecialidadesController : Controller
    {
        //Atributo de contexto 
        private readonly Contexto _context;

        //Constructor
        public EspecialidadesController(Contexto context)
        {
            _context = context;
        }//Fin del Constructor

        /*************** Action Index ***************/
        public IActionResult Index()
        {
            IEnumerable<Especialidad> listaespecialidades = _context.Especialidad;
            return View();
        }//Fin de accion Index

    }//Fin de la class FuncionariosController
}//Fin del namespace
