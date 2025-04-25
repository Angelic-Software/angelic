using System.CodeDom.Compiler;
using Angelic.Area;
using Angelic.Configuration.TicketType;
using Newtonsoft.Json;

namespace Angelic;

    [GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public class FaqListHead
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
        public bool? IsGroup { get; set; } 

        [JsonProperty("group_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? GroupId { get; set; } 

        [JsonProperty("group_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? GroupName { get; set; } 

        [JsonProperty("full_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? FullName { get; set; } 

        [JsonProperty("article_count", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? ArticleCount { get; set; } 

        [JsonProperty("type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Type { get; set; } 

        [JsonProperty("fields", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<TicketTypeField>? Fields { get; set; } 

        [JsonProperty("grandparent_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? GrandparentName { get; set; } 

        [JsonProperty("greatgrandparent_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? GreatgrandparentName { get; set; } 

        [JsonProperty("greatgreatgrandparent_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? GreatgreatgrandparentName { get; set; } 

        [JsonProperty("greatgreatgreatgrandparent_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? GreatgreatgreatgrandparentName { get; set; } 

        [JsonProperty("fullgroup_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? FullgroupName { get; set; } 

        [JsonProperty("roles", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<UserRoles>? Roles { get; set; } 

        [JsonProperty("draft_roles", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<UserRoles>? DraftRoles { get; set; } 

        [JsonProperty("new_external_link", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ExternalLinkList? NewExternalLink { get; set; } 

        [JsonProperty("_match_thirdparty_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? MatchThirdpartyId { get; set; } 

        [JsonProperty("_match_integration_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? MatchIntegrationId { get; set; } 

        [JsonProperty("_match_integration_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? MatchIntegrationName { get; set; } 

        [JsonProperty("_isimport", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Isimport { get; set; } 

        [JsonProperty("_importtype", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Importtype { get; set; } 

        [JsonProperty("import_details_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? ImportDetailsId { get; set; } 

        [JsonProperty("third_party_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? ThirdPartyId { get; set; } 

        [JsonProperty("translations", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<LanguagePackTranslationsCustom>? Translations { get; set; } 

        [JsonProperty("access_control", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<AccessControl>? AccessControl { get; set; } 

        [JsonProperty("access_control_level", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? AccessControlLevel { get; set; } 

        [JsonProperty("clients", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<AreaList>? Clients { get; set; } 

        [JsonProperty("dontshowonportal", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Dontshowonportal { get; set; } 

        [JsonProperty("geo_restrictions", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<GeoLocationRestriction>? GeoRestrictions { get; set; } 

    }