using Microsoft.AspNetCore.Mvc;

namespace DailyNews.Web.Controllers
{
    public class ArticleController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Detail()
        {
            return View();
        }
    }
}
