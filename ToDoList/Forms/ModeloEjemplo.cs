using System.ComponentModel.DataAnnotations;

namespace ToDoList.wwwroot.Forms;

public class ModeloEjemplo
{
    [Required]
    [StringLength(10, ErrorMessage = "Nombre es demasiado largo")]
    public string? Nombre { get; set; }
}
