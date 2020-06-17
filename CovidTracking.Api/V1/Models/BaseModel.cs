using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace CovidTracking.Api.Models.V1
{
	public abstract class BaseModel
	{
		/// <summary>
		/// Date for which the daily totals were collected.
		/// </summary>
		[JsonProperty("date")]
		public long? Date { get; set; }

		/// <summary>
		/// Total number of people who have tested positive for COVID-19 so far.
		/// Returns null if no data is available
		/// </summary>
		[JsonProperty("positive")]
		public long? Positive { get; set; }

		/// <summary>
		/// Total number of people who have tested negative for COVID-19 so far.
		/// Returns null if no data is available
		/// </summary>
		[JsonProperty("negative")]
		public long? Negative { get; set; }

		/// <summary>
		/// Number of tests whose results have yet to be determined.
		/// Returns null if no data is available
		/// </summary>
		[JsonProperty("pending")]
		public long? Pending { get; set; }

		/// <summary>
		/// Number of people in hospital for COVID-19 on this day.
		/// Returns null if no data is available
		/// </summary>
		[JsonProperty("hospitalizedCurrently")]
		public long? HospitalizedCurrently { get; set; }

		/// <summary>
		/// Total number of people who have gone to the hospital for COVID-19 so far, including those who have since recovered or died.
		/// Returns null if no data is available
		/// </summary>
		[JsonProperty("hospitalizedCumulative")]
		public long? HospitalizedCumulative { get; set; }

		/// <summary>
		/// Total number of people who have gone to the ICU for COVID-19 so far, including those who have since recovered or died.
		/// Returns null if no data is available.
		/// </summary>
		[JsonProperty("inIcuCurrently")]
		public long? InIcuCurrently { get; set; }

		/// <summary>
		/// Total number of people in the ICU for COVID-19 on this day.
		/// Returns null if no data is available.
		/// </summary>
		[JsonProperty("inIcuCumulative")]
		public long? InIcuCumulative { get; set; }

		/// <summary>
		/// Number of people using a ventilator for COVID-19 on this day.
		/// Returns null if no data is available
		/// </summary>
		[JsonProperty("onVentilatorCurrently")]
		public long? OnVentilatorCurrently { get; set; }

		/// <summary>
		/// Total number of people who have used a ventilator for COVID-19 so far, including those who have since recovered or died.
		/// Returns null if no data is available
		/// </summary>
		[JsonProperty("onVentilatorCumulative")]
		public long? OnVentilatorCumulative { get; set; }

		/// <summary>
		/// Total number of people who have recovered from COVID-19 so far.
		/// Returns null if no data is available
		/// </summary>
		[JsonProperty("recovered")]
		public long? Recovered { get; set; }

		/// <summary>
		/// Total number of people who have died as a result of COVID-19 so far.
		/// </summary>
		[JsonProperty("death")]
		public long? Death { get; set; }

		/// <summary>
		/// DateTime this data was entered into our database.
		/// </summary>
		[JsonProperty("dateChecked")]
		public DateTimeOffset? DateChecked { get; set; }

		/// <summary>
		/// Deprecated, Returns null if no data is available
		/// </summary>
		[JsonProperty("hospitalized")]
		[Obsolete("Deprecated in API", false)]
		public long? Hospitalized { get; set; }

		/// <summary>
		/// Deprecated
		/// Returns null if no data is available
		/// </summary>
		[JsonProperty("negativeIncrease")]
		[Obsolete("Deprecated in API", false)]
		public long? NegativeIncrease { get; set; }

		/// <summary>
		/// Deprecated
		/// Returns null if no data is available
		/// </summary>
		[JsonProperty("positiveIncrease")]
		[Obsolete("Deprecated in API", false)]
		public long? PositiveIncrease { get; set; }

		/// <summary>
		/// Deprecated
		/// Returns null if no data is available
		/// </summary>
		[JsonProperty("total")]
		[Obsolete("Deprecated in API.", false)]
		public long? Total { get; set; }

		/// <summary>
		/// Deprecated
		/// Returns null if no data is available
		/// </summary>
		[JsonProperty("posNeg")]
		[Obsolete("Deprecated in API.", false)]
		public long? PosNeg { get; set; }

		/// <summary>
		/// Deprecated, Returns null if no data is available
		/// </summary>
		[JsonProperty("deathIncrease")]
		[Obsolete("Deprecated in API", false)]
		public long? DeathIncrease { get; set; }

		/// <summary>
		/// Deprecated, Returns null if no data is available
		/// </summary>
		[JsonProperty("hospitalizedIncrease")]
		[Obsolete("Deprecated in API", false)]
		public long? HospitalizedIncrease { get; set; }

		/// <summary>
		/// A hash for this record
		/// </summary>
		[JsonProperty("hash")]
		public string Hash { get; set; }

		/// <summary>
		/// Deprecated
		/// Returns null if no data is available
		/// </summary>
		[JsonProperty("totalTestResults")]
		[Obsolete("Deprecated in API.", false)]
		public long? TotalTestResults { get; set; }

		/// <summary>
		/// Deprecated
		/// Returns null if no data is available
		/// </summary>
		[JsonProperty("totalTestResultsIncrease")]
		[Obsolete("Deprecated in API.", false)]
		public long? TotalTestResultsIncrease { get; set; }
	}
}
