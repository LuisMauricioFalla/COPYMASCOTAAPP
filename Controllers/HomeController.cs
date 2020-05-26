using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MASCOTAAPP.Models;
using MASCOTAAPP.Datos;
using Microsoft.EntityFrameworkCore;

namespace MASCOTAAPP.Controllers
{
    public class HomeController : Controller
    {
        private MascotaContext _context;
        public HomeController(MascotaContext c){
            _context = c;
        }
        
        //Listado de Mascotas
        public IActionResult Index(int tipomascota)
        {
            ViewBag.Tipos = _context.Tipos.ToList();
            var mascotas = _context.Mascotas.Include(x => x.Tipo).ToList();

            if( tipomascota != 0){
              mascotas = _context.Mascotas.Include( x => x.Tipo).Where(x => x.TipoID == tipomascota).ToList();
            }
            return View(mascotas);
        }

        
        //Formulario de ingreso de mascotas
        public IActionResult Registro(){

            ViewBag.Tipos = _context.Tipos.ToList();

            return View();

        }

        [HttpPost]
        public IActionResult Registro(Mascota m){
            if(ModelState.IsValid){
                _context.Add(m);
                _context.SaveChanges();

                return RedirectToAction("index");
            }

            ViewBag.Tipos = _context.Tipos.ToList();

            return View(m);

        }
    }
}
