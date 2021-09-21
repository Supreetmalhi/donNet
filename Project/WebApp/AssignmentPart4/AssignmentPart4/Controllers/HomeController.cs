using AssignmentPart4.Models;
using AssignmentPart4.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AssignmentPart4.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index([Bind(Include = "FirstName, LastName, Email, Age, CarName,CarModel,CarYear,SpeedingTicket,DUI,FullCoverage")]  UserInput userModel)
        {
            if (ModelState.IsValid)
            {
                double Base = 50;
                
                if(userModel.Age <= 18)
                {
                    Base = Base + 100;
                }
                else if(userModel.Age >= 19 &&  userModel.Age<=25)
                {
                    Base = Base + 50;
                }
                else
                {
                    Base = Base + 25;
                }

                if (userModel.CarYear <= 2000)
                {
                    Base = Base + 25;
                }
                if (userModel.CarYear > 2015)
                {
                    Base = Base + 25;
                }
                if(userModel.CarName.ToLower().Contains("porsche"))
                {
                    Base = Base + 25;
                }
                else if (userModel.CarName.ToLower().Contains("porsche") && userModel.CarModel.ToLower().Contains("911 Carrera"))
                {
                    Base = Base + 25;
                }
                Base = Base + (userModel.SpeedingTicket * 10);
                if (userModel.DUI)
                {
                    Base = Base + (Base * .25);
                }
                if (userModel.FullCoverage)
                {
                    Base = Base + (Base * .5);
                }

                Console.WriteLine(Base);

                //calcuate the insarnce qoute.
                //save to database
                using (var ctx = new InsuranceContext())
                {

                    var insurance = new Insurance() { FirstName = userModel.FirstName, LastName = userModel.LastName, Email = userModel.Email, Age = userModel.Age, CarName = userModel.CarName, CarModel = userModel.CarModel, CarYear = userModel.CarYear, SpeedingTicket = userModel.SpeedingTicket, DUI = userModel.DUI, FullCoverage = userModel.FullCoverage, Base= Base };

                    ctx.Insurance.Add(insurance);
                    ctx.SaveChanges();
                    return View("About", insurance);
                }
            }
            else
            {
                return View();
            }
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}