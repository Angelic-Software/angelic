using System.CodeDom.Compiler;
using Newtonsoft.Json;

namespace Angelic.Models;

    [GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public class RtPermission
    {
        [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Id { get; set; } 

        [JsonProperty("create", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Create { get; set; } 

        [JsonProperty("read", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Read { get; set; } 

        [JsonProperty("edit", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Edit { get; set; } 

    }