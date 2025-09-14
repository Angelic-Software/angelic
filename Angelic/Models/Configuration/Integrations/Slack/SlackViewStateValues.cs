using System.CodeDom.Compiler;
using Newtonsoft.Json;

namespace Angelic.Models.Configuration.Integrations.Slack;

[GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
public record SlackViewStateValues
{
    [JsonProperty("summary_input", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public SlackViewStateValuesInput? SummaryInput { get; set; } 

    [JsonProperty("details_input", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public SlackViewStateValuesInput? DetailsInput { get; set; } 

    [JsonProperty("note_input", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public SlackViewStateValuesInput? NoteInput { get; set; } 

    [JsonProperty("ticket_id_input", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public SlackViewStateValuesInput? TicketIdInput { get; set; } 

    [JsonProperty("status_input", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public SlackViewStateStatusField? StatusInput { get; set; } 

}