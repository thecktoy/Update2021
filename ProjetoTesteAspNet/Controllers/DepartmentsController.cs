using Microsoft.AspNetCore.Mvc;
using ProjetoTesteAspNet.Models;

namespace ProjetoTesteAspNet.Controllers
{
    public class DepartmentsController : Controller
    {
        public IActionResult Index()
        {
            List<Department> List = new List<Department>();
            List.Add(new Department { Id = 1, Name = "Eletronics" });
            List.Add(new Department { Id = 2, Name = "Fashion" });


            return View(List);
        }
    }
}
