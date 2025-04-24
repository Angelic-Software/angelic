using System.CodeDom.Compiler;
using Newtonsoft.Json;

namespace Angelic;

[GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class EmailAddress
{
    [JsonProperty("name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Name { get; set; } 

    [JsonProperty("address", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Address { get; set; } 

    [JsonProperty("routingType", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? RoutingType { get; set; } 

    [JsonProperty("mailboxType", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public MailboxType? MailboxType { get; set; } 

    [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ItemId? Id { get; set; } 

}