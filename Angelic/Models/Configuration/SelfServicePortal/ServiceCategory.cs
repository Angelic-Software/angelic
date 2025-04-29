using System.CodeDom.Compiler;
using Angelic.Models.Configuration.Language;
using Newtonsoft.Json;

namespace Angelic.Models.Configuration.SelfServicePortal;

[GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class ServiceCategory
{
    [JsonProperty("guid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public Guid? Guid { get; set; } 

    [JsonProperty("intent", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Intent { get; set; } 

    [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Id { get; set; } 

    [JsonProperty("name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Name { get; set; } 

    [JsonProperty("userlevel", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Userlevel { get; set; } 

    [JsonProperty("seq", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Seq { get; set; } 

    [JsonProperty("important", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Important { get; set; } 

    [JsonProperty("icon", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Icon { get; set; } 

    [JsonProperty("new_icon", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? NewIcon { get; set; } 

    [JsonProperty("summary", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Summary { get; set; } 

    [JsonProperty("parent_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? ParentId { get; set; } 

    [JsonProperty("parent_guid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public Guid? ParentGuid { get; set; } 

    [JsonProperty("parent_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? ParentName { get; set; } 

    [JsonProperty("grandparent_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? GrandparentName { get; set; } 

    [JsonProperty("long_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? LongName { get; set; } 

    [JsonProperty("service_count", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? ServiceCount { get; set; } 

    [JsonProperty("user_access", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<ServiceRestriction>? UserAccess { get; set; } 

    [JsonProperty("translations", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<LanguagePackTranslationsCustom>? Translations { get; set; } 

    [JsonProperty("_warning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Warning { get; set; } 

    [JsonProperty("access_control", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<AccessControl>? AccessControl { get; set; } 

    [JsonProperty("access_control_level", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? AccessControlLevel { get; set; } 

    [JsonProperty("phonenumber", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? PhoneNumber { get; set; } 

    [JsonProperty("portalbackgroundimageurl", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    [System.ComponentModel.DataAnnotations.StringLength(500)]
    public string? PortalBackgroundImageUrl { get; set; } 

    [JsonProperty("portaldesc", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? PortalDesc { get; set; } 

}