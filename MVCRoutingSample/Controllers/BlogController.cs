using MVCRoutingSample.Models;
using System.Web.Mvc;

namespace MVCRoutingSample.Controllers
{
    public class BlogController : Controller
    {
        [HttpGet]
        public ActionResult ByDate(Blog blog)
        {
            /*ViewBag.Message =
                string.Format("The blog {3} for the year:{0}, month:{1}, and day:{2} has been visited",
                year, month, day, title);*/

            return View(blog);
        }
    }
}