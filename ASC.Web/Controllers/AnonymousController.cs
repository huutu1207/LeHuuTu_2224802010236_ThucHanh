using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace ASC.Web.Controllers
{
    [Authorize]
    public class AnonymousController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
