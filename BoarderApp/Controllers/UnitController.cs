using BoarderApp.Data;
using BoarderApp.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace BoarderApp.Controllers
{
    public class UnitController : Controller
    {
        private readonly ApplicationDbContext _db;

        public UnitController(ApplicationDbContext db)
        {
            _db = db;

        }
        public IActionResult Index()
        {
            IEnumerable<Unit> objList = _db.Units;
            return View(objList);
        }

        
    }
}
