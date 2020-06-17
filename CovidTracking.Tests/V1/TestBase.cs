using CovidTracking.Api.V1;
using System;
using System.Collections.Generic;
using System.Text;

namespace CovidTracking.Tests.V1
{
	public abstract class TestBase : IDisposable
	{
		internal readonly ICovidTrackingRequest _covidTrackingRequest;

		public TestBase()
		{
			_covidTrackingRequest = new CovidTrackingRequest();
		}

		public void Dispose()
		{

		}
	}
}
