using kanban;
using Microsoft.AspNetCore.Mvc;

namespace tl2_tp09_2023_FranceFalci.Controllers;

[ApiController]
[Route("[controller]")]
public class TareaController : ControllerBase
{

  private ITareaRepository tareaRepository;
  private readonly ILogger<TareaController> _logger;

  public TareaController(ILogger<TareaController> logger)
  {
    _logger = logger;
    tareaRepository = new TareaRepository();
  }

  [HttpGet]
  [Route("api/tarea/tablero")]

  public List<Tarea> GetTareaByTablero(int idTablero)
  {
    return tareaRepository.GetTareasPorTablero(idTablero);
  }

  [HttpGet]
  [Route("api/tarea/")]
  public Tarea GetTareaById(int id)
  {
    return tareaRepository.GetTareaById(id);
  }

  [HttpPost]
  [Route("api/tarea/agregar")]
  public IActionResult AddTarea(Tarea tarea, int idTablero)
  {
    tareaRepository.Create(tarea, idTablero);
    return Ok();
  }

  [HttpPut]
  [Route("api/tarea/modificar")]
  public IActionResult EditTarea(Tarea tarea, int idTarea)
  {
    tareaRepository.Update(tarea,idTarea);
    return Ok("usuario modificado");
  }

  [HttpPut]
  [Route("api/tarea/asignarUsuario")]
  public IActionResult AsignarUsuario(int idUsuario, int idTarea)
  {
    tareaRepository.AsignarTareaUsuario(idUsuario, idTarea);
    return Ok("usuario asignado");
  }

  [HttpDelete]
  [Route("api/tarea/eliminar/{id}")]
  public IActionResult DeleteUser(int id)
  {
    tareaRepository.RemoveTarea(id);
    return Ok();
  }



}