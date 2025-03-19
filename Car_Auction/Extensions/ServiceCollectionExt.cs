using Auction_Business.Abstraction;
using Auction_Business.Concrete;
using Core.MailHelper;
using Core.Model;

namespace Car_Auction.Extensions
{
	public static class ServiceCollectionExt
	{
		public static IServiceCollection AddApplicationLayer(this IServiceCollection services, IConfiguration configuration)
		{
			#region Services
			services.AddScoped<IUserService, UserService>();
			services.AddScoped<IVehicleService, VehicleService>();
			services.AddScoped<IBidService, BidService>();
			services.AddScoped<IMailService, MailService>();
			services.AddScoped(typeof(ApiResponse));
			return services;
			#endregion

		}
	}
}
