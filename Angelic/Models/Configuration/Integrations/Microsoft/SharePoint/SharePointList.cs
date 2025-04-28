using System.CodeDom.Compiler;
using Newtonsoft.Json;

namespace Angelic.Models.Configuration.Integrations.Microsoft.SharePoint;

[GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class SharePointList
{
    [JsonProperty("odata.error", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public SharePointError? OdataError { get; set; } 

    [JsonProperty("error_description", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? ErrorDescription { get; set; } 

    [JsonProperty("odata.metadata", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? OdataMetadata { get; set; } 

    [JsonProperty("odata.type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? OdataType { get; set; } 

    [JsonProperty("odata.id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? OdataId { get; set; } 

    [JsonProperty("title", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Title { get; set; } 

    [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Id { get; set; } 

}