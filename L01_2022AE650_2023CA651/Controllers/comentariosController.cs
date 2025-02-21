using L01_2022AE650_2023CA651.Models;
using Microsoft.AspNetCore.Mvc;

public class comentariosController : ControllerBase
{
    private readonly comentariosContext _comentariosContext;
    public comentariosController(comentariosContext comentariosContext)
    {
        _comentariosContext = comentariosContext;
    }

    [HttpGet]
    [Route("GetAll")]

    public IActionResult Get()
    {
        List<comentarios> listadoComentarios = (from e in _comentariosContext.comentarios select e).ToList();
        if (listadoComentarios.Count() == 0)
        {
            return NotFound();
        }
        return Ok(listadoComentarios);
    }

}
