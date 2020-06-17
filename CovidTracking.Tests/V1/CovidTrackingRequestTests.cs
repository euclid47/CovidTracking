using System;
using Xunit;

namespace CovidTracking.Tests.V1
{
	public class CovidTrackingRequestTests : TestBase
	{
		[Fact]
		public async void GetApiStatusTest()
		{
			var result = await _covidTrackingRequest.GetApiStatus();
			Assert.NotNull(result);
		}

		[Fact]
		public async void GetStateHistoricByDateTest()
		{
			var result = await _covidTrackingRequest.GetStateHistoricByDate(Api.Enums.UsState.AK, new DateTime(2020, 06, 16));
			Assert.NotNull(result);
		}

		[Fact]
		public async void GetStateHistoricTest()
		{
			var result = await _covidTrackingRequest.GetStateHistoric(Api.Enums.UsState.AK);
			Assert.NotNull(result);
		}

		[Fact]
		public async void GetStateCurrent()
		{
			var result = await _covidTrackingRequest.GetStateCurrent(Api.Enums.UsState.AK);
			Assert.NotNull(result);
		}

		[Fact]
		public async void GetAllStateCurrentTest()
		{
			var result = await _covidTrackingRequest.GetAllStateCurrent();
			Assert.NotNull(result);
		}

		[Fact]
		public async void GetAllStateHistoricTest()
		{
			var result = await _covidTrackingRequest.GetAllStateHistoric();
			Assert.NotNull(result);
		}

		[Fact]
		public async void GetStateMetadata()
		{
			var result = await _covidTrackingRequest.GetStateMetadata(Api.Enums.UsState.AK);
			Assert.NotNull(result);
		}

		[Fact]
		public async void GetAllStateMetadata()
		{
			var result = await _covidTrackingRequest.GetAllStateMetadata();
			Assert.NotNull(result);
		}

		[Fact]
		public async void GetCountryHistoricTest()
		{
			var result = await _covidTrackingRequest.GetCountryHistoric();
			Assert.NotNull(result);
		}

		[Fact]
		public async void GetCountryCurrentDailyTest()
		{
			var result = await _covidTrackingRequest.GetCountryCurrentDaily();
			Assert.NotNull(result);
		}

		[Fact]
		public async void GetCountryHistoricByDayTest()
		{
			var result = await _covidTrackingRequest.GetCountryHistoricByDay(new DateTime(2020, 6, 16));
			Assert.NotNull(result);
		}
	}
}
