using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SadarakDeptProject.Data;
using SadarakDeptProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SadarakDeptProject.Controllers
{
    public class DebtController : Controller
    {
        private readonly DebtContext _context;
        public DebtController(DebtContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> List()
        {
            List<Debt> debt = await _context.Debts.OrderByDescending(m=>m.Id).ToListAsync();

            return View(debt);
        }
        public IActionResult DebtById(int id)
        {
            Debt debt = _context.Debts.Find(id);
            return View(debt);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create([FromForm] Debt request)
        {
            var debt = _context.Debts.Add(request);
            _context.SaveChanges();
            return RedirectToAction("List");
        }
        public IActionResult Edit(int id)
        {
            Debt debt = _context.Debts.Find(id);

            return View(debt);
        }
        [HttpPost]
        public IActionResult Edit(int id, Debt request)
        {
            Debt debt = _context.Debts.Find(id);
            debt.Name = request.Name;
            debt.Prise = request.Prise;
            debt.isDollar = request.isDollar;
            debt.Date = request.Date;
            debt.Info = request.Info;
            debt.MobileNo = request.MobileNo;
            debt.MobilNo2 = request.MobilNo2;
            _context.SaveChanges();
            return RedirectToAction("List");
        }
        
        public IActionResult Delete( int id)
        {
            Debt debt = _context.Debts.Find(id);
            _context.Remove(debt);
            _context.SaveChanges();
            return RedirectToAction("List");
        }
    }
}
