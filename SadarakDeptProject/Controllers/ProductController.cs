using Microsoft.AspNetCore.Mvc;
using SadarakDeptProject.Data;
using SadarakDeptProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SadarakDeptProject.Controllers
{
    public class ProductController : Controller
    {
        private readonly DebtContext _context;
        public ProductController(DebtContext context)
        {
            _context = context;
        }
        public IActionResult List()
        {
            List<Product> products = _context.Products.OrderByDescending(m=>m.Id).ToList();
            return View(products);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create([FromForm] Product request)
        {
            Product product = new Product
            {
                Code = request.Code,
                Name = request.Name,
                Company = request.Company,
                BuyPrise = request.BuyPrise,
                SellPrise = 0,
                WayPrice = request.WayPrice,
                Weight = request.Weight,
                isKg = request.isKg,
                isDollar = true,
                Count = request.Count,
                PlusPrise = 0,
                Rate = 0,
                CreateDate = DateTime.Now,
                ArrivalDate = request.ArrivalDate,
                Status = request.Status
            };
            _context.Products.Add(product);
            _context.SaveChanges();
            return RedirectToAction("List");
        }
        public IActionResult Edit(int id)
        {
            Product product = _context.Products.Find(id);
            return View(product);
        }
        [HttpPost]
        public IActionResult Edit(int id, Product request)
        {
            Product product = _context.Products.Find(id);
            product.Name = request.Name;
            product.Code = request.Code;
            product.Company = request.Company;
            product.Count = request.Count;
            product.BuyPrise = request.BuyPrise;
            product.Rate = request.Rate;
            product.PlusPrise = request.PlusPrise;
            product.Weight = request.Weight;
            product.isKg = request.isKg;
            product.WayPrice = request.WayPrice;
           
            _context.SaveChanges();
            return RedirectToAction("List");
        }
        public IActionResult Calculate(int id)
        {
            var product = _context.Products.Find(id);

            return View(product);
        }
        public IActionResult Delete(int id)
        {
            Product product = _context.Products.Find(id);
            _context.Remove(product);
            _context.SaveChanges();
            return RedirectToAction("List");
        }
    }
}
