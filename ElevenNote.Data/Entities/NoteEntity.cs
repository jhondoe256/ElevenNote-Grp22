
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class NoteEntity
{
    [Key]
    public int Id { get; set; }

    [Required]
    public string Title { get; set; }

    [Required]
    public string Content { get; set; }

    [Required]
    public DateTimeOffset CreatedUtc { get; set; }

    public DateTimeOffset? ModifiedUtc { get; set; }

    [Required]
    [ForeignKey(nameof(Owner))]
    public int OwnerId { get; set; }
    public virtual UserEntity Owner { get; set; }

    [Required]
    [ForeignKey(nameof(Category))]
    public int CatetoryId { get; set; }
    public virtual Category Category { get; set; }
}
