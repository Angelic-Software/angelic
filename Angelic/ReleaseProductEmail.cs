using System.CodeDom.Compiler;
using Newtonsoft.Json;

namespace Angelic;

[GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class ReleaseProductEmail
{
    [JsonProperty("product_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Product_id { get; set; } 

    [JsonProperty("release_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Release_id { get; set; } 

    [JsonProperty("releasetype_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Releasetype_name { get; set; } 

    [JsonProperty("emailtemplate_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Emailtemplate_id { get; set; } 

    [JsonProperty("emailtemplate_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Emailtemplate_name { get; set; } 

    [JsonProperty("change_status_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Change_status_id { get; set; } 

    [JsonProperty("push_to_children", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Push_to_children { get; set; } 

    [JsonProperty("_warning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? _warning { get; set; } 

}