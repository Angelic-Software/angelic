using System.CodeDom.Compiler;
using Newtonsoft.Json;

namespace Angelic;

[GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class SlackViewStateValues
{
    [JsonProperty("summary_input", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public SlackViewStateValuesInput? Summary_input { get; set; } 

    [JsonProperty("details_input", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public SlackViewStateValuesInput? Details_input { get; set; } 

    [JsonProperty("note_input", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public SlackViewStateValuesInput? Note_input { get; set; } 

    [JsonProperty("ticket_id_input", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public SlackViewStateValuesInput? Ticket_id_input { get; set; } 

    [JsonProperty("status_input", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public SlackViewStateStatusField? Status_input { get; set; } 

}