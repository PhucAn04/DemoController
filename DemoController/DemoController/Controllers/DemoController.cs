using Microsoft.AspNetCore.Mvc;

namespace DemoController.Controllers
{
    public class DemoController : Controller
    {
        public IActionResult ActionIndex()
        {
            ViewBag.MyData = "Hello from ActionIndex!";
            return View("MyView");
        }

        public ViewResult MyView()
        {
            ViewBag.MyData = "Hello from MyView!";
            return View();
        }

        public string ActionTest()
        {
            return "Hello world!";
        }

        //public IActionResult AAA()
        //{
        //    return Content("OK");
        //}

        public int BBB()
        {
            return new Random().Next();
        }
    }
}
