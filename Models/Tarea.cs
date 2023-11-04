namespace kanban;

public class Tarea{
  int id;
  int idUsuarioPropietario;
  int idTablero;

  string nombre;
  string color;
  string descripcion;
  EstadoTarea estado;
}

public enum EstadoTarea{
  Ideas, 
  ToDo, 
  Doing, 
  Review, 
  Done
}