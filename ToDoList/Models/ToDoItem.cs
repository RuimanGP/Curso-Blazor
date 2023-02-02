namespace ToDoList.Models;

public class ToDoItem
{
    public int TodoItemID { get; set; }
    public string? Titulo { get; set; }
    public string? Contenido { get; set; }
    public string? Responsable { get; set; }
    public List<string> Etiquetas { get; set; } = new List<string>();
    public DateOnly? FechaEntrega { get; set; }
    public TimeOnly? HoraEntrega { get; set; }
    public bool EstaCompletado { get; set; } = false;        
}
