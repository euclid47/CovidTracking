using CovidTracking.Api.V1;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using System;
using System.Threading.Tasks;

namespace CovidTracking.Example
{
	class Program
	{
		private static IServiceProvider serviceProvider;

		static async Task Main(string[] args)
		{
			ConfigureServices();
			var app = serviceProvider.GetService<IApp>();

			app.Run();

			Console.ReadKey();
			Environment.Exit(0);
		}

		private static void ConfigureServices()
		{
			serviceProvider = new ServiceCollection()
				.AddLogging(x => x.AddConsole())
				.AddMemoryCache()
				.AddSingleton<ICovidTrackingRequest, CovidTrackingRequest>()
				.AddSingleton<IApp, App>()
				.BuildServiceProvider();
		}
	}
}
