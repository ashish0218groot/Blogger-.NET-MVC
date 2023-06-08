using Microsoft.AspNetCore.Mvc;

namespace Blogger.Web.Controllers
{
    public class AdminTagsController : Controller
    {
        public IActionResult Add()
        {
            return View();
        }
    }
}
