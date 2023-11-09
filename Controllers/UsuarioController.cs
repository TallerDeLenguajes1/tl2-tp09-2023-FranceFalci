using kanban;
using Microsoft.AspNetCore.Mvc;

namespace tl2_tp09_2023_FranceFalci.Controllers;

[ApiController]
[Route("[controller]")]
public class UsuarioController : ControllerBase
{

    private IUsuarioRepository usuarioRepository;
    private readonly ILogger<UsuarioController> _logger;

    public UsuarioController(ILogger<UsuarioController> logger)
    {
        _logger = logger;
        usuarioRepository = new UsuarioRepository();
    }

    [HttpGet]
    public List<Usuario> Get()
    {
        return usuarioRepository.GetAll();
    }

    [HttpGet]
    [Route("api/usuarios/{id}")]
    public Usuario Get(int id)
    {
        return usuarioRepository.GetById(id);
    }

    [HttpPost]
    [Route("api/usuarios/agregar")]
    public IActionResult AddUser(Usuario usuario)
    {
        usuarioRepository.Create(usuario);
        return Ok("usuario creado");
    }

    [HttpPut]
    [Route("api/usuarios/modificar")]
    public IActionResult EditUser(Usuario usuario)
    {
        usuarioRepository.Update(usuario);
        return Ok("usuario modificado");
    }

    [HttpDelete]
    [Route("api/usuarios/eliminar/{id}")]
    public IActionResult DeleteUser(int id){
        usuarioRepository.Remove(id);
        return Ok();
    }



}