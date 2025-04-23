using System.CodeDom.Compiler;
using Angelic.KeyPairs;
using Newtonsoft.Json;

namespace Angelic;

    [GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public class JamfDetails
    {
        [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Id { get; set; } 

        [JsonProperty("url", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Url { get; set; } 

        [JsonProperty("username", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Username { get; set; } 

        [JsonProperty("new_password", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? New_password { get; set; } 

        [JsonProperty("new_integration_method", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? New_integration_method { get; set; } 

        [JsonProperty("instancetype", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Instancetype { get; set; } 

        [JsonProperty("devicetypes", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Devicetypes { get; set; } 

        [JsonProperty("device_types", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<ValueLabelIsNewKeyPair>? Device_types { get; set; } 

        [JsonProperty("defaultsite", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Defaultsite { get; set; } 

        [JsonProperty("defaultsite_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Defaultsite_name { get; set; } 

        [JsonProperty("site_links", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<ExternalLink_List>? Site_links { get; set; } 

        [JsonProperty("fieldmappings", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<IntegrationFieldMapping>? Fieldmappings { get; set; } 

        [JsonProperty("sitematchtype", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Sitematchtype { get; set; } 

        [JsonProperty("computerassettype", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Computerassettype { get; set; } 

        [JsonProperty("computerassettype_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Computerassettype_name { get; set; } 

        [JsonProperty("mobileassettype", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Mobileassettype { get; set; } 

        [JsonProperty("mobileassettype_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Mobileassettype_name { get; set; } 

        [JsonProperty("assetimportidentifier", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Assetimportidentifier { get; set; } 

        [JsonProperty("assetmatchingfield_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Assetmatchingfield_name { get; set; } 

        [JsonProperty("halointegrator", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Halointegrator { get; set; } 

        [JsonProperty("halointegratorerror", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Halointegratorerror { get; set; } 

        [JsonProperty("halointegratorlastsync", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? Halointegratorlastsync { get; set; } 

        [JsonProperty("dontupdateassettype", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Dontupdateassettype { get; set; } 

        [JsonProperty("_warning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? _warning { get; set; } 

        [JsonProperty("dont_create_new_devices", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Dont_create_new_devices { get; set; } 

    }

    [GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public class JiraDetails
    {
        [JsonProperty("guid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public Guid? Guid { get; set; } 

        [JsonProperty("intent", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Intent { get; set; } 

        [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Id { get; set; } 

        [JsonProperty("name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Name { get; set; } 

        [JsonProperty("instance_url", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Instance_url { get; set; } 

        [JsonProperty("username", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Username { get; set; } 

        [JsonProperty("newmethod", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Newmethod { get; set; } 

        [JsonProperty("new_password", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? New_password { get; set; } 

        [JsonProperty("sync_components", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Sync_components { get; set; } 

        [JsonProperty("issue_body", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Issue_body { get; set; } 

        [JsonProperty("defaulttickettype", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Defaulttickettype { get; set; } 

        [JsonProperty("defaulttickettype_guid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public Guid? Defaulttickettype_guid { get; set; } 

        [JsonProperty("defaulttickettype_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Defaulttickettype_name { get; set; } 

        [JsonProperty("defaultuser", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Defaultuser { get; set; } 

        [JsonProperty("defaultuser_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Defaultuser_name { get; set; } 

        [JsonProperty("visibletoendusers", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Visibletoendusers { get; set; } 

        [JsonProperty("primary_update_status", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Primary_update_status { get; set; } 

        [JsonProperty("relation_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Relation_type { get; set; } 

        [JsonProperty("type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Type { get; set; } 

        [JsonProperty("issuetype", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Issuetype { get; set; } 

        [JsonProperty("defaultsendattachments", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Defaultsendattachments { get; set; } 

        [JsonProperty("default_reporter", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Default_reporter { get; set; } 

        [JsonProperty("status_mappings", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<IntegrationFieldMapping>? Status_mappings { get; set; } 

        [JsonProperty("tickettype_mappings", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<JiraMappings>? Tickettype_mappings { get; set; } 

        [JsonProperty("jirafield_mappings", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<IntegrationFieldMapping>? Jirafield_mappings { get; set; } 

        [JsonProperty("comment_contains", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Comment_contains { get; set; } 

        [JsonProperty("remove_comment_tag", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Remove_comment_tag { get; set; } 

        [JsonProperty("priority_mappings", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<IntegrationFieldMapping>? Priority_mappings { get; set; } 

        [JsonProperty("_warning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? _warning { get; set; } 

    }

    [GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public class JiraMappings
    {
        [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Id { get; set; } 

        [JsonProperty("rtid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Rtid { get; set; } 

        [JsonProperty("rtid_guid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public Guid? Rtid_guid { get; set; } 

        [JsonProperty("name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Name { get; set; } 

        [JsonProperty("jira_issue_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Jira_issue_type { get; set; } 

        [JsonProperty("jira_category1", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Jira_category1 { get; set; } 

        [JsonProperty("jira_category2", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Jira_category2 { get; set; } 

        [JsonProperty("jira_category3", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Jira_category3 { get; set; } 

        [JsonProperty("jira_category4", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Jira_category4 { get; set; } 

        [JsonProperty("detailsid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Detailsid { get; set; } 

        [JsonProperty("_warning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? _warning { get; set; } 

    }

    [GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public class Journey
    {
        [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Id { get; set; } 

        [JsonProperty("unum", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Unum { get; set; } 

        [JsonProperty("faultid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Faultid { get; set; } 

        [JsonProperty("actionnumber", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Actionnumber { get; set; } 

        [JsonProperty("description", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Description { get; set; } 

        [JsonProperty("startdate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? Startdate { get; set; } 

        [JsonProperty("enddate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? Enddate { get; set; } 

        [JsonProperty("startodometer", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Startodometer { get; set; } 

        [JsonProperty("endodometer", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Endodometer { get; set; } 

        [JsonProperty("vehicle", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Vehicle { get; set; } 

        [JsonProperty("startgps", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Startgps { get; set; } 

        [JsonProperty("endgps", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Endgps { get; set; } 

        [JsonProperty("datereimbursed", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? Datereimbursed { get; set; } 

        [JsonProperty("dateinvoicedmileage", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? Dateinvoicedmileage { get; set; } 

        [JsonProperty("dateinvoicedtraveltime", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? Dateinvoicedtraveltime { get; set; } 

        [JsonProperty("ihidmileage", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Ihidmileage { get; set; } 

        [JsonProperty("ihidtraveltime", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Ihidtraveltime { get; set; } 

        [JsonProperty("invoiceable", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Invoiceable { get; set; } 

        [JsonProperty("type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Type { get; set; } 

        [JsonProperty("_warning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? _warning { get; set; } 

    }