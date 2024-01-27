using Microsoft.EntityFrameworkCore;

namespace MVC_CRUD.Models
{
	public class ContextoBancoDeDados : DbContext
	{
		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			optionsBuilder.UseSqlServer("Data Source=localhost; Initial Catalog=MVC CRUD; Integrated Security=True; Trusted_Connection=True; Encrypt=True;TrustServerCertificate=True;");
		}

		public DbSet<Produto> Produto { get; set; }
	}
}
