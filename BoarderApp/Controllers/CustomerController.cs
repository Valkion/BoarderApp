using BoarderApp.Data;
using BoarderApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;



namespace BoarderApp.Controllers
{
    public class CustomerController : Controller
    {
        private readonly ApplicationDbContext _db;
 

        public CustomerController(ApplicationDbContext db)
        {
            _db = db;

        }
        public IActionResult Index()
        {
            IEnumerable<Customer> objList = _db.Customers;

            return View(objList);


        } 

        public IActionResult Create()
        {
            return View();
        }
        //POST
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Customer obj)
        {
          
            List<Unit> unitList = new List<Unit>();

            ViewBag.MyUnits = new SelectList(_db.Units,"UnitID", "UnitName");
           


         

             DateTime date = DateTime.Parse(DateTime.Now.ToString("MM/dd/yyyy"));

            
            obj.Active = true;
            obj.DateCreated = date;
            
            _db.Customers.Add(obj);
            _db.SaveChanges();
            return RedirectToAction("Index");   
            
        }
    }
}
