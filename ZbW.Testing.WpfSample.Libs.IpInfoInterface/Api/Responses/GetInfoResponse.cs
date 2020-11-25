using Newtonsoft.Json;

namespace ZbW.Testing.WpfSample.Libs.IpInfoInterface.Api.Responses
{
    public class GetInfoResponse
    {
        [JsonProperty("ip")] public string Ip { get; set; }

        [JsonProperty("hostname")] public string Hostname { get; set; }

        [JsonProperty("city")] public string City { get; set; }

        [JsonProperty("region")] public string Region { get; set; }

        [JsonProperty("country")] public string Country { get; set; }

        [JsonProperty("loc")] public string GeoLocation { get; set; }

        [JsonProperty("org")] public string Organization { get; set; }

        [JsonProperty("postal")] public string Postalcode { get; set; }

        [JsonProperty("timezone")] public string Timezone { get; set; }
    }
}