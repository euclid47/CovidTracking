using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace CovidTracking.Api.Models.V1
{
    /// <summary>
    /// US state and territory covid-19 model
    /// </summary>
    public class State : BaseModel
    {
        /// <summary>
        /// Two-letter code for the state.
        /// </summary>
        [JsonProperty("state")]
        public string UsState { get; set; }

        /// <summary>
        /// Grade assigned to the state based on the quality of their data reporting.
        /// </summary>
        [JsonProperty("dataQualityGrade")]
        public string DataQualityGrade { get; set; }

        /// <summary>
        /// Last time the day's data was updated.
        /// </summary>
        [JsonProperty("lastUpdateEt")]
        public string LastUpdateEt { get; set; }

        /// <summary>
        /// Deprecated, use lastUpdateEt instead
        /// </summary>
        [JsonProperty("dateModified")]
        [Obsolete("Deprecated, use lastUpdateEt instead", false)]
        public DateTimeOffset? DateModified { get; set; }

        /// <summary>
        /// Deprecated
        /// </summary>
        [JsonProperty("checkTimeEt")]
        [Obsolete("Deprecated in API.", false)]
        public string CheckTimeEt { get; set; }

        /// <summary>
        /// Total number of PCR tests performed.
        /// Returns null if no data is available
        /// </summary>
        [JsonProperty("totalTestsViral")]
        public long? TotalTestsViral { get; set; }

        /// <summary>
        /// Total number of positive PCR tests.
        /// Returns null if no data is available
        /// </summary>
        [JsonProperty("positiveTestsViral")]
        public object PositiveTestsViral { get; set; }

        /// <summary>
        /// Total number of negative PCR tests.
        /// Returns null if no data is available
        /// </summary>
        [JsonProperty("negativeTestsViral")]
        public object NegativeTestsViral { get; set; }

        /// <summary>
        /// Total number of positive cases measured with PCR tests.
        /// Returns null if no data is available
        /// </summary>
        [JsonProperty("positiveCasesViral")]
        public long? PositiveCasesViral { get; set; }

        /// <summary>
        /// Census FIPS code for the state.
        /// </summary>
        [JsonProperty("fips")]
        public string Fips { get; set; }

        /// <summary>
        /// Deprecated
        /// Returns null if no data is available
        /// </summary>
        [JsonProperty("commercialScore")]
        [Obsolete("Deprecated in API.", false)]
        public long? CommercialScore { get; set; }

        /// <summary>
        /// Deprecated
        /// Returns null if no data is available
        /// </summary>
        [JsonProperty("negativeRegularScore")]
        [Obsolete("Deprecated in API.", false)]
        public long? NegativeRegularScore { get; set; }

        /// <summary>
        /// Deprecated
        /// Returns null if no data is available
        /// </summary>
        [JsonProperty("negativeScore")]
        [Obsolete("Deprecated in API.", false)]
        public long? NegativeScore { get; set; }

        /// <summary>
        /// Deprecated
        /// Returns null if no data is available
        /// </summary>
        [JsonProperty("positiveScore")]
        [Obsolete("Deprecated in API.", false)]
        public long? PositiveScore { get; set; }

        /// <summary>
        /// Deprecated
        /// Returns null if no data is available
        /// </summary>
        [JsonProperty("score")]
        [Obsolete("Deprecated in API.", false)]
        public long? Score { get; set; }

        /// <summary>
        /// Deprecated
        /// </summary>
        [JsonProperty("grade")]
        [Obsolete("Deprecated in API.", false)]
        public string Grade { get; set; }
    }
}
