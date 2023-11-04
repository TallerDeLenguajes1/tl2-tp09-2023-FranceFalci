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
    
    
    [HttpPost]
    public void AddUser(Usuario usuario)
    {
        usuarioRepository.Create(usuario);
    }
}
