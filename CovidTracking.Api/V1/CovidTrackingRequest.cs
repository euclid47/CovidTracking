using CovidTracking.Api.Enums;
using CovidTracking.Api.Extensions;
using CovidTracking.Api.Models.V1;
using Microsoft.Extensions.Caching.Distributed;
using Microsoft.Extensions.Caching.Memory;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace CovidTracking.Api.V1
{

	/// <inheritdoc cref="ICovidTrackingRequest"/>
	public class CovidTrackingRequest : ICovidTrackingRequest
	{
		private readonly ILogger<CovidTrackingRequest> _logger;
		private readonly IDistributedCache _cache;
		private readonly IMemoryCache _memoryCache;

		//Country
		private const string countryHistoricDaily = "/v1/us/daily.json";
		private const string countryCurrentDaily = "/v1/us/current.json";
		private const string countryHistoricByDay = "/v1/us/{0}.json";

		//State
		private const string stateAllMetadata = "/v1/states/info.json";
		private const string stateSingleMetadata = "/v1/states/{0}/info.json";
		private const string stateAllHistoric = "/v1/states/daily.json";
		private const string stateAllCurrent = "/v1/states/current.json";
		private const string stateSingleCurrent = "/v1/states/{0}/current.json";
		private const string stateSingleHistoric = "/v1/states/{0}/daily.json";
		private const string stateSingleHistoricByDay = "/v1/states/{0}/{1}.json";

		//Status
		private const string statusUrl = "/v1/status.json";

		public CovidTrackingRequest(ILogger<CovidTrackingRequest> logger = null, IDistributedCache cache = null, IMemoryCache memoryCache = null)
		{
			_logger = logger;
			_cache = cache;
			_memoryCache = memoryCache;
		}

		public async Task<ApiStatus> GetApiStatus()
		{
			return await RequestData<ApiStatus>(statusUrl);
		}

		public async Task<State> GetStateHistoricByDate(UsState usState, DateTime date)
		{
			return await RequestData<State>(string.Format(stateSingleHistoricByDay, usState.ToString().ToLower(), date.ToCovidTrackingDate()));
		}

		public async Task<IEnumerable<State>> GetStateHistoric(UsState usState)
		{
			return await RequestData<IEnumerable<State>>(string.Format(stateSingleHistoric, usState.ToString().ToLower()));
		}

		public async Task<State> GetStateCurrent(UsState usState)
		{
			return await RequestData<State>(string.Format(stateSingleCurrent, usState.ToString().ToLower()));
		}

		public async Task<IEnumerable<State>> GetAllStateCurrent()
		{
			return await RequestData<IEnumerable<State>>(stateAllCurrent);
		}

		public async Task<IEnumerable<State>> GetAllStateHistoric()
		{
			return await RequestData<IEnumerable<State>>(stateAllHistoric);
		}

		public async Task<StateMetadata> GetStateMetadata(UsState usState)
		{
			return await RequestData<StateMetadata>(string.Format(stateSingleMetadata, usState.ToString().ToLower()));
		}

		public async Task<IEnumerable<StateMetadata>> GetAllStateMetadata()
		{
			return await RequestData<IEnumerable<StateMetadata>>(stateAllMetadata);
		}

		public async Task<IEnumerable<Country>> GetCountryHistoric()
		{
			return await RequestData<IEnumerable<Country>>(countryHistoricDaily);
		}

		public async Task<Country> GetCountryCurrentDaily()
		{
			var result =  await RequestData<IEnumerable<Country>>(countryCurrentDaily);
			return result.FirstOrDefault();
		}

		public async Task<Country> GetCountryHistoricByDay(DateTime date)
		{
			return await RequestData<Country>(string.Format(countryHistoricByDay, date.ToCovidTrackingDate()));
		}

		private async Task<T> RequestData<T>(string url)
		{
			var resultString = await GetCache(url);

			if (string.IsNullOrWhiteSpace(resultString))
			{
				try
				{
					using (var client = new HttpClient())
					{
						client.DefaultRequestHeaders.Add("Accept", "application/json");
						var response = await client.GetAsync($"https://covidtracking.com/api{url}");
						response.EnsureSuccessStatusCode();

						resultString = await response.Content.ReadAsStringAsync();

						SetCache(url, resultString);
					}
				}
				catch(Exception e)
				{
					if(_logger != null)
					{
						_logger.LogError(e.Message, e);
					}

					throw;
				}				
			}

			return JsonConvert.DeserializeObject<T>(resultString);
		}

		private async Task<string> GetCache(string key)
		{
			var result = string.Empty;

			if(_memoryCache != null)
			{
				_memoryCache.TryGetValue(key, out result);
			}

			if(_cache != null && string.IsNullOrWhiteSpace(result))
			{
				result = await _cache.GetStringAsync(key);
			}

			return result;
		}

		private async void SetCache(string key, string value)
		{
			if (_cache != null)
				await _cache.SetStringAsync(key, value, new DistributedCacheEntryOptions { AbsoluteExpirationRelativeToNow = TimeSpan.FromMinutes(60) });

			if (_memoryCache != null)
				_memoryCache.Set(key, value, new MemoryCacheEntryOptions { AbsoluteExpirationRelativeToNow = TimeSpan.FromMinutes(60) });
		}
	}
}
