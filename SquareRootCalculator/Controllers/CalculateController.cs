using Microsoft.AspNetCore.Mvc;
using System;

namespace SquareRootCalculator.Controllers
{
    public class CalculateController : Controller
    {
        [HttpGet]
        public IActionResult Calc()
        {
            return View();  
        }
        [HttpPost]
        public IActionResult Calc(string FirstNumber, string SecondNumber)
        {
            try
            {
                if (int.Parse(FirstNumber) < 0 || int.Parse(SecondNumber) < 0)
                {
                    ViewBag.NegNumError = "Please Insert a Positive Number";
                }
                double firstNum = double.Parse(FirstNumber);
                double secondNum = double.Parse(SecondNumber);

                double firstNumSqrt = Math.Sqrt(firstNum);
                double secondNumSqrt = Math.Sqrt(secondNum);

                ViewBag.first = firstNum;
                ViewBag.second = secondNum;
                ViewBag.firstSqrt = firstNumSqrt;
                ViewBag.secondSqrt = secondNumSqrt;



            }
            catch (ArgumentNullException ex)
            {
                string emptyValueError = ex.Message;
                ViewBag.errorMessageEmpty = "Please input a number and try again";
            }
            catch(FormatException ex)
            {
                string alphabetError = ex.Message;
                ViewBag.alphError = "Pleas input numbers only";
            }
           
            return View();
        }
    }
}
