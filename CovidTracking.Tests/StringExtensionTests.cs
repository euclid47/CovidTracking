using System;
using Xunit;
using CovidTracking.Api.Extensions;

namespace CovidTracking.Tests
{
	public class StringExtensionTests
	{
		[Fact]
		public void ToCovidTrackingDateTest()
		{
			var testDate = new DateTime(2020, 01, 02);
			Assert.Equal("20200102", testDate.ToCovidTrackingDate());
		}
	}
}
