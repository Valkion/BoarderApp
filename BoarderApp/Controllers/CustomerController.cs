using BoarderApp.Data;
using BoarderApp.Models;
using BoarderApp.Models.ViewModel;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;

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

        // GET-Create
        //public IActionResult Create()
       // {
            //IEnumerable<SelectListItem> TypeDropDown = _db.ExpenseTypes.Select(i => new SelectListItem
            //{
            //    Text = i.Name,
            //    Value = i.Id.ToString()
            //});

            //ViewBag.TypeDropDown = TypeDropDown;

        //    UnitVM unitVM = new UnitVM()
        //    {
        //        Unit = new Unit(),
        //        TypeDropDown = _db.ExpenseTypes.Select(i => new SelectListItem
        //        {
        //            Text = i.Name,
        //            Value = i.Id.ToString()
        //        })
        //    };

        //    return View(expenseVM);
       // }


        public IActionResult Create()
        {

            IEnumerable<SelectListItem> UnitDropDown = _db.Units.Select(i => new SelectListItem
            {
                Text = i.UnitName,
                Value = i.UnitID.ToString(),

            });

            ViewBag.UnitDropDown = UnitDropDown;
            return View();
        }
        //POST
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Customer obj)
        {
      
             DateTime date = DateTime.Parse(DateTime.Now.ToString("MM/dd/yyyy"));

            
            obj.Active = true;
            obj.DateCreated = date;
            
            if(ModelState.IsValid)
            {
                _db.Customers.Add(obj);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
         
              return View(obj); 
            
        }
    }
}
