using System.CodeDom.Compiler;
using Angelic.Dtos;
using Angelic.KeyPairs;
using Newtonsoft.Json;

namespace Angelic;





    [GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public class LDAPConnection
    {
        [JsonProperty("guid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public Guid? Guid { get; set; } 

        [JsonProperty("intent", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Intent { get; set; } 

        [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Id { get; set; } 

        [JsonProperty("name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Name { get; set; } 

        [JsonProperty("connection_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Connection_type { get; set; } 

        [JsonProperty("hostname", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Hostname { get; set; } 

        [JsonProperty("domainname", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Domainname { get; set; } 

        [JsonProperty("authentication_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Authentication_type { get; set; } 

        [JsonProperty("username", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Username { get; set; } 

        [JsonProperty("integrator_password", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Integrator_password { get; set; } 

        [JsonProperty("basedn", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Basedn { get; set; } 

        [JsonProperty("synccontacts", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Synccontacts { get; set; } 

        [JsonProperty("external", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? External { get; set; } 

        [JsonProperty("phppassword", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Phppassword { get; set; } 

        [JsonProperty("pagesize", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Pagesize { get; set; } 

        [JsonProperty("port", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Port { get; set; } 

        [JsonProperty("use_ssl", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Use_ssl { get; set; } 

        [JsonProperty("mappings_user", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<LDAPName>? Mappings_user { get; set; } 

        [JsonProperty("mappings_agent", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<LDAPName>? Mappings_agent { get; set; } 

        [JsonProperty("ldap_strings", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<LDAPString>? Ldap_strings { get; set; } 

        [JsonProperty("useadauthentication", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Useadauthentication { get; set; } 

        [JsonProperty("_is_test", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? _is_test { get; set; } 

        [JsonProperty("_connection_success", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? _connection_success { get; set; } 

        [JsonProperty("_connection_message", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? _connection_message { get; set; } 

        [JsonProperty("_get_mappings", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? _get_mappings { get; set; } 

        [JsonProperty("_containers", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<LDAPString>? _containers { get; set; } 

        [JsonProperty("_containerfilter", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? _containerfilter { get; set; } 

        [JsonProperty("_get_users", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? _get_users { get; set; } 

        [JsonProperty("_userfilter", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? _userfilter { get; set; } 

        [JsonProperty("_new_only", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? _new_only { get; set; } 

        [JsonProperty("cab_ldap_strings", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<LDAPString>? Cab_ldap_strings { get; set; } 

        [JsonProperty("halointegratorenabled", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Halointegratorenabled { get; set; } 

        [JsonProperty("halointegrator_lastsync", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? Halointegrator_lastsync { get; set; } 

        [JsonProperty("halointegrator_lasterror", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Halointegrator_lasterror { get; set; } 

        [JsonProperty("halointegrator_importtype", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Halointegrator_importtype { get; set; } 

        [JsonProperty("halointegrator_batch", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Halointegrator_batch { get; set; } 

        [JsonProperty("halointegrator_ipaddress", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Halointegrator_ipaddress { get; set; } 

        [JsonProperty("halointegrator_allowedclientidslist", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<ValueLabelKeyPair>? Halointegrator_allowedclientidslist { get; set; } 

        [JsonProperty("halointegrator_allowedclientids", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Halointegrator_allowedclientids { get; set; } 

        [JsonProperty("user_matching_fields", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? User_matching_fields { get; set; } 

        [JsonProperty("agent_matching_fields", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Agent_matching_fields { get; set; } 

        [JsonProperty("user_matching_list", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<ValueLabelIsNewKeyPair>? User_matching_list { get; set; } 

        [JsonProperty("agent_matching_list", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<ValueLabelIsNewKeyPair>? Agent_matching_list { get; set; } 

        [JsonProperty("new_password", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? New_password { get; set; } 

        [JsonProperty("new_method", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? New_method { get; set; } 

        [JsonProperty("allow_access", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Allow_access { get; set; } 

        [JsonProperty("syncedstrings", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<int>? Syncedstrings { get; set; } 

        [JsonProperty("_warning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? _warning { get; set; } 

        [JsonProperty("uactguidmappingfield", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Uactguidmappingfield { get; set; } 

        [JsonProperty("new_user_template", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? New_user_template { get; set; } 

        [JsonProperty("new_user_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? New_user_type { get; set; } 

        [JsonProperty("mappings_new_user", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<LDAPName>? Mappings_new_user { get; set; } 

        [JsonProperty("new_user_template_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? New_user_template_name { get; set; } 

    }

    [GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public class LDAPName
    {
        [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Id { get; set; } 

        [JsonProperty("connection_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Connection_id { get; set; } 

        [JsonProperty("ldap_field", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Ldap_field { get; set; } 

        [JsonProperty("nhd_field", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Nhd_field { get; set; } 

        [JsonProperty("is_user", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Is_user { get; set; } 

        [JsonProperty("is_userticket", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Is_userticket { get; set; } 

        [JsonProperty("_warning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? _warning { get; set; } 

    }

    [GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public class LDAPString
    {
        [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Id { get; set; } 

        [JsonProperty("connection_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Connection_id { get; set; } 

        [JsonProperty("name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Name { get; set; } 

        [JsonProperty("dn", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Dn { get; set; } 

        [JsonProperty("ldapstring", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Ldapstring { get; set; } 

        [JsonProperty("site_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Site_id { get; set; } 

        [JsonProperty("site_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Site_name { get; set; } 

        [JsonProperty("client_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Client_id { get; set; } 

        [JsonProperty("lastnewuserdate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? Lastnewuserdate { get; set; } 

        [JsonProperty("filter", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Filter { get; set; } 

        [JsonProperty("agentmapping", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Agentmapping { get; set; } 

        [JsonProperty("isrecursive", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Isrecursive { get; set; } 

        [JsonProperty("mapping_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Mapping_type { get; set; } 

        [JsonProperty("role_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Role_id { get; set; } 

        [JsonProperty("users", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<LDAPUser>? Users { get; set; } 

        [JsonProperty("cabmapping", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Cabmapping { get; set; } 

        [JsonProperty("cab_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Cab_id { get; set; } 

        [JsonProperty("cab_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Cab_name { get; set; } 

        [JsonProperty("lastsynced", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? Lastsynced { get; set; } 

        [JsonProperty("userrole_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Userrole_id { get; set; } 

        [JsonProperty("_warning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? _warning { get; set; } 

    }

    [GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public class LDAPUser
    {
        [JsonProperty("name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Name { get; set; } 

        [JsonProperty("distinguishedname", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Distinguishedname { get; set; } 

        [JsonProperty("userAccountControl", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? UserAccountControl { get; set; } 

        [JsonProperty("objectguid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Objectguid { get; set; } 

        [JsonProperty("manager", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Manager { get; set; } 

        [JsonProperty("memberOf", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? MemberOf { get; set; } 

        [JsonProperty("attributes", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<StringIdNameKeyPair>? Attributes { get; set; } 

        [JsonProperty("uactguidMapping", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? UactguidMapping { get; set; } 

    }

    [GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public class LanguagePack
    {
        [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Id { get; set; } 

        [JsonProperty("name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Name { get; set; } 

        [JsonProperty("short_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Short_name { get; set; } 

        [JsonProperty("active", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Active { get; set; } 

        [JsonProperty("flag", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Flag { get; set; } 

        [JsonProperty("is_custom", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Is_custom { get; set; } 

        [JsonProperty("synctonhd", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Synctonhd { get; set; } 

        [JsonProperty("linked_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Linked_id { get; set; } 

        [JsonProperty("linked_code", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Linked_code { get; set; } 

        [JsonProperty("azure_code", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        [System.ComponentModel.DataAnnotations.StringLength(20)]
        public string? Azure_code { get; set; } 

        [JsonProperty("is_right_to_left", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Is_right_to_left { get; set; } 

        [JsonProperty("notes", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        [System.ComponentModel.DataAnnotations.StringLength(1000)]
        public string? Notes { get; set; } 

        [JsonProperty("translations", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<ValueLabelIsNewKeyPair>? Translations { get; set; } 

        [JsonProperty("translation_details", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<LanguagePackTranslations>? Translation_details { get; set; } 

        [JsonProperty("translations_are_custom", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Translations_are_custom { get; set; } 

        [JsonProperty("dont_remove_translations", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Dont_remove_translations { get; set; } 

        [JsonProperty("access_control", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<AccessControl>? Access_control { get; set; } 

        [JsonProperty("access_control_level", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Access_control_level { get; set; } 

        [JsonProperty("_warning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? _warning { get; set; } 

    }

    [GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public class LanguagePackTranslations
    {
        [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Id { get; set; } 

        [JsonProperty("language_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Language_id { get; set; } 

        [JsonProperty("sysid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Sysid { get; set; } 

        [JsonProperty("systype", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Systype { get; set; } 

        [JsonProperty("display_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Display_id { get; set; } 

        [JsonProperty("translation", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Translation { get; set; } 

        [JsonProperty("incomplete", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Incomplete { get; set; } 

        [JsonProperty("iscustomised", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Iscustomised { get; set; } 

        [JsonProperty("description", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Description { get; set; } 

        [JsonProperty("default_string", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Default_string { get; set; } 

        [JsonProperty("context", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Context { get; set; } 

        [JsonProperty("_warning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? _warning { get; set; } 

    }

    [GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public class LanguagePackTranslationsCustom
    {
        [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Id { get; set; } 

        [JsonProperty("language_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Language_id { get; set; } 

        [JsonProperty("entity", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        [System.ComponentModel.DataAnnotations.StringLength(100)]
        public string? Entity { get; set; } 

        [JsonProperty("fieldname", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        [System.ComponentModel.DataAnnotations.StringLength(100)]
        public string? Fieldname { get; set; } 

        [JsonProperty("entity_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Entity_id { get; set; } 

        [JsonProperty("entity_id2", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Entity_id2 { get; set; } 

        [JsonProperty("translation", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Translation { get; set; } 

        [JsonProperty("_dotranslate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? _dotranslate { get; set; } 

        [JsonProperty("_translateonly", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? _translateonly { get; set; } 

        [JsonProperty("_isimport", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? _isimport { get; set; } 

        [JsonProperty("default_translation", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Default_translation { get; set; } 

        [JsonProperty("_warning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? _warning { get; set; } 

    }

    [GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public class LansweeperRelation
    {
        [JsonProperty("childAssetKey", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? ChildAssetKey { get; set; } 

        [JsonProperty("lastChanged", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? LastChanged { get; set; } 

        [JsonProperty("parentAssetKey", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? ParentAssetKey { get; set; } 

        [JsonProperty("startDate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? StartDate { get; set; } 

        [JsonProperty("endDate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? EndDate { get; set; } 

        [JsonProperty("comment", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Comment { get; set; } 

        [JsonProperty("name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Name { get; set; } 

    }

    [GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public class LansweeperSoftware
    {
        [JsonProperty("name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Name { get; set; } 

        [JsonProperty("publisher", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Publisher { get; set; } 

        [JsonProperty("version", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Version { get; set; } 

        [JsonProperty("installDate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? InstallDate { get; set; } 

    }

    [GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public class LansweeperStartExport
    {
        [JsonProperty("siteMappingId", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? SiteMappingId { get; set; } 

    }

    [GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public class LicenceInfo
    {
        [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public Guid? Id { get; set; } 

        [JsonProperty("site_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Site_id { get; set; } 

        [JsonProperty("client_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Client_id { get; set; } 

        [JsonProperty("client_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Client_name { get; set; } 

        [JsonProperty("version", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Version { get; set; } 

        [JsonProperty("apiurl", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Apiurl { get; set; } 

        [JsonProperty("organisationname", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Organisationname { get; set; } 

        [JsonProperty("is_trial", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Is_trial { get; set; } 

        [JsonProperty("support_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Support_type { get; set; } 

        [JsonProperty("trialexpiry", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? Trialexpiry { get; set; } 

        [JsonProperty("registrationdate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? Registrationdate { get; set; } 

    }

    [GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public class LicenceMatch
    {
        [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Id { get; set; } 

        [JsonProperty("licence_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Licence_id { get; set; } 

        [JsonProperty("type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Type { get; set; } 

        [JsonProperty("licence_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Licence_name { get; set; } 

        [JsonProperty("text", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Text { get; set; } 

        [JsonProperty("_warning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? _warning { get; set; } 

    }

    [GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public class LicenceRole
    {
        [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Id { get; set; } 

        [JsonProperty("softwarelicence_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Softwarelicence_id { get; set; } 

        [JsonProperty("name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Name { get; set; } 

        [JsonProperty("note", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Note { get; set; } 

        [JsonProperty("_warning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? _warning { get; set; } 

    }

    [GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public class Licence_List
    {
        [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Id { get; set; } 

        [JsonProperty("type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Type { get; set; } 

        [JsonProperty("name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Name { get; set; } 

        [JsonProperty("count", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Count { get; set; } 

        [JsonProperty("client_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Client_id { get; set; } 

        [JsonProperty("site_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Site_id { get; set; } 

        [JsonProperty("client_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Client_name { get; set; } 

        [JsonProperty("site_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Site_name { get; set; } 

        [JsonProperty("purchase_price", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Purchase_price { get; set; } 

        [JsonProperty("start_date", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? Start_date { get; set; } 

        [JsonProperty("snowid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Snowid { get; set; } 

        [JsonProperty("manufacturer", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Manufacturer { get; set; } 

        [JsonProperty("notes", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Notes { get; set; } 

        [JsonProperty("licences_in_use", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Licences_in_use { get; set; } 

        [JsonProperty("licences_in_use_user", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Licences_in_use_user { get; set; } 

        [JsonProperty("licences_available", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Licences_available { get; set; } 

        [JsonProperty("supplier_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Supplier_id { get; set; } 

        [JsonProperty("supplier_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Supplier_name { get; set; } 

        [JsonProperty("licence_client_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Licence_client_name { get; set; } 

        [JsonProperty("vendor", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Vendor { get; set; } 

        [JsonProperty("licence_roles", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<LicenceRole>? Licence_roles { get; set; } 

        [JsonProperty("end_date", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? End_date { get; set; } 

        [JsonProperty("tenant_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Tenant_id { get; set; } 

        [JsonProperty("tenant_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Tenant_name { get; set; } 

        [JsonProperty("name_extra", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Name_extra { get; set; } 

        [JsonProperty("deleted", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Deleted { get; set; } 

        [JsonProperty("assigned_at_deletion", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Assigned_at_deletion { get; set; } 

        [JsonProperty("billing_cycle", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Billing_cycle { get; set; } 

        [JsonProperty("term_duration", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Term_duration { get; set; } 

        [JsonProperty("status", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Status { get; set; } 

        [JsonProperty("autorenew", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Autorenew { get; set; } 

        [JsonProperty("_isimport", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? _isimport { get; set; } 

        [JsonProperty("_importtype", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? _importtype { get; set; } 

        [JsonProperty("_importchildren", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? _importchildren { get; set; } 

        [JsonProperty("third_party_product", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Third_party_product { get; set; } 

        [JsonProperty("price", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Price { get; set; } 

        [JsonProperty("monthly_price", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Monthly_price { get; set; } 

        [JsonProperty("monthly_cost", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Monthly_cost { get; set; } 

        [JsonProperty("_removed", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? _removed { get; set; } 

        [JsonProperty("distributor", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Distributor { get; set; } 

        [JsonProperty("is_active", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Is_active { get; set; } 

        [JsonProperty("azure_connection_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Azure_connection_id { get; set; } 

        [JsonProperty("azure_connection", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public AzureADConnection? Azure_connection { get; set; } 

        [JsonProperty("requested_quantity", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Requested_quantity { get; set; } 

        [JsonProperty("requested_quantity_date", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? Requested_quantity_date { get; set; } 

        [JsonProperty("_warning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? _warning { get; set; } 

        [JsonProperty("ingram_micro_details_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Ingram_micro_details_id { get; set; } 

        [JsonProperty("_details_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? _details_id { get; set; } 

        [JsonProperty("snow_client_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Snow_client_id { get; set; } 

        [JsonProperty("thirdparty_client_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Thirdparty_client_id { get; set; } 

        [JsonProperty("product_sku", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Product_sku { get; set; } 

        [JsonProperty("vendor_product_sku", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Vendor_product_sku { get; set; } 

        [JsonProperty("parent_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Parent_id { get; set; } 

        [JsonProperty("configuration_items", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<Device_List>? Configuration_items { get; set; } 

        [JsonProperty("add_configuration_items", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<Device_List>? Add_configuration_items { get; set; } 

        [JsonProperty("licence_match", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<LicenceMatch>? Licence_match { get; set; } 

        [JsonProperty("device_child_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Device_child_id { get; set; } 

        [JsonProperty("device_count", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Device_count { get; set; } 

        [JsonProperty("new_software", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DeviceApplications? New_software { get; set; } 

    }

    [GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public enum LicenseModel
    {

        _0 = 0,

        _1 = 1,

        _2 = 2,

    }

    [GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public class LinkIssue
    {
        [JsonProperty("ticketId", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? TicketId { get; set; } 

        [JsonProperty("issueId", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? IssueId { get; set; } 

        [JsonProperty("externalLinkId", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? ExternalLinkId { get; set; } 

        [JsonProperty("ticket", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public Faults? Ticket { get; set; } 

        [JsonProperty("product", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ReleaseProduct? Product { get; set; } 

    }

    [GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public class LinkWorkItem
    {
        [JsonProperty("ticketId", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? TicketId { get; set; } 

        [JsonProperty("workItemId", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? WorkItemId { get; set; } 

        [JsonProperty("externalLinkId", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? ExternalLinkId { get; set; } 

        [JsonProperty("product", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ReleaseProduct? Product { get; set; } 

        [JsonProperty("rev", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Rev { get; set; } 

    }

    [GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public class LiveChatIsTyping
    {
        [JsonProperty("chat_id", Required = Required.Always)]
        public int Chat_id { get; set; } 

        [JsonProperty("sender_id", Required = Required.Always)]
        public int Sender_id { get; set; } 

        [JsonProperty("timestamp", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? Timestamp { get; set; } 

        [JsonProperty("_stopped", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? _stopped { get; set; } 

    }

    [GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public class LiveChatMsg
    {
        [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Id { get; set; } 

        [JsonProperty("chat_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Chat_id { get; set; } 

        [JsonProperty("sender_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Sender_id { get; set; } 

        [JsonProperty("text", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Text { get; set; } 

        [JsonProperty("value_int", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Value_int { get; set; } 

        [JsonProperty("timestamp", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? Timestamp { get; set; } 

        [JsonProperty("system_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? System_id { get; set; } 

        [JsonProperty("ticket_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Ticket_id { get; set; } 

        [JsonProperty("user_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? User_id { get; set; } 

        [JsonProperty("agent_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Agent_id { get; set; } 

        [JsonProperty("unknown_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Unknown_id { get; set; } 

        [JsonProperty("display_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Display_name { get; set; } 

        [JsonProperty("lastmessageid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Lastmessageid { get; set; } 

        [JsonProperty("_isremoteinvite", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? _isremoteinvite { get; set; } 

        [JsonProperty("_remoteintegration", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? _remoteintegration { get; set; } 

        [JsonProperty("remotetechid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Remotetechid { get; set; } 

        [JsonProperty("user_chat_url", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? User_chat_url { get; set; } 

        [JsonProperty("input_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Input_id { get; set; } 

        [JsonProperty("next_input_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Next_input_id { get; set; } 

        [JsonProperty("next_input_fieldinfo", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ChatInputField? Next_input_fieldinfo { get; set; } 

        [JsonProperty("kb_search_results", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<KBEntry_List>? Kb_search_results { get; set; } 

        [JsonProperty("services_search_results", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<ServSite_List>? Services_search_results { get; set; } 

        [JsonProperty("chat_image_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Chat_image_type { get; set; } 

        [JsonProperty("attachment_ids", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<int>? Attachment_ids { get; set; } 

        [JsonProperty("attachment_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Attachment_id { get; set; } 

        [JsonProperty("_warning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? _warning { get; set; } 

        [JsonProperty("value_bool", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Value_bool { get; set; } 

        [JsonProperty("value_date", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? Value_date { get; set; } 

        [JsonProperty("value_multi", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Value_multi { get; set; } 

        [JsonProperty("is_message_safe", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Is_message_safe { get; set; } 

    }

    [GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public class LogicMonitorWebhook
    {
        [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Id { get; set; } 

        [JsonProperty("status", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Status { get; set; } 

        [JsonProperty("type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Type { get; set; } 

        [JsonProperty("message", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Message { get; set; } 

        [JsonProperty("level", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Level { get; set; } 

        [JsonProperty("host", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Host { get; set; } 

        [JsonProperty("datasource", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Datasource { get; set; } 

        [JsonProperty("admin", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Admin { get; set; } 

        [JsonProperty("ticketid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Ticketid { get; set; } 

        [JsonProperty("halo_customer_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Halo_customer_id { get; set; } 

        [JsonProperty("halo_customer_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Halo_customer_name { get; set; } 

    }

    [GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public class LoginScreenConfig
    {
        [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Id { get; set; } 

        [JsonProperty("application_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Application_id { get; set; } 

        [JsonProperty("function", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Function { get; set; } 

        [JsonProperty("function_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Function_name { get; set; } 

        [JsonProperty("sequence", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Sequence { get; set; } 

        [JsonProperty("display", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Display { get; set; } 

        [JsonProperty("label_override", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Label_override { get; set; } 

        [JsonProperty("hasform", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Hasform { get; set; } 

    }

    [GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public class LoginToken
    {
        [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Id { get; set; } 

        [JsonProperty("type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Type { get; set; } 

        [JsonProperty("timestamp", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? Timestamp { get; set; } 

        [JsonProperty("verifier", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Verifier { get; set; } 

        [JsonProperty("token", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Token { get; set; } 

        [JsonProperty("enc_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Enc_id { get; set; } 

        [JsonProperty("token_used", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Token_used { get; set; } 

        [JsonProperty("used_timestamp", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? Used_timestamp { get; set; } 

        [JsonProperty("used_userid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Used_userid { get; set; } 

        [JsonProperty("jwt", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Jwt { get; set; } 

        [JsonProperty("_warning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? _warning { get; set; } 

    }

    [GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public class Lookup
    {
        [JsonProperty("intent", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Intent { get; set; } 

        [JsonProperty("lookupid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Lookupid { get; set; } 

        [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Id { get; set; } 

        [JsonProperty("name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Name { get; set; } 

        [JsonProperty("value2", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Value2 { get; set; } 

        [JsonProperty("value2_bool", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Value2_bool { get; set; } 

        [JsonProperty("value3", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Value3 { get; set; } 

        [JsonProperty("value3_bool", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Value3_bool { get; set; } 

        [JsonProperty("value4", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Value4 { get; set; } 

        [JsonProperty("value4_bool", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Value4_bool { get; set; } 

        [JsonProperty("value5", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Value5 { get; set; } 

        [JsonProperty("value5_bool", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Value5_bool { get; set; } 

        [JsonProperty("value6", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Value6 { get; set; } 

        [JsonProperty("value6_bool", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Value6_bool { get; set; } 

        [JsonProperty("value7", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Value7 { get; set; } 

        [JsonProperty("value7_bool", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Value7_bool { get; set; } 

        [JsonProperty("value8", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Value8 { get; set; } 

        [JsonProperty("value8_bool", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Value8_bool { get; set; } 

        [JsonProperty("value9", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Value9 { get; set; } 

        [JsonProperty("value9_bool", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Value9_bool { get; set; } 

        [JsonProperty("rates", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<ChargeRate>? Rates { get; set; } 

        [JsonProperty("contract_ref", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Contract_ref { get; set; } 

        [JsonProperty("overriding_rate_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Overriding_rate_id { get; set; } 

        [JsonProperty("_isnewcode", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? _isnewcode { get; set; } 

        [JsonProperty("_isimport", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? _isimport { get; set; } 

        [JsonProperty("_importtype", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? _importtype { get; set; } 

        [JsonProperty("kashflow_tenant", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Kashflow_tenant { get; set; } 

        [JsonProperty("email_template_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Email_template_name { get; set; } 

        [JsonProperty("sla_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Sla_name { get; set; } 

        [JsonProperty("access_control", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<AccessControl>? Access_control { get; set; } 

        [JsonProperty("access_control_level", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Access_control_level { get; set; } 

        [JsonProperty("custom1", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Custom1 { get; set; } 

        [JsonProperty("custom1_bool", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Custom1_bool { get; set; } 

        [JsonProperty("custom2", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Custom2 { get; set; } 

        [JsonProperty("tax_rate_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Tax_rate_name { get; set; } 

        [JsonProperty("xero_tenant_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Xero_tenant_name { get; set; } 

        [JsonProperty("surcharge_item_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Surcharge_item_name { get; set; } 

        [JsonProperty("dynamics_company_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Dynamics_company_name { get; set; } 

        [JsonProperty("valueint1", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Valueint1 { get; set; } 

        [JsonProperty("linked_item", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Linked_item { get; set; } 

        [JsonProperty("sequence", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Sequence { get; set; } 

        [JsonProperty("sub_lookup", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<Lookup>? Sub_lookup { get; set; } 

        [JsonProperty("translations", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<LanguagePackTranslationsCustom>? Translations { get; set; } 

        [JsonProperty("_warning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? _warning { get; set; } 

        [JsonProperty("inactive", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Inactive { get; set; } 

        [JsonProperty("column_profile_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Column_profile_name { get; set; } 

        [JsonProperty("jira_instance_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Jira_instance_name { get; set; } 

    }