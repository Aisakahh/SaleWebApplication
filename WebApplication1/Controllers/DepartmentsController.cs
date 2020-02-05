using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SaleWebApplication.Models;

namespace SaleWebApplication.Controllers
{
    public class DepartmentsController : Controller
    {
        public IActionResult Index()
        {
            List<Department> listdep = new List<Department>();
            listdep.Add(new Department { Id = 1, Name = "Eletronics" });
            listdep.Add(new Department { Id = 2, Name = "Fashion" });

            return View(listdep);
        }
    }
}