using System.CodeDom.Compiler;
using Newtonsoft.Json;

namespace Angelic.Models;

[GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class ContactGroup
{
    [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Id { get; set; } 

    [JsonProperty("name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Name { get; set; } 

    [JsonProperty("ownerunum", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Ownerunum { get; set; } 

    [JsonProperty("allowall", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Allowall { get; set; } 

    [JsonProperty("allowalledit", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Allowalledit { get; set; } 

    [JsonProperty("contactgroupcontacts", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<ContactGroupContacts>? Contactgroupcontacts { get; set; } 

    [JsonProperty("_warning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Warning { get; set; } 

}