using System.CodeDom.Compiler;
using Angelic.KeyPairs;
using Newtonsoft.Json;

namespace Angelic;

[GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class RequestType_List
{
    [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Id { get; set; } 

    [JsonProperty("guid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public Guid? Guid { get; set; } 

    [JsonProperty("intent", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Intent { get; set; } 

    [JsonProperty("name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Name { get; set; } 

    [JsonProperty("use", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Use { get; set; } 

    [JsonProperty("sequence", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Sequence { get; set; } 

    [JsonProperty("default_sla", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Default_sla { get; set; } 

    [JsonProperty("default_sla_guid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public Guid? Default_sla_guid { get; set; } 

    [JsonProperty("group_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Group_id { get; set; } 

    [JsonProperty("group_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Group_name { get; set; } 

    [JsonProperty("jira_issue_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Jira_issue_type { get; set; } 

    [JsonProperty("ticket_count", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Ticket_count { get; set; } 

    [JsonProperty("cancreate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Cancreate { get; set; } 

    [JsonProperty("agentscanselect", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Agentscanselect { get; set; } 

    [JsonProperty("itilrequesttype", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Itilrequesttype { get; set; } 

    [JsonProperty("allowattachments", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Allowattachments { get; set; } 

    [JsonProperty("copyattachmentstochild", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Copyattachmentstochild { get; set; } 

    [JsonProperty("copyattachmentstorelated", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Copyattachmentstorelated { get; set; } 

    [JsonProperty("is_sprint", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Is_sprint { get; set; } 

    [JsonProperty("fieldidlist", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<int>? Fieldidlist { get; set; } 

    [JsonProperty("enduserscanselect", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Enduserscanselect { get; set; } 

    [JsonProperty("anonymouscanselect", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Anonymouscanselect { get; set; } 

    [JsonProperty("hasmandatorytechfields", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Hasmandatorytechfields { get; set; } 

    [JsonProperty("hasmandatoryuserfields", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Hasmandatoryuserfields { get; set; } 

    [JsonProperty("project_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Project_type { get; set; } 

    [JsonProperty("kanbanstatuschoice", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<StringIdNameKeyPair>? Kanbanstatuschoice { get; set; } 

    [JsonProperty("kanbanstatuschoice_list", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Kanbanstatuschoice_list { get; set; } 

    [JsonProperty("email_start_tag", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Email_start_tag { get; set; } 

    [JsonProperty("email_end_tag", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Email_end_tag { get; set; } 

    [JsonProperty("default_agent", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Default_agent { get; set; } 

    [JsonProperty("default_agent_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Default_agent_name { get; set; } 

    [JsonProperty("default_team", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Default_team { get; set; } 

    [JsonProperty("workflow_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Workflow_name { get; set; } 

    [JsonProperty("overridewiththefollowingtemplatewhenloggingmanuallyname", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Overridewiththefollowingtemplatewhenloggingmanuallyname { get; set; } 

    [JsonProperty("default_priority", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Default_priority { get; set; } 

    [JsonProperty("visible", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Visible { get; set; } 

}