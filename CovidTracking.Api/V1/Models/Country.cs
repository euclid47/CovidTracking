using Newtonsoft.Json;
using System;

namespace CovidTracking.Api.Models.V1
{
    /// <summary>
    /// United States covid-19 model
    /// </summary>
    public class Country : BaseModel
    {
        /// <summary>
        /// Number of states included in the data for this day.
        /// </summary>
        [JsonProperty("states")]
        public long? States { get; set; }

        /// <summary>
        /// Deprecated
        /// </summary>
        [JsonProperty("lastModified")]
        [Obsolete("Deprecated", false)]
        public DateTimeOffset? LastModified { get; set; }
    }
}
