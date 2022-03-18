using DB_Context.Models;
using Microsoft.AspNetCore.Mvc;
using System.Data.Entity;

namespace E_commerce_Mvc_app.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly CompanyContext _dbContext;

        public EmployeeController()
        {
            _dbContext = new CompanyContext();
        }

        //GET Employee 
        public IActionResult Index()
        {
            var employeeList = this._dbContext.Employee.Include(x => x.Department).ToList();
            return View(employeeList);  
        }


        //CRUD operations here!





    }
}
