using System.CodeDom.Compiler;
using Angelic.Models.Configuration.TeamsAndAgents.Agents;
using Angelic.Models.Configuration.TeamsAndAgents.Agents.AgentNotifications;
using Angelic.Models.KeyPairs;
using Newtonsoft.Json;

namespace Angelic.Models.Configuration.TeamsAndAgents;

[GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
public record Roles
{
    [JsonProperty("intent", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Intent { get; set; } 

    [JsonProperty("chargerates", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<Restriction>? ChargeRates { get; set; } 

    [JsonProperty("id_int", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? IdInt { get; set; } 

    [JsonProperty("notes", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Notes { get; set; } 

    [JsonProperty("teams", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<AgentSection>? Teams { get; set; } 

    [JsonProperty("departments", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<AgentDepartment>? Departments { get; set; } 

    [JsonProperty("clients", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<AgentAreaRestriction>? Clients { get; set; } 

    [JsonProperty("tickettypes", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<AgentTicketType>? TicketTypes { get; set; } 

    [JsonProperty("assetfields", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<AgentField>? AssetFields { get; set; } 

    [JsonProperty("unamecustomfields", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<AgentCustom>? UnameCustomFields { get; set; } 

    [JsonProperty("unameappointmenttypes", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<AgentAppointment>? UnameAppointmentTypes { get; set; } 

    [JsonProperty("notifications", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<AgentNotification>? Notifications { get; set; } 

    [JsonProperty("claims", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<NhdClaim>? Claims { get; set; } 

    [JsonProperty("custombuttons", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<AgentButton>? CustomButtons { get; set; } 

    [JsonProperty("_warning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Warning { get; set; } 

    [JsonProperty("assettypes", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<AgentAssetType>? AssetTypes { get; set; } 

    [JsonProperty("Oo_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? OoName { get; set; } 

    [JsonProperty("uname_usercustomfields", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<AgentCustom>? UnameUserCustomFields { get; set; } 

    [JsonProperty("access_control", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<AccessControl>? AccessControl { get; set; } 

    [JsonProperty("access_control_level", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? AccessControlLevel { get; set; } 

    [JsonProperty("ac_tickettypes", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<AccessControl>? AcTicketTypes { get; set; } 

    [JsonProperty("ac_approvals", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<AccessControl>? AcApprovals { get; set; } 

    [JsonProperty("ac_rules", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<AccessControl>? AcRules { get; set; } 

    [JsonProperty("ac_cannedtext", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<AccessControl>? AcCannedText { get; set; } 

    [JsonProperty("ac_customfields", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<AccessControl>? AcCustomFields { get; set; } 

    [JsonProperty("ac_customtables", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<AccessControl>? AcCustomTables { get; set; } 

    [JsonProperty("ac_dashboards", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<AccessControl>? AcDashboards { get; set; } 

    [JsonProperty("ac_workflows", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<AccessControl>? AcWorkflows { get; set; } 

    [JsonProperty("ac_roles", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<AccessControl>? AcRoles { get; set; } 

    [JsonProperty("ac_slas", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<AccessControl>? AcSlas { get; set; } 

    [JsonProperty("ac_templates", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<AccessControl>? AcTemplates { get; set; } 

    [JsonProperty("ac_outcomes", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<AccessControl>? AcOutcomes { get; set; } 

    [JsonProperty("ac_workdays", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<AccessControl>? AcWorkdays { get; set; } 

    [JsonProperty("ac_emailtemplates", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<AccessControl>? AcEmailTemplates { get; set; } 

    [JsonProperty("ac_messagegroups", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<AccessControl>? AcMessageGroups { get; set; } 

    [JsonProperty("ac_reportgroups", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<AccessControl>? AcReportGroups { get; set; } 

    [JsonProperty("ac_fieldgroups", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<AccessControl>? AcFieldGroups { get; set; } 

    [JsonProperty("ac_languagepacks", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<AccessControl>? AcLanguagePacks { get; set; } 

    [JsonProperty("ac_itemgroups", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<AccessControl>? AcItemGroups { get; set; } 

    [JsonProperty("ac_suppliers", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<AccessControl>? AcSuppliers { get; set; } 

    [JsonProperty("ac_suppliercontracts", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<AccessControl>? AcSupplierContracts { get; set; } 

    [JsonProperty("is_integration", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? IsIntegration { get; set; } 

    [JsonProperty("ac_assettypes", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<AccessControl>? AcAssetTypes { get; set; } 

    [JsonProperty("ac_assetgroups", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<AccessControl>? AcAssetGroups { get; set; } 

    [JsonProperty("ac_servicecategories", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<AccessControl>? AcServiceCategories { get; set; } 

    [JsonProperty("ac_services", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<AccessControl>? AcServices { get; set; } 

    [JsonProperty("ac_chatprofiles", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<AccessControl>? AcChatProfiles { get; set; } 

    [JsonProperty("ac_faqlists", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<AccessControl>? AcFaqLists { get; set; } 

    [JsonProperty("ac_devices", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<AccessControl>? AcDevices { get; set; } 

    [JsonProperty("sites", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<AgentSite>? Sites { get; set; } 

    [JsonProperty("ac_databaselookups", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<AccessControl>? AcDatabaseLookups { get; set; } 

    [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Id { get; set; } 

    [JsonProperty("name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Name { get; set; } 

    [JsonProperty("normalizedName", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? NormalizedName { get; set; } 

    [JsonProperty("concurrencyStamp", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? ConcurrencyStamp { get; set; } 

}