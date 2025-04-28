using System.CodeDom.Compiler;
using Newtonsoft.Json;

namespace Angelic.Models.Items;

[GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class ItemId
{
    [JsonProperty("uniqueId", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? UniqueId { get; set; } 

    [JsonProperty("changeKey", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? ChangeKey { get; set; } 

}