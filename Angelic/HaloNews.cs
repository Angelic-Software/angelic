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
        public string? ButtonLabel { get; set; } 

        [JsonProperty("button_url", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? ButtonUrl { get; set; } 

        [JsonProperty("height", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Height { get; set; } 

        [JsonProperty("theme_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? ThemeName { get; set; } 

        [JsonProperty("theme_base", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? ThemeBase { get; set; } 

        [JsonProperty("theme_css", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        [System.ComponentModel.DataAnnotations.StringLength(4000)]
        public string? ThemeCss { get; set; } 

        [JsonProperty("theme_colour_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? ThemeColourType { get; set; } 

        [JsonProperty("theme_colour", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? ThemeColour { get; set; } 

        [JsonProperty("one_version", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? OneVersion { get; set; } 

        [JsonProperty("one_patch", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? OnePatch { get; set; } 

        [JsonProperty("min_version", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? MinVersion { get; set; } 

        [JsonProperty("min_version_seq", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? MinVersionSeq { get; set; } 

        [JsonProperty("max_version", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? MaxVersion { get; set; } 

        [JsonProperty("max_version_seq", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? MaxVersionSeq { get; set; } 

        [JsonProperty("one_dbid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? OneDbid { get; set; } 

        [JsonProperty("one_product", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? OneProduct { get; set; } 

        [JsonProperty("db_location", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? DbLocation { get; set; } 

        [JsonProperty("version_group", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? VersionGroup { get; set; } 

        [JsonProperty("start_date", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? StartDate { get; set; } 

        [JsonProperty("end_date", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? EndDate { get; set; } 

        [JsonProperty("agent_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? AgentType { get; set; } 

        [JsonProperty("customer_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? CustomerType { get; set; } 

        [JsonProperty("enabled_module", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? EnabledModule { get; set; } 

        [JsonProperty("read", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Read { get; set; } 

        [JsonProperty("_warning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Warning { get; set; } 

    }