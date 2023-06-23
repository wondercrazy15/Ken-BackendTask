using System.ComponentModel.DataAnnotations;

namespace APIProject.Model;

public class StoreValues
{
    [Key]
    public int Id { get; set; }
    public int Number1 { get; set; }
    public int Number2 { get; set; }
}
