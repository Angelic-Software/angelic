using System.CodeDom.Compiler;
using Angelic.Models.KeyPairs;
using Newtonsoft.Json;

namespace Angelic.Models.Configuration.SqlImports;

[GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
public record SqlLookupRequest
{
    [JsonProperty("connection_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? ConnectionName { get; set; } 

    [JsonProperty("sql_string", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? SqlString { get; set; } 

    [JsonProperty("db_params", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<StringObjectDbTypeTuple>? DbParams { get; set; } 

    [JsonProperty("filookup", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Filookup { get; set; } 

}