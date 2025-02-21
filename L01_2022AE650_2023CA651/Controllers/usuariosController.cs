using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using L01_2022AE650_2023CA651.Models;
using Microsoft.EntityFrameworkCore;

namespace L01_2022AE650_2023CA651.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class usuariosController : ControllerBase
    {
        private readonly usuariosContext _usuariosContext;
        public usuariosController(usuariosContext usuariosContext)
        {
           _usuariosContext = usuariosContext;
        }

        [HttpGet]
        [Route("GetAll")]

        public IActionResult Get()
        {
            List<usuarios> listadoUsuarios = (from e in _usuariosContext.usuarios select e).ToList();
            if (listadoUsuarios.Count() == 0)
            {
                return NotFound();
            }
            return Ok(listadoUsuarios);
        }

    }
}
