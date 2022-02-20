using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lab_7.Areas.Help.Controllers
{
    public class TutorialController : Controller
    {
        public IActionResult Index(string id)
        {

            if(id == "1")
            {
                return View("Page1");
            }else if(id == "2")
            {
                return View("Page2");
            }else
            {
                return View("Page3");
            }
            
        }
    }
}
