using System.CodeDom.Compiler;
using Angelic.Models.Configuration.Integrations.Meta.Instagram;
using Newtonsoft.Json;

namespace Angelic.Models.Configuration.Integrations.Meta.Facebook;

[GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class FacebookPage
{
    [JsonProperty("access_token", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? AccessToken { get; set; } 

    [JsonProperty("category", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Category { get; set; } 

    [JsonProperty("category_list", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<FacebookKeyPair>? CategoryList { get; set; } 

    [JsonProperty("name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Name { get; set; } 

    [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Id { get; set; } 

    [JsonProperty("tasks", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<string>? Tasks { get; set; } 

    [JsonProperty("instagram_business_account", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public InstagramBusinessAccount? InstagramBusinessAccount { get; set; } 

}