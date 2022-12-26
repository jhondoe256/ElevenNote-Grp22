
using System.ComponentModel.DataAnnotations;

public class Category
{
    [Key]
    public int Id { get; set; }
    public string Title { get; set; }
    public List<NoteEntity> Notes { get; set; }
}
