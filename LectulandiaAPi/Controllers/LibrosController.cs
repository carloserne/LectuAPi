using LectulandiaAPi.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace LectulandiaAPi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LibrosController : ControllerBase
    {
        private readonly LectulandiaContext _baseDatos;


        public LibrosController(LectulandiaContext baseDatos)
        {
            _baseDatos = baseDatos;
        }

        // Metodo GET ListaTareas
        [HttpGet]
        [Route("listaLibros")]
        public async Task<IActionResult> Lista()
        {
            var listaLibros = await _baseDatos.Libros.ToListAsync();
            return Ok(listaLibros);
        }

        // Método GET para obtener libros por categoría
        [HttpGet]
        [Route("listaLibros/{categoria}")]
        public async Task<IActionResult> ListaLibrosPorCategoria(string categoria)
        {
            var librosPorCategoria = await _baseDatos.Libros
                .Where(libro => libro.Categoria == categoria)
                .ToListAsync();
            return Ok(librosPorCategoria);
        }

    }
}
