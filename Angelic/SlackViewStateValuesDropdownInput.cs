using System.CodeDom.Compiler;
using Newtonsoft.Json;

namespace Angelic;

[GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class SlackViewStateValuesDropdownInput
{
    [JsonProperty("external_select", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? External_select { get; set; } 

    [JsonProperty("selected_option", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public SlackOption? Selected_option { get; set; } 

}