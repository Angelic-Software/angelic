using System.CodeDom.Compiler;
using Angelic.Attributes;
using Newtonsoft.Json;

namespace Angelic.Models.Reports;

[HasEndpoint("Report")]
[ListVariantOf(typeof(Report))]
[GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class ReportList
{
    [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Id { get; set; }
    
    [JsonProperty("name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Name { get; set; }
    
    [JsonProperty("description", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Description { get; set; }
    
    [JsonProperty("last_run_date", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeOffset? LastRunDate { get; set; }
    
    [JsonProperty("group_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? GroupId { get; set; }
    
    [JsonProperty("group_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? GroupName { get; set; }
    
    [JsonProperty("is_published", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? IsPublished { get; set; }
    
    [JsonProperty("publish_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? PublishType { get; set; }
    
    [JsonProperty("bookmarked", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Bookmarked { get; set; }
    
    [JsonProperty("_warning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Warning { get; set; }
}
