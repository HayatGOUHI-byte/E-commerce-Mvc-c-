using DB_Context.Models;
using E_commerce_Mvc_app.Models;
using Microsoft.AspNetCore.Mvc;
using System.Data.Entity;
using System.Diagnostics;

namespace E_commerce_Mvc_app.Controllers
{
    public class HomeController : Controller
    {
        /* attributes */
        private readonly ILogger<HomeController> _logger;


        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }


        /*******Index method *******/
        public void Index()
        {
            using (var context = new CompanyContext())
            {
                var dept = new Department()
                {
                    Name = "first Commitment"
                };
                context.Entry(dept).State = (Microsoft.EntityFrameworkCore.EntityState)EntityState.Added;
                context.SaveChanges();
            }
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