using System.Diagnostics;
using ContactManager.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ContactManager.Controllers
{
    public class HomeController : Controller
    {
        private ContactContext context { get; set; }
        
        public HomeController(ContactContext ctx)
        {
            context = ctx;
        }
        public IActionResult Index()
        {
            var contacts = context.Contact.Include(d => d.Category).OrderBy(c => c.FirstName).ToList();
            return View(contacts);
        }

    }
}
