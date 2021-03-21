using HattrickMVC.Data;
using HattrickMVC.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.JSInterop;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HattrickMVC.Controllers
{
    public class ViewController : Controller
    {

        private readonly ApplicationDbContext _db;
        static ViewModel vm = new ViewModel();

        public ViewController(ApplicationDbContext db)
        {
            _db = db;
        }

        
        public IActionResult Index()
        {
            vm.Nogomet = _db.GetNogomet();
            vm.AvailableBetTypes = _db.GetBetTypes();
            vm.PossibleTips = _db.GetPossibleTips();
            vm.User = _db.GetUser();
            
            return View(vm);
        }

        public bool Uplata(int ulog) {
            ApplicationDbContext newDb = this._db;
            User someUser = newDb.GetUser().First();
            if (ulog > someUser.novcanik) {
                return false; 
            }
            someUser.novcanik = someUser.novcanik - ulog;
            newDb.Entry(someUser).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            newDb.SaveChanges();
            return true;
        }

        public bool Dodaj(int ulog)
        {
            ApplicationDbContext newDb = this._db;
            User someUser = newDb.GetUser().First();          
            someUser.novcanik += ulog;
            newDb.Entry(someUser).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            newDb.SaveChanges();
            return true;
        }

        //public ViewResult TestBeginForm()
        //{

        //    return View(vm);
        // }
    }
}
