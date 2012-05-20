using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RazorEngineTest.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Default1/

        public ActionResult Index()
        {

            var result = Infrastructure.DynamicTemplate.GiveCshtml(new
            {
                Title = "Top 10 books",
                Books = new List<string> {
                    "Harry poter1",
                    "Harry poter2",
                    "Harry poter3",
                    "The hunger game1" ,
                    "Harry poter1", 
                    "The Hobbit", 
                    "Eat Pray Love", 
                    "A Tale of Two Cities",
                    "The Lion, the Witch and the Wardrobe",
                    "Think and Grow Rich" }
            });

            return Content(result);
        }

    }
}
