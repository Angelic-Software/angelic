using System.CodeDom.Compiler;
using Newtonsoft.Json;

namespace Angelic;

[GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class DashboardFilter
{
    [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Id { get; set; } 

    [JsonProperty("dashboard_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? DashboardId { get; set; } 

    [JsonProperty("name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Name { get; set; } 

    [JsonProperty("column", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Column { get; set; } 

    [JsonProperty("filter_sql", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? FilterSql { get; set; } 

    [JsonProperty("sequence", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Sequence { get; set; } 

    [JsonProperty("default", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Default { get; set; } 

    [JsonProperty("_warning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Warning { get; set; } 

}