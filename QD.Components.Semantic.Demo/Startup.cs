using Microsoft.AspNetCore.Components.Builder;
using Microsoft.Extensions.DependencyInjection;

namespace QD.Components.Semantic.Demo
{
	public class Startup
	{
		public void ConfigureServices(IServiceCollection services)
		{
			// Do nothing because don't have services.
		}

		public void Configure(IComponentsApplicationBuilder app)
		{
			app.AddComponent<App>("app");
		}
	}
}
