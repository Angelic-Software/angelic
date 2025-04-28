using System.CodeDom.Compiler;
using Newtonsoft.Json;

namespace Angelic.Models.Configuration.Integrations.Slack;

[GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class SlackViewStateValuesDropdownInput
{
    [JsonProperty("external_select", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? ExternalSelect { get; set; } 

    [JsonProperty("selected_option", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public SlackOption? SelectedOption { get; set; } 

}