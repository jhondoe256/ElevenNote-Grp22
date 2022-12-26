
using Microsoft.EntityFrameworkCore;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }
    public DbSet<NoteEntity> Notes { get; set; }
    public DbSet<UserEntity> Users { get; set; }
    public DbSet<Category> Categories { get; set; }
}
