using System.CodeDom.Compiler;
using Newtonsoft.Json;

namespace Angelic.Models.Timesheet;

[GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class TimesheetApproval
{
    [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Id { get; set; } 

    [JsonProperty("tsid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? TsId { get; set; } 

    [JsonProperty("unum", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Unum { get; set; } 

    [JsonProperty("approvalstatus", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public TimeSheetApprovalStatus? ApprovalStatus { get; set; } 

    [JsonProperty("approvedby", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? ApprovedBy { get; set; } 

    [JsonProperty("submissiondate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeOffset? SubmissionDate { get; set; } 

    [JsonProperty("approver", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Approver { get; set; } 

    [JsonProperty("message", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Message { get; set; } 

    [JsonProperty("_warning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Warning { get; set; } 

}