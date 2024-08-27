using Microsoft.EntityFrameworkCore;

public class AppDbContext : DbContext
{
	public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
	{

	}

	public DbSet<Question> questions { get; set; }
	public DbSet<Answer> answers { get; set; }
	public DbSet<UserRole> userroles { get; set; }
	public DbSet<User> users { get; set; }
	public DbSet<ImageAnswer> imageanswers { get; set; }
	public DbSet<QuestionAssignment> questionassignments { get; set; }
}
