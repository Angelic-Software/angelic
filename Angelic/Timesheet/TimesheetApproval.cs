using System.CodeDom.Compiler;
using Newtonsoft.Json;

namespace Angelic;

[GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class TimesheetApproval
{
    [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Id { get; set; } 

    [JsonProperty("tsid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Tsid { get; set; } 

    [JsonProperty("unum", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Unum { get; set; } 

    [JsonProperty("approvalstatus", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public TimeSheetApprovalStatus? Approvalstatus { get; set; } 

    [JsonProperty("approvedby", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Approvedby { get; set; } 

    [JsonProperty("submissiondate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeOffset? Submissiondate { get; set; } 

    [JsonProperty("approver", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Approver { get; set; } 

    [JsonProperty("message", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Message { get; set; } 

    [JsonProperty("_warning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Warning { get; set; } 

}