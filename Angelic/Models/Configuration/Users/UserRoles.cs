using System.CodeDom.Compiler;
using Angelic.Models.Configuration.TeamsAndAgents.Agents;
using Angelic.Models.Configuration.TeamsAndAgents.Agents.AgentNotifications;
using Newtonsoft.Json;

namespace Angelic.Models.Configuration.Users;

[GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
public record UserRoles
{
    [JsonProperty("guid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public Guid? Guid { get; set; } 

    [JsonProperty("intent", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Intent { get; set; } 

    [JsonProperty("isimportantcontact2", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? IsImportantContact2 { get; set; } 

    [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Id { get; set; } 

    [JsonProperty("showmeonly", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? ShowMeOnly { get; set; } 

    [JsonProperty("ischangeapprover2", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? IsChangeApprover2 { get; set; } 

    [JsonProperty("ispoapprover", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? IsPoApprover { get; set; } 

    [JsonProperty("web_access_level", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? WebAccessLevel { get; set; } 

    [JsonProperty("canadd", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? CanAdd { get; set; } 

    [JsonProperty("canviewopps", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? CanViewOpps { get; set; } 

    [JsonProperty("allowviewsitedocs", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? AllowViewSiteDocs { get; set; } 

    [JsonProperty("allowviewclientdocs", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? AllowViewClientDocs { get; set; } 

    [JsonProperty("canviewcontracts", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? CanViewContracts { get; set; } 

    [JsonProperty("canaccesscatalog", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? CanAccessCatalog { get; set; } 

    [JsonProperty("cataloglevel", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? CatalogLevel { get; set; } 

    [JsonProperty("canaccessinvoices", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? CanAccessInvoices { get; set; } 

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
    public bool? DontAckEmails2 { get; set; } 

    [JsonProperty("departments", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<UserDepartment>? Departments { get; set; } 

    [JsonProperty("notifications", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<AgentNotification>? Notifications { get; set; } 

    [JsonProperty("canuploaddocuments", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? CanUploadDocuments { get; set; } 

}