using CovidTracking.Api.V1;
using Microsoft.Extensions.Caching.Memory;
using System;
using System.Collections.Generic;
using System.Text;

namespace CovidTracking.Tests.V1
{
	public abstract class TestBase : IDisposable
	{
		internal readonly IMemoryCache _memoryCache;
		internal readonly ICovidTrackingRequest _covidTrackingRequest;
		internal readonly ICovidTrackingRequest _covidTrackingRequestCached;

		public TestBase()
		{
			_memoryCache = new MemoryCache(new MemoryCacheOptions());
			_covidTrackingRequestCached = new CovidTrackingRequest(null, null, _memoryCache);
			_covidTrackingRequest = new CovidTrackingRequest();
		}

		public void Dispose()
		{

		}
	}
}
