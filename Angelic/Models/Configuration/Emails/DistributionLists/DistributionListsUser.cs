using System.CodeDom.Compiler;
using Newtonsoft.Json;

namespace Angelic.Models.Configuration.Emails.DistributionLists;

[GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class DistributionListsUser
{
    [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Id { get; set; } 

    [JsonProperty("distributionlists_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? DistributionlistsId { get; set; } 

    [JsonProperty("user_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? UserId { get; set; } 

    [JsonProperty("email", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Email { get; set; } 

    [JsonProperty("phone_extn", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? PhoneExtn { get; set; } 

    [JsonProperty("phone_mobile", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? PhoneMobile { get; set; } 

    [JsonProperty("phone_mobile2", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? PhoneMobile2 { get; set; } 

}