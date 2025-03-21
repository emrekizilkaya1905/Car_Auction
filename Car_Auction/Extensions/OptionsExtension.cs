using Core.Common;

namespace Car_Auction.Extensions
{
	public static class OptionsExtension
	{
		public static IServiceCollection AddInfrastruceLayer(this IServiceCollection services, IConfiguration configuration)
		{
			services.Configure<StripeSettings>(options => { 
			configuration.GetSection("StripeSettings").Bind(options);
				
		});
			return services;
		}
	}
}
