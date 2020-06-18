using CovidTracking.Api.Models.V1;
using CovidTracking.Api.V1;
using Microsoft.Extensions.Logging;
using System;
using System.Text.Json;

namespace CovidTracking.Example
{
	internal class App : IApp
	{
		private readonly ICovidTrackingRequest _covidTrackingRequest;
		private readonly ILogger<App> _logger;

		public App(ICovidTrackingRequest covidTrackingRequest, ILogger<App> logger)
		{
			_covidTrackingRequest = covidTrackingRequest ?? throw new ArgumentNullException(nameof(covidTrackingRequest));
			_logger = logger ?? throw new ArgumentNullException(nameof(logger));
		}

		public async void Run()
		{
			var apiStatus = await _covidTrackingRequest.GetApiStatus();
			_logger.LogInformation(JsonSerializer.Serialize<ApiStatus>(apiStatus));
		}
	}
}
