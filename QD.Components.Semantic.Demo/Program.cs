using Microsoft.AspNetCore.Blazor.Hosting;

namespace QD.Components.Semantic.Demo
{
	public static class Program
	{
		public static void Main()
		{
			CreateHostBuilder().Build().Run();
		}

		public static IWebAssemblyHostBuilder CreateHostBuilder() =>
			BlazorWebAssemblyHost.CreateDefaultBuilder()
				.UseBlazorStartup<Startup>();
	}
}
