using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using PaelytTest.Models;

namespace PaelytTest.Controllers;
public class UserCourseController : Controller
{
    [HttpGet]
    public IActionResult Index()
    {
        return View();
    }

    [HttpPost]
    public IActionResult Index(UserCourseModel model)
    {
        if (ModelState.IsValid)
        {
            // Save the user's information and courses to the database
            // Generate a unique reference number
            // Redirect to a confirmation page with the reference number
        }

        return View(model);
    }
}
