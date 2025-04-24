using Angelic.KeyPairs;
using Newtonsoft.Json;

namespace Angelic;


    public class OktaMapping
    {
        [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Id { get; set; } 

        [JsonProperty("siteid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Siteid { get; set; } 

        [JsonProperty("site_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Site_name { get; set; } 

        [JsonProperty("included_statuses", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Included_statuses { get; set; } 

        [JsonProperty("included_statuses_list", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<ValueLabelIsNewKeyPair>? Included_statuses_list { get; set; } 

        [JsonProperty("included_statuses_display", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Included_statuses_display { get; set; } 

        [JsonProperty("group_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Group_name { get; set; } 

        [JsonProperty("roleid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Roleid { get; set; } 

        [JsonProperty("applicationid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Applicationid { get; set; } 

        [JsonProperty("applicationid_display", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Applicationid_display { get; set; } 

        [JsonProperty("filterbyapp", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Filterbyapp { get; set; } 

        [JsonProperty("userroleid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Userroleid { get; set; } 

        [JsonProperty("_warning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? _warning { get; set; } 

        [JsonProperty("new_users_only", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? New_users_only { get; set; } 

        [JsonProperty("filters", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<IntegrationFilter>? Filters { get; set; } 

    }