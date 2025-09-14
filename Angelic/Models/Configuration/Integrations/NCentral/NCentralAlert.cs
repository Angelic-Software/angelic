using System.CodeDom.Compiler;
using Newtonsoft.Json;

namespace Angelic.Models.Configuration.Integrations.NCentral;


    [GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public record NCentralAlert
    {
        [JsonProperty("action", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Action { get; set; } 

        [JsonProperty("title", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Title { get; set; } 

        [JsonProperty("details", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Details { get; set; } 

        [JsonProperty("ncentralTicketId", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? NCentralTicketId { get; set; } 

        [JsonProperty("psaTicketNumber", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? PsaTicketNumber { get; set; } 

        [JsonProperty("customTags", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public NCentralCustomTags? CustomTags { get; set; } 

    }