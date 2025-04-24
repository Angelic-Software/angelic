using System.CodeDom.Compiler;
using Newtonsoft.Json;

namespace Angelic;

[GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class ReleaseNote
{
    [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Id { get; set; } 

    [JsonProperty("note", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Note { get; set; } 

    [JsonProperty("category", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Category { get; set; } 

    [JsonProperty("important", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Important { get; set; } 

    [JsonProperty("group_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? GroupId { get; set; } 

    [JsonProperty("changeinformation", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Changeinformation { get; set; } 

    [JsonProperty("changeinformationexists", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Changeinformationexists { get; set; } 

    [JsonProperty("date", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeOffset? Date { get; set; } 

    [JsonProperty("month", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Month { get; set; } 

    [JsonProperty("version", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Version { get; set; } 

    [JsonProperty("group", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ReleaseNoteGroup? Group { get; set; } 

}