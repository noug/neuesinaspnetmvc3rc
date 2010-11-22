using System.Collections.Generic;
using System.Web.Helpers;
using System.Web.Mvc;
using NewInMVC3.Models;

namespace NewInMVC3.Controllers
{
    public class FancyController : Controller
    {
        public ActionResult Grid()
        {
            var people = new List<Person>
            {
                new Person
                {
                    Name = "Weinert",
                    Vorname = "Albert"
                },
                new Person
                {
                    Name = "Rochel",
                    Vorname = "Björn"
                },
                new Person
                {
                    Name = "Forkmann",
                    Vorname = "Steffen"
                },
                new Person
                {
                    Name = "Bild",
                    Vorname = "Mike"
                },
                new Person
                {
                    Name = "Haacked",
                    Vorname = "Phil"
                }
            };
            return View(people);
        }

        public ActionResult Chart()
        {
            return View();
        }

        public ActionResult RenderChart()
        {
            var myChart = new Chart(width: 600, height: 400)
                .AddSeries(
                    name: "Employee", xValue: new[] {"Peter", "Andrew", "Julie", "Mary", "Dave"},
                    yValues: new[] {"2", "6", "4", "5", "3"});

            return File(myChart.GetBytes(), "image/jpeg");
        }

        public ActionResult Index()
        {
            return View();
        }
    }
}