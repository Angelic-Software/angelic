using System.CodeDom.Compiler;
using Newtonsoft.Json;

namespace Angelic;

    [GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public class HaloNews
    {
        [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Id { get; set; } 

        [JsonProperty("name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Name { get; set; } 

        [JsonProperty("title", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Title { get; set; } 

        [JsonProperty("details", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Details { get; set; } 

        [JsonProperty("css", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        [System.ComponentModel.DataAnnotations.StringLength(4000)]
        public string? Css { get; set; } 

        [JsonProperty("use", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Use { get; set; } 

        [JsonProperty("button_label", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Button_label { get; set; } 

        [JsonProperty("button_url", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Button_url { get; set; } 

        [JsonProperty("height", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Height { get; set; } 

        [JsonProperty("theme_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Theme_name { get; set; } 

        [JsonProperty("theme_base", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Theme_base { get; set; } 

        [JsonProperty("theme_css", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        [System.ComponentModel.DataAnnotations.StringLength(4000)]
        public string? Theme_css { get; set; } 

        [JsonProperty("theme_colour_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Theme_colour_type { get; set; } 

        [JsonProperty("theme_colour", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Theme_colour { get; set; } 

        [JsonProperty("one_version", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? One_version { get; set; } 

        [JsonProperty("one_patch", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? One_patch { get; set; } 

        [JsonProperty("min_version", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Min_version { get; set; } 

        [JsonProperty("min_version_seq", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Min_version_seq { get; set; } 

        [JsonProperty("max_version", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Max_version { get; set; } 

        [JsonProperty("max_version_seq", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Max_version_seq { get; set; } 

        [JsonProperty("one_dbid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? One_dbid { get; set; } 

        [JsonProperty("one_product", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? One_product { get; set; } 

        [JsonProperty("db_location", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Db_location { get; set; } 

        [JsonProperty("version_group", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Version_group { get; set; } 

        [JsonProperty("start_date", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? Start_date { get; set; } 

        [JsonProperty("end_date", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? End_date { get; set; } 

        [JsonProperty("agent_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Agent_type { get; set; } 

        [JsonProperty("customer_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Customer_type { get; set; } 

        [JsonProperty("enabled_module", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Enabled_module { get; set; } 

        [JsonProperty("read", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Read { get; set; } 

        [JsonProperty("_warning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? _warning { get; set; } 

    }