using Microsoft.AspNetCore.Mvc;
using SadarakDeptProject.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SadarakDeptProject.Controllers
{
    public class CalculatorController : Controller
    {
        private readonly DebtContext _context;
        public CalculatorController(DebtContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult List()
        {

            return View();
        }
        public IActionResult Create()
        {
            return View();
        }
    }
}
