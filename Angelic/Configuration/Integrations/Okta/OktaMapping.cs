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
        public string? SiteName { get; set; } 

        [JsonProperty("included_statuses", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? IncludedStatuses { get; set; } 

        [JsonProperty("included_statuses_list", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<ValueLabelIsNewKeyPair>? IncludedStatusesList { get; set; } 

        [JsonProperty("included_statuses_display", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? IncludedStatusesDisplay { get; set; } 

        [JsonProperty("group_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? GroupName { get; set; } 

        [JsonProperty("roleid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Roleid { get; set; } 

        [JsonProperty("applicationid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Applicationid { get; set; } 

        [JsonProperty("applicationid_display", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? ApplicationidDisplay { get; set; } 

        [JsonProperty("filterbyapp", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Filterbyapp { get; set; } 

        [JsonProperty("userroleid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Userroleid { get; set; } 

        [JsonProperty("_warning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Warning { get; set; } 

        [JsonProperty("new_users_only", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? NewUsersOnly { get; set; } 

        [JsonProperty("filters", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<IntegrationFilter>? Filters { get; set; } 

    }