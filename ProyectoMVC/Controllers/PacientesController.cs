using Microsoft.AspNetCore.Mvc;
using ProyectoMVC.Data;
using ProyectoMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProyectoMVC.Controllers
{
    public class PacientesController : Controller
    {
        //Atributo de contexto 
        private readonly Contexto _context;

        //Constructor
        public PacientesController(Contexto context)
        {
            _context = context;
        }//Fin del Constructor

        /*************** Action Index ***************/
        public IActionResult Index()
        {
            IEnumerable<Paciente> listapacientes = _context.Paciente;
            return View();
        }//Fin de accion Index


        /*************** Action Create ***************/


    }//Fin de la class ClientesController
}//Fin del namespace
