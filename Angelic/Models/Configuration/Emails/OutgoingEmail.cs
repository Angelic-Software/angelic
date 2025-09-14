using System.CodeDom.Compiler;
using Newtonsoft.Json;

namespace Angelic.Models.Configuration.Emails;

[GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
public record OutgoingEmail
{
    [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Id { get; set; } 

    [JsonProperty("datesent", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeOffset? DateSent { get; set; } 

    [JsonProperty("memo", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Memo { get; set; } 

    [JsonProperty("html", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Html { get; set; } 

    [JsonProperty("delete", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Delete { get; set; } 

    [JsonProperty("from", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? From { get; set; } 

    [JsonProperty("to", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? To { get; set; } 

    [JsonProperty("cc", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Cc { get; set; } 

    [JsonProperty("subject", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Subject { get; set; } 

    [JsonProperty("likely_cause", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? LikelyCause { get; set; } 

    [JsonProperty("changeseq", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? ChangeSeq { get; set; } 

    [JsonProperty("type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Type { get; set; } 

    [JsonProperty("idone", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? IdOne { get; set; } 

    [JsonProperty("idtwo", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? IdTwo { get; set; } 

    [JsonProperty("actiondate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeOffset? ActionDate { get; set; } 

    [JsonProperty("error", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Error { get; set; } 

    [JsonProperty("_warning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Warning { get; set; } 

}