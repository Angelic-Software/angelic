using System.CodeDom.Compiler;
using Newtonsoft.Json;

namespace Angelic.Models.Configuration.Integrations.Adobe.AdobeAcrobat;

[GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
public record AdobeAcrobatWebhookNotificationApplicableUser
{
    [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Id { get; set; }

    [JsonProperty("email", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Email { get; set; }

    [JsonProperty("role", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Role { get; set; }

    [JsonProperty("payloadApplicable", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? PayloadApplicable { get; set; }
}
