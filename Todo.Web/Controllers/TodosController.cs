using Microsoft.AspNetCore.Mvc;

namespace Todo.Web.Controllers
{
    public class TodosController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
    }
}
