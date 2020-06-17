using System;

namespace CovidTracking.Api.Extensions
{
	public static class StringExtensions
	{
		public static string ToCovidTrackingDate(this DateTime val)
		{
			return $"{val:yyyyMMdd}";
		}
	}
}
