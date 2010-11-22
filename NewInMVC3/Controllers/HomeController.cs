using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using NewInMVC3.ActionFilter;
using NewInMVC3.Models;
using NewInMVC3.Services;

namespace NewInMVC3.Controllers
{
    public class HomeController : Controller
    {
        private ISimpleService service;
        public ISimpleService SimpleService { get; set; }

        public HomeController(ISimpleService service)
        {
            this.service = service;
        }

        public ActionResult Index()
        {
            ViewModel.Message = "Welcome to ASP.NET MVC!";

            return View();
        }

        [DIAction]
        public ActionResult About( Person person)
        {
            return View();
        }

        public ActionResult RazorSyntax()
        {
            return View();
        }
       
        [OutputCache(Duration=20,VaryByParam="*")]
        public ActionResult Include()
        {
            return View(DateTime.Now);
        }
    }
}
