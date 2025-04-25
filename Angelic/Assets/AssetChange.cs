using System.CodeDom.Compiler;
using Newtonsoft.Json;

namespace Angelic.Assets;

[GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class AssetChange
{
    [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public long? Id { get; set; } 

    [JsonProperty("field_desc", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? FieldDesc { get; set; } 

    [JsonProperty("asset_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? AssetId { get; set; } 

    [JsonProperty("asset_site", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? AssetSite { get; set; } 

    [JsonProperty("asset_number", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? AssetNumber { get; set; } 

    [JsonProperty("field_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? FieldId { get; set; } 

    [JsonProperty("field_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? FieldName { get; set; } 

    [JsonProperty("old_value", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? OldValue { get; set; } 

    [JsonProperty("new_value", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? NewValue { get; set; } 

    [JsonProperty("who", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Who { get; set; } 

    [JsonProperty("datetime", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeOffset? Datetime { get; set; } 

    [JsonProperty("software_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? SoftwareId { get; set; } 

    [JsonProperty("software_user_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? SoftwareUserId { get; set; } 

    [JsonProperty("software_user_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? SoftwareUserName { get; set; } 

    [JsonProperty("old_site", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? OldSite { get; set; } 

    [JsonProperty("new_site", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? NewSite { get; set; } 

    [JsonProperty("customfield_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? CustomfieldId { get; set; } 

    [JsonProperty("item_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? ItemId { get; set; } 

}