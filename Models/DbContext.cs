using Microsoft.EntityFrameworkCore;

namespace Lab_11_version_2.Models
{
	public class ProfessorDbContext : DbContext
	{
		public ProfessorDbContext(DbContextOptions<ProfessorDbContext> options) : base(options)
		{

		}	
	public DbSet<Professor> Professor {get; set;}
	}
}