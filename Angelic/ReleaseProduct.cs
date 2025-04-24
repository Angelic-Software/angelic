using System.CodeDom.Compiler;
using Angelic.KeyPairs;
using Newtonsoft.Json;

namespace Angelic;

[GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class ReleaseProduct
{
    [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Id { get; set; } 

    [JsonProperty("name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Name { get; set; } 

    [JsonProperty("third_party_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Third_party_id { get; set; } 

    [JsonProperty("release_count", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Release_count { get; set; } 

    [JsonProperty("logo", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Logo { get; set; } 

    [JsonProperty("new_icon", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? New_icon { get; set; } 

    [JsonProperty("release_emails", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<ReleaseProductEmail>? Release_emails { get; set; } 

    [JsonProperty("components", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<ReleaseComponent>? Components { get; set; } 

    [JsonProperty("third_party_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Third_party_name { get; set; } 

    [JsonProperty("third_party_url", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Third_party_url { get; set; } 

    [JsonProperty("devops_project", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public DevOpsProject? Devops_project { get; set; } 

    [JsonProperty("devops_otherfield_mappings", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<IntegrationFieldMapping>? Devops_otherfield_mappings { get; set; } 

    [JsonProperty("devops_details_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Devops_details_id { get; set; } 

    [JsonProperty("devops_details_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Devops_details_name { get; set; } 

    [JsonProperty("devops_instance", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public AzureDevOpsDetails? Devops_instance { get; set; } 

    [JsonProperty("show_devops_mappings", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Show_devops_mappings { get; set; } 

    [JsonProperty("github_repo", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Github_repo { get; set; } 

    [JsonProperty("branches", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<ReleaseBranch>? Branches { get; set; } 

    [JsonProperty("jira_details_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Jira_details_id { get; set; } 

    [JsonProperty("jira_details_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Jira_details_name { get; set; } 

    [JsonProperty("jira_instance", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public JiraDetails? Jira_instance { get; set; } 

    [JsonProperty("jirafield_mappings", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<IntegrationFieldMapping>? Jirafield_mappings { get; set; } 

    [JsonProperty("jira_project", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ValueLabelIsNewKeyPair? Jira_project { get; set; } 

    [JsonProperty("devops_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Devops_id { get; set; } 

    [JsonProperty("devops_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Devops_name { get; set; } 

    [JsonProperty("devops_url", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Devops_url { get; set; } 

    [JsonProperty("default_pipeline", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Default_pipeline { get; set; } 

    [JsonProperty("default_pipeline_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Default_pipeline_name { get; set; } 

    [JsonProperty("_warning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? _warning { get; set; } 

}