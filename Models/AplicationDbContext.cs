using Microsoft.EntityFrameworkCore;

namespace app_web_backend.Models
{
	public class AplicationDbContext :DbContext
	{

		public AplicationDbContext(DbContextOptions<AplicationDbContext> options):base(options) 
		{

		}



	}
}
