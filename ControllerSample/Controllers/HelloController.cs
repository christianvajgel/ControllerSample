using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace ControllerSample.Controllers
{
    public class HelloController : Controller
    {
        public IActionResult Index(string firstName, string surname)
        {
            TimeSpan time = DateTime.Now.TimeOfDay;
            //var time = new TimeSpan(20, 00, 00);
            var morning = new TimeSpan(0, 00, 00);
            var afternoon = new TimeSpan(13, 00, 00);
            var evening = new TimeSpan(19, 00, 00);
            var good = "Good ";
            if (time > morning && time < afternoon)
            {
                good += "Morning!";
            }
            else if (time > afternoon && time < evening)
            {
                good += "Afternoon!";
            }
            else {
                good += "Evening!";
            }
            return Content($"{good} {firstName} {surname}! {time} ");
        }
        public IActionResult Interation()
        {
            return Content("Testing Action.");
        }
    }
}