using System.CodeDom.Compiler;
using Newtonsoft.Json;

namespace Angelic.Configuration.Advanced;

[GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class Certificate
{
    [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Id { get; set; } 

    [JsonProperty("name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Name { get; set; } 

    [JsonProperty("subject", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Subject { get; set; } 

    [JsonProperty("issuer", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Issuer { get; set; } 

    [JsonProperty("thumbprint", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Thumbprint { get; set; } 

    [JsonProperty("new_password", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? NewPassword { get; set; } 

    [JsonProperty("attachment_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? AttachmentId { get; set; } 

    [JsonProperty("attachment_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? AttachmentName { get; set; } 

    [JsonProperty("_warning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Warning { get; set; } 

}