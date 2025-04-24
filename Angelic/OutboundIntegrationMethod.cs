using System.CodeDom.Compiler;
using Newtonsoft.Json;

namespace Angelic;

[GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class OutboundIntegrationMethod
{
    [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Id { get; set; } 

    [JsonProperty("guid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public Guid? Guid { get; set; } 

    [JsonProperty("intent", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Intent { get; set; } 

    [JsonProperty("integration_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Integration_id { get; set; } 

    [JsonProperty("integration_guid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public Guid? Integration_guid { get; set; } 

    [JsonProperty("integration_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Integration_name { get; set; } 

    [JsonProperty("integration_baseurl", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Integration_baseurl { get; set; } 

    [JsonProperty("name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Name { get; set; } 

    [JsonProperty("full_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Full_name { get; set; } 

    [JsonProperty("resource", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Resource { get; set; } 

    [JsonProperty("path", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Path { get; set; } 

    [JsonProperty("method", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Method { get; set; } 

    [JsonProperty("authorizationtype", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Authorizationtype { get; set; } 

    [JsonProperty("requesttype", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Requesttype { get; set; } 

    [JsonProperty("responsetype", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Responsetype { get; set; } 

    [JsonProperty("requestbody", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Requestbody { get; set; } 

    [JsonProperty("log_retention_policy_days", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Log_retention_policy_days { get; set; } 

    [JsonProperty("uri_params", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<OutboundIntegrationMethodValue>? Uri_params { get; set; } 

    [JsonProperty("headers", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<OutboundIntegrationMethodValue>? Headers { get; set; } 

    [JsonProperty("body_mappings", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<OutboundIntegrationMethodValue>? Body_mappings { get; set; } 

    [JsonProperty("output_variables", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<OutboundIntegrationMethodValue>? Output_variables { get; set; } 

    [JsonProperty("_test", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? _test { get; set; } 

    [JsonProperty("_test_variables", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<IntegrationRunbookVariable>? _test_variables { get; set; } 

    [JsonProperty("_test_runbook_variables", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<IntegrationRunbookVariable>? _test_runbook_variables { get; set; } 

    [JsonProperty("_test_output_variables", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<IntegrationRunbookVariable>? _test_output_variables { get; set; } 

    [JsonProperty("_test_result", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public WebhookEvent? _test_result { get; set; } 

    [JsonProperty("_warning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? _warning { get; set; } 

    [JsonProperty("_isbatch", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? _isbatch { get; set; } 

    [JsonProperty("_is_system_method", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? _is_system_method { get; set; } 

    [JsonProperty("_is_cf_method", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? _is_cf_method { get; set; } 

}