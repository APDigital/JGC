using Jgamerclub.Models;
using System.Web.Mvc;

namespace Jgamerclub.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            
            return View();
        }
        public ActionResult SendEmail(EmailBuilder emailBuilder)
        {
            if (emailBuilder != null)
            {
                emailBuilder.SendEmail();
            }
            return View();
        }
    }
}