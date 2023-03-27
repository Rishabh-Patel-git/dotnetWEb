using Microsoft.AspNetCore.Mvc;


namespace Assignment2_webApp.Controllers
{
    public class CalculatorController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        [Route("calculate")]
        public IActionResult Index(double num1,double num2,string operation)
        {
            double result;
            switch (operation)
            {
                case "+":
                    result = num1 + num2;
                    break;
                case "-":
                    if(num2 == 0)
                    {
                        ViewBag.ErrorMsg = "Cannot divide by Zero";
                        return View();
                    }
                    result = num1 - num2;
                    break;
                case "*":
                    result = num1 * num2;
                    break;
                case "/":
                    if(num2 == 0)
                    {
                        ViewBag.ErrorMsg = "Cannot divide by Zero";
                    }
                    result = num1 / num2;
                    break;
                default:
                    ViewBag.ErrorMsg = "Invalid operator selected";
                    return View();
            }
            string ans = num1 + " " + operation + " " + num2 + " = " + result;
            ViewBag.Result = ans;
            return View();
        }
    }
}
