using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Kol.DAL;
using Kol.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Kol.Controllers
{
    public class RentsController : Controller
    {
        private readonly IDbLayer _context;

        public RentsController(IDbLayer context)
        {
            _context = context;
        }


        public IActionResult Index()
        {


            ViewBag.Rent = _context.GetRents();
            ViewBag.Car = _context.GetCars();

            return View();
        }

        [HttpPost]
        public IActionResult Create(Rent rent)
        {
            ViewBag.Rent = _context.GetRents();

            ViewBag.Car = _context.GetCars();

            if (rent == null)
            {
                return RedirectToAction("Index");
            }

           

            //foreach(var r in _context.GetRents())
            //{
               // Rent rentLoop = r;

               // if(r.DateTo > )
            //}

            if (!ModelState.IsValid)
            {
                //ViewBag.Rent = _context.GetRents();



                return View("Index");

            }

            _context.AddNewRent(rent);

            return RedirectToAction("Index");
        }
    }
}