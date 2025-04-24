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
    public string? ThirdPartyId { get; set; } 

    [JsonProperty("release_count", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? ReleaseCount { get; set; } 

    [JsonProperty("logo", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Logo { get; set; } 

    [JsonProperty("new_icon", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? NewIcon { get; set; } 

    [JsonProperty("release_emails", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<ReleaseProductEmail>? ReleaseEmails { get; set; } 

    [JsonProperty("components", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<ReleaseComponent>? Components { get; set; } 

    [JsonProperty("third_party_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? ThirdPartyName { get; set; } 

    [JsonProperty("third_party_url", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? ThirdPartyUrl { get; set; } 

    [JsonProperty("devops_project", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public DevOpsProject? DevopsProject { get; set; } 

    [JsonProperty("devops_otherfield_mappings", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<IntegrationFieldMapping>? DevopsOtherfieldMappings { get; set; } 

    [JsonProperty("devops_details_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? DevopsDetailsId { get; set; } 

    [JsonProperty("devops_details_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? DevopsDetailsName { get; set; } 

    [JsonProperty("devops_instance", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public AzureDevOpsDetails? DevopsInstance { get; set; } 

    [JsonProperty("show_devops_mappings", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? ShowDevopsMappings { get; set; } 

    [JsonProperty("github_repo", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? GithubRepo { get; set; } 

    [JsonProperty("branches", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<ReleaseBranch>? Branches { get; set; } 

    [JsonProperty("jira_details_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? JiraDetailsId { get; set; } 

    [JsonProperty("jira_details_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? JiraDetailsName { get; set; } 

    [JsonProperty("jira_instance", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public JiraDetails? JiraInstance { get; set; } 

    [JsonProperty("jirafield_mappings", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<IntegrationFieldMapping>? JirafieldMappings { get; set; } 

    [JsonProperty("jira_project", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ValueLabelIsNewKeyPair? JiraProject { get; set; } 

    [JsonProperty("devops_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? DevopsId { get; set; } 

    [JsonProperty("devops_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? DevopsName { get; set; } 

    [JsonProperty("devops_url", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? DevopsUrl { get; set; } 

    [JsonProperty("default_pipeline", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? DefaultPipeline { get; set; } 

    [JsonProperty("default_pipeline_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? DefaultPipelineName { get; set; } 

    [JsonProperty("_warning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Warning { get; set; } 

}