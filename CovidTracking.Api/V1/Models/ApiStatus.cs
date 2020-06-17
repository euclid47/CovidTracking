using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace CovidTracking.Api.Models.V1
{
    /// <summary>
    /// Get the status of the CovidTracking API
    /// </summary>
	public class ApiStatus
	{
        /// <summary>
        /// The last time the API was built.
        /// </summary>
        [JsonProperty("buildTime")]
        public DateTimeOffset? BuildTime { get; set; }

        /// <summary>
        /// Whether this is a production build of the API.
        /// </summary>
        [JsonProperty("production")]
        public bool? Production { get; set; }

        /// <summary>
        /// The run ID. Set to zero if it is a non-production run.
        /// </summary>
        [JsonProperty("runNumber")]
        public string RunNumber { get; set; }
    }
}
