using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace CovidTracking.Api.Models.V1
{
    /// <summary>
    /// Basic information about states, including notes about our methodology and the websites we use to check for data.
    /// </summary>
	public class StateMetadata
	{
        /// <summary>
        /// The state postal code
        /// </summary>
        [JsonProperty("state")]
        public string State { get; set; }

        /// <summary>
        /// Notes about the state
        /// </summary>
        [JsonProperty("notes")]
        public string Notes { get; set; }

        /// <summary>
        /// URL to the state's COVID website
        /// </summary>
        [JsonProperty("covid19Site")]
        public Uri Covid19Site { get; set; }

        /// <summary>
        /// URL to the state's secondary COVID website
        /// </summary>
        [JsonProperty("covid19SiteSecondary")]
        public Uri Covid19SiteSecondary { get; set; }

        /// <summary>
        /// URL to the state's tertiary COVID website
        /// </summary>
        [JsonProperty("covid19SiteTertiary")]
        public string Covid19SiteTertiary { get; set; }

        /// <summary>
        /// The state's COVID-related Twitter handle
        /// </summary>
        [JsonProperty("twitter")]
        public string Twitter { get; set; }

        /// <summary>
        /// URL to the state's old COVID website
        /// </summary>
        [JsonProperty("covid19SiteOld")]
        public Uri Covid19SiteOld { get; set; }

        /// <summary>
        /// The name of the state
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// The census FIPS code
        /// </summary>
        [JsonProperty("fips")]
        public string Fips { get; set; }

        /// <summary>
        /// Deprecated
        /// </summary>
        [JsonProperty("pui")]
        [Obsolete("Deprecated in API.", false)]
        public string Pui { get; set; }

        /// <summary>
        /// Deprecated
        /// </summary>
        [JsonProperty("pum")]
        [Obsolete("Deprecated in API.", false)]
        public bool? Pum { get; set; }
    }
}
