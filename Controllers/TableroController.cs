using kanban;
using Microsoft.AspNetCore.Mvc;

namespace tl2_tp09_2023_FranceFalci.Controllers;

[ApiController]
[Route("[controller]")]
public class TableroController : ControllerBase
{

  private ITableroRepository tableroRepository;
  private readonly ILogger<UsuarioController> _logger;

  public TableroController(ILogger<UsuarioController> logger)
  {
    _logger = logger;
    tableroRepository = new TableroRepository();
  }

  [HttpGet]
  public List<Tablero> GetTableros()
  {
    return tableroRepository.GetTableros();
  }

  [HttpGet]
  [Route("api/tableros/{id}")]
  public Tablero GetTableroById(int id)
  {
    return tableroRepository.GetTableroById(id);
  }

  [HttpGet]
  [Route("api/tableros/usuario/{idUsuario}")]
  public  List<Tablero> GetTablerosByIdUsuario(int idUsuario)
  {
    return tableroRepository.GetTableroByIdUsuario(idUsuario);
  }


  [HttpPost]
  [Route("api/tableros/agregar")]
  public IActionResult AddUser(Tablero tablero)
  {
    tableroRepository.Create(tablero);
    return Ok("tablero creado");
  }

  [HttpPut]
  [Route("api/tableros/modificar")]
  public IActionResult EditTablero(Tablero tablero,int idTablero)
  {
    tableroRepository.Update(tablero,idTablero);
    return Ok("usuario modificado");
  }

  [HttpDelete]
  [Route("api/tableros/eliminar/{id}")]
  public IActionResult DeleteUser(int id)
  {
    tableroRepository.RemoveTablero(id);
    return Ok();
  }



  

}