using System.CodeDom.Compiler;
using Newtonsoft.Json;

namespace Angelic;

[GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class Contactgroupcontacts
{
    [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Id { get; set; } 

    [JsonProperty("ccgid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Ccgid { get; set; } 

    [JsonProperty("cuid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Cuid { get; set; } 

    [JsonProperty("cunum", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Cunum { get; set; } 

    [JsonProperty("name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Name { get; set; } 

    [JsonProperty("emailaddress", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Emailaddress { get; set; } 

    [JsonProperty("contacttype", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Contacttype { get; set; } 

    [JsonProperty("_warning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Warning { get; set; } 

}