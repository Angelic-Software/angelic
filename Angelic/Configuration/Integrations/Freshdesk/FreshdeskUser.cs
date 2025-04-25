using System.CodeDom.Compiler;
using Newtonsoft.Json;

namespace Angelic.Configuration.Integrations.Freshdesk;

[GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class FreshdeskUser
{
    [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public long? Id { get; set; } 

    [JsonProperty("name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Name { get; set; } 

    [JsonProperty("email", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Email { get; set; } 

    [JsonProperty("mobile", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Mobile { get; set; } 

    [JsonProperty("phone", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Phone { get; set; } 

    [JsonProperty("active", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Active { get; set; } 

    [JsonProperty("address", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Address { get; set; } 

    [JsonProperty("avatar", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public object? Avatar { get; set; } 

    [JsonProperty("company_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public long? CompanyId { get; set; } 

    [JsonProperty("view_all_tickets", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? ViewAllTickets { get; set; } 

    [JsonProperty("deleted", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Deleted { get; set; } 

    [JsonProperty("description", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Description { get; set; } 

    [JsonProperty("job_title", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? JobTitle { get; set; } 

    [JsonProperty("language", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Language { get; set; } 

    [JsonProperty("other_emails", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<string>? OtherEmails { get; set; } 

    [JsonProperty("tags", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Tags { get; set; } 

    [JsonProperty("time_zone", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? TimeZone { get; set; } 

    [JsonProperty("twitter_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? TwitterId { get; set; } 

    [JsonProperty("unique_external_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? UniqueExternalId { get; set; } 

    [JsonProperty("created_at", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? CreatedAt { get; set; } 

    [JsonProperty("updated_at", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? UpdatedAt { get; set; } 

    [JsonProperty("custom_fields", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public IDictionary<string, string?>? CustomFields { get; set; } 

}