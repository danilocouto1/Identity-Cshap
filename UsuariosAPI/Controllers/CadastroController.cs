using Microsoft.AspNetCore.Mvc;
using UsuariosAPI.Data.DTO;

namespace UsuariosAPI.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class CadastroController : ControllerBase
    {
        [HttpPost]
        public IActionResult CadastrarUsuario(CreateUsuarioDto usuarioDto)
        {
            return Ok(usuarioDto);
        }
    }
}
