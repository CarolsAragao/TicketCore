using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TicketCore.Application.Dtos;
using TicketCore.Application.Interfaces;

namespace TicketCore.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]    
    public class UsuarioController : ControllerBase
    {
        private readonly IUsuarioService _usuarioService;

        public UsuarioController(IUsuarioService usuarioService)
        {
            _usuarioService = usuarioService;
        }

        [HttpPost]
        public async Task<IActionResult> CriarUsuario([FromBody] UsuarioDto usuario)
        {
            await _usuarioService.CriarUsuario(usuario);
            return Ok();
        }
    }
}
