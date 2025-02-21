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
    }
}
