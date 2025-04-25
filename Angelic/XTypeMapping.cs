using System.CodeDom.Compiler;
using Angelic.Configuration.Integrations;
using Angelic.KeyPairs;
using Newtonsoft.Json;

namespace Angelic;

[GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public class XTypeMapping
    {
        [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Id { get; set; } 

        [JsonProperty("typeid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Typeid { get; set; } 

        [JsonProperty("name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Name { get; set; } 

        [JsonProperty("value", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Value { get; set; } 

        [JsonProperty("thirdpartyname", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Thirdpartyname { get; set; } 

        [JsonProperty("msid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Msid { get; set; } 

        [JsonProperty("isbladehost", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Isbladehost { get; set; } 

        [JsonProperty("tags", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Tags { get; set; } 

        [JsonProperty("category", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Category { get; set; } 

        [JsonProperty("includesoftware", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Includesoftware { get; set; } 

        [JsonProperty("field_mappings", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<IntegrationFieldMapping>? FieldMappings { get; set; } 

        [JsonProperty("field_mapping_count", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? FieldMappingCount { get; set; } 

        [JsonProperty("sub_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? SubType { get; set; } 

        [JsonProperty("tag_list", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? TagList { get; set; } 

        [JsonProperty("tag_list_pairs", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<ValueLabelIsNewKeyPair>? TagListPairs { get; set; } 

        [JsonProperty("seq", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Seq { get; set; } 

        [JsonProperty("partial_match", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? PartialMatch { get; set; } 

        [JsonProperty("detailsid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Detailsid { get; set; } 

        [JsonProperty("userules", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Userules { get; set; } 

        [JsonProperty("criteria", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<XTypeMappingCriteria>? Criteria { get; set; } 

        [JsonProperty("rule_count", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? RuleCount { get; set; } 

        [JsonProperty("_warning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Warning { get; set; } 

    }