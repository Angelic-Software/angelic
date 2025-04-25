using System.CodeDom.Compiler;
using Angelic.Configuration.TeamsAndAgents.Agents;
using Newtonsoft.Json;

namespace Angelic;

[GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class UserRoles
{
    [JsonProperty("guid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public Guid? Guid { get; set; } 

    [JsonProperty("intent", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Intent { get; set; } 

    [JsonProperty("isimportantcontact2", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Isimportantcontact2 { get; set; } 

    [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Id { get; set; } 

    [JsonProperty("showmeonly", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? ShowMeonly { get; set; } 

    [JsonProperty("ischangeapprover2", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Ischangeapprover2 { get; set; } 

    [JsonProperty("ispoapprover", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Ispoapprover { get; set; } 

    [JsonProperty("web_access_level", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? WebAccessLevel { get; set; } 

    [JsonProperty("canadd", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Canadd { get; set; } 

    [JsonProperty("canviewopps", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Canviewopps { get; set; } 

    [JsonProperty("allowviewsitedocs", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Allowviewsitedocs { get; set; } 

    [JsonProperty("allowviewclientdocs", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Allowviewclientdocs { get; set; } 

    [JsonProperty("canviewcontracts", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Canviewcontracts { get; set; } 

    [JsonProperty("canaccesscatalog", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Canaccesscatalog { get; set; } 

    [JsonProperty("cataloglevel", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Cataloglevel { get; set; } 

    [JsonProperty("canaccessinvoices", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Canaccessinvoices { get; set; } 

    [JsonProperty("name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Name { get; set; } 

    [JsonProperty("notes", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Notes { get; set; } 

    [JsonProperty("device_access_level", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? DeviceAccessLevel { get; set; } 

    [JsonProperty("is_integration", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? IsIntegration { get; set; } 

    [JsonProperty("_warning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Warning { get; set; } 

    [JsonProperty("dontackemails2", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Dontackemails2 { get; set; } 

    [JsonProperty("departments", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<UserDepartment>? Departments { get; set; } 

    [JsonProperty("notifications", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<AgentNotification>? Notifications { get; set; } 

    [JsonProperty("canuploaddocuments", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Canuploaddocuments { get; set; } 

}