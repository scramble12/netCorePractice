using HattrickMVC.Data;
using HattrickMVC.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HattrickMVC.Controllers
{
    public class NogometController : Controller
    {
        private readonly ApplicationDbContext _db;

        public NogometController(ApplicationDbContext db)
        {
            _db = db;
        }


        public IActionResult Index()
        {
            IEnumerable<Nogomet> objList = _db.Nogomet;
            return View(objList);
        }
    }
}
