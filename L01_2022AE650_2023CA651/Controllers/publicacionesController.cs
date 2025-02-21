using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using L01_2022AE650_2023CA651.Models;
using Microsoft.EntityFrameworkCore;
namespace L01_2022AE650_2023CA651.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class publicacionesController : ControllerBase
    {

        private readonly publicacionesContext _publicacionesContext;
        public publicacionesController(publicacionesContext publicacionesContext)
        {
               _publicacionesContext = publicacionesContext;
        }


        [HttpGet]
        [Route("GetAll")]

        public IActionResult Get()
        {
            List<publicaciones> listadoPublicaciones = (from e in _publicacionesContext.publicaciones select e).ToList();
            if (listadoPublicaciones.Count() == 0)
            { 
                return NotFound();
            }

            return Ok(listadoPublicaciones);
        }
        [HttpGet]
        [Route("TopPublicaciones")]
        public IActionResult GetTopPublicaciones(int TopPublicaciones)
        {
            var topPublicaciones = _publicacionesContext.publicaciones
                .Select(publicaciones => new
                {
                    publicaciones.publicacionId,
                    publicaciones.titulo,
                    ComentariosCount = _publicacionesContext.comentarios.Count(comentarios => comentarios.publicacionId == comentarios.publicacionId)
                })
                .OrderByDescending(publicaciones => publicaciones.ComentariosCount)
                .Take(TopPublicaciones)
                .ToList();

            if (topPublicaciones.Count == 0)
            {
                return NotFound("No hay publicaciones con comentarios.");
            }

            return Ok(topPublicaciones);
        }



    }
}
