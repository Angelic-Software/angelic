using System.CodeDom.Compiler;
using Newtonsoft.Json;

namespace Angelic.Models.Configuration.Integrations.Custom;

[GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class CustomIntegrationMethod
{
    [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Id { get; set; } 

    [JsonProperty("guid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public Guid? Guid { get; set; } 

    [JsonProperty("intent", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Intent { get; set; } 

    [JsonProperty("integration_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? IntegrationId { get; set; } 

    [JsonProperty("integration_guid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public Guid? IntegrationGuid { get; set; } 

    [JsonProperty("integration_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? IntegrationName { get; set; } 

    [JsonProperty("integration_baseurl", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? IntegrationBaseurl { get; set; } 

    [JsonProperty("name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Name { get; set; } 

    [JsonProperty("full_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? FullName { get; set; } 

    [JsonProperty("resource", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Resource { get; set; } 

    [JsonProperty("path", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Path { get; set; } 

    [JsonProperty("method", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Method { get; set; } 

    [JsonProperty("authorizationtype", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Authorizationtype { get; set; } 

    [JsonProperty("requesttype", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? RequestType { get; set; } 

    [JsonProperty("responsetype", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Responsetype { get; set; } 

    [JsonProperty("requestbody", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Requestbody { get; set; } 

    [JsonProperty("log_retention_policy_days", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? LogRetentionPolicyDays { get; set; } 

    [JsonProperty("uri_params", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<CustomIntegrationMethodValue>? UriParams { get; set; } 

    [JsonProperty("headers", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<CustomIntegrationMethodValue>? Headers { get; set; } 

    [JsonProperty("body_mappings", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<CustomIntegrationMethodValue>? BodyMappings { get; set; } 

    [JsonProperty("output_variables", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<CustomIntegrationMethodValue>? OutputVariables { get; set; } 

    [JsonProperty("_test", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Test { get; set; } 

    [JsonProperty("_test_variables", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<IntegrationRunbookVariable>? TestVariables { get; set; } 

    [JsonProperty("_test_runbook_variables", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<IntegrationRunbookVariable>? TestRunbookVariables { get; set; } 

    [JsonProperty("_test_output_variables", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<IntegrationRunbookVariable>? TestOutputVariables { get; set; } 

    [JsonProperty("_test_result", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public WebhookEvent? TestResult { get; set; } 

    [JsonProperty("_warning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Warning { get; set; } 

    [JsonProperty("_isbatch", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Isbatch { get; set; } 

    [JsonProperty("_is_system_method", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? IsSystemMethod { get; set; } 

    [JsonProperty("_is_cf_method", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? IsCfMethod { get; set; } 

}