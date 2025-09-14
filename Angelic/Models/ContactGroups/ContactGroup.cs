using System.CodeDom.Compiler;
using Newtonsoft.Json;

namespace Angelic.Models.ContactGroups;

[GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
public record ContactGroup
{
    [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Id { get; set; } 

    [JsonProperty("name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Name { get; set; } 

    [JsonProperty("ownerunum", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? OwnerUnum { get; set; } 

    [JsonProperty("allowall", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? AllowAll { get; set; } 

    [JsonProperty("allowalledit", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? AllowAllEdit { get; set; } 

    [JsonProperty("contactgroupcontacts", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<ContactGroupContacts>? ContactGroupContacts { get; set; } 

    [JsonProperty("_warning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Warning { get; set; } 

}