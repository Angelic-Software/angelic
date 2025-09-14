using System.CodeDom.Compiler;
using Newtonsoft.Json;

namespace Angelic.Models.Configuration.Integrations.Snow;

[GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
public record SnowComputerUserAbstract
{
    [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Id { get; set; } 

    [JsonProperty("customerId", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? CustomerId { get; set; } 

    [JsonProperty("username", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Username { get; set; } 

    [JsonProperty("lastLogon", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeOffset? LastLogon { get; set; } 

    [JsonProperty("fullName", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? FullName { get; set; } 

    [JsonProperty("updatedDate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeOffset? UpdatedDate { get; set; } 

    [JsonProperty("updatedBy", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? UpdatedBy { get; set; } 

    [JsonProperty("logonCount", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? LogonCount { get; set; } 

    [JsonProperty("userIsAccessible", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? UserIsAccessible { get; set; } 

}