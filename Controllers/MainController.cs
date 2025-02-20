using Cv_webapp.Models;
using Microsoft.AspNetCore.Mvc;
using System.Reflection.Metadata.Ecma335;

namespace Cv_webapp.Controllers
{
    public class MainController : Controller
    {
        public IActionResult Home()
        {
            var result = new HomeModel()
            {
                FullName = "Glory Chiwendu Benjamin",
                Bio = "I am a Nigerian based Software developer with experience in Frontend development and a keen interest in Backend technologies. Did i mention that i'm also a quick leraner who pays so much details to my self devlopment and growth."


            };
            if (result != null)
            {
                return View(result);
            }
            else
            {
                var reult = "it is";
                return View(reult);
            }
        }
       /* [Route("/Main/Education")]
        [Route("/Main/Experience")]*/
        public IActionResult Experience()
        {
            var result = new ExperienceModel()
            {
               position="Junior Web Developer",
               Company = "Credevnet Technologies",
               Description="Developed responsive and user-friendly websites and applications using Html,Css,Bootstrap and Javascript ensuring optimal" +
               "user experience across various devices"
            };
            return View(result);
        }
        public IActionResult Education()
        {
            var result = new Education()
            {
                Institution = "Federal University of Petroleum Resources, Effurun.",
                Degree = "Bachelor of science",
                StartYear = new DateOnly(2019, 1, 23),
                EndYear =new DateOnly(2025, 1, 17)
            };
            return (result != null) ? View(result) : RedirectToAction("Home");
           
        }

        public IActionResult Skills()
        {
            var skill = new List<Skills>()
            {
                new Skills { TechnicalSkills = "Html"},
                new Skills {TechnicalSkills = "Css" },
                new Skills {TechnicalSkills = "Javascript" },
                new Skills {TechnicalSkills = "Bootstrap" },
                new Skills {TechnicalSkills = "React" },
                new Skills {TechnicalSkills = "CSharp" }
            };
            return View(skill);
            /*var skill = new List<Skills>()
            {
              new Skills{
              tester = "kolp",
              TechnicalSkills = new List<Skills>()
                   {
                       new Skills{tester="kop"},
                       new Skills{tester="kuilp"}
                   }
              }


            };*/

        }
        public IActionResult Tax()
        {
            var crazy = new TaxModel()
            {
                Amount = 100000
            };
            crazy.TaxAmount = CalculateTax(crazy);
            return View(crazy);

        }
        public decimal CalculateTax(TaxModel tax)
        {
            if (tax.Amount <= 300000)
            {
                tax.TaxAmount = tax.Amount * 0.07m;
                return tax.TaxAmount;
            }// 7% for income ≤ 300k
            else if (tax.Amount <= 600000)
            {
                tax.TaxAmount = tax.Amount * 0.17m;
                return tax.TaxAmount;
            }// 11% for income ≤ 600k
            else if (tax.Amount <= 1100000)
            {
                tax.TaxAmount = tax.Amount * 0.15m;
                return tax.TaxAmount;
            } // 15% for income ≤ 1.1M
            else
            {
                return tax.Amount * 0.20m;
            }
        }
    }
}
