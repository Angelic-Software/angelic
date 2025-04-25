using System.CodeDom.Compiler;
using Newtonsoft.Json;

namespace Angelic.Configuration.Integrations.Jira;

[GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class JiraMappings
{
    [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Id { get; set; } 

    [JsonProperty("rtid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? RtId { get; set; } 

    [JsonProperty("rtid_guid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public Guid? RtIdGuid { get; set; } 
    
    [JsonProperty("name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Name { get; set; } 
    
    [JsonProperty("jira_issue_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? JiraIssueType { get; set; } 
    
    [JsonProperty("jira_category1", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? JiraCategory1 { get; set; } 
    
    [JsonProperty("jira_category2", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? JiraCategory2 { get; set; } 
    
    [JsonProperty("jira_category3", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? JiraCategory3 { get; set; } 
    
    [JsonProperty("jira_category4", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? JiraCategory4 { get; set; } 
    
    [JsonProperty("detailsid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? DetailsId { get; set; } 
    
    [JsonProperty("_warning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Warning { get; set; } 

}
