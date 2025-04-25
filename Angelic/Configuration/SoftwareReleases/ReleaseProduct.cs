using System.CodeDom.Compiler;
using Angelic.Configuration.Integrations;
using Angelic.Configuration.Integrations.Jira;
using Angelic.Configuration.Integrations.Microsoft.Azure.AzureDevOps;
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
    public DevOpsProject? DevOpsProject { get; set; } 

    [JsonProperty("devops_otherfield_mappings", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<IntegrationFieldMapping>? DevOpsOtherfieldMappings { get; set; } 

    [JsonProperty("devops_details_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? DevOpsDetailsId { get; set; } 

    [JsonProperty("devops_details_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? DevOpsDetailsName { get; set; } 

    [JsonProperty("devops_instance", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public AzureDevOpsDetails? DevOpsInstance { get; set; } 

    [JsonProperty("show_devops_mappings", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? ShowDevOpsMappings { get; set; } 

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
    public ICollection<IntegrationFieldMapping>? JiraFieldMappings { get; set; } 

    [JsonProperty("jira_project", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ValueLabelIsNewKeyPair? JiraProject { get; set; } 

    [JsonProperty("devops_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? DevOpsId { get; set; } 

    [JsonProperty("devops_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? DevOpsName { get; set; } 

    [JsonProperty("devops_url", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? DevOpsUrl { get; set; } 

    [JsonProperty("default_pipeline", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? DefaultPipeline { get; set; } 

    [JsonProperty("default_pipeline_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? DefaultPipelineName { get; set; } 

    [JsonProperty("_warning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Warning { get; set; } 

}