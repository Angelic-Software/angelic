using System.CodeDom.Compiler;
using Angelic.KeyPairs;
using Newtonsoft.Json;

namespace Angelic;

[GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class CustomQuery
{
    [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Id { get; set; } 

    [JsonProperty("name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Name { get; set; } 

    [JsonProperty("sql_script", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? SqlScript { get; set; } 

    [JsonProperty("run", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Run { get; set; } 

    [JsonProperty("run_result", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public CustomSqlResult? RunResult { get; set; } 

    [JsonProperty("lookup_values", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<StringIdNameKeyPair>? LookupValues { get; set; } 

    [JsonProperty("column_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? ColumnName { get; set; } 

    [JsonProperty("top_max", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? TopMax { get; set; } 

}