using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using PrimerMVC.Models;
using PrimerMVC.Models.ViewModels;

namespace PrimerMVC.Controllers
{
    public class ContactosController : Controller
    {
        private readonly ContactosDbContext _context;

        public ContactosController(ContactosDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        => View(await _context.Contactos.ToListAsync());

        public IActionResult Create() => View();

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(ContactoViewModel model)
        {
            if (ModelState.IsValid)
            {
                var contacto = new Contacto()
                {
                    Nombre = model.nombre,
                    Correo = model.correo,
                    Telefono = model.telefono
                };
                _context.Add(contacto);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }

            //ViewData["Contactos"] = new SelectList(_context.Contactos, "ContactoId", "Nombre");
            return View(model);
        }
	}
}
