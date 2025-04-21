using System.CodeDom.Compiler;
using Newtonsoft.Json;
using Angelic.AdobeAcrobatDocumentsinfo;

namespace Angelic.AdobeAcrobatWebhookAgreement;

[GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class AdobeAcrobatWebhookAgreement
{
    [JsonProperty("documentsInfo", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public AdobeAcrobatDocumentsinfo? DocumentsInfo { get; set; }

    [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Id { get; set; }

    [JsonProperty("name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Name { get; set; }

    [JsonProperty("status", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Status { get; set; }
}
