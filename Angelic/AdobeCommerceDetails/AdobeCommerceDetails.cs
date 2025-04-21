using System.CodeDom.Compiler;
using Newtonsoft.Json;

namespace Angelic.AdobeCommerceDetails;

[GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class AdobeCommerceDetails
{
    [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Id { get; set; }

    [JsonProperty("connectionname", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Connectionname { get; set; }

    [JsonProperty("url", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Url { get; set; }

    [JsonProperty("new_integration_method", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? NewIntegrationMethod { get; set; }

    [JsonProperty("enabled", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Enabled { get; set; }

    [JsonProperty("integrator_last_sync", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public System.DateTimeOffset? IntegratorLastSync { get; set; }

    [JsonProperty("_warning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Warning { get; set; }
}
