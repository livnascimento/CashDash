using CashDash.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using CashDash.Data;
using Microsoft.EntityFrameworkCore;

namespace CashDash.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly DBContext _context;

        public HomeController(ILogger<HomeController> logger, DBContext context)
        {
            _logger = logger;
            _context = context;
        }

        public IActionResult Index()
        {
            var sales = _context.Sale
                        .OrderByDescending(sale => sale.SaleID)
                        .Include(sale => sale.Customer)
                        .Include(sale => sale.Product)
                        .Include(sale => sale.Employee)
                        .Take(10)
                        .ToList();
            ViewBag.EmployeesCount = _context.Employee.Count();
            ViewBag.SalesCount = _context.Sale.Count();
            ViewBag.CustomerCount = _context.Customer.Count();
            ViewBag.ProductCount = _context.Product.Count();
            return View(sales);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
