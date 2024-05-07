using Microsoft.AspNetCore.Mvc;

namespace BloggieMVC.Controllers
{
    public class AdminTagsController : Controller
    {
        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }
    }
}
