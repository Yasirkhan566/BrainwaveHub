using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Linq;
using EAD_Project.Data;
using EAD_Project.Models;
using System;
namespace student_feedback_recommendation_system.Controllers
{
    public class Signin : Controller
    {
        //public IActionResult Index()
        //{
        //    return View();
        //}
        private readonly AppDbContext _context;

        public Signin(AppDbContext context)
        {
            _context = context;
        }
        // GET: /signup
        public IActionResult Index()
        {
            return View();
        }

        // POST: /signup/createaccount
        [HttpPost]
        public IActionResult CheckAccount(string email, string password)
        {
            // Perform validation and account creation logic here
            // For simplicity, let's just print the values to the console
            Console.WriteLine($"Email from signin: {email}");
            Console.WriteLine($"Password: {password}");
            // Console.WriteLine(_context.Students.ToList().Count);
            // You would typically save the data to a database or perform other business logic here
            // Check if the user exists in the database
            var user = _context.Students.FirstOrDefault(u => u.Email == email);

            if (user == null)
            {
                // User does not exist, show error message
                TempData["ErrorMessage"] = "User does not exist.";
                return RedirectToAction("Index");
            }

            // User exists, now check the password
            if (user.Password == password)
            {
                // Password is correct, redirect to the home page or another authenticated page
                return RedirectToAction("Index", "Home");
            }
            else
            {
                // Password is incorrect, show error message
                TempData["ErrorMessage"] = "Incorrect password.";
                return RedirectToAction("Index");
            }

            // Redirect to a success page or return a view
        }
    }
}
