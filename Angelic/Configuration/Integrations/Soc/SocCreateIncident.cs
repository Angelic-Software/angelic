using Newtonsoft.Json;
using System.CodeDom.Compiler;

namespace Angelic;


    [GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public class SocCreateIncident
    {
        [JsonProperty("summary", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Summary { get; set; } 

        [JsonProperty("details", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Details { get; set; } 

        [JsonProperty("userName", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? UserName { get; set; } 

        [JsonProperty("isMultiResponder", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsMultiResponder { get; set; } 

        [JsonProperty("targets", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<SocCreateIncidentTarget>? Targets { get; set; } 

    }