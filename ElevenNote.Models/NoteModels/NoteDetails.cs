
public class NoteDetails
{
    public int Id { get; set; }
    public string Title { get; set; }
    public string Content { get; set; }
    public DateTimeOffset CreatedUtc { get; set; }
    public DateTimeOffset? ModifiedUtc { get; set; }

}
