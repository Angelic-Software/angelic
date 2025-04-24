using System.CodeDom.Compiler;
using Angelic.KeyPairs;
using Newtonsoft.Json;

namespace Angelic;



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