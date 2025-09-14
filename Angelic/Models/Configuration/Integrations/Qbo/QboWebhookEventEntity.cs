using System.CodeDom.Compiler;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;

namespace Angelic.Models.Configuration.Integrations.Qbo;

    [GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public record QboWebhookEventEntity
    {
        [JsonProperty("name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Name { get; set; } 

        [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Id { get; set; } 

        [JsonProperty("operation", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Operation { get; set; } 

        [JsonProperty("lastUpdated", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? LastUpdated { get; set; } 

        [JsonProperty("realmId", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? RealmId { get; set; } 

        [JsonProperty("resourceObject", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public object? ResourceObject { get; set; } 

        [JsonProperty("eventTypeNum", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        [Range(0, 3)]
        public int? EventTypeNum { get; set; } 

        [JsonProperty("eventCategoryNum", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        [Range(0, 7)]
        public int? EventCategoryNum { get; set; } 

    }