using Microsoft.AspNetCore.Mvc;
using Sazon.interfaces;
using Sazon.Models;

namespace Sazon.Controllers
{
    public class CategoriasController : Controller //Hereda de Controller 
    {
        //Hace referencia a que el Controller tiene un objeto que cumple con ICategoriaRepository 
        private readonly ICategoriaRepository _categoriaRepository;

        //y este permite que ASP.NET haga la inyeccion de dependecia 
        public CategoriasController(ICategoriaRepository categoriaRepository) 
        {
            _categoriaRepository = categoriaRepository;
        }


        //CRUD

        //Ordena que deben hacer con las Categorias
        public IActionResult Index() 
        {

            var categorias = _categoriaRepository.ObtenerTodas();

            return View(categorias);

        }


        public IActionResult Create() 
        {

            return View();

        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Categoria categoria)
        {
            if (!ModelState.IsValid)
            {
                return View(categoria);
            }

            categoria.Activa = true;

            _categoriaRepository.Agregar(categoria);

            return RedirectToAction(nameof(Index));
        }

        public IActionResult Edit(int id)
        {
            var categoria = _categoriaRepository.ObtenerPorId(id);

            if (categoria == null)
            {
                return NotFound();
            }

            return View(categoria);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Categoria categoria)
        {
            if (!ModelState.IsValid)
            {
                return View(categoria);
            }

            _categoriaRepository.Actualizar(categoria);

            return RedirectToAction(nameof(Index));
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Delete(int id)
        {
            _categoriaRepository.Eliminar(id);

            return RedirectToAction(nameof(Index));
        }

    }
}
