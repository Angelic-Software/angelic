using System.CodeDom.Compiler;
using Newtonsoft.Json;

namespace Angelic;

[GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class UserPrefs
{
    [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Id { get; set; } 

    [JsonProperty("lang", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Lang { get; set; } 

    [JsonProperty("theme", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Theme { get; set; } 

    [JsonProperty("userdetails", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public Users? Userdetails { get; set; } 

}