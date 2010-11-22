using System.Web.Mvc;
using NewInMVC3.Models;

namespace NewInMVC3.Controllers
{

    public class ValidationController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Create()
        {
            return View(new NewPersonModel());
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(NewPersonModel person)
        {
            if (ModelState.IsValid){
                return RedirectToAction("Index");
            }
            return View(person);
        }

        [HttpGet]
        public JsonResult ValidateUser(string name)
        {
            return Json(!name.Contains(" "), JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        public JsonResult ValidatePassword(NewPersonModel person)
        {
            return Json(person.Password.Length>6);
        }
    }
}