using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RazorTemplatesLawler.Models;

namespace RazorTemplatesLawler.Controllers
{
    public class AssignmentController : Controller
    {
        private StudentContext context { get; set; }

        public AssignmentController(StudentContext ctx)
        {
            context = ctx;
        }
        //[Route("[controller]/[action]/[access?]")]
        public IActionResult Index(int access)
        {
            ViewBag.Admin = "Hello Admin";
            ViewBag.AccessLevel = access;
            var students = context.Students.OrderBy(m => m.LastName).ToList();
            return View("Index", students);
        }
    }
}
