using AspWebUygulama.Data;
using Microsoft.AspNetCore.Mvc;
using AspWebUygulama.Models;
namespace AspWebUygulama.Controllers
{
    public class ContactController : Controller
    {
        private readonly Context _context;
        public ContactController(Context context) {
            _context = context;
        }

        [HttpGet]
        public IActionResult Index()
        {
                return View();
        }

        public IActionResult History() {
            
            var messages = _context.Contacts.ToList();

            return View(messages);
            
        }

        [HttpPost]
        public IActionResult Form(Contact contact)
        {
            if (ModelState.IsValid)
            {
                _context.Contacts.Add(contact);
                _context.SaveChanges();

                return RedirectToAction("Index");
            }

            return View();
        }

        public IActionResult Success()
        {
            return View();
        }

    }
}
