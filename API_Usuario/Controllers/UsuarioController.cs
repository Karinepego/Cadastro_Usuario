using API_Usuario.Models.Entities.DTO;
using API_Usuario.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace API_Usuario.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuarioController : ControllerBase
    {
        private readonly IUsuarioRepository repos;
        public UsuarioController(IUsuarioRepository _repos)
        {
            repos = _repos;
        }

        [HttpGet("{Id}")]
        public IActionResult Get([FromRoute] int clienteId)
        {
            var cliente_db = repos.FindById(clienteId);
            return Ok(cliente_db);
        }

        [HttpPost]
        public IActionResult Post(PostUsuarioRequest cliente)
        {
            if (repos.Create(cliente))
                return Ok();

            return BadRequest();
        }

        [HttpPut]
        public IActionResult Put(PutUsuario usuario)
        {
            if (repos.Update(usuario))
                return Ok();

            return BadRequest();
        }

        [HttpDelete("{Id}")]
        public IActionResult Delete([FromRoute] int cliendId)
        {
            if (repos.Delete(cliendId))
                return Ok();

            return BadRequest();
        }

    }
}
