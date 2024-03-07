using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Linq;
using EAD_Project.Data;
using EAD_Project.Models;
using System;

namespace EAD_Project.Controllers
{
    public class Signup : Controller
    {
        private readonly AppDbContext _context;

        public Signup(AppDbContext context)
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
        public IActionResult CreateAccount(string email, string password, string confirmPassword, bool terms)
        {
            // Perform validation and account creation logic here
            // For simplicity, let's just print the values to the console
            Console.WriteLine($"Email: {email}");
            Console.WriteLine($"Password: {password}");
            Console.WriteLine($"ConfirmPassword: {confirmPassword}");
            Console.WriteLine($"Agreed to Terms: {terms}");
            Console.WriteLine(_context.Students.ToList().Count);
            // You would typically save the data to a database or perform other business logic here
            if (password == confirmPassword)
            {

                var user = new Student
                {
                    Email = email,
                    Password = password
                };
                _context.Students.Add(user);
                _context.SaveChanges();
                Console.WriteLine("data inserted");
                return RedirectToAction("Index", "SIGNIN");
            }
            else
            {
                TempData["ErrorMessage"] = "Password and Confirm are not same.";
                return RedirectToAction("Index");
            }
        }
    }
}
