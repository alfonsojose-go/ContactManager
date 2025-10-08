using ContactManager.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace ContactManager.Controllers
{
    public class ContactController : Controller
    {
        private ContactContext context { get; set; }

        public ContactController(ContactContext ctx)
        {
            context = ctx;
        }
        [HttpGet]
        public IActionResult Add()
        {
            ViewBag.Action = "Add";
            ViewBag.Categories = context.Category.OrderBy(c => c.CategoryName).ToList();
            return View("Edit", new Contact());
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            ViewBag.Action = "Edit";
            ViewBag.Categories = context.Category.OrderBy(c => c.CategoryName).ToList();
            var contact = context.Contact.Find(id);
            return View(contact);
        }

        [HttpPost]
        public IActionResult Edit(Contact contact)
        {
            if (ModelState.IsValid)
            {
                if (contact.ContactId == 0)
                {
                    context.Contact.Add(contact);
                    context.SaveChanges();
                    return RedirectToAction("Index", "Home");
                }
                else
                {
                    context.Contact.Update(contact);
                    context.SaveChanges();
                    return RedirectToAction("Index", "Home");

                }
                    
                
            }
            else
            {
                ViewBag.Action = (contact.ContactId == 0) ? "Add" : "Edit";
                ViewBag.Categories = context.Category.OrderBy(c => c.CategoryName).ToList();
                return View(contact);
            }
        }
        [HttpGet]
        public IActionResult Delete(int id)
        {
            var contact = context.Contact.Find(id);
            return View(contact);
        }

        [HttpPost]
        public IActionResult Delete(Contact contact)
        {
            context.Contact.Remove(contact);
            context.SaveChanges();
            return RedirectToAction("Index", "Home");
        }

        [HttpGet]
        public IActionResult Details(int id)
        {
            var contact = context.Contact
                .Include(c => c.Category)  // This loads the Category data
                .FirstOrDefault(c => c.ContactId == id);

            if (contact == null)
            {
                return NotFound();
            }

            return View(contact);
        }
    }
}
