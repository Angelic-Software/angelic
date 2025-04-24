using System.CodeDom.Compiler;
using Newtonsoft.Json;

namespace Angelic;

[GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class SlackViewStateStatusField
{
    [JsonProperty("search_status", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public SlackViewStateValuesDropdownInput? Search_status { get; set; } 

}