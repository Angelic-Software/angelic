using System.CodeDom.Compiler;
using Newtonsoft.Json;

namespace Angelic;

    [GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public class FAQListHead
    {
        [JsonProperty("guid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public Guid? Guid { get; set; } 

        [JsonProperty("intent", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Intent { get; set; } 

        [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Id { get; set; } 

        [JsonProperty("name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Name { get; set; } 

        [JsonProperty("showforall", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Showforall { get; set; } 

        [JsonProperty("showforallagents", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Showforallagents { get; set; } 

        [JsonProperty("level", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Level { get; set; } 

        [JsonProperty("is_group", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Is_group { get; set; } 

        [JsonProperty("group_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Group_id { get; set; } 

        [JsonProperty("group_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Group_name { get; set; } 

        [JsonProperty("full_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Full_name { get; set; } 

        [JsonProperty("article_count", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Article_count { get; set; } 

        [JsonProperty("type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Type { get; set; } 

        [JsonProperty("fields", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<RequestTypeField>? Fields { get; set; } 

        [JsonProperty("grandparent_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Grandparent_name { get; set; } 

        [JsonProperty("greatgrandparent_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Greatgrandparent_name { get; set; } 

        [JsonProperty("greatgreatgrandparent_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Greatgreatgrandparent_name { get; set; } 

        [JsonProperty("greatgreatgreatgrandparent_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Greatgreatgreatgrandparent_name { get; set; } 

        [JsonProperty("fullgroup_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Fullgroup_name { get; set; } 

        [JsonProperty("roles", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<UserRoles>? Roles { get; set; } 

        [JsonProperty("draft_roles", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<UserRoles>? Draft_roles { get; set; } 

        [JsonProperty("new_external_link", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ExternalLink_List? New_external_link { get; set; } 

        [JsonProperty("_match_thirdparty_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? _match_thirdparty_id { get; set; } 

        [JsonProperty("_match_integration_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? _match_integration_id { get; set; } 

        [JsonProperty("_match_integration_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? _match_integration_name { get; set; } 

        [JsonProperty("_isimport", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? _isimport { get; set; } 

        [JsonProperty("_importtype", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? _importtype { get; set; } 

        [JsonProperty("import_details_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Import_details_id { get; set; } 

        [JsonProperty("third_party_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Third_party_id { get; set; } 

        [JsonProperty("translations", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<LanguagePackTranslationsCustom>? Translations { get; set; } 

        [JsonProperty("access_control", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<AccessControl>? Access_control { get; set; } 

        [JsonProperty("access_control_level", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Access_control_level { get; set; } 

        [JsonProperty("clients", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<AreaList>? Clients { get; set; } 

        [JsonProperty("dontshowonportal", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Dontshowonportal { get; set; } 

        [JsonProperty("geo_restrictions", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<GeoLocationRestriction>? Geo_restrictions { get; set; } 

    }