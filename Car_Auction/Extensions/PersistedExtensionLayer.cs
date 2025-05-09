using DataAccess.Context;
using DataAccess.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace Car_Auction.Extensions
{
	public static class PersistedExtensionLayer
	{
		public static IServiceCollection AddPersistentLayer(this IServiceCollection services, IConfiguration configuration)
		{

			#region Context
			services.AddDbContext<ApplicationDbContext>(options =>
			{
				options.UseMySQL(configuration.GetConnectionString("MySqlServer"));
			});
			services.AddIdentity<ApplicationUser, IdentityRole>()
				.AddEntityFrameworkStores<ApplicationDbContext>();
			return services;
			#endregion
		}
	}
	
}
