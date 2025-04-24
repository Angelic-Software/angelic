using System.CodeDom.Compiler;
using Newtonsoft.Json;

namespace Angelic;

[GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class DeviceChange
{
    [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public long? Id { get; set; } 

    [JsonProperty("field_desc", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Field_desc { get; set; } 

    [JsonProperty("asset_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Asset_id { get; set; } 

    [JsonProperty("asset_site", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Asset_site { get; set; } 

    [JsonProperty("asset_number", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Asset_number { get; set; } 

    [JsonProperty("field_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Field_id { get; set; } 

    [JsonProperty("field_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Field_name { get; set; } 

    [JsonProperty("old_value", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Old_value { get; set; } 

    [JsonProperty("new_value", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? New_value { get; set; } 

    [JsonProperty("who", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Who { get; set; } 

    [JsonProperty("datetime", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeOffset? Datetime { get; set; } 

    [JsonProperty("software_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Software_id { get; set; } 

    [JsonProperty("software_user_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Software_user_id { get; set; } 

    [JsonProperty("software_user_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Software_user_name { get; set; } 

    [JsonProperty("old_site", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Old_site { get; set; } 

    [JsonProperty("new_site", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? New_site { get; set; } 

    [JsonProperty("customfield_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Customfield_id { get; set; } 

    [JsonProperty("item_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Item_id { get; set; } 

}