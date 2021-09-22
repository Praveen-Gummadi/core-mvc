using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using core_mvc.Models;
namespace core_mvc.Controllers
{
    public class newrecordController1 : Controller
    {
        private readonly connectionStringClass _cc;
            public newrecordController1(connectionStringClass cc)
        {
            _cc = cc;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult create(EmpClass ec)
        {
            _cc.Add(ec);
            _cc.SaveChanges();
            ViewBag.message = "the record " + ec.ename + "is saved successfully... !";
            return View();
        }
    }
}
