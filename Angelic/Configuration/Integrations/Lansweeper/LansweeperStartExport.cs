using System.CodeDom.Compiler;
using Newtonsoft.Json;

namespace Angelic.Configuration.Integrations.Lansweeper;

[GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class LansweeperStartExport
{
    [JsonProperty("siteMappingId", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? SiteMappingId { get; set; } 

}