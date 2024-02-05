using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using WebAppOne.Models;

namespace WebAppOne.Controllers
{
    public class EmployeeController : Controller
    {
        static List<Employee> listemployees = new List<Employee>()
        {
            new Employee{Id=1,Name="Sam",Designation="Manager",Salary=98000,DOJ=new DateTime(day:12,month:1,year:2021)},
             new Employee{Id=2,Name="Ajay",Designation="Hr",Salary=96000,DOJ=new DateTime(day:11,month:2,year:2022)},
              new Employee{Id=3,Name="Kiran",Designation="Manager",Salary=96000,DOJ=new DateTime(day:25,month:1,year:2023)},
               new Employee{Id=4,Name="Surya",Designation="Developer",Salary=88000,DOJ=new DateTime(day:10,month:10,year:2021)}
        };
        public IActionResult Index()
        {
            return View(listemployees);
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View(new Employee());
        }
        [HttpPost]
        public IActionResult Create(Employee employee)
        {
            if (employee != null)
            {
                if(ModelState.IsValid)
                {
                    listemployees.Add(employee);
                    return RedirectToAction("Index");
                }
            }
            return View(employee);
        }
        [HttpPost]
        public IActionResult Delete(int? id)
        {
            Employee emp = listemployees.SingleOrDefault(e => e.Id == id);
            if (emp != null)
            {
                listemployees.Remove(emp);
            }
            return RedirectToAction("Index");
        }
    }
}
